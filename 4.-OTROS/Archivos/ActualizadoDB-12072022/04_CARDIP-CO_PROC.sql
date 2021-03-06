USE BD_CARDIP
GO
IF NOT EXISTS (SELECT OBJECT_ID FROM SYS.OBJECTS WHERE OBJECT_ID = OBJECT_ID(N'[SC_CARDIP].[USP_CD_REPORTE_CONSULTA_CARNET]') AND TYPE IN (N'P', N'PC'))
BEGIN
EXEC DBO.SP_EXECUTESQL @STATEMENT = N'CREATE PROCEDURE [SC_CARDIP].[USP_CD_REPORTE_CONSULTA_CARNET] AS' 
END
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO	
--======================================================================
--SISTEMA		:	CARDIP -administrador
--OBJETIVO		:	consulta para el reporte de consulta de carnets	
--CREADO POR	:	VPIPA
--FECHA			:	01/07/2021
--ejecutar exec [SC_CARDIP].[USP_CD_REPORTE_CONSULTA_CARNET] 0,'1900-01-01','1900-01-01',0,'','','','', 'ORTEGA ZAVALA JUAN MANUEL','1900-01-01',0,0,0,0
--======================================================================

ALTER PROCEDURE [SC_CARDIP].[USP_CD_REPORTE_CONSULTA_CARNET]	
	@P_RELI_STIPO_EMISION	SMALLINT,
	@P_FECHA_INICIO			DATETIME,
	@P_FECHA_FIN			DATETIME,
	@P_CAID_SESTADOID		SMALLINT,
	@P_TIPODOC				VARCHAR(20), 
	@DOCUMENTONUMERO		VARCHAR(20),
	@NUM_SOLICITUD			VARCHAR(15),
	@NUMERO_CARNE			VARCHAR(15),
	@APELLIDOS_NOMBRES		VARCHAR(40),
	@FECHA_NACIMIENTOFECHA	DATETIME,
	@PERS_SPAISID			SMALLINT,
	@PARA_SPARAMETROID		SMALLINT,
	@OFICINA_CONSULARID		SMALLINT,
	@CAID_SUSUARIOCREACION	SMALLINT
	AS
	BEGIN
		BEGIN TRY
				SELECT 
				REPORT.NUM_SOLICITUD,
				REPORT.RELI_STIPO_EMISION,
				REPORT.APELLIDOS_NOMBRES,
				REPORT.FECHA_NACIMIENTOFECHA,
				REPORT.TIPODOC,
				REPORT.DOCUMENTONUMERO,
				REPORT.PARA_SPARAMETROID,
				REPORT.STATUS_MIG,
				REPORT.DOCUMENTO_TITULAR,
				REPORT.PERS_SPAISID,
				REPORT.PAIS_NACIONALIDAD,
				REPORT.CALIDAD_MIGRATORIA,
				REPORT.CAID_SESTADOID,
				REPORT.ESTADO,
				REPORT.NUMERO_CARNE,
				REPORT.FECHA_EMISION,
				REPORT.FECHA_VENCIMIENTO,
				REPORT.OFICINA_CONSULARID,
				REPORT.OFICINA_CONSULAR_EXTRANJERA,
				REPORT.CAID_DFECHACREACION,
				REPORT.CAID_SUSUARIOCREACION
				FROM (
					SELECT		
					RL.RELI_VDP_NUMERO_REG_LINEA NUM_SOLICITUD,RELI_STIPO_EMISION,
					(
						CASE
							WHEN (PERSONA.PERS_VAPELLIDOPATERNO + ' ' + ISNULL(PERSONA.PERS_VAPELLIDOMATERNO,'') + ' ' + PERSONA.PERS_VNOMBRES) IS NULL
								THEN REGPREV.REPE_VPRIMER_APELLIDO + ' ' + ISNULL(REGPREV.REPE_VSEGUNDO_APELLIDO,'') + ' ' + REGPREV.REPE_VNOMBRES 
							ELSE (PERSONA.PERS_VAPELLIDOPATERNO + ' ' + ISNULL(PERSONA.PERS_VAPELLIDOMATERNO,'') + ' ' + PERSONA.PERS_VNOMBRES)
						END	
					) AS APELLIDOS_NOMBRES,

					ISNULL(CONVERT(VARCHAR(10),PERSONA.PERS_DNACIMIENTOFECHA,103),'-') AS FECHA_NACIMIENTOFECHA,PERS_DNACIMIENTOFECHA,
						DOID_VDESCRIPCIONCORTA as  TIPODOC,
					PEID_VDOCUMENTONUMERO as  DOCUMENTONUMERO,
					TITDEP.PARA_SPARAMETROID,ISNULL(TITDEP.PARA_VDESCRIPCION,'-') AS STATUS_MIG,	
					'' DOCUMENTO_TITULAR,
					PERSONA.PERS_SPAISID,
					(SELECT ISNULL((PAIS_VNOMBRE + ' (' + ISNULL(PAIS_VNACIONALIDAD,'[ NO DEFINIDO ]') + ')'),'-')
						FROM PS_SISTEMA.SI_PAIS WITH(NOLOCK)
							WHERE PAIS_SPAISID = PERSONA.PERS_SPAISID) AS PAIS_NACIONALIDAD,
					ISNULL(CALMIG.CAMI_VNOMBRE,ISNULL((SELECT CAMI_VNOMBRE 
						FROM SC_MAESTRO.MA_CALIDAD_MIGRATORIA WITH(NOLOCK)
							WHERE CAMI_SCALIDAD_MIGRATORIAID = REGPREV.REPE_SCALIDAD_MIGRATORIA),'-')) AS CALIDAD_MIGRATORIA,
					CARDIP.CAID_SESTADOID,
					(SELECT ESTA_VDESCRIPCIONCORTA 
						FROM SC_MAESTRO.MA_ESTADO ESTADO WITH(NOLOCK) 
							WHERE ESTA_SESTADOID = CARDIP.CAID_SESTADOID) AS ESTADO,
					ISNULL(CARDIP.CAID_VCARNE_NUMERO,'[ S/N ]') AS NUMERO_CARNE,
					ISNULL(CONVERT(VARCHAR,CARDIP.CAID_DFECHA_EMISION,103),'-') AS FECHA_EMISION,CARDIP.CAID_DFECHA_EMISION,
					ISNULL(CONVERT(VARCHAR,CARDIP.CAID_DFECHA_VENCIMIENTO,103),'-') AS FECHA_VENCIMIENTO,
					ISNULL(CARDIP.CAID_SOFICINA_CONSULAR_EXID,OFCOEX.OFCE_SCATEGORIAID)AS OFICINA_CONSULARID,
					ISNULL(OFCOEX.OFCE_VNOMBRE, (SELECT OFCE_VNOMBRE 
						FROM PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA WITH(NOLOCK)
							WHERE OFCE_SOFICINACONSULAR_EXTRANJERAID = REGPREV.REPE_SOFICINA_CONSULAR_EX_ID)) AS OFICINA_CONSULAR_EXTRANJERA,
					CAID_DFECHACREACION,CARDIP.CAID_SUSUARIOCREACION
					FROM SC_CARDIP.CD_CARNE_IDENTIDAD CARDIP WITH(NOLOCK)
					LEFT JOIN PN_REGISTRO.RE_PERSONA PERSONA WITH(NOLOCK) ON CARDIP.CAID_IPERSONAID=PERSONA.PERS_IPERSONAID
					LEFT JOIN PN_REGISTRO.RE_PERSONAIDENTIFICACION PEID WITH(NOLOCK) ON PEID.PEID_IPERSONAID = PERSONA.PERS_IPERSONAID and PEID_BACTIVOENRUNE=1
					LEFT JOIN SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD  DOCIDENT WITH(NOLOCK) ON PEID.PEID_SDOCUMENTOTIPOID=DOCIDENT.DOID_STIPODOCUMENTOIDENTIDADID AND DOCIDENT.DOID_CESTADO='A'
					LEFT JOIN SC_MAESTRO.MA_CALIDAD_MIGRATORIA CALMIG WITH(NOLOCK) ON CARDIP.CAID_SCALIDAD_MIGRATORIAID = CALMIG.CAMI_SCALIDAD_MIGRATORIAID
					LEFT JOIN SC_MAESTRO.MA_CALIDAD_MIGRATORIA CALMIGSEC WITH(NOLOCK) ON CARDIP.CAID_SCALIDAD_MIGRATORIA_SEC_ID = CALMIGSEC.CAMI_SCALIDAD_MIGRATORIAID
					LEFT JOIN PS_SISTEMA.SI_PARAMETRO TITDEP WITH(NOLOCK) ON CALMIGSEC.CAMI_SFLAG_TITULAR_DEPENDIENTE = TITDEP.PARA_SPARAMETROID
					LEFT JOIN PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX WITH(NOLOCK) ON CARDIP.CAID_SOFICINA_CONSULAR_EXID = OFCOEX.OFCE_SOFICINACONSULAR_EXTRANJERAID
					LEFT JOIN SC_CARDIP.CD_REGISTRO_PREVIO REGPREV WITH(NOLOCK) ON CARDIP.CAID_SREGISTRO_PREVIO = REGPREV.REPE_SREGISTRO_PREVIO_ID
					LEFT JOIN SC_REGLINEA.RL_REGISTRO_LINEA RL WITH(NOLOCK) ON CARDIP.[CAID_ICARNE_IDENTIDADID]=RL.RELI_ICARNE_IDENTIDAD_ID and rl.RELI_CESTADO='A'
				)REPORT
				WHERE	
				 REPORT.RELI_STIPO_EMISION			= (CASE WHEN @P_RELI_STIPO_EMISION = 0 THEN REPORT.RELI_STIPO_EMISION ELSE @P_RELI_STIPO_EMISION END)
				 AND REPORT.CAID_DFECHA_EMISION		>=(CASE WHEN YEAR(@P_FECHA_INICIO)=1900 THEN REPORT.CAID_DFECHA_EMISION ELSE @P_FECHA_INICIO END)
				 AND REPORT.CAID_DFECHA_EMISION		<=(CASE WHEN YEAR(@P_FECHA_FIN)=1900 THEN REPORT.CAID_DFECHA_EMISION ELSE @P_FECHA_FIN END)
				 AND REPORT.CAID_SESTADOID			= (CASE WHEN @P_CAID_SESTADOID = 0 THEN REPORT.CAID_SESTADOID ELSE @P_CAID_SESTADOID END)
				 AND REPORT.TIPODOC					= (CASE WHEN @P_TIPODOC = '' THEN REPORT.TIPODOC ELSE @P_TIPODOC END)
				 AND REPORT.DOCUMENTONUMERO			= (CASE WHEN @DOCUMENTONUMERO = '' THEN REPORT.DOCUMENTONUMERO ELSE @DOCUMENTONUMERO END)
				 AND REPORT.NUM_SOLICITUD			= (CASE WHEN @NUM_SOLICITUD = '' THEN REPORT.NUM_SOLICITUD ELSE @NUM_SOLICITUD END)
				 AND REPORT.NUMERO_CARNE			= (CASE WHEN @NUMERO_CARNE = '' THEN REPORT.NUMERO_CARNE ELSE @NUMERO_CARNE END)
				 AND REPORT.APELLIDOS_NOMBRES		= (CASE WHEN @APELLIDOS_NOMBRES = '' THEN REPORT.APELLIDOS_NOMBRES ELSE @APELLIDOS_NOMBRES END)
				 AND REPORT.PERS_DNACIMIENTOFECHA	= (CASE WHEN YEAR(@FECHA_NACIMIENTOFECHA)=1900  THEN REPORT.PERS_DNACIMIENTOFECHA ELSE @FECHA_NACIMIENTOFECHA END)
				 AND REPORT.PERS_SPAISID			= (CASE WHEN @PERS_SPAISID = 0 THEN REPORT.PERS_SPAISID ELSE @PERS_SPAISID END)
				 AND REPORT.PARA_SPARAMETROID		= (CASE WHEN @PARA_SPARAMETROID = 0 THEN REPORT.PARA_SPARAMETROID ELSE @PARA_SPARAMETROID END)
				 AND REPORT.OFICINA_CONSULARID		= (CASE WHEN @OFICINA_CONSULARID = 0 THEN REPORT.OFICINA_CONSULARID ELSE @OFICINA_CONSULARID END)
				 AND REPORT.CAID_SUSUARIOCREACION	= (CASE WHEN @CAID_SUSUARIOCREACION = 0 THEN REPORT.CAID_SUSUARIOCREACION ELSE @CAID_SUSUARIOCREACION END)

		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END
	
