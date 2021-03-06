USE [BD_SGAC_local]
GO
/****** Object:  StoredProcedure [PN_REPORTES].[USP_RP_NOTARIAL_PROTOCOLAR_PARTE]    Script Date: 02/06/2022 11:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--=========================================================================================
-- Nombre				: [PN_REPORTES].[USP_RP_NOTARIAL_PROTOCOLAR_PARTE]
-- Descripción			: Formato de reporte Protocolar Parte
-- Fecha Creación		: 26/01/2015
-- Fecha Modificacion	: 23/09/2021
-- Parámetro(s)			:	
	--@acno_iActoNotarialId			BIGINT		Identificador de Acto Notarial
	--@acno_sOficinaConsularId		SMALLINT	Identificador de Oficina consular
	--@acno_sNumeroParte			SMALLINT 	Identificador de Numero de Parte
	--@acno_vNumeroOficio			VARCHAR(20)	Número de Oficio que se imprimirá en el parte.	
-- Autor				: JOSE CAYCHO
-- Version				: 1.0
-- Cambios:
-- MDIAZ	17/09/2015	Se agrega dato de número de oficio y Se cambia la obtención de los datos
-- MDIAZ	13/10/2015	DATOS NUEVOS DEL PRESENTANTE : SOLICITUD DE PARTES ADICIONALES
-- MMARQUEZ 24/04/2020	SE REEMPLAZA: [PN_REGISTRO].[FN_OBTENER_DATOS_PERSONA] POR
--										[PN_REGISTRO].[FN_OBTENER_DATOS_PERSONA_PROTOCOLAR]
-- MMARQUEZ 27/04/2020	SE REEMPLAZO LA FUNCIÓN [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA] 
--						POR UNA FUNCIÓN PARA CONVERTIR DE NUMEROS A ROMANOS:
--									PS_ACCESORIOS.FN_CONVERTIR_NUMERO_A_ROMANO.
-- MMARQUEZ	21/12/2020	SE CAMBIÓ A MAYUSCULAS EL TEXTO DE LA PRIMERA HOJA DEL PARTE.
-- MMARQUEZ	06/09/2021	SE ADICIONO LA COLUMNA acno_iOficinaRegistralId
-- MMARQUEZ	23/09/2021	SE MODIFICA EL FORMATO
-- MMARQUEZ	23/11/2021	SE CONCATENAN LOS PARTICIPANTES PARA MOSTRAR TODOS LOS PARTICIPANTES.
-- MMARQUEZ	02/12/2021	SE MUESTRA EL AÑO AL LADO IZQUIERDO DEL NRO.OFICIO Y
--						SE MUESTRA EL NRO. DE ESCRITURA.
--=========================================================================================
-- FECHA		USUARIO		MOTIVO
--=========================================================================================
--21/12/2021	MMARQUEZ	CAMBIAR EL CONTENIDO DEL PARTE.
--30/12/2021	MMARQUEZ	CAMBIOS EN EL FORMATO DEL PARTE.
--10/01/2022	MMARQUEZ	SE CAMBIA OTORGANTE POR PODERDANTE.
--13/01/2022	MMARQUEZ	SE ADICIONA AL PRESENTANTE.
--04/03/2022	MMARQUEZ	SE CAMBIA EL CONTENIDO Y SE ADICIONAN LOS PRESENTANTES.
--=========================================================================================
/*
exec PN_REPORTES.[USP_RP_NOTARIAL_PROTOCOLAR_PARTE] 
@acno_iActoNotarialId=31696,@acno_sOficinaConsularId=30,@acno_sNumeroParte=1,@acno_vNumeroOficio='1230'
go
*/
ALTER PROCEDURE [PN_REPORTES].[USP_RP_NOTARIAL_PROTOCOLAR_PARTE]
@acno_iActoNotarialId		BIGINT,
@acno_sOficinaConsularId	SMALLINT,
@acno_sNumeroParte			SMALLINT = NULL,
@acno_vNumeroOficio			varchar(20) = NULL
 AS
 BEGIN

	DECLARE @vParteInicio VARCHAR(MAX) = ''
	DECLARE @vParteFecha VARCHAR(MAX) = ''
	DECLARE @vParteFin VARCHAR(MAX) = ''


	DECLARE @Departamento AS varchar(50) = ''
	DECLARE @Provincia AS varchar(50)  = ''
	DECLARE @Distrito AS varchar(50)	  = ''
	DECLARE @CiudadOficinaConsular AS varchar(50)  = ''
	
	DECLARE @NombreOficinaConsular AS varchar(200)  = ''

	DECLARE @NombreFuncionario AS varchar(200)  = ''
	DECLARE @NumeroDocumentoFuncionario AS varchar(50)  = ''
	DECLARE @CiudadOficinaFuncionario AS varchar(50)  = ''

	DECLARE @vTipoActoNotarialId AS varchar(5)  = ''
	DECLARE @vSubTipoActoNotarialDesc AS varchar(100)  = ''
	DECLARE @vSubTipoActoNotarialId AS varchar(100)  = ''
	DECLARE @vDenominacion AS varchar(200)  = ''

	DECLARE @vNroEscritura AS varchar(50)  = ''
	DECLARE @vNroFojaInicial AS smallint  = 0
	DECLARE @vNroFojaFinal AS smallint = 0

	DECLARE @vNroLibro AS varchar(50)	  = ''
	DECLARE @Minuta AS bit  = 0

	DECLARE @sAutorizacionTipoId AS varchar(100)  = ''
	DECLARE @vNumeroColegiatura AS varchar(50)  = ''
	DECLARE @vFirmaIlegible AS varchar(200)  = ''

	DECLARE @CargoFuncionario AS varchar(200)  = ''


	DECLARE @acno_vRegistrador varchar(200)  = ''
	DECLARE @acno_cRegistradorUbigeo char(6)  = ''
	
	DECLARE @acno_vRegistrador_ubge_vDepartamento varchar(200)  = ''
	DECLARE @acno_vRegistrador_ubge_vProvincia varchar(200)  = ''
	DECLARE @acno_vRegistrador_ubge_vDistrito varchar(200) = ''
	 	
	DECLARE @vEmpresa VARCHAR(200)  = ''
	DECLARE @Pers_iPersonaID BIGINT = 0
	DECLARE @vPersona VARCHAR(200)  = ''
	DECLARE @vTipoParticioanteId VARCHAR(200)  = ''
	DECLARE @vDescTipDoc VARCHAR(200)  = ''
	DECLARE @vNroDoc VARCHAR(20)  = ''
	DECLARE @pers_sNacionalidad SMALLINT = 0
	DECLARE @vNacionalidad VARCHAR(200)  = ''
	DECLARE @pers_sEstadoCivil SMALLINT = 0
	DECLARE @vEstadoCivil VARCHAR(100)  = ''
	DECLARE @vDireccion VARCHAR(200)  = ''
	DECLARE @cResidenciaUbigeo VARCHAR(200)
	DECLARE @DptoCont VARCHAR(100)  = ''
	DECLARE @ProvPais VARCHAR(100)  = ''
	DECLARE @DistCiu VARCHAR(100)  = ''
	DECLARE @Ocupacion VARCHAR(200)  = ''
	DECLARE @vProfesion VARCHAR(200)  = ''
	DECLARE @vTipoDocumeno VARCHAR(100)  = ''
	DECLARE @iGenero SMALLINT = 0

	DECLARE @STR_GENERO VARCHAR(50)  = ''
	DECLARE @strEstadoCivil VARCHAR(50)  = ''
	DECLARE @strOcupacion VARCHAR(150)  = ''
	
	
	DECLARE @strParticipanteOtorgantes VARCHAR(500) = ''
	DECLARE @strParticipanteOtorgantes_V2 VARCHAR(500) = ''
	DECLARE @strParticipanteOtorgantes_V3 VARCHAR(1000) = ''

	DECLARE @strParticipanteFavorecido VARCHAR(200) = ''
	DECLARE @strParticipanteFavorecido_V2 VARCHAR(500) = ''
	DECLARE @strOtorganteArticuloSexoPS VARCHAR(20) = 'EL'
	DECLARE @strOtorganteOtorgaSP VARCHAR(20) = 'OTORGA'
	DECLARE	@strParticipanteQuienSP VARCHAR(20) = 'QUIEN'
    DECLARE @strParticipanteElSP VARCHAR(20) = 'LE'
    DECLARE	@strParticipanteCompareceSP VARCHAR(20) = 'COMPARECE' 
	DECLARE	@strParticipanteAfirmoSP VARCHAR(20) = 'AFIRMÓ' 
	DECLARE	@strParticipanteRatificoSP VARCHAR(20) = 'RATIFICÓ' 
	DECLARE	@strParticipanteHaSP VARCHAR(20) = 'HA' 
	DECLARE	@strParticipanteInformadoSP VARCHAR(20) = 'INFORMADO' 
	DECLARE	@strParticipanteFirmaSP VARCHAR(20) = 'FIRMA' 
	DECLARE	@strParticipanteSuSP VARCHAR(20) = 'SU' 
	DECLARE	@strParticipanteImprimeSP VARCHAR(20) = 'IMPRIME' 
	DECLARE	@strParticipanteHuellaSP VARCHAR(20) = 'HUELLA' 
	DECLARE	@strParticipanteDactilarSP VARCHAR(20) = 'DACTILAR' 
	DECLARE @strParticipanteProcede VARCHAR(20) = 'PROCEDE'
	   
	DECLARE @strParticipanteEsSP VARCHAR(20) = 'ES'
	DECLARE @strParticipanteMayorSP VARCHAR(20) = 'MAYOR'

	DECLARE @strParticipanteOtorgantesSeparador char(2) = ''
	DECLARE @strParticipanteFavorecidoSeparador CHAR(2) = ''

	DECLARE @strParticipanteOtorganteFirma varchar(max) = ''

	DECLARE @ContadorParticipanteHombres INT = 1
	DECLARE @contadorOtorgantes INT = 0
	DECLARE @contadorParticipantes INT = 0 	


	DECLARE @contadorFAVOR INT = 0
	DECLARE @SEPARADOR_AFAVOR VARCHAR(2) = ''
	DECLARE @SEPARADOR_A_FAVOR_ VARCHAR(2) = ''

	DECLARE @AUX_OTORGANTE VARCHAR(200) = ''
	DECLARE @sActuacionID Bigint

	Declare @V_DATOS_OTORGANTE VARCHAR(500)
	Declare @V_DATOS_APODERADO VARCHAR(500)

	Declare @iOficinaRegistralId smallint

	Declare @cCodigoZona       char(2)
	Declare @cCodigoOficina    char(2)
	Declare @vOficinaRegistral varchar(100)
	Declare @vYear	char(4)
	---------------------------------------
	DECLARE @FechaEP		varchar(100)
	DECLARE @FechaParte		varchar(100)
	DECLARE @sNumeroFoja	smallint	
	DECLARE @strOtorgados_das VARCHAR(10)

	SET NOCOUNT ON
------------------------------------------
--17B	EXPEDICION PRIMER PARTE ESCRITURA PUBLICA
--17C	EXPEDICION PARTE ADICIONAL
------------------------------------------

	BEGIN TRY

		SET @FechaEP = convert(varchar,(select an.acno_dFechaExtension from [PN_REGISTRO].[RE_ACTONOTARIAL] an (nolock)
										where an.acno_iActoNotarialId = @acno_iActoNotarialId),103)

		set @FechaParte = convert(varchar,(select P.pago_dFechaOperacion
									from [PN_REGISTRO].[RE_ACTONOTARIAL] an  (nolock)
									inner join [PN_REGISTRO].[RE_ACTUACIONDETALLE] ad  (nolock)
										on an.acno_iActuacionId = ad.acde_iActuacionId
									INNER JOIN [PN_REGISTRO].[RE_ACTONOTARIALDETALLE] ANDE  (nolock)
										ON ad.acde_iActuacionDetalleId = ANDE.ande_iActuacionDetalleId
									INNER JOIN [PN_REGISTRO].[RE_PAGO] P  (nolock)
										ON ad.acde_iActuacionDetalleId = P.pago_iActuacionDetalleId
									INNER JOIN [PS_SISTEMA].[SI_TARIFARIO] t  (nolock) 
										ON ad.acde_sTarifarioId = t.tari_sTarifarioId
									where an.acno_iActoNotarialId =@acno_iActoNotarialId
									AND  t.tari_sNumero = 17 AND t.tari_vLetra IN ('B','C') 
									AND ANDE.ande_sCorrelativo = @acno_sNumeroParte),103)
	
												
		--DATOS DEL ACTO PROTOCOLAR
		SELECT
			@vTipoActoNotarialId = ISNULL(TA.para_vDescripcion,''), 
			@vSubTipoActoNotarialId = ISNULL(SUBTIPO.para_sParametroId,''),
			@vSubTipoActoNotarialDesc = ISNULL(SUBTIPO.para_vDescripcion,''),
			@vDenominacion = AN.acno_vDenominacion,
			@Minuta = acno_bFlagMinuta,
			@vNroEscritura = ISNULL(AN.acno_vNumeroEscrituraPublica,''),
			@vNroFojaInicial = AN.acno_vNumeroFojaInicial,
			@vNroFojaFinal = AN.acno_vNumeroFojaFinal,
			@vNroLibro = AN.acno_vNumeroLibro,
		
			@sAutorizacionTipoId = ISNULL(AN.acno_vAutorizacionTipo,0),
			@vNumeroColegiatura = ISNULL(AN.acno_vNumeroColegiatura,'(SIN N° COLEGIATURA)'),
		
			@acno_vNumeroOficio = ISNULL(@acno_vNumeroOficio,'(N° OFICIO)'),
			@acno_vRegistrador = ISNULL(AN.acno_vRegistradorNombre,'(SIN REGISTRADOR)'),
			@acno_cRegistradorUbigeo = ISNULL(AN.acno_cRegistradorUbigeo,''),

			@sActuacionID = ISNULL(acno_iActuacionId,0),
			@iOficinaRegistralId = ISNULL(AN.acno_iOficinaRegistralId,0),
			@vYear = YEAR(AN.acno_dFechaExtension)
			

		FROM
			PN_REGISTRO.RE_ACTONOTARIAL AN	(nolock)
			INNER JOIN PS_SISTEMA.SI_PARAMETRO TA (nolock) ON AN.acno_sTipoActoNotarialId = TA.para_sParametroId
			INNER JOIN PS_SISTEMA.SI_PARAMETRO SUBTIPO (nolock) ON AN.acno_sSubTipoActoNotarialId = SUBTIPO.para_sParametroId	
		WHERE
			AN.acno_iActoNotarialId = @acno_iActoNotarialId;



		-- SOLICITUD PARTE : NUEVOS DATOS PRESENTANTE
		IF (@acno_sNumeroParte IS NOT NULL)
		BEGIN
			SELECT 
				@sNumeroFoja = det.ande_sNumeroFoja
			FROM PN_REGISTRO.RE_ACTONOTARIALDETALLE DET (nolock)
			INNER JOIN PN_REGISTRO.RE_ACTUACIONDETALLE AD (nolock) ON DET.ande_iActuacionDetalleId = AD.acde_iActuacionDetalleId
			INNER JOIN PN_REGISTRO.RE_ACTUACION A (nolock) ON acde_iActuacionId = A.actu_iActuacionId
			INNER JOIN PN_REGISTRO.RE_ACTONOTARIAL AN (nolock) ON A.actu_iActuacionId = AN.acno_iActuacionId
			WHERE AN.acno_iActoNotarialId = @acno_iActoNotarialId
				AND DET.ANDE_SCORRELATIVO = @acno_sNumeroParte
				AND DET.ande_vNumeroOficio = @acno_vNumeroOficio
		END
	
		--DATOS DE LA OFICINA CONSULAR
		SELECT
			@Departamento = UPPER(ubge_vDepartamento),
			@Provincia = UPPER(ubge_vProvincia),
			@Distrito = UPPER(ubge_vDistrito),		
			@CiudadOficinaConsular = UPPER(ubge_vDistrito),
			@NombreOficinaConsular = UPPER(ofco_vNombre)
		FROM
			 PS_SISTEMA.SI_OFICINACONSULAR OFCO (nolock)
			INNER JOIN PS_SISTEMA.SI_UBICACIONGEOGRAFICA UBI (nolock) ON OFCO.ofco_cUbigeoCodigo = UBI.ubge_cCodigo
		WHERE
			OFCO.ofco_sOficinaConsularId=@acno_sOficinaConsularId AND
			OFCO.ofco_cEstado='A'

		-- DATOS ACTO NOTARIAL : FUNCIONARIO
		SELECT
			@NombreFuncionario= (FUN.ocfu_vNombreFuncionario + ' ' + FUN.ocfu_vApellidoPaternoFuncionario + ' ' + FUN.ocfu_vApellidoMaternoFuncionario),
			@NumeroDocumentoFuncionario=FUN.ocfu_vDocumentoNumero,
			@CiudadOficinaFuncionario=ubge_vDistrito,
			@CargoFuncionario = FUN.ocfu_vCargo
		FROM
			PN_REGISTRO.RE_ACTONOTARIAL ACNO (nolock)
			INNER JOIN PN_REGISTRO.RE_OFICINACONSULARFUNCIONARIO FUN (nolock) ON ACNO.acno_IFuncionarioAutorizadorId=FUN.ocfu_IFuncionarioId
			INNER JOIN PS_SISTEMA.SI_OFICINACONSULAR OFC (nolock) ON ACNO.acno_sOficinaConsularId=OFC.ofco_sOficinaConsularId
			INNER JOIN PS_SISTEMA.SI_UBICACIONGEOGRAFICA UBI (nolock) ON OFC.ofco_cUbigeoCodigo=UBI.ubge_cCodigo 
		WHERE
			ACNO.acno_iActoNotarialId=@acno_iActoNotarialId AND
			FUN.ocfu_cEstado='A' AND
			FUN.ocfu_sOficinaConsularId = @acno_sOficinaConsularId
		
		-- DATOS ACTO NOTARIAL : UBICACIÓN GEOGRÁFICA
		SELECT
			@acno_vRegistrador_ubge_vDepartamento = ubge_vDepartamento,
			@acno_vRegistrador_ubge_vProvincia = ubge_vProvincia,
			@acno_vRegistrador_ubge_vDistrito = ubge_vDistrito
		 
		FROM
			PN_REGISTRO.RE_ACTONOTARIAL ACNO (nolock)
			INNER JOIN PS_SISTEMA.SI_UBICACIONGEOGRAFICA UBI (nolock) ON ACNO.acno_cRegistradorUbigeo = UBI.ubge_cCodigo
		WHERE
			 ACNO.acno_iActoNotarialId = @acno_iActoNotarialId

		SELECT 
			@cCodigoZona = ofic_cCodigoZona,
			@cCodigoOficina = ofic_cCodigoOficina,
			@vOficinaRegistral = ofic_vDescripcion
		FROM SC_SUNARP.SU_MAESTRO_OFICINAS OFI (nolock)
		WHERE OFI.ofic_iOficinaId = @iOficinaRegistralId

		SET @acno_vRegistrador_ubge_vDistrito = (SELECT CASE WHEN LEN(LTRIM(@acno_vRegistrador_ubge_vDistrito)) = 0 THEN 'LIMA' ELSE @acno_vRegistrador_ubge_vDistrito END)
		
		

		/*-- VALOR NUMERICO DEL PARTE EN LETRAS*/
		DECLARE @NumeroCardinal Varchar(50)

		SELECT @NumeroCardinal =
		CASE 
		WHEN @acno_sNumeroParte = 1 THEN 'PRIMER' 
		WHEN @acno_sNumeroParte = 2 THEN 'SEGUNDO' 
		WHEN @acno_sNumeroParte = 3 THEN 'TERCER' 
		WHEN @acno_sNumeroParte = 4 THEN 'CUARTO'
		WHEN @acno_sNumeroParte = 5 THEN 'QUINTO' 
		WHEN @acno_sNumeroParte = 6 THEN 'SEXTO' 
		WHEN @acno_sNumeroParte = 7 THEN 'SEPTIMO' 
		WHEN @acno_sNumeroParte = 8 THEN 'OCTAVO'
		WHEN @acno_sNumeroParte = 9 THEN 'NOVENO' 
		WHEN @acno_sNumeroParte = 10 THEN 'DÉCIMO' 
		WHEN @acno_sNumeroParte = 11 THEN 'UNDÉCIMO' 
		WHEN @acno_sNumeroParte = 12 THEN 'DUODÉCIMO' 
		WHEN @acno_sNumeroParte = 13 THEN 'DECIMO TERCER' 
		WHEN @acno_sNumeroParte = 14 THEN 'DECIMO CUARTO' 
		WHEN @acno_sNumeroParte = 15 THEN 'DECIMO QUINTO' 
		WHEN @acno_sNumeroParte = 16 THEN 'DECIMO SEXTO' 
		WHEN @acno_sNumeroParte = 17 THEN 'DECIMO SEPTIMO' 
		WHEN @acno_sNumeroParte = 18 THEN 'DECIMO OCTAVO' 
		WHEN @acno_sNumeroParte = 19 THEN 'DECIMO NOVENO' 
		WHEN @acno_sNumeroParte = 20 THEN 'VEINTEAVO' 
		END

		-- SECCIÓN INICIAL DEL PARTE (I/II)
		SET @vParteFecha = @vParteFecha +  @CiudadOficinaConsular +', ' +  RIGHT('00'+ LTRIM(cast(day(convert(date,@FechaParte,103))as varchar(2))) ,2)  + ' DE ' + [PN_REGISTRO].[FN_CONVERTIR_FECHAMES_LETRA]( MONTH(CONVERT(DATE,@FechaParte,103))) + ' DEL AÑO ' + CAST(YEAR(CONVERT(DATE,@FechaParte,103)) AS VARCHAR(4))
	
		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  'OFICIO N° ' + @acno_vNumeroOficio + '.'
		SET @vParteInicio = @vParteInicio+ '</p>'
		

		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  @NumeroCardinal + ' PARTE CONSULAR DE ESCRITURA PÚBLICA DE ' + @vDenominacion + '.'
		SET @vParteInicio = @vParteInicio+ '</p>'
		
		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  '@OTORGANTE' + '.'
		SET @vParteInicio = @vParteInicio+ '</p>'
		
		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  @vParteFecha 
		SET @vParteInicio = @vParteInicio+ '</p>'

		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  'SEÑOR REGISTRADOR.'
		SET @vParteInicio = @vParteInicio+ '</p>'

		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  'REGISTROS DE MANDATOS Y PODERES.'  
		SET @vParteInicio = @vParteInicio+ '</p>' 

		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  'SUPERINTENDENCIA NACIONAL DE REGISTROS PÚBLICOS.'
		SET @vParteInicio = @vParteInicio+ '</p>' 

		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  'ZONA REGISTRAL Nº ' + @cCodigoZona + '.'
		SET @vParteInicio = @vParteInicio+ '</p>'
	 
		SET @vParteInicio = @vParteInicio+  '<p style=''text-align:left;''>'  
		SET @vParteInicio = @vParteInicio+  @vOficinaRegistral
		SET @vParteInicio = @vParteInicio+ '</p>'

		--PERSONA-GÉNERO 2001 = MASCULINO; 2002 = FEMENINO
		declare @dFechaSuscripcion	datetime

		DECLARE cActonotarialObtenerParticipantes
		CURSOR FOR
		SELECT	
		 
		ISNULL(e.empr_vRazonSocial,'') AS vEmpresa,
		p.pers_iPersonaId,
		ISNULL(P.pers_vNombres,' ') + ' ' +  ISNULL(P.pers_vApellidoPaterno,' ') + ' ' + ISNULL(P.pers_vApellidoMaterno,' ') AS vPersona,
		(SELECT para_vDescripcion FROM PS_SISTEMA.SI_PARAMETRO (nolock) WHERE ANP.anpa_sTipoParticipanteId = para_sParametroId AND para_vGrupo = 'REGISTRO NOTARIAL- PROTOCOLAR TIPO PARTICIPANTE' AND para_cEstado = 'A') AS vTipoParticipanteId,		
		
       case when (SELECT doid_vDescripcionLarga FROM SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD (nolock) WHERE doid_sTipoDocumentoIdentidadId = PID.peid_sDocumentoTipoId)= 'OTROS'
		    then
				ISNULL(pid.peid_vTipoDocumento,'OTROS')
			else
				(SELECT doid_vDescripcionLarga FROM SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD (nolock) WHERE doid_sTipoDocumentoIdentidadId = PID.peid_sDocumentoTipoId)
			end vDescTipDoc,

		PID.peid_vDocumentoNumero AS vNroDocumento,	
		P.pers_sNacionalidadId,
		(SELECT para_vDescripcion FROM PS_SISTEMA.SI_PARAMETRO (nolock) WHERE P.pers_sNacionalidadId = para_sParametroId AND para_vGrupo = 'PERSONA-NACIONALIDAD' AND para_cEstado = 'A') AS vNacionalidad,
		P.pers_sEstadoCivilId,
		(SELECT esci_vDescripcionCorta FROM SC_MAESTRO.MA_ESTADO_CIVIL (nolock) WHERE esci_sEstadoCivilId = P.pers_sEstadoCivilId) AS vEstadoCivil,
		R.resi_vResidenciaDireccion AS vDireccion,
		R.resi_cResidenciaUbigeo AS cResidenciaUbigeo,
		(SELECT ubge_vDepartamento FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA (nolock) WHERE ubge_cCodigo = R.resi_cResidenciaUbigeo) AS DptoCont,
		(SELECT ubge_vProvincia FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA (nolock) WHERE ubge_cCodigo = R.resi_cResidenciaUbigeo) AS ProvPais,
		ISNULL((SELECT ubge_vDistrito FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA (nolock) WHERE ubge_cCodigo = R.resi_cResidenciaUbigeo),'') AS DistCiu,
		ISNULL((SELECT ocup_vDescripcionCorta FROM SC_MAESTRO.MA_OCUPACION (nolock) WHERE ocup_sOcupacionId = P.pers_sOcupacionId),'(SIN OCUPACION)') AS vOcupacion,
		ISNULL((SELECT prof_vDescripcionCorta FROM SC_MAESTRO.MA_PROFESION (nolock) WHERE prof_sProfesionId = P.pers_sProfesionId),'(SIN PROFESIÓN)') AS vProfesion,
		ISNULL((SELECT doid_vDescripcionCorta FROM SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD (nolock) WHERE doid_sTipoDocumentoIdentidadId = PID.peid_sDocumentoTipoId),'(SIN TIPO DOCUMENTO)') AS vTipoDocumento,
		P.pers_sGeneroId AS iGenero, 
		ANP.anpa_dFechaSuscripcion
		FROM 
		PN_REGISTRO.RE_ACTONOTARIALPARTICIPANTE ANP	(nolock)
		LEFT JOIN PN_REGISTRO.RE_PERSONA P (nolock) ON ANP.anpa_iPersonaId = P.pers_iPersonaId
		LEFT JOIN PN_REGISTRO.RE_EMPRESA E (nolock) ON ANP.anpa_iEmpresaId = E.empr_iEmpresaId
		INNER JOIN PN_REGISTRO.RE_PERSONAIDENTIFICACION PID (nolock) ON (P.pers_iPersonaId = PID.peid_iPersonaId AND 
																PID.peid_bActivoEnRune = 1 AND 
																PID.peid_cEstado='A')
		LEFT JOIN PN_REGISTRO.RE_PERSONARESIDENCIA PR (nolock) 
					ON(P.pers_iPersonaId = PR.pere_iPersonaId AND PR.pere_iResidenciaId = (SELECT MAX(pere_iResidenciaId) 
														FROM PN_REGISTRO.RE_PERSONARESIDENCIA PR (nolock) 
														INNER JOIN PN_REGISTRO.RE_RESIDENCIA R (nolock) 
															ON PR.pere_iResidenciaId = R.resi_iResidenciaId 
																WHERE pere_iPersonaId = P.pers_iPersonaId and R.resi_sResidenciaTipoId = 2252))
		LEFT JOIN PN_REGISTRO.RE_RESIDENCIA R (nolock) ON (R.resi_iResidenciaId = PR.pere_iResidenciaId AND 
												   R.resi_sResidenciaTipoId = 2252 AND resi_cEstado <> 'E' ) --TIPO RESIDENCIA
		WHERE
		anpa_iActoNotarialId = @acno_iActoNotarialId AND
		anpa_cEstado = 'A'
	
		OPEN cActonotarialObtenerParticipantes

		FETCH cActonotarialObtenerParticipantes
		INTO 
		@vEmpresa,
		@Pers_iPersonaID,
		@vPersona,
		@vTipoParticioanteId,
		@vDescTipDoc,
		@vNroDoc,
		@pers_sNacionalidad,
		@vNacionalidad,
		@pers_sEstadoCivil,
		@vEstadoCivil,
		@vDireccion,
		@cResidenciaUbigeo,
		@DptoCont,
		@ProvPais,
		@DistCiu,
		@Ocupacion,
		@vProfesion,
		@vTipoDocumeno,
		@iGenero,
		@dFechaSuscripcion

		WHILE (@@FETCH_STATUS = 0)
		BEGIN	
			
			SET @strEstadoCivil = @vEstadoCivil

			if (@iGenero =2002) --FEMENINO
			BEGIN

				IF @vEstadoCivil = 'SOLTERO'
				BEGIN
					SET @strEstadoCivil = 'SOLTERA'
				END
				ELSE IF @vEstadoCivil = 'CASADO'
				BEGIN
					SET @strEstadoCivil = 'CASADA'
				END
				ELSE IF @vEstadoCivil = 'DIVORCIADO'
				BEGIN
					SET @strEstadoCivil = 'DIVORCIADA'
				END
				ELSE IF @vEstadoCivil = 'VIUDO'
				BEGIN
					SET @strEstadoCivil = 'VIUDA'
				END
					 
			END
	 
			if LTRIM(@Ocupacion)=''
			begin
				set @Ocupacion = '(SIN OCUPACIÓN)'
			end
 			
			IF @vTipoParticioanteId ='OTORGANTE'
			BEGIN
			
				SET @contadorOtorgantes =  @contadorOtorgantes + 1
				SET @V_DATOS_OTORGANTE = [PN_REGISTRO].[FN_OBTENER_DATOS_PERSONA_PROTOCOLAR](@Pers_iPersonaID,0)
				IF @contadorOtorgantes = 1
				BEGIN
					SET @strOtorganteOtorgaSP = 'QUE OTORGA'
					set @strParticipanteOtorgantesSeparador = '; '
					
					IF (@iGenero = 2001) -- MASCULINO
					BEGIN
						SET @strOtorganteArticuloSexoPS = 'EL'
						SET @strParticipanteInformadoSP = 'INFORMADO'
						SET @strParticipanteProcede = 'PROCEDE'
						SET @ContadorParticipanteHombres = @ContadorParticipanteHombres + 1
						set @strOtorgados_das = 'OTORGADO'
					END 
					ELSE IF (@iGenero = 2002)  -- FEMENINO
					BEGIN
						SET @strOtorganteArticuloSexoPS = 'LA'
						SET @strParticipanteInformadoSP = 'INFORMADA'
						SET @strParticipanteProcede = 'PROCEDE'
						set @strOtorgados_das = 'OTORGADA'
					END
				END
				ELSE
				BEGIN
					IF @contadorOtorgantes > 1
					BEGIN
						SET @strOtorganteOtorgaSP = 'QUE OTORGAN'
						set @strParticipanteOtorgantesSeparador = ', '
						SET @strParticipanteEsSP = 'SON'
						SET @strParticipanteMayorSP  = 'MAYORES'
						SET @strParticipanteProcede = 'PROCEDEN'
						SET @strParticipanteFirmaSP  = 'FIRMAN' 
						SET	@strParticipanteSuSP = 'SUS' 
						SET	@strParticipanteImprimeSP = 'IMPRIMEN' 
						SET	@strParticipanteHuellaSP  = 'HUELLAS' 
						set @strParticipanteDactilarSP = 'DACTILARES'

						IF (@iGenero = 2001) -- MASCULINO
						BEGIN
							SET @strOtorganteArticuloSexoPS = 'LOS'
							SET @strParticipanteInformadoSP = 'INFORMADOS'
							SET @strParticipanteProcede = 'PROCEDEN'
							set @strOtorgados_das = 'OTORGADOS'
						END 
						ELSE 
						BEGIN
							IF (@iGenero = 2002)  -- FEMENINO
							BEGIN
								IF (@ContadorParticipanteHombres > 1) -- MASCULINO
								BEGIN
									SET @strOtorganteArticuloSexoPS = 'LOS'
									SET @strParticipanteInformadoSP = 'INFORMADOS'
									SET @strParticipanteProcede = 'PROCEDEN'
									set @strOtorgados_das = 'OTORGADOS'
								END 
								ELSE
								BEGIN
									SET @strOtorganteArticuloSexoPS = 'LAS'
									SET @strParticipanteInformadoSP = 'INFORMADAS'
									SET @strParticipanteProcede = 'PROCEDEN'
									set @strOtorgados_das = 'OTORGADAS'
								END
							END
						END
					END
				END
				IF LEN(@strParticipanteOtorgantes) = 0
				 BEGIN
					SET @strParticipanteOtorgantes =  @strParticipanteOtorgantes +  ': ' + @vPersona
					
					IF (@iGenero = 2001)
					BEGIN
						SET @strParticipanteOtorgantes_V3 = @strParticipanteOtorgantes_V3 + @vPersona + ' IDENTIFICADO CON ' + @vDescTipDoc + ' Nº' + @vNroDoc
					END
					ELSE
					BEGIN
						SET @strParticipanteOtorgantes_V3 = @strParticipanteOtorgantes_V3 + @vPersona + ' IDENTIFICADA CON ' + @vDescTipDoc + ' Nº' + @vNroDoc
					END
				 END
				 ELSE
				 BEGIN
					SET @strParticipanteOtorgantes =  @strParticipanteOtorgantes + @strParticipanteOtorgantesSeparador +  @vPersona

					IF (@iGenero = 2001)
					BEGIN
						SET @strParticipanteOtorgantes_V3 = @strParticipanteOtorgantes_V3 + @strParticipanteOtorgantesSeparador + @vPersona + ' IDENTIFICADO CON ' + @vDescTipDoc + ' Nº' + @vNroDoc
					END
					ELSE
					BEGIN
						SET @strParticipanteOtorgantes_V3 = @strParticipanteOtorgantes_V3 + @strParticipanteOtorgantesSeparador + @vPersona + ' IDENTIFICADA CON ' + @vDescTipDoc + ' Nº' + @vNroDoc
					END
				 END
				SET @strParticipanteOtorgantes_V2 = @strParticipanteOtorgantes_V2 + @V_DATOS_OTORGANTE + @strParticipanteOtorgantesSeparador
				IF (LEN(@strParticipanteOtorganteFirma) = 0)
				BEGIN
					set @strParticipanteOtorganteFirma = @strParticipanteOtorganteFirma + 'UNA FIRMA ILEGIBLE E IMPRESIÓN DACTILAR DE ' + @vPersona + ', FIRMADO EL ' + [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA](DAY(CONVERT(DATE,@dFechaSuscripcion,103))) + ' DE '+ [PN_REGISTRO].[FN_CONVERTIR_FECHAMES_LETRA](MONTH(CONVERT(DATE,@dFechaSuscripcion,103)))+ ' DE ' + [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA](YEAR(CONVERT(DATE,@dFechaSuscripcion,103))) 
				END
				ELSE
				BEGIN
					set @strParticipanteOtorganteFirma = @strParticipanteOtorganteFirma + ', UNA FIRMA ILEGIBLE E IMPRESIÓN DACTILAR DE ' + @vPersona + ', FIRMADO EL ' + [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA](DAY(CONVERT(DATE,@dFechaSuscripcion,103))) + ' DE '+ [PN_REGISTRO].[FN_CONVERTIR_FECHAMES_LETRA](MONTH(CONVERT(DATE,@dFechaSuscripcion,103)))+ ' DE ' + [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA](YEAR(CONVERT(DATE,@dFechaSuscripcion,103))) 
				END
				IF @iGenero =2001
				BEGIN
					SET @AUX_OTORGANTE = 'OTORGADO POR ' + @vPersona
				END
				ELSE
				begin
					IF @iGenero =2002
					BEGIN
						SET @AUX_OTORGANTE = 'OTORGADA POR ' + @vPersona
					END	
				END

				set @contadorParticipantes = @contadorParticipantes + 1
			END
			ELSE
			BEGIN
				IF @vTipoParticioanteId ='APODERADO'
				BEGIN
					SET @contadorFAVOR  = @contadorFAVOR + 1
					SET @V_DATOS_APODERADO = [PN_REGISTRO].[FN_OBTENER_DATOS_PERSONA_PROTOCOLAR](@Pers_iPersonaID,0)
					IF @contadorFAVOR > 1
					BEGIN
						SET @SEPARADOR_AFAVOR  = ', '
						SET @SEPARADOR_A_FAVOR_ = '; '
					END
					SET @strParticipanteFavorecido = @strParticipanteFavorecido +  @SEPARADOR_AFAVOR + @vPersona
					SET @strParticipanteFavorecido_V2 =@strParticipanteFavorecido_V2 + @V_DATOS_APODERADO + @strParticipanteOtorgantesSeparador
				END
			END


		FETCH cActonotarialObtenerParticipantes INTO 
			@vEmpresa,
			@Pers_iPersonaID,
			@vPersona,
			@vTipoParticioanteId,
			@vDescTipDoc,
			@vNroDoc,
			@pers_sNacionalidad,
			@vNacionalidad,		
			@pers_sEstadoCivil,
			@vEstadoCivil,
			@vDireccion,
			@cResidenciaUbigeo,
			@DptoCont,
			@ProvPais,
			@DistCiu,
			@Ocupacion,
			@vProfesion,
			@vTipoDocumeno,
			@iGenero,
			@dFechaSuscripcion
			END 
			CLOSE cActonotarialObtenerParticipantes
			DEALLOCATE cActonotarialObtenerParticipantes


		  if (@contadorParticipantes = 1)
		  BEGIN
			SET	@strParticipanteQuienSP = 'QUIEN'
            SET	@strParticipanteElSP = 'LE'
            SET	@strParticipanteCompareceSP = 'COMPARECE'
			SET @strParticipanteProcede = 'PROCEDE'
		  END
		  ELSE IF (@contadorParticipantes > 1)
		  BEGIN
			SET	@strParticipanteQuienSP = 'QUIENES'
            SET	@strParticipanteElSP = 'LES'
            SET	@strParticipanteCompareceSP = 'COMPARECEN'
			SET @strParticipanteAfirmoSP = 'AFIRMARON'
			SET @strParticipanteRatificoSP = 'RATIFICARON'
			set @strParticipanteHaSP = 'HAN'
		    SET @strParticipanteProcede = 'PROCEDEN'
		  END

		IF (@contadorOtorgantes=1)
		BEGIN
			SET	@strParticipanteCompareceSP = 'COMPARECE'
		END
		ELSE
		BEGIN
			SET	@strParticipanteCompareceSP = 'COMPARECEN'
		END
         
		
	

-------------------------------------------------------
-- OBTENER LOS PRESENTANTES
-------------------------------------------------------
DECLARE @vPresentanteNombre			varchar(200)
DECLARE @vPresentanteNumeroDocumento varchar(50)
DECLARE @vPresentanteTipoDocumento	varchar(50)
DECLARE @vPresentanteSePresenta		varchar(10)
DECLARE @vPresentadoIdentificado_da varchar(12)
DECLARE @iPresentanteCuenta			 int
DECLARE @iPresentanteCuentaFemenino	 int
DECLARE @iPresentanteCuentaMasculino int
DECLARE @iPresentanteGenero			 smallint
DECLARE @vListaPresentantes			varchar(max)


SET @vListaPresentantes = ''
SET @iPresentanteCuenta = 0
SET @iPresentanteCuentaFemenino = 0
SET @iPresentanteCuentaMasculino = 0
--------------------------------------


DECLARE curPresentantes
		CURSOR FOR
SELECT 
 anp.anpr_vPresentanteNombre,
 anp.anpr_vPresentanteNumeroDocumento,
 anp.anpr_sPresentanteGenero,
 tdoc.doid_vDescripcionLarga 

FROM [PN_REGISTRO].[RE_ACTONOTARIALPRESENTANTE] ANP (nolock)
inner join [SC_MAESTRO].[MA_DOCUMENTO_IDENTIDAD] tdoc  (nolock)
	on ANP.anpr_sPresentanteTipoDocumento = tdoc.doid_sTipoDocumentoIdentidadId
WHERE ANP.anpr_iActoNotarialId = @acno_iActoNotarialId AND ANP.anpr_cEtsado = 'A'
AND ANP.anpr_sPresentanteTipoDocumento > 0

OPEN curPresentantes

FETCH curPresentantes
INTO @vPresentanteNombre, @vPresentanteNumeroDocumento, @iPresentanteGenero, @vPresentanteTipoDocumento
WHILE (@@FETCH_STATUS = 0)
		BEGIN

		if (@iPresentanteGenero = 2001)
		BEGIN
			SET @vPresentanteSePresenta = 'AL SR.'
			SET @vPresentadoIdentificado_da = 'IDENTIFICADO'
			SET @iPresentanteCuentaMasculino = @iPresentanteCuentaMasculino + 1
		END
		ELSE
		BEGIN
			SET @vPresentanteSePresenta = 'A LA SRA.'
			SET @vPresentadoIdentificado_da = 'IDENTIFICADA'
			SET @iPresentanteCuentaFemenino = @iPresentanteCuentaFemenino + 1
		END

		SET @vListaPresentantes = @vListaPresentantes + @vPresentanteSePresenta + ' ' + @vPresentanteNombre + ' ' + 
									@vPresentadoIdentificado_da + ' CON ' + @vPresentanteTipoDocumento + ' NÚMERO ' + @vPresentanteNumeroDocumento + ' Y/O '
		
		SET @iPresentanteCuenta = @iPresentanteCuenta + 1


	FETCH curPresentantes
	INTO @vPresentanteNombre, @vPresentanteNumeroDocumento, @iPresentanteGenero, @vPresentanteTipoDocumento
END
CLOSE curPresentantes
DEALLOCATE curPresentantes
IF (LEN(@vListaPresentantes) > 4)
BEGIN
	SET @vListaPresentantes = LEFT(@vListaPresentantes,LEN(@vListaPresentantes)-5)
	IF (@iPresentanteCuenta = 1)
	BEGIN
		IF (@iPresentanteCuentaMasculino > 0)
		BEGIN
			SET @vListaPresentantes = @vListaPresentantes + ' QUIEN ESTA AUTORIZADO'
		END
		ELSE
		BEGIN
			SET @vListaPresentantes = @vListaPresentantes + ' QUIEN ESTA AUTORIZADA'
		END
	END
	ELSE
	BEGIN
		IF (@iPresentanteCuentaMasculino > 0)
		BEGIN
			SET @vListaPresentantes = @vListaPresentantes + ' QUIENES ESTAN AUTORIZADOS'
		END
		ELSE
		BEGIN
			SET @vListaPresentantes = @vListaPresentantes + ' QUIENES ESTAN AUTORIZADAS'
		END
	END

END
ELSE
BEGIN
	SET @vListaPresentantes = '(SIN PRESENTANTE)'
END

---------------------------------------
-- FIN DE PRESENTANTES
---------------------------------------

		-- SECCIÓN INICIAL DEL PARTE (II/II)
		set @vParteInicio = @vParteInicio + '<p style=''text-align:justify;''>'  
		SET @vParteInicio = @vParteInicio+  'CUMPLO CON DIRIGIRME A USTED, PARA PONER EN CONOCIMIENTO QUE A FOJAS ' +  [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA](@vNroFojaInicial) + ' '

		SET @vParteInicio = @vParteInicio + 'A FOJAS ' + [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA](@vNroFojaFinal)  + ' '

		SET @vParteInicio = @vParteInicio+  'DEL LIBRO ' + @vNroLibro + ', ' + 'DEL AÑO ' + CAST(YEAR(convert(date,@FechaEP,103)) AS VARCHAR(4)) + ', '
										
		SET @vParteInicio = @vParteInicio+  'DEL REGISTRO DE INSTRUMENTOS PÚBLICOS DEL ' + @NombreOficinaConsular +', SE ENCUENTRA INSCRITA LA ESCRITURA PÚBLICA Nº' + @vNroEscritura + ' DE '+ @vDenominacion + ' OTORGADO POR ' + @strParticipanteOtorgantes_V3 + '.'
		
		SET @vParteInicio = @vParteInicio+ '</p>'
  

		-- SECCIÓN FINAL DEL PARTE

		SET @vParteFin = @vParteFin + '<p style=''text-align:justify;''>'  
		SET @vParteFin = @vParteFin + 'CONFORME A LA SÉPTIMA DISPOSICIÓN COMPLEMENTARIA TRANSITORIA ';


		SET @vParteFin = @vParteFin + 'Y FINAL DEL D.LEG. 1049, SE CUMPLE CON PRESENTAR ';
		
		SET @vParteFin = @vParteFin + @vListaPresentantes
		SET @vParteFin = @vParteFin + ' POR '

		IF (@contadorOtorgantes = 1)
		BEGIN
			IF (@ContadorParticipanteHombres > 0)
			BEGIN
				SET @vParteFin = @vParteFin + 'EL OTORGANTE, '
			END
			ELSE
			BEGIN
				SET @vParteFin = @vParteFin + 'LA OTORGANTE, '
			END
		END
		ELSE
		BEGIN
			IF (@ContadorParticipanteHombres > 0)
			BEGIN
				SET @vParteFin = @vParteFin + 'LOS OTORGANTES, '
			END
			ELSE
			BEGIN
				SET @vParteFin = @vParteFin + 'LAS OTORGANTES, '
			END
		END
		
		---------------------------------------------------------------------------------------------

		SET @vParteFin = @vParteFin + 'PARA REALIZAR LA PRESENTACIÓN Y TRAMITACIÓN DEL PRESENTE '
		SET @vParteFin = @vParteFin + 'ANTE LA SUPERINTENDENCIA NACIONAL DE REGISTROS PÚBLICOS '
		SET @vParteFin = @vParteFin + 'CON LA CONSIGUIENTE PROCEDENCIA LEGÍTIMA DEL PARTE.'
		SET @vParteFin = @vParteFin + '</p>'

		SET @vParteFin = @vParteFin + '<p style=''text-align:justify;''>'  
		SET @vParteFin = @vParteFin + 'SE EXPIDE EL PRESENTE PARTE Nº ' + ltrim(STR(@acno_sNumeroParte))
		SET @vParteFin = @vParteFin + ' EN UN TOTAL DE '+ LTRIM(str(@sNumeroFoja)) + ' FOJAS '

		SET @vParteFin = @vParteFin + 'EN LA CIUDAD DE '
		SET @vParteFin = @vParteFin + @Distrito + ', ' + @Provincia + ', '
		SET @vParteFin = @vParteFin + 'EL DÍA ' +  [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA](DAY(convert(date,@FechaParte,103))) + ' DEL MES DE '+ [PN_REGISTRO].[FN_CONVERTIR_FECHAMES_LETRA](MONTH(convert(date,@FechaParte,103)))+ ' DEL AÑO ' + [PN_REGISTRO].[FN_CONVERTIR_NUMERO_LETRA](YEAR(convert(date,@FechaParte,103))) + ', '
		SET @vParteFin = @vParteFin + 'A SOLICITUD DE PARTE INTERESADA, '		
		SET @vParteFin = @vParteFin + 'EL MISMO QUE GUARDA IDENTIDAD CON LA MATRIZ QUE SE CONSERVA EN ESTE '
		SET @vParteFin = @vParteFin + @NombreOficinaConsular + ', '
		SET @vParteFin = @vParteFin + 'LA QUE HA SIDO SUSCRITA POR '
------------------------------------------------------------
		IF (@contadorOtorgantes = 1)
		BEGIN
			IF (@ContadorParticipanteHombres > 0)
			BEGIN
				SET @vParteFin = @vParteFin + 'EL OTORGANTE '
			END
			ELSE
			BEGIN
				SET @vParteFin = @vParteFin + 'LA OTORGANTE '
			END
		END
		ELSE
		BEGIN
			IF (@ContadorParticipanteHombres > 0)
			BEGIN
				SET @vParteFin = @vParteFin + 'LOS OTORGANTES '
			END
			ELSE
			BEGIN
				SET @vParteFin = @vParteFin + 'LAS OTORGANTES '
			END
		END
------------------------------------------------------------

		SET @vParteFin = @vParteFin + 'Y AUTORIZADA POR '
		SET @vParteFin = @vParteFin + @NombreFuncionario + ', '
				
		SET @vParteFin = @vParteFin + 'EL CUAL RUBRICO, SELLO Y FIRMO DE ACUERDO A LEY.'
		SET @vParteFin = @vParteFin + '</p>'
		SET @vParteFin = @vParteFin + '<p style=''text-align:justify;''>'  
		SET @vParteFin = @vParteFin + 'ATENTAMENTE,'
		SET @vParteFin = @vParteFin + '</p>'

		/*REEMPLAZO*/
		SET @vParteInicio = REPLACE(@vParteInicio,'@OTORGANTE',@strOtorgados_das + ' POR ' + @strParticipanteOtorgantes)
		

		-- RESULTADO
	 	SELECT @vParteFecha, @vParteInicio, @vParteFin

	END TRY
	BEGIN CATCH
		DECLARE @ErrorNumber INT = ERROR_NUMBER();
		DECLARE @ErrorMessage NVARCHAR(1000) = ERROR_MESSAGE() 
		RAISERROR('Error Number-%d : Error Message-%s', 16, 1,@ErrorNumber, @ErrorMessage)
	END CATCH

	SET NOCOUNT OFF
 
 END

