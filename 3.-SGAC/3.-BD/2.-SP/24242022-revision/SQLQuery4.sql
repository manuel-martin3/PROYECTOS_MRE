USE [BD_SGAC]
GO
/****** Object:  StoredProcedure [PN_REGISTRO].[USP_RE_REGISTROCIVIL_ADICIONAR]    Script Date: 24/04/2022 13:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--====================================================================================================
-- Nombre: PN_REGISTRO.USP_RE_REGISTROCIVIL_ADICIONAR
-- Descripción: ADICIONAR REGISTRO EN LA TABLA RE_REGISTROCIVIL
-- Fecha Creación:		26/12/2014
-- Fecha Modificacion:	08/02/2015
-- Descripción Parámetros:
-- Parámetro(s):
	-- @reci_iActuacionDetalleId				bigint			Id de detalle de actuación,
	-- @reci_sTipoActaId						smallint		Id de tipo de acta,
	-- @reci_vNumeroCUI							varchar(20)		Numer CUI,
	-- @reci_iNumeroActa						int				Numero de acta,
	-- @reci_dFechaRegistro						datetime		Fecha de registro del acto civil,
	-- @reci_cOficinaRegistralUbigeo			char(6)			Codigo ubigeo de la oficina registral,
	-- @reci_IOficinaRegistralCentroPobladoId	int				Id de centro poblado donde se encuentra oficina registral,	
	-- @reci_dFechaHoraOcurrenciaActo			datetime		Registro de la Fecha de la fecha de Ocurrencia,
	-- @reci_sOcurrenciaTipoId					smallint		Id del tipo de lugar de ocurrencia del acto civil,
	-- @reci_vOcurrenciaLugar					varchar(100)	Dirección del lugar de ocurrencia del acto civil,
	-- @reci_cOcurrenciaUbigeo					char(6)			Codigo de ubig,
	-- @reci_IOcurrenciaCentroPobladoId			int				Registro o descripción del centro poblado,
	-- @reci_vNumeroExpedienteMatrimonio		varchar(100)	Registro del número de expediente,
	-- @reci_IAprobacionUsuarioId				int				Id del usuario que aprueba el cuadro civil,
	-- @reci_vIPAprobacion						varchar(50)		Identificador IP de la PC en donde se aprueba la digitalización,
	-- @reci_dFechaAprobacion					datetime		Registro de la fecha de Aprobación de la digitalización,
	-- @reci_bDigitalizadoFlag					bit				Registro del estado del documento digitalizado,
	-- @reci_vCargoCelebrante					varchar(300)	Nombre del cargo celebrante,
	-- @reci_vLibro								varchar(50)		Descripción del libro asignado al acto civil,
	-- @reci_bAnotacionFlag						bit				Registro del estado de anotación,
	-- @reci_vObservaciones						varchar(300)	Registro o descripción de las observaciones ,	
	-- @reci_sUsuarioCreacion					smallint		Usuario que crea el registro,
	-- @reci_vIPCreacion						varchar(50)		IP de la pc donde se crea el registro,	
	-- @reci_sOficinaConsularId					smallint		Id de oficina consular,
	-- @reci_vHostName							varchar(20)		Nombre del hostname,
	-- @reci_iRegistroCivilId					bigint out		Retorna del id del registro civil,
	-- @reci_cConCUI							char(1)			Identificar si es con CUI (valor S/N)
	-- @reci_cReconocimientoAdopcion			char(1)			Identificar si es con Reconocimiento o Adopción (valor S/N)
	-- @reci_cReconstitucionReposicion			char(1)			Identificar si es con Reconstitución o Reposición (valor S/N)
	-- @reci_iNumeroActaAnterior				int				Número de acta anterior de un acto civil
	-- @reci_vTitular							varchar(200)	Nombre del Titular
-- Autor: Sandro Guinet
-- Version: 2.0
-- Cambios Importantes:
--====================================================================================================
-- MODIFICADO POR: JONATAN SILVA CACHAY
-- FECHA DE MODIFICACIÓN: 29/05/2018
-- MOTIVO: SE AUMENTA A 70 EL VARCHAR DE OCURRENFCIA
--====================================================================================================
-- MODIFICADO POR: MIGUEL MÁRQUEZ BELTRÁN
-- FECHA: 15/10/2018
-- MOTIVO: SE ADICIONARON LOS PARAMETROS: @reci_cConCUI, @reci_cReconocimientoAdopcion, 
--				@reci_cReconstitucionReposicion, @reci_iNumeroActaAnterior y @reci_vTitular
--====================================================================================================
-- MODIFICADO POR: JONATAN SILVA CACHAY
-- FECHA: 19/06/2020
-- MOTIVO: SE REGISTRA LA @reci_cOficinaRegistralUbigeo segun el codigo de la oficina consular 
--====================================================================================================
-- MODIFICADO POR: MIGUEL MÁRQUEZ BELTRÁN
-- FECHA: 01/09/2021
-- MOTIVO: SE ADICIONA EL PARAMETRO: @reci_bInscripcionOficio
--====================================================================================================
ALTER PROCEDURE [PN_REGISTRO].[USP_RE_REGISTROCIVIL_ADICIONAR]
@reci_iActuacionDetalleId bigint,
@reci_sTipoActaId smallint = NULL,
@reci_vNumeroCUI varchar(20) = NULL,
@reci_vNumeroActa varchar(10) = NULL,
@reci_dFechaRegistro datetime = NULL,
@reci_cOficinaRegistralUbigeo char(6) = NULL,
@reci_IOficinaRegistralCentroPobladoId int = null,
@reci_dFechaHoraOcurrenciaActo datetime = null,
@reci_sOcurrenciaTipoId smallint = NULL,
@reci_vOcurrenciaLugar varchar(70) = NULL,
@reci_cOcurrenciaUbigeo char(6) = NULL,
@reci_IOcurrenciaCentroPobladoId int = null,
@reci_vNumeroExpedienteMatrimonio varchar(100) = NULL,
@reci_IAprobacionUsuarioId int = NULL,
@reci_vIPAprobacion varchar(50) = NULL,
@reci_dFechaAprobacion datetime = null,
@reci_bDigitalizadoFlag bit = NULL,
@reci_vCargoCelebrante varchar(100),
@reci_vLibro varchar(50) = NULL,
@reci_bAnotacionFlag bit = NULL,
@reci_vObservaciones varchar(300) = NULL,
@reci_sUsuarioCreacion smallint = NULL,
@reci_vIPCreacion varchar(50),
@reci_sOficinaConsularId smallint = NULL,
@reci_vHostName varchar(20),
@reci_iRegistroCivilId bigint out,
@reci_cConCUI	char(1) = '',
@reci_cReconocimientoAdopcion char(1) = '',
@reci_cReconstitucionReposicion char(1) = '',
@reci_iNumeroActaAnterior int = null,
@reci_vTitular	varchar(200) = '',
@reci_bInscripcionOficio bit = NULL
AS
BEGIN
	
	DECLARE @datFechaRegistro datetime;
	DECLARE @cOficinaRegistralUbigeo CHAR(6)
	SET @datFechaRegistro = PS_ACCESORIOS.FN_OBTENER_FECHAACTUAL(@reci_sOficinaConsularId);	

	SET NOCOUNT ON


	BEGIN TRY	
	Select @cOficinaRegistralUbigeo = ofco_cUbigeoCodigo
	FROM [PS_SISTEMA].[SI_OFICINACONSULAR] 
	Where ofco_sOficinaConsularId = @reci_sOficinaConsularId

	Select @reci_cOficinaRegistralUbigeo = @cOficinaRegistralUbigeo

	INSERT INTO PN_REGISTRO.RE_REGISTROCIVIL
		(reci_iActuacionDetalleId, reci_sTipoActaId, reci_vNumeroCUI, reci_vNumeroActa,	reci_dFechaRegistro,
		 reci_cOficinaRegistralUbigeo, reci_IOficinaRegistralCentroPobladoId, reci_dFechaHoraOcurrenciaActo, reci_sOcurrenciaTipoId, reci_vOcurrenciaLugar, reci_cOcurrenciaUbigeo, reci_IOcurrenciaCentroPobladoId,
		 reci_vNumeroExpedienteMatrimonio, reci_IAprobacionUsuarioId, reci_vIPAprobacion, reci_dFechaAprobacion, reci_bDigitalizadoFlag,
		 reci_vCargoCelebrante, reci_vLibro, reci_bAnotacionFlag, reci_vObservaciones,reci_cEstado,
		 reci_sUsuarioCreacion, reci_vIPCreacion, reci_dFechaCreacion,
		 reci_cConCUI, reci_cReconocimientoAdopcion, reci_cReconstitucionReposicion, reci_iNumeroActaAnterior, reci_vTitular, reci_bInscripcionOficio)
	VALUES(@reci_iActuacionDetalleId, @reci_sTipoActaId, @reci_vNumeroCUI, @reci_vNumeroActa, @reci_dFechaRegistro,
		   @reci_cOficinaRegistralUbigeo, @reci_IOcurrenciaCentroPobladoId, @reci_dFechaHoraOcurrenciaActo, @reci_sOcurrenciaTipoId, @reci_vOcurrenciaLugar, @reci_cOcurrenciaUbigeo, @reci_IOcurrenciaCentroPobladoId,
		   @reci_vNumeroExpedienteMatrimonio, @reci_IAprobacionUsuarioId, @reci_vIPAprobacion, @reci_dFechaAprobacion, @reci_bDigitalizadoFlag,
		   @reci_vCargoCelebrante, @reci_vLibro, @reci_bAnotacionFlag, @reci_vObservaciones,'A',
		   @reci_sUsuarioCreacion, @reci_vIPCreacion, @datFechaRegistro,
		   @reci_cConCUI, @reci_cReconocimientoAdopcion, @reci_cReconstitucionReposicion, @reci_iNumeroActaAnterior, @reci_vTitular, @reci_bInscripcionOficio)

	SET @reci_iRegistroCivilId = @@IDENTITY -- toma el nuevo id generado

	-- AUDITORIA
	DECLARE @vCamposGenerales varchar(500);		
	SET @vCamposGenerales = '8,1055,1101,376'
	EXEC PS_SISTEMA.USP_SI_AUDITORIA_ADICIONAR
		@vCamposGenerales = @vCamposGenerales,
		@vNombreTabla = 'RE_REGISTROCIVIL',
		@vClavePrimaria = @reci_iRegistroCivilId,
		@sOficinaConsularId = @reci_sOficinaConsularId,	
		@audi_vComentario = 'Registro de Registro Civil',
		@audi_vHostName = @reci_vHostName,
		@audi_sUsuarioCreacion = @reci_sUsuarioCreacion,
		@audi_vIPCreacion = @reci_vIPCreacion
	END TRY
	BEGIN CATCH
		DECLARE @ErrorNumber INT = ERROR_NUMBER();
		DECLARE @ErrorMessage NVARCHAR(1000) = ERROR_MESSAGE() 
		RAISERROR('Error Number-%d : Error Message-%s', 16, 1, @ErrorNumber, @ErrorMessage)		
	END CATCH
	
	SET NOCOUNT OFF
END

