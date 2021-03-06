USE [BD_SGAC]
GO
/****** Object:  StoredProcedure [PN_REGISTRO].[USP_RE_ACTUACIONDETALLE_VINCULAR]    Script Date: 24/04/2022 12:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	--======================================================
	-- Objeto: [PN_REGISTRO].[USP_RE_ACTUACIONDETALLE_VINCULAR]
	-- Parámetro(s):
		--@iActuacionId					bigint,			Identificador de Actuación
		--@iActuacionDetalleId			bigint,			Identificador de Actuación Detalle
		--@sInsumoTipoId smallint,		smallint		Identificador de Tipo de Insumo
		--@vCodigoAutoadhesivo			varchar(12),	Código de Fábrica del Autoadhesivo
		--@dFechaVinculacion			datetime,		Fecha vinculación con el autoadhesivo
		--@bImpresionFlag				bit,			Flag de Impresión del autoadhesivo
		--@dFechaImpresion				datetime,		Fecha de Impresión
		--@sImpresionFuncionarioId		smallint,		Identificador del Funcionario que realizó la impresión
		--@sOficinaConsularId			smallint,		Identificador de la Oficina Consular
		--@sUsuarioModificacion			smallint,		Identificador de Usuario Modificación
		--@vIPModificacion				varchar(50),	Dirección IP 
		--@vHostName					varchar(20)		HostName Usuario
		--@strMensaje					varchar(200)	Mensaje de retorno

	-- Descripción: Actualiza los datos asociados a la vinculación de autoadhesivo 
	-- Fecha Creación:		02/12/2014
	-- Fecha Modificacion:	30/04/2015
	-- Autor: Margarita Díaz
	-- Version: 1.1
	-- Cambios Importantes:
	--======================================================
	-- MODIFICADO POR: JONATAN SILVA CACHAY
	-- FECHA DE MODIFICACIÓN: 17/07/2017
	-- MOTIVO: SE CAMBIO EL ORDEN QUE SE REALIZA LA TRANSACCIÓN DE INSERTAR EN LA TABLA RE_ACTUACIONINSUMODETALLE SOLO SI SE ACTUALIZÓ EL AUTOADHESIVO
	--======================================================
	-- MODIFICADO POR: JONATAN SILVA CACHAY
	-- FECHA DE MODIFICACIÓN: 24/11/2017
	-- MOTIVO: EN CASO LA ACTUACIÓN SEA DE BIOMETRICOS AL MOMENTO DE VINCULAR SE ACTUALIZA LA CIUDAD ITINERANTE
	--======================================================
	-- MODIFICADO POR: JONATAN SILVA CACHAY
	-- FECHA DE MODIFICACIÓN: 13/12/2017
	-- MOTIVO: SE EVITA QUE VINCULE CUANDO EL TRAMITE YA HA SIDO ANULADO (EN CASO SE ENCUENTRE EN PAGINAS DISTINTAS)
	--======================================================
	-- MODIFICADO POR: JONATAN SILVA CACHAY
	-- FECHA DE MODIFICACIÓN: 21/02/2018
	-- MOTIVO: SE PONE EN UNA VARIABLE EL VALOR DE CANTIDAD DE DIGITOS DEL AUTOADHESIVOS
	--======================================================
	-- MODIFICADO POR: JONATAN SILVA CACHAY
	-- FECHA DE MODIFICACIÓN: 26/04/2018
	-- MOTIVO: EN CASO @vCorrActuacion sea vacio no se continuará grabando
	--======================================================
	-- MODIFICADO POR: MIGUEL MÁRQUEZ BELTRÁN
	-- FECHA DE MODIFICACIÓN: 15/08/2018
	-- MOTIVO: Actualiza los campos: Fecha de modificación, 
	--			oficina consular, usuario de modificación y la ip de modificación del registro persona 
	--			Caso usuario UCOESY 
	--======================================================
   -- MODIFICADO POR: JONATAN SILVA CACHAY
	-- FECHA DE MODIFICACIÓN: 07/01/2020
	-- MOTIVO: Se coloca los where de INSUMOS utilizando los indices
	--======================================================
   -- MODIFICADO POR: JONATAN SILVA CACHAY
	-- FECHA DE MODIFICACIÓN: 16/01/2020
	-- MOTIVO: Se quita los registros de movimiento
	--======================================================
	ALTER PROCEDURE [PN_REGISTRO].[USP_RE_ACTUACIONDETALLE_VINCULAR]
		@iActuacionId bigint,
		@iActuacionDetalleId bigint,
		@sInsumoTipoId smallint,
		@vCodigoAutoadhesivo varchar(20),
		@dFechaVinculacion datetime,
		@bImpresionFlag bit,
		@dFechaImpresion datetime,
		@sImpresionFuncionarioId smallint,
		@sOficinaConsularId smallint,	
		@sUsuarioModificacion smallint,
		@vIPModificacion varchar(50),
		@vHostName varchar(20),
		@actu_sCiudadItinerante SMALLINT = 0,
		@strMensaje varchar(200) OUTPUT
	AS
	BEGIN
		SET NOCOUNT ON;
	
		SET @strMensaje = '';

		DECLARE @bVincula bit = 0;
		DECLARE @IInsumoId BIGINT = 0;

		DECLARE @sOficinaConsularMovimientoId SMALLINT;
		DECLARE @sTipoBovedaId SMALLINT;
		DECLARE @sUsuarioId SMALLINT;
		DECLARE @sEstadoMovimientoId SMALLINT;
		DECLARE @sEstadoInsumoId SMALLINT;
		Declare @insu_vCodigoUnicoFabrica varchar(25)

      Declare @insu_vPrefijoNumeracion Varchar(5) = 'MREAC'
      Declare @insu_vCodigoUnicoFabrica_SinMREAC varchar(25) = REPLACE(@vCodigoAutoadhesivo,@insu_vPrefijoNumeracion,'')

		DECLARE @sTipopagoId SMALLINT

		BEGIN TRY


		IF EXISTS(Select acde_iActuacionId from PN_REGISTRO.RE_ACTUACIONDETALLE (NoLock)
					Where acde_iActuacionId = @iActuacionId 
					And acde_iActuacionDetalleId = @iActuacionDetalleId
					And acde_sEstadoId = 1)
		Begin
			SET @bVincula = 0
			SET @strMensaje = 'La actuación se encuentra anulada.';
			return
		End 
		DECLARE @sCantInsumoVinculado BIT = 0;
		DECLARE @sValorNumericoInsumo SmallInt
      DECLARE @USUARIO_ALIAS VARCHAR(100)
		Select @sValorNumericoInsumo = LEN(@vCodigoAutoadhesivo) - 5

		 SET  @sTipopagoId = (	SELECT TOP 1 PA.pago_sPagoTipoId 
                              FROM PN_REGISTRO.RE_ACTUACION ACTU (nolock)
			                     INNER JOIN PN_REGISTRO.RE_ACTUACIONDETALLE ACDE (nolock) ON ACTU.actu_iActuacionId = ACDE.acde_iActuacionId AND ACDE.acde_sEstadoId <> 1
			                     INNER JOIN PN_REGISTRO.RE_PAGO PA (nolock) ON ACDE.acde_iActuacionDetalleId = PA.pago_iActuacionDetalleId AND PA.pago_cEstado <> 'E'
			WHERE ACTU.actu_sEstado <> 1 AND ACDE.acde_iActuacionDetalleId = @iActuacionDetalleId)

			-- VERIFICAR VINCULACIONES ACTUACIÓN (01/03/2016)
			SELECT @sCantInsumoVinculado = ISNULL(count (aid.aide_iActuacionInsumoDetalleId), 0)
			FROM PN_REGISTRO.RE_ACTUACIONINSUMODETALLE AID (nolock)
			INNER JOIN PN_ALMACEN.AL_INSUMO I (nolock) ON AID.aide_iInsumoId = I.insu_iInsumoId AND I.insu_sEstadoId NOT IN (20,106)
			WHERE AID.aide_iActuacionDetalleId = @iActuacionDetalleId
			AND I.insu_sInsumoTipoId = @sInsumoTipoId
			AND AID.aide_cEstado = 'A';

			IF @sCantInsumoVinculado > 0
			BEGIN
				SET @bVincula = 0
				SET @strMensaje = ' - La actuación ya tiene un Insumo Vinculado.';
			END
			ELSE
			BEGIN
         
			-- VALIDAR INSUMO
			SELECT 
				@IInsumoId = ISNULL(insu_iInsumoId,0),		
				@sOficinaConsularMovimientoId = MOV.movi_sOficinaConsularIdDestino,	--  @sOficinaConsularId
				@sTipoBovedaId = MOV.movi_sBovedaTipoIdDestino,						-- TIPO BOVEDA: USUARIO (6005)
				@sUsuarioId = MOV.movi_sBodegaDestinoId,								-- @sUsuarioModificacion
				@sEstadoMovimientoId = MOV.movi_sEstadoId,							-- Movimiento ACEPTADO
				@sEstadoInsumoId = INS.insu_sEstadoId,								-- Insumo DISPONIBLE
				@insu_vCodigoUnicoFabrica = CONVERT(INT, RIGHT(insu_vCodigoUnicoFabrica, @sValorNumericoInsumo))
			FROM PN_ALMACEN.AL_INSUMO AS INS (nolock)
			INNER JOIN PN_ALMACEN.AL_MOVIMIENTO AS MOV (nolock) ON INS.insu_iMovimientoId = MOV.movi_iMovimientoId
			WHERE INS.insu_sInsumoTipoId = @sInsumoTipoId			
				AND INS.insu_vPrefijoNumeracion = @insu_vPrefijoNumeracion
            AND INS.insu_vCodigoUnicoFabrica = @insu_vCodigoUnicoFabrica_SinMREAC
				
	
			SET @bVincula = 1;			
	
			SET @strMensaje='Insumo ' + @vCodigoAutoadhesivo

			if @IInsumoId = 0 or @IInsumoId is null
			begin
				SET @bVincula = 0
				SET @strMensaje += ' - CÓDIGO NO EXISTENTE';
			end


			IF @sOficinaConsularMovimientoId <> @sOficinaConsularId
			BEGIN
				SET @bVincula = 0
				SET @strMensaje += ' - No pertenece a la Oficina Consular Logueada';
			END
			ELSE
			BEGIN
				IF @sTipoBovedaId <> 6005 
				BEGIN
					SET @bVincula = 0
					SET @strMensaje += ' - No pertenece a un usuario';
				END			
				ELSE
				BEGIN
					IF @sUsuarioId <> @sUsuarioModificacion
					BEGIN
						SET @bVincula = 0
						SET @strMensaje += ' - No pertenece al Usuario Logueado';
					END
				END
			END

			IF @sEstadoMovimientoId <> 10
			BEGIN
				SET @bVincula = 0
				SET @strMensaje += ' - El Movimiento no ha sido aceptado';
			END

			IF @sEstadoInsumoId <> 17
			BEGIN
				SET @bVincula = 0
				SET @strMensaje += ' - El Insumo no se encuentra disponible';
			END

			END

			IF @sTipopagoId = 0
			BEGIN
				SET @bVincula = 0
				SET @strMensaje += ' - No se podra vincular, favor de registrar el pago';
			END
			
			-- 
			IF @bVincula = 1 
			BEGIN		
					
				DECLARE @vCorrActuacion varchar(250) 	
				
				IF (@iActuacionDetalleId = 0)
				BEGIN
					SELECT 	@iActuacionDetalleId = acde_iActuacionDetalleId ,
							@vCorrActuacion = acde_ICorrelativoActuacion
					FROM PN_REGISTRO.RE_ACTUACIONDETALLE (nolock) WHERE acde_iActuacionId = @iActuacionId AND acde_sItem = 1
					ORDER BY acde_iActuacionDetalleId ASC
				END
				ELSE
				BEGIN
					SELECT	@iActuacionDetalleId = acde_iActuacionDetalleId ,
							@vCorrActuacion = acde_ICorrelativoActuacion
					FROM PN_REGISTRO.RE_ACTUACIONDETALLE (nolock) WHERE acde_iActuacionDetalleId = @iActuacionDetalleId
				END
 
				DECLARE @DFECREGISTRO DATETIME;
				SELECT @DFECREGISTRO = PS_ACCESORIOS.FN_OBTENER_FECHAACTUAL(@sOficinaConsularId)
			
				DECLARE @aide_iActuacionInsumoDetalleId bigint = 0;
				SET @aide_iActuacionInsumoDetalleId = @@IDENTITY
			 
				Declare @para_vValor varchar(15) = (Select para_vValor from PS_SISTEMA.SI_PARAMETRO (nolock)
					where para_sParametroId =  @sInsumoTipoId) 
		 
				DECLARE	@return_value int,
					@insu_sInsumoEstadoId smallint

				SELECT	@insu_sInsumoEstadoId = 19

            

				if ISNULL(RTRIM(@vCorrActuacion),'') = ''
				Begin
					SET @strMensaje += ' - No se pudo vincular, pero favor vuelva a ingresar a la actuación';
				End
				Else
				Begin
                  Select @USUARIO_ALIAS = usua_vAlias
                  from PS_SEGURIDAD.SE_USUARIO (NOLOCK)
                  WHERE usua_sUsuarioId = @sUsuarioModificacion

                  SET @vCorrActuacion = @USUARIO_ALIAS  + ' - POR ACTUACIÓN CONSULAR (RGE: ' + @vCorrActuacion + ')';

						INSERT INTO 
						PN_REGISTRO.RE_ACTUACIONINSUMODETALLE 
						(
						aide_iActuacionDetalleId,
						aide_iInsumoId,
						aide_dFechaVinculacion,
						aide_sUsuarioVinculacionId,
						aide_bFlagImpresion,
						aide_dFechaImpresion,
						aide_cEstado,
						aide_sUsuarioCreacion,			
						aide_vIPCreacion,
						aide_dFechaCreacion
						)
						Select @iActuacionDetalleId ,@IInsumoId
						,@DFECREGISTRO
						,@sUsuarioModificacion
						,@bImpresionFlag
						,@dFechaImpresion
						,'A'
						,@sUsuarioModificacion
						,@vIPModificacion
						,@DFECREGISTRO
						from  [PN_ALMACEN].[AL_INSUMO] (NOLOCK)
						Where  insu_vPrefijoNumeracion = @insu_vPrefijoNumeracion
                  AND insu_vCodigoUnicoFabrica = @insu_vCodigoUnicoFabrica_SinMREAC
						AND insu_sEstadoId = @sEstadoInsumoId -- DISPONIBLE

                  INSERT INTO [PN_ALMACEN].[AL_INSUMOHISTORICO]
					   (inhi_IInsumoId,inhi_sEstadoId,inhi_dFecharegistro,inhi_vObservacion,
					   inhi_dFechaCreacion, inhi_sUsuarioCreacion,inhi_vIPCreacion) 
				      SELECT 
					      insu_iInsumoId,@insu_sInsumoEstadoId,PS_ACCESORIOS.FN_OBTENER_FECHAACTUAL(@sOficinaConsularId),@vCorrActuacion,
					      PS_ACCESORIOS.FN_OBTENER_FECHAACTUAL(@sOficinaConsularId), @sUsuarioModificacion,@vIPModificacion
					      FROM [PN_ALMACEN].[AL_INSUMO] INS (NOLOCK)
                     Where  insu_vPrefijoNumeracion = @insu_vPrefijoNumeracion
                     AND insu_vCodigoUnicoFabrica = @insu_vCodigoUnicoFabrica_SinMREAC
						   AND insu_sEstadoId = @sEstadoInsumoId


                  /*SE ACTUALIZA EL INSUMO*/
                  UPDATE [PN_ALMACEN].[AL_INSUMO]
                  SET insu_sEstadoId = @insu_sInsumoEstadoId -- VINCULADO
                  Where insu_vPrefijoNumeracion = @insu_vPrefijoNumeracion
                  AND insu_vCodigoUnicoFabrica = @insu_vCodigoUnicoFabrica_SinMREAC
						AND insu_sEstadoId = @sEstadoInsumoId -- DISPONIBLE

						/*
							ACTUALIZA ITINERANTE, EN CASO LO SEA (CUANDO VIENE DE BIOMETRICOS)
						*/
						DECLARE @sUsuario_UCOESY SMALLINT
			
						Select @sUsuario_UCOESY = usua_sUsuarioId 
						from PS_SEGURIDAD.SE_USUARIO (NoLock)
						where usua_vAlias = 'UCOESY'

						IF @actu_sCiudadItinerante != 0
						Begin							
							If ((Select Top 1 acde_sUsuarioCreacion 
								From PN_REGISTRO.RE_ACTUACIONDETALLE(NoLock) 
								where  acde_iActuacionDetalleId = @iActuacionDetalleId) = @sUsuario_UCOESY)
							Begin
								Update PN_REGISTRO.RE_ACTUACION
								Set actu_sCiudadItinerante = @actu_sCiudadItinerante
								Where actu_iActuacionId = @iActuacionId
							End
						End
						----------------------------------------------------------------
						-- MODIFICADO POR: MIGUEL MÁRQUEZ BELTRÁN
						-- FECHA DE MODIFICACIÓN: 16/08/2018
						-- MOTIVO: Caso usuario UCOESY
						----------------------------------------------------------------
						Declare @actu_iPersonaRecurrenteId bigint

						set @actu_iPersonaRecurrenteId = (select actu_iPersonaRecurrenteId from PN_REGISTRO.RE_ACTUACION Where actu_iActuacionId = @iActuacionId) 

						UPDATE PN_REGISTRO.RE_PERSONA
						SET pers_dFechaModificacion = PS_ACCESORIOS.FN_OBTENER_FECHAACTUAL(@sOficinaConsularId),
							pers_sOficinaConsularId = @sOficinaConsularId,
							pers_sUsuarioModificacion = @sUsuarioModificacion,
							pers_vIPModificacion =  @vIPModificacion
						WHERE pers_iPersonaId = @actu_iPersonaRecurrenteId and pers_sUsuarioCreacion = @sUsuario_UCOESY
						----------------------------------------------------------------
					
					

					EXEC PS_SISTEMA.USP_SI_AUDITORIA_ADICIONAR
						@vCamposGenerales = '8,1055,1101,394',
						@vNombreTabla = 'RE_ACTUACIONINSUMODETALLE',
						@vClavePrimaria = @aide_iActuacionInsumoDetalleId,
						@sOficinaConsularId = @sOficinaConsularId,			
						@audi_vComentario = 'Vinculación - Movimiento de Almacen',
						@audi_vHostName = @vHostName,
						@audi_sUsuarioCreacion = @sUsuarioModificacion,
						@audi_vIPCreacion = @vIPModificacion

					set @strMensaje=''
				End
			END
			ELSE
			BEGIN
				SET @strMensaje = @strMensaje + '.';
			END		
		END TRY	
		BEGIN CATCH
			SELECT @strMensaje = ERROR_MESSAGE();		 
		END CATCH;

		SET NOCOUNT OFF;
	END


