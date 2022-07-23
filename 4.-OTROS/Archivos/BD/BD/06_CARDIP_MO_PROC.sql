USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_GENERALES_MRE]    Script Date: 25/06/2021 03:34:08 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	ALTER PROCEDURE [SC_CARDIP].[USP_CD_GENERALES_MRE]
	--================================================================================
	--SISTEMA			: SISTEMA CARNÉ PARA DIPLOMATICOS
	--OBJETIVO			: 
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 23/11/2014 18:47:27
	--PARAMETROS        :	@P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
	--EJECUTAR          : [SC_CARDIP].[USP_CD_GENERALES_MRE]
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================
	--VPIPA						25/06/2021				Adcion de lista de estados de mensaje
	AS
	BEGIN
		DECLARE @VALORES varchar(1000),
		@V_ESTADO VARCHAR(1)='A'
		SET NOCOUNT ON
		BEGIN TRY
			--SISTEMA
			SELECT	SISTEMA.sist_sSistemaId AS IDSISTEMA,
					SISTEMA.sist_vNombre AS NOMBRESISTEMA,
					SISTEMA.sist_vDescripcion AS DESCRIPCIONSISTEMA,
					SISTEMA.sist_vAbreviatura AS ABREVSISTEMA
			FROM	SC_ADM.SE_SISTEMA SISTEMA
			WHERE	SISTEMA.sist_sSistemaId = (SELECT sist_sSistemaId FROM [SC_ADM].[SE_SISTEMA] WHERE [sist_vAbreviatura] = 'CARDIP' AND sist_cEstado = 'A')
					AND SISTEMA.sist_cEstado = @V_ESTADO
			--ESTADOS
			SELECT	ESTA_SESTADOID AS ESTADO_ID,
					ESTA_VDESCRIPCIONCORTA AS ESTADO_DESCRIPCION,
					ESTA_VGRUPO AS ESTADO_GRUPO 
			FROM	SC_MAESTRO.MA_ESTADO
			WHERE	ESTA_VGRUPO='CARNE IDENTIDAD - ESTADO' AND
					ESTA_CESTADO='A'
			-- OFICINAS EN PERU
			SELECT	ofco_sOficinaConsularId AS OFICINAPERUID,
					ofco_vSiglas AS SIGLASPERU,
					ofco_vNombre AS NOMBREPERU
			FROM	PS_SISTEMA.SI_OFICINACONSULAR 
			WHERE	ofco_sPaisId=(SELECT PAIS_SPAISID FROM PS_SISTEMA.SI_PAIS WHERE PAIS_VNOMBRE='PERÚ' AND PAIS_CESTADO='A') AND
					ofco_cEstado = 'A'
			ORDER BY OFCO_VNOMBRE
			--OFICINAS CONSULARES PERUANAS
			SELECT	OFCO.ofco_sOficinaConsularId AS OFICINAEXID, 
					OFCO.ofco_vSiglas AS SIGLASEX,
					OFCO.ofco_vNombre AS  NOMBREEX
			FROM	PS_SISTEMA.SI_OFICINACONSULAR OFCO
				INNER JOIN PS_SISTEMA.SI_PARAMETRO PAR ON OFCO.ofco_sCategoriaId = PAR.para_sParametroId
				WHERE PAR.para_vDescripcion<>'LOCAL DE VOTACION' AND OFCO.ofco_sPaisId IS NULL AND OFCO.ofco_cEstado='A'
				ORDER BY OFCO.OFCO_VNOMBRE
			-- OFICINAS CONSULARES EXTRANJERAS
			SELECT		OFCE_SOFICINACONSULAR_EXTRANJERAID AS OFCOEX_ID,
						OFCE_SCATEGORIAID AS OFCOEX_CATEGORIA,
						OFCE_VSIGLAS AS OFCOEX_SIGLAS,
						OFCE_VNOMBRE AS OFCOEX_NOMBRE,
						OFCE_CUBIGEOCODIGO AS OFCOEX_UBIGEO,
						OFCE_BJEFATURAFLAG AS OFCOEX_JEFAFLAG
			FROM		PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX
			WHERE		OFCE_CESTADO='A'
			ORDER BY OFCOEX.OFCE_VNOMBRE

			SELECT	CALMIG.CAMI_SCALIDAD_MIGRATORIAID AS CALMIG_ID,
					CALMIG.CAMI_VNUMERO_ORDEN AS CALMIG_NUMORDEN,
					CALMIG.CAMI_SFLAG_NIVEL_CALIDAD AS CALMIG_NIVEL,
					CALMIG.CAMI_VNOMBRE AS CALMIG_NOMBRE,
					CAMI_VDEFINICION AS CALMIG_DEFINICION
			FROM	SC_MAESTRO.MA_CALIDAD_MIGRATORIA CALMIG
			WHERE	CALMIG.CAMI_CESTADO='A' AND
					CALMIG.CAMI_VNUMERO_ORDEN IS NOT NULL
			ORDER BY CALMIG.CAMI_VNUMERO_ORDEN
			-- CALIDAD MIGRATORIA - NIVEL 1
			SELECT	CALMIG.CAMI_SCALIDAD_MIGRATORIAID AS CALMIG_ID,
					CALMIG.CAMI_SFLAG_TITULAR_DEPENDIENTE AS CALMIG_TITDEP,
					CALMIG.CAMI_SFLAG_NIVEL_CALIDAD AS CALMIG_NIVEL,
					CALMIG.CAMI_SREFERENCIA_ID AS CALMIG_REFERENCIA,
					CALMIG.CAMI_VNOMBRE AS CALMIG_NOMBRE,
					TITDEP.PARA_VDESCRIPCION AS TIT_DEP,
					CAMI_GENERO AS CALMIG_GENERO
			FROM	SC_MAESTRO.MA_CALIDAD_MIGRATORIA CALMIG
			INNER JOIN PS_SISTEMA.SI_PARAMETRO TITDEP ON CALMIG.CAMI_SFLAG_TITULAR_DEPENDIENTE=TITDEP.PARA_SPARAMETROID
			WHERE	CALMIG.CAMI_CESTADO='A' AND
					CALMIG.CAMI_SFLAG_TITULAR_DEPENDIENTE IS NOT NULL
					AND CAMI_GENERO IS NOT NULL
			ORDER BY CALMIG.CAMI_VNOMBRE
			-- CATEGORIA FUNCIONARIO CONSULAR
			SELECT	CATFUN.CATF_SCATEGORIAFUNCIONARIOID AS CATFUN_ID,
					CATFUN.CATF_VDESCRIPCIONCORTA AS CATFUN_DESCCORTA,
					CATFUN.CATF_VDESCRIPCIONLARGA AS CATFUN_DESCLARGA
			FROM	SC_MAESTRO.MA_CATEGORIA_FUNCIONARIO CATFUN
			WHERE	CATF_CESTADO='A'
			-- GENERO PERSONA (PARAMETRO)
			SELECT	PARA_GENERO.PARA_SPARAMETROID AS PARA_GENERO_ID,
					PARA_GENERO.PARA_VGRUPO AS PARA_GENERO_GRUPO,
					PARA_GENERO.PARA_VDESCRIPCION AS PARA_GENERO_DESC,
					PARA_GENERO.PARA_VVALOR AS PARA_GENERO_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO PARA_GENERO
			WHERE	PARA_VGRUPO='PERSONA-GÉNERO' AND
					PARA_GENERO.PARA_CESTADO='A'
			-- ESTADO CIVIL PERSONA (PARAMETRO)
			SELECT	PARA_ESTCIV.PARA_SPARAMETROID AS PARA_ESTCIV_ID,
					PARA_ESTCIV.PARA_VGRUPO AS PARA_ESTCIV_GRUPO,
					PARA_ESTCIV.PARA_VDESCRIPCION AS PARA_ESTCIV_DESC,
					PARA_ESTCIV.PARA_VVALOR AS PARA_ESTCIV_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO PARA_ESTCIV
			WHERE	PARA_VGRUPO='PERSONA - ESTADO CIVIL' AND
					PARA_ESTCIV.PARA_CESTADO='A'
			-- DOCUMENTO DE IDENTIDAD
			SELECT	DOCIDENT.DOID_STIPODOCUMENTOIDENTIDADID AS DOCIDENT_ID,
					DOCIDENT.DOID_VDESCRIPCIONCORTA AS DOCIDENT_DESCORTA,
					DOCIDENT.DOID_VDESCRIPCIONLARGA AS DOCIDENT_DESCLARGA
			FROM	SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD DOCIDENT
			WHERE	DOCIDENT.DOID_CESTADO='A'
			-- CONTINENTE
			SELECT	CONTI.CONT_SCONTINENTEID AS CONTI_ID,
					CONTI.CONT_VNOMBRE AS CONTI_NOMBRE
			FROM	SC_MAESTRO.MA_CONTINENTE CONTI
			WHERE	CONTI.CONT_CESTADO='A'
			-- PAISES
			SELECT	PAIS.PAIS_SPAISID AS PAIS_ID,
					PAIS.PAIS_SCONTINENTEID AS PAIS_CONTI_ID,
					PAIS.PAIS_VNOMBRE AS PAIS_NOMBRE,
					PAIS.PAIS_VNACIONALIDAD AS PAIS_NACIONALIDAD,
					PAIS.PAIS_CUBIGEO AS PAIS_UBIGEI
			FROM	PS_SISTEMA.SI_PAIS PAIS
			WHERE	PAIS.PAIS_CESTADO='A'
			-- TITULAR DEPENDIENTE (PARAMETRO)
			SELECT	PARA_TITDEP.PARA_SPARAMETROID AS PARA_TITDEP_ID,
					PARA_TITDEP.PARA_VGRUPO AS PARA_TITDEP_GRUPO,
					PARA_TITDEP.PARA_VDESCRIPCION AS PARA_TITDEP_DESC,
					PARA_TITDEP.PARA_VVALOR AS PARA_TITDEP_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO PARA_TITDEP
			WHERE	PARA_VGRUPO='CALIDAD MIG - TITULAR DEPENDIENTE' AND
					PARA_TITDEP.PARA_CESTADO='A'
			-- CATEGORIA OFICINA EXTRANJERA (PARAMETRO)
			SELECT	PARA_TITDEP.PARA_SPARAMETROID AS PARA_TITDEP_ID,
					PARA_TITDEP.PARA_VGRUPO AS PARA_TITDEP_GRUPO,
					PARA_TITDEP.PARA_VDESCRIPCION AS PARA_TITDEP_DESC,
					PARA_TITDEP.PARA_VVALOR AS PARA_TITDEP_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO PARA_TITDEP
			WHERE	PARA_VGRUPO='CATEGORÍA OFICINA CONSULAR EXTRANJERA' AND
					PARA_TITDEP.PARA_CESTADO='A'

			-- CATEGORIA OFICINA EXTRANJERA (PARAMETRO)
			SELECT	TIPOOBS.PARA_SPARAMETROID AS PARA_TIPOOBS_ID,
					TIPOOBS.PARA_VGRUPO AS PARA_TIPOOBS_GRUPO,
					TIPOOBS.PARA_VDESCRIPCION AS PARA_TIPOOBS_DESC,
					TIPOOBS.PARA_VVALOR AS PARA_TIPOOBS_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPOOBS
			WHERE	TIPOOBS.PARA_VGRUPO='CARDIP-TIPO OBSERVACION' AND
					TIPOOBS.PARA_CESTADO='A'

			-- TIPO DUPLICADO
			SELECT	TIPODUP.PARA_SPARAMETROID AS PARA_TIPODUP_ID,
					TIPODUP.PARA_VGRUPO AS PARA_TIPODUP_GRUPO,
					TIPODUP.PARA_VDESCRIPCION AS PARA_TIPODUP_DESC,
					TIPODUP.PARA_VVALOR AS PARA_TIPODUP_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPODUP
			WHERE	TIPODUP.PARA_VGRUPO='CARDIP-TIPO DUPLICADO' AND
					TIPODUP.PARA_CESTADO='A'
			
			-- LISTA DE USUARIOS
			SELECT DISTINCT U.usua_vDocumentoNumero AS NDOCIDENT, 
							U.usua_sUsuarioId as IDUSUARIO, 
							U.usua_vAlias AS ALIAS, 
							U.USUA_VAPELLIDOPATERNO AS APEPAT,
							U.USUA_VAPELLIDOMATERNO AS APEMAT,
							U.USUA_VNOMBRES AS NOMBRES,
							U.usua_vApellidoPaterno + ' ' + U.usua_vApellidoMaterno + ' ' + U.usua_vNombres AS NOMBRECOMPLETO,
							X.ROCO_SROLCONFIGURACIONID AS RO_ID,
							X.roco_vNombre AS ROL, 
							(SELECT [ofco_sOficinaConsularId] FROM [PS_SISTEMA].[SI_OFICINACONSULAR] WHERE [ofco_sOficinaConsularId] = R.usro_sOficinaConsularId) AS IDOFICON,
							(SELECT [ofco_vNombre] FROM [PS_SISTEMA].[SI_OFICINACONSULAR] WHERE [ofco_sOficinaConsularId] = R.usro_sOficinaConsularId) AS OFICINA,
							U.USUA_BBLOQUEOACTIVA AS BLOQUEO_ACTIVA
			FROM [PS_SEGURIDAD].[SE_USUARIO] U
			INNER JOIN [PS_SEGURIDAD].[SE_USUARIOROL] R ON U.usua_sUsuarioId = R.usro_sUsuarioId
			INNER JOIN [PS_SEGURIDAD].[SE_ROLCONFIGURACION] X ON R.usro_sRolConfiguracionId = X.roco_sRolConfiguracionId
			WHERE X.roco_sAplicacionId = (SELECT sist_sSistemaId FROM SC_ADM.SE_SISTEMA WHERE sist_vAbreviatura='CARDIP' AND sist_cEstado='A') AND U.usua_cEstado = 'A' AND R.usro_cEstado = 'A'
			ORDER BY APEPAT

			-- PERFILES DEL SISTEMA
			SELECT	ROCO_SROLCONFIGURACIONID AS ROL_ID,
					ROCO_VNOMBRE AS ROL_NOMBRE
			FROM	PS_SEGURIDAD.SE_ROLCONFIGURACION
			WHERE	ROCO_CESTADO='A'

			-- OFICINA RECEPCION
			SELECT	TIPOENT.PARA_SPARAMETROID AS PARA_TIPOENT_ID,
					TIPOENT.PARA_VGRUPO AS PARA_TIPOENT_GRUPO,
					TIPOENT.PARA_VDESCRIPCION AS PARA_TIPOENTP_DESC,
					TIPOENT.PARA_VVALOR AS PARA_TIPOENT_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPOENT
			WHERE	TIPOENT.PARA_VGRUPO='CARDIP-OFICINA ENTRADA' AND
					TIPOENT.PARA_CESTADO='A'

			-- TIPO ADJUNTO
			SELECT	TIPOADJ.PARA_SPARAMETROID AS PARA_TIPOADJ_ID,
					TIPOADJ.PARA_VGRUPO AS PARA_TIPOADJ_GRUPO,
					TIPOADJ.PARA_VDESCRIPCION AS PARA_TIPOADJ_DESC,
					TIPOADJ.PARA_VVALOR AS PARA_TIPOADJ_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPOADJ
			WHERE	TIPOADJ.PARA_VGRUPO='CARDIP-TIPO ADJUNTO' AND
					TIPOADJ.PARA_CESTADO='A'
			ORDER BY PARA_TIPOADJ_VALOR ASC

			-- TIPO ARCHIVO
			SELECT	TIPOARC.PARA_SPARAMETROID AS PARA_TIPOARC_ID,
					TIPOARC.PARA_VGRUPO AS PARA_TIPOARC_GRUPO,
					TIPOARC.PARA_VDESCRIPCION AS PARA_TIPOARC_DESC,
					TIPOARC.PARA_VVALOR AS PARA_TIPOARC_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPOARC
			WHERE	TIPOARC.PARA_VGRUPO='EXTENSION-ARCHIVO' AND
					TIPOARC.PARA_CESTADO='A'
			ORDER BY PARA_TIPOARC_VALOR ASC

			-- ESTADO ADJUNTO
			SELECT	ESTA_SESTADOID AS ESTADO_ADJUNTO_ID,
					ESTA_VDESCRIPCIONCORTA AS ESTADO_ADJUNTO_DESCRIPCION,
					ESTA_VGRUPO AS ESTADO_ADJUNTO_GRUPO 
			FROM	SC_MAESTRO.MA_ESTADO
			WHERE	ESTA_VGRUPO='ADJUNTO - ESTADO' AND
					ESTA_CESTADO='A'

			-- ESTADO SOLICITUD
			SELECT	ESTA_SESTADOID AS ESTADO_SOL_ID,
					ESTA_VDESCRIPCIONCORTA AS ESTADO_SOL_DESCRIPCION,
					ESTA_VGRUPO AS ESTADO_SOL_GRUPO 
			FROM	SC_MAESTRO.MA_ESTADO
			WHERE	ESTA_VGRUPO='SOLICITUD - ESTADO' AND
					ESTA_CESTADO='A'

			-- TIPO EMISION
			SELECT	TIPO_EMI.PARA_SPARAMETROID AS PARA_TIPOEMI_ID,
					TIPO_EMI.PARA_VGRUPO AS PARA_TIPOEMI_GRUPO,
					TIPO_EMI.PARA_VDESCRIPCION AS PARA_TIPOEMI_DESC,
					TIPO_EMI.PARA_VVALOR AS PARA_TIPOEMI_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPO_EMI
			WHERE	TIPO_EMI.PARA_VGRUPO='TIPO-EMISION' AND
					TIPO_EMI.PARA_CESTADO='A'
			ORDER BY PARA_TIPOEMI_VALOR ASC

			-- ESTADO SOLICITUD
			SELECT	ESTA_SESTADOID AS ESTADO_ACTAOBS_ID,
					ESTA_VDESCRIPCIONCORTA AS ESTADO_ACTAOBS_DESCRIPCION,
					ESTA_VGRUPO AS ESTADO_ACTAOBS_GRUPO 
			FROM	SC_MAESTRO.MA_ESTADO
			WHERE	ESTA_VGRUPO='ACTAOBS - ESTADO' AND
					ESTA_CESTADO='A'


			-- REGISTRO LINEA
			-- TIPO INSTITUCION
			SELECT	TIPO_INST.PARA_SPARAMETROID AS PARA_TIPOINS_ID,
					TIPO_INST.PARA_VGRUPO AS PARA_TIPOINS_GRUPO,
					TIPO_INST.PARA_VDESCRIPCION AS PARA_TIPOINS_DESC,
					TIPO_INST.PARA_VVALOR AS PARA_TIPOINS_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPO_INST
			WHERE	TIPO_INST.PARA_VGRUPO='TIPO-INST' AND
					TIPO_INST.PARA_CESTADO='A'
			ORDER BY PARA_TIPOINS_VALOR ASC

			-- TIPO CARGO INSTITUCION
			SELECT	TIPO_INST.PARA_SPARAMETROID AS PARA_TIPOINS_CARGO_ID,
					TIPO_INST.PARA_VGRUPO AS PARA_TIPOINS_CARGO_GRUPO,
					TIPO_INST.PARA_VDESCRIPCION AS PARA_TIPOINS_CARGO_DESC,
					TIPO_INST.PARA_VVALOR AS PARA_TIPOINS_CARGO_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPO_INST
			WHERE	(TIPO_INST.PARA_VGRUPO='TIPO-INST-EMBAJADA' OR TIPO_INST.PARA_VGRUPO='TIPO-INST-OFICINA CONSULAR' OR TIPO_INST.PARA_VGRUPO='TIPO-INST-ORGANISMO INTERNACIONAL' OR TIPO_INST.PARA_VGRUPO='TIPO-INST-OTROS') AND
					TIPO_INST.PARA_CESTADO='A'
			ORDER BY PARA_TIPOINS_CARGO_VALOR ASC
		
			-- RELACION DEPENDENCIA
			SELECT	TIPO_INST.PARA_SPARAMETROID AS PARA_REDE_ID,
					TIPO_INST.PARA_VGRUPO AS PARA_REDE_GRUPO,
					TIPO_INST.PARA_VDESCRIPCION AS PARA_REDE_DESC,
					TIPO_INST.PARA_VVALOR AS PARA_REDE_VALOR
			FROM	PS_SISTEMA.SI_PARAMETRO TIPO_INST
			WHERE	TIPO_INST.PARA_VGRUPO='RELACION-DEPENDENCIA' AND
					TIPO_INST.PARA_CESTADO='A'
			ORDER BY PARA_REDE_VALOR ASC

			-- ESTADO REG LINEA
			SELECT	ESTA_SESTADOID AS ESTADO_REGLINEA_ID,
					ESTA_VDESCRIPCIONCORTA AS ESTADO_REGLINEA_DESCRIPCION,
					ESTA_VGRUPO AS ESTADO_REGLINEA_GRUPO 
			FROM	SC_MAESTRO.MA_ESTADO
			WHERE	ESTA_VGRUPO='REG LINEA - ESTADO' AND
					ESTA_CESTADO='A'

			-- DOCUMENTO DE IDENTIDAD REG LINEA
			SELECT	DOCIDENT.DOID_STIPODOCUMENTOIDENTIDADID AS DOCIDENT_ID,
					DOCIDENT.DOID_VDESCRIPCIONCORTA AS DOCIDENT_DESCORTA,
					DOCIDENT.DOID_VDESCRIPCIONLARGA AS DOCIDENT_DESCLARGA,
					ISNULL(DOID_SPAIS_ID,0) AS DOCIDENT_PAIS
			FROM	SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD DOCIDENT
			WHERE	DOCIDENT.DOID_CESTADO='A'
			--AND		DOID_SPAIS_ID IS NOT NULL

			-- MENSAJE POR ESTADO
			SELECT	MEES_SESTADOID PARA_ESTADOID,
			E.ESTA_VDESCRIPCIONCORTA PARA_DESCRIPCIONCORTA,
			MEES_VMENSAJE PARA_MENSAJE
			FROM	SC_CARDIP.CD_MENSAJE_ESTADO M
			INNER JOIN SC_MAESTRO.MA_ESTADO E ON E.ESTA_SESTADOID=M.MEES_SESTADOID
			WHERE	E.ESTA_CESTADO='A'
			AND		M.MEES_CESTADO='A' 

		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END

