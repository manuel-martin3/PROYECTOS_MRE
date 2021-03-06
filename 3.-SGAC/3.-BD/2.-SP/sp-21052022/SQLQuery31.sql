USE [BD_SGAC]
GO
/****** Object:  StoredProcedure [PN_REGISTRO].[USP_RE_ACTONOTARIALPROTOCOLAR_OBTENER_PARA_CUERPO]    Script Date: 21/05/2022 3:11:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ======================================================================================================
-- Objeto: PN_REGISTRO.USP_RE_ACTONOTARIALPROTOCOLAR_OBTENER_PARA_CUERPO
-- Descripción: Obtiene los datos principales del acto protocolar realizado
-- Parámetro(s):
	-- @acno_iActoNotarialId				bigint,		Id del Acto Notarial 
	-- @acno_sOficinaConsularId				smallint	Id de la oficina consular 
		
-- Fecha Creación:		27/04/2015
-- Autor:		Sandro Guinet
-- Version:		1.0
-- Cambios Importantes:
-- 24/08/2015	MDIAZ		Cambio de longitud del parámetro denominación
-- 25/09/2017	MMARQUEZ	Se adiciono la columna fecha de conclusión de la firma
-- ======================================================================================================
-- MODIFICADO POR: JONATAN SILVA CACHAY
-- FECHA DE MODIFICACIÓN: 27/02/2018
-- MOTIVO: SE MODIFICA LA FECHA @Fecha por la fecha del pago del acto 
-- ======================================================================================================
-- MODIFICADO POR: JONATAN SILVA CACHAY
-- FECHA DE MODIFICACIÓN: 12/12/2018
-- MOTIVO: SE AGREGA LOS CAMPOS DE SUBTIPO DE ACTO Y PARTIDA REGISTRAL
-- ======================================================================================================
-- MODIFICADO POR: JONATAN SILVA CACHAY
-- FECHA DE MODIFICACIÓN: 19/03/2019
-- MOTIVO: SE AGREGA EL CAMPO @vAcno_vPresentanteNombre
-- ======================================================================================================
-- MODIFICADO POR: MIGUEL MÁRQUEZ BELTRÁN
-- FECHA DE MODIFICACIÓN: 06/09/2021
-- MOTIVO: ADICIONAR LA COLUMNA acno_iOficinaRegistralId
-- ======================================================================================================
--	FECHA		USUARIO		MOTIVO
-- ======================================================================================================
--	30/12/2021	MMARQUEZ	SE ADICIONO LA COLUMNA: @vOficinaRegistral
-- ======================================================================================================
ALTER PROCEDURE [PN_REGISTRO].[USP_RE_ACTONOTARIALPROTOCOLAR_OBTENER_PARA_CUERPO]
@acno_iActoNotarialId	bigint,
@acno_sOficinaConsularId smallint
AS
BEGIN

	DECLARE @Fecha AS varchar(20)
	DECLARE @FechaConclusionFirma as varchar(20)
	DECLARE @Departamento AS varchar(50)
	DECLARE @Provincia AS varchar(50)
	DECLARE @Distrito AS varchar(50)	
	DECLARE @CiudadOficinaConsular AS varchar(50)
	DECLARE @NombreOficinaConsular AS varchar(100)

	DECLARE @NombreFuncionario AS varchar(50)
	DECLARE @NumeroDocumentoFuncionario AS varchar(50)
	DECLARE @CiudadOficinaFuncionario AS varchar(50)

	DECLARE @vTipoActoNotarialId AS varchar(5) 
	DECLARE @vSubTipoActoNotarialDesc AS varchar(100)
	DECLARE @vSubTipoActoNotarialId AS varchar(100)
	DECLARE @vDenominacion AS varchar(200)

	DECLARE @vNroEscritura AS varchar(50)
	DECLARE @vNroFojaInicial AS smallint
	DECLARE @vNroFojaFinal AS smallint
	DECLARE @vNroLibro AS varchar(50)	
	DECLARE @Minuta AS bit

	DECLARE @sAutorizacionTipoId AS varchar(100)
	DECLARE @vNumeroColegiatura AS varchar(50)
	DECLARE @vFirmaIlegible AS varchar(200)

	DECLARE @CargoFuncionario AS varchar(200)
	DECLARE @acno_iNumeroActoNotarial AS VARCHAR(20)
	DECLARE @UBIGEOREGISTRADOR AS VARCHAR(6)
	DECLARE @sGeneroFuncionario as SMALLINT
	DECLARE @vPartidaRegistral as Varchar(30)
	DECLARE @vSubTipoActoNotarialExtraProtocolar as Varchar(100)
	DECLARE @vAcno_vPresentanteNombre VARCHAR(200)
	DECLARE @iOficinaRegistral smallint
	DECLARE @vOficinaRegistral	varchar(100)
	SET NOCOUNT ON

	BEGIN TRY

	--FECHA ACTUAL
	SET @Fecha = CONVERT(VARCHAR, PS_ACCESORIOS.FN_OBTENER_FECHAACTUAL(@acno_sOficinaConsularId), 103)

	--DATOS DEL ACTO PROTOCOLAR
	SELECT
		@vTipoActoNotarialId = TA.para_vDescripcion, 
		@vSubTipoActoNotarialId = SUBTIPO.para_sParametroId,
		@vSubTipoActoNotarialDesc = SUBTIPO.para_vDescripcion,
		@vDenominacion = AN.acno_vDenominacion,
		@Minuta = acno_bFlagMinuta,
		@vNroEscritura = AN.acno_vNumeroEscrituraPublica,
		@vNroFojaInicial = AN.acno_vNumeroFojaInicial,
		@vNroFojaFinal = AN.acno_vNumeroFojaFinal,
		@vNroLibro = AN.acno_vNumeroLibro,
		
		@sAutorizacionTipoId = AN.acno_vAutorizacionTipo,
		@vNumeroColegiatura = AN.acno_vNumeroColegiatura,
		@acno_iNumeroActoNotarial = AN.acno_iNumeroActoNotarial,
		@UBIGEOREGISTRADOR = AN.acno_cRegistradorUbigeo,
		@FechaConclusionFirma = CONVERT(VARCHAR, AN.acno_dFechaConclusionFirma,103),
		@Fecha = ISNULL(CONVERT(VARCHAR,AN.acno_dFechaPagoActo,103),@Fecha),
		@vSubTipoActoNotarialExtraProtocolar = ISNULL(SUBTIPOAN.para_vDescripcion,''),
		@vAcno_vPresentanteNombre = acno_vPresentanteNombre,
		@iOficinaRegistral = AN.acno_iOficinaRegistralId,
		@vOficinaRegistral = ISNULL((SELECT ofic_vDescripcion FROM SC_SUNARP.SU_MAESTRO_OFICINAS OFI (nolock)
								WHERE OFI.ofic_iOficinaId = AN.acno_iOficinaRegistralId),'')
	FROM
		PN_REGISTRO.RE_ACTONOTARIAL AN	(NoLock)
		INNER JOIN PS_SISTEMA.SI_PARAMETRO TA (NoLock)ON AN.acno_sTipoActoNotarialId = TA.para_sParametroId
		INNER JOIN PS_SISTEMA.SI_PARAMETRO SUBTIPO (NoLock)ON AN.acno_sSubTipoActoNotarialId = SUBTIPO.para_sParametroId	
		INNER JOIN PS_SISTEMA.SI_PARAMETRO SUBTIPOAN (NoLock)ON AN.acno_sSubTipoActoNotarialExtraProtocolarId = SUBTIPOAN.para_sParametroId	
	WHERE
		AN.acno_iActoNotarialId = @acno_iActoNotarialId

	--DATOS DE LA OFICINA CONSULAR
		
	SELECT
		@Departamento = ubge_vDepartamento,
		@Provincia = ubge_vProvincia,
		@Distrito = ubge_vDistrito,		
		@CiudadOficinaConsular = ubge_vDistrito,		 
		@NombreOficinaConsular = ofco_vNombre
	FROM
		PS_SISTEMA.SI_OFICINACONSULAR OFCO (NoLock) 
		INNER JOIN PS_SISTEMA.SI_UBICACIONGEOGRAFICA UBI (NoLock) ON OFCO.ofco_cUbigeoCodigo = UBI.ubge_cCodigo
	WHERE
		OFCO.ofco_sOficinaConsularId = @acno_sOficinaConsularId AND
		OFCO.ofco_cEstado='A'


	SELECT
		@NombreFuncionario= (FUN.ocfu_vNombreFuncionario + ' ' + FUN.ocfu_vApellidoPaternoFuncionario + ' ' + FUN.ocfu_vApellidoMaternoFuncionario),
		@NumeroDocumentoFuncionario=FUN.ocfu_vDocumentoNumero,
		@CiudadOficinaFuncionario=ubge_vDistrito,
		@CargoFuncionario = FUN.ocfu_vCargo,
		@sGeneroFuncionario = FUN.ocfu_sGenero,
		@vPartidaRegistral = ISNULL(ACNO.acno_vPartidaRegistral,'')
	FROM
		PN_REGISTRO.RE_ACTONOTARIAL ACNO  (NoLock)
		INNER JOIN PN_REGISTRO.RE_OFICINACONSULARFUNCIONARIO FUN  (NoLock) ON ACNO.acno_IFuncionarioAutorizadorId=FUN.ocfu_IFuncionarioId 
			AND FUN.ocfu_sOficinaConsularId = ACNO.acno_sOficinaConsularId
		INNER JOIN PS_SISTEMA.SI_OFICINACONSULAR OFC  (NoLock) ON ACNO.acno_sOficinaConsularId=OFC.ofco_sOficinaConsularId
		INNER JOIN PS_SISTEMA.SI_UBICACIONGEOGRAFICA UBI  (NoLock) ON OFC.ofco_cUbigeoCodigo=UBI.ubge_cCodigo 
	WHERE
		ACNO.acno_iActoNotarialId=@acno_iActoNotarialId 
		AND	FUN.ocfu_cEstado='A'
   			
		
	--DATOS DE SALIDA
	SELECT
	UPPER(isnull(@Distrito,'')) Distrito, --Ciudad
	UPPER(isnull(@Departamento,'')) Departamento, --Continente
	UPPER(isnull(@Provincia,'')) Provincia,	-- Pais
	@Fecha Fecha,
	isnull(@Minuta, 0) Minuta,
	UPPER(isnull(@CiudadOficinaConsular,'')) CiudadOficinaConsular, --Ciudad
	UPPER(isnull(@NombreOficinaConsular,'')) NombreOficinaConsular,
	UPPER(isnull(@NombreFuncionario,'')) NombreFuncionario, 
	UPPER(isnull(@NumeroDocumentoFuncionario,'')) NumeroDocumentoFuncionario, 
	UPPER(isnull(@CiudadOficinaFuncionario,'')) CiudadOficinaFuncionario,

	UPPER(isnull(@CargoFuncionario,'')) CargoFuncionario,

	UPPER(isnull(@vTipoActoNotarialId,'')) TipoActoNotarialId, 
	UPPER(isnull(@vSubTipoActoNotarialId,'')) SubTipoActoNotarialId,
	UPPER(isnull(@vSubTipoActoNotarialDesc,'')) SubTipoActoNotarialDesc,
	UPPER(isnull(@vDenominacion,'')) vDenominacion,
	UPPER(isnull(@vNroEscritura,'')) NumeroEscrituraPublica,
	UPPER(isnull(@vNroFojaInicial,'')) NumeroFojaInicial,
	UPPER(isnull(@vNroFojaFinal,'')) vNumeroFojaFinal,
	UPPER(isnull(@vNroLibro,'')) vNroLibro,

	UPPER(isnull(@sAutorizacionTipoId,'')) AutorizacionTipoId,
	UPPER(isnull(@vNumeroColegiatura,'')) NumeroColegiatura,
	UPPER(isnull(@acno_iNumeroActoNotarial,'')) acno_iNumeroActoNotarial,
		
	UPPER(isnull(@UBIGEOREGISTRADOR,'')) acno_cRegistradorUbigeo,
	isnull(@sGeneroFuncionario,1) sGeneroFuncionario,
	@FechaConclusionFirma FechaconclusionFirma,
	@vPartidaRegistral vPartidaRegistral,
	@vSubTipoActoNotarialExtraProtocolar vSubTipoActoNotarialExtraProtocolar,
	ISNULL(@vAcno_vPresentanteNombre,'') vAcno_vPresentanteNombre,
	isnull(@iOficinaRegistral,0) iOficinaRegistral,
	ISNULL(@vOficinaRegistral,'') vOficinaRegistral

	END TRY
	BEGIN CATCH
		DECLARE @ErrorNumber INT = ERROR_NUMBER();
		DECLARE @ErrorMessage NVARCHAR(1000) = ERROR_MESSAGE() 
		RAISERROR('Error Number-%d : Error Message-%s', 16, 1,@ErrorNumber, @ErrorMessage)
	END CATCH

	SET NOCOUNT OFF

END

