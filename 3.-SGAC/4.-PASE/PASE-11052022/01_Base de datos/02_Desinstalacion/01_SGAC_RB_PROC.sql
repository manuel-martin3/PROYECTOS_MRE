USE [BD_SGAC]
GO
/****** Object:  StoredProcedure [PN_REGISTRO].[USP_RE_REGISTROCIVIL_ELIMINAR]    Script Date: 11/05/2022 0:18:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--====================================================================================================
-- Nombre: PN_REGISTRO.USP_RE_REGISTROCIVIL_ELIMINAR
-- Descripción: ELIMINAR REGISTRO EN LA TABLA RE_REGISTROCIVIL
-- Fecha Creación: 26/12/2014
-- Fecha Modificacion: 26/12/2014
-- Descripción Parámetros:
-- Parámetro(s):
	--@reci_iRegistroCivilId		bigint,			Id del registro civil
	--@reci_sUsuarioModificacion	smallint,		Id del usuario que modifica el registro
	--@reci_vIPModificacion			varchar(50),	IP de la pc donde se modifica el registro
	--@reci_sOficinaConsularId		smallint,		Id de la oficina Consular
	--@reci_vHostName				varchar(20)		Nombre del Host Name

-- Autor: Sandro Guinet
-- Version: 2.0
-- Cambios Importantes:
--====================================================================================================
-- MODIFICADO POR: JONATAN SILVA CACHAY
-- FECHA DE MODIFICACIÓN: 24/05/2019
-- MOTIVO: SE ADICIONA LA ELIMINACION DE PARTICIPANTES
--====================================================================================================
-- FECHA		AUTOR		MOTIVO
--====================================================================================================
-- 11/04/2022	MMARQUEZ	AL ANULAR EL ACTA DE NACIMIENTO CON CUI SE DEBE ANULAR AL TITULAR. 
-- 19/04/2022	MMARQUEZ	SE DEBE ANULAR EL REGISTRO PERSONA Y EL DOCUMENTO DEL TITULAR.
--							DE ACUERDO AL DOCUMENTO: ECPP-SGAC-18042022.
--====================================================================================================
ALTER PROCEDURE [PN_REGISTRO].[USP_RE_REGISTROCIVIL_ELIMINAR]
@reci_iRegistroCivilId bigint,
@reci_sUsuarioModificacion smallint,
@reci_vIPModificacion varchar(50),
@reci_sOficinaConsularId smallint,
@reci_vHostName varchar(20)
AS
BEGIN
	DECLARE @datFechaRegistro datetime;
	SET @datFechaRegistro = PS_ACCESORIOS.FN_OBTENER_FECHAACTUAL(@reci_sOficinaConsularId);	

	SET NOCOUNT ON

	BEGIN TRY

	UPDATE PN_REGISTRO.RE_REGISTROCIVIL
	SET 
		reci_cEstado = 'E',      
		reci_sUsuarioModificacion = @reci_sUsuarioModificacion,
		reci_vIPModificacion = @reci_vIPModificacion,
		reci_dFechaModificacion = @datFechaRegistro
	 WHERE reci_iRegistroCivilId = @reci_iRegistroCivilId


	 Declare @cTieneCUI char(1)
	 Declare @sTipoActaId smallint
	 Declare @iActuacionDetalle Bigint

	 Select @iActuacionDetalle = RC.reci_iActuacionDetalleId,
	 @cTieneCUI = ISNULL(RC.reci_cConCUI,'N'), @sTipoActaId = RC.reci_sTipoActaId
	 From PN_REGISTRO.RE_REGISTROCIVIL RC (nolock)
	 WHere RC.reci_iRegistroCivilId = @reci_iRegistroCivilId

	 UPDATE PN_REGISTRO.RE_ACTUACIONPARTICIPANTE
	 Set acpa_cEstado = 'E',
		 acpa_sUsuarioModificacion = @reci_sUsuarioModificacion,
		 acpa_vIPModificacion = @reci_vIPModificacion,
		 acpa_dFechaModificacion = @datFechaRegistro
	 Where acpa_iActuacionDetalleId = @iActuacionDetalle

	--------------------------------------------------
Declare @sParTipoActa  SMALLINT

SET @sParTipoActa = (SELECT P.para_sParametroId FROM [PS_SISTEMA].[SI_PARAMETRO] P (nolock)
					WHERE P.para_vGrupo='REGISTRO CIVIL-TIPO RECONOCIMIENTO'
							AND P.para_vDescripcion = 'NACIMIENTO' AND P.para_cEstado = 'A')


if (@sTipoActaId = @sParTipoActa AND @cTieneCUI = 'S')
BEGIN
	Declare @sParTitular  SMALLINT

	SET @sParTitular = ISNULL((select par.para_sParametroId from [PS_SISTEMA].[SI_PARAMETRO] par (nolock)
							where par.para_vGrupo='REGISTRO CIVIL - PARTICIPANTE TIPO NACIMIENTO'
							and par.para_vDescripcion = 'TITULAR'),0)
	IF (@sParTitular > 0)
	BEGIN

	DECLARE @IPERSONAID	BIGINT

	SET @IPERSONAID = ISNULL((SELECT ACTPAR.acpa_iPersonaId
						FROM [PN_REGISTRO].[RE_REGISTROCIVIL] RC (nolock)
						INNER JOIN PN_REGISTRO.RE_ACTUACIONPARTICIPANTE ACTPAR (nolock) ON
						RC.reci_iActuacionDetalleId = ACTPAR.acpa_iActuacionDetalleId
						WHERE RC.reci_iRegistroCivilId = @reci_iRegistroCivilId and 
							  ACTPAR.acpa_sTipoParticipanteId = @sParTitular),0) 

		IF (@IPERSONAID > 0)
		BEGIN	
		   UPDATE [PN_REGISTRO].[RE_PERSONA]
		   SET [pers_cEstado] = 'E',
			   [pers_sUsuarioModificacion]=@reci_sUsuarioModificacion,
			   [pers_vIPModificacion] = @reci_vIPModificacion,
			   [pers_dFechaModificacion] = @datFechaRegistro
		   WHERE [pers_iPersonaId] = @IPERSONAID

			UPDATE [PN_REGISTRO].[RE_PERSONAIDENTIFICACION]
			SET [peid_cEstado] = 'E',
				[peid_sUsuarioModificacion] = @reci_sUsuarioModificacion,
				[peid_vIPModificacion] = @reci_vIPModificacion,
				[peid_dFechaModificacion] = @datFechaRegistro
			WHERE [peid_iPersonaId] = @IPERSONAID
		END
	END				
END

	--------------------------------------------------

	-- AUDITORIA
	DECLARE @vCamposGenerales varchar(500);				
	SET @vCamposGenerales = '8,1057,1101,376'

	EXEC PS_SISTEMA.USP_SI_AUDITORIA_ADICIONAR
		@vCamposGenerales = @vCamposGenerales,
		@vNombreTabla = 'RE_REGISTROCIVIL',
		@vClavePrimaria = @reci_iRegistroCivilId,
		@sOficinaConsularId = @reci_sOficinaConsularId,			
		@audi_vComentario = 'Registro de Registro Civil',
		@audi_vHostName = @reci_vHostName,
		@audi_sUsuarioCreacion = @reci_sUsuarioModificacion,
		@audi_vIPCreacion = @reci_vIPModificacion

	 END TRY
	 BEGIN CATCH
		DECLARE @ErrorNumber INT = ERROR_NUMBER();
		DECLARE @ErrorMessage NVARCHAR(1000) = ERROR_MESSAGE() 
		RAISERROR('Error Number-%d : Error Message-%s', 16, 1, @ErrorNumber, @ErrorMessage)		
	 END CATCH

	 SET NOCOUNT OFF
END

