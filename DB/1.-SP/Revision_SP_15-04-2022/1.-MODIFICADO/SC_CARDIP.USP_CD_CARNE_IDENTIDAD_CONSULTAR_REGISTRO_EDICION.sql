USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_CONSULTAR_REGISTRO_EDICION]    Script Date: 15/04/2022 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_CONSULTAR_REGISTRO_EDICION]
	--================================================================================
	--SISTEMA			: SISTEMA DE ENVIO VIRTUAL DE DOCUMENTOS
	--OBJETIVO			: OBTIENE EL REGISTRO DE LA CABECERA Y EL DETALLE PARA GENERAR LA ORDEN DE PAGO
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 23/11/2014 18:47:27
	--PARAMETROS        : @P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
	--EJECUTAR          : [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_CONSULTAR_REGISTRO_EDICION] 370
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--MANUEL NUNJA				20180524		-			VALIDACION DE NULL EN REG PREVIO
	--================================================================================
	-- MODIFICADO POR: JONATAN SILVA CACHAY
	-- FECHA DE MODIFICACIÓN: 05/10/2020
	-- MOTIVO: SE AGREGA EL ESTADO DEL CARNET
	--================================================================================
	--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
	--FECHA DE MODIFICACIÓN  : 13/04/2022
	--MOTIVO				 : SE CAMBIA TIPO DE DATO SMALLINT A INT
	--PARAMETROS			 : @P_CARNE_ID
	--================================================================================
	@P_CARNE_ID		INT
	AS
	BEGIN
		SET NOCOUNT ON
		BEGIN TRY
			
			;WITH DETALLE AS
			(SELECT	CARDIP.CAID_VIDENT_MESA_PARTES AS MESA_PARTES,
				(CAST(CARDIP.CAID_IPERIODO AS varchar) + ' - ' + (RIGHT(REPLICATE('0',5) + CAST(CARDIP.CAID_IIDENT_NUMERO AS VARCHAR(5)),5))) AS NUMERO_IDENT,
				PERSONA.PERS_IPERSONAID AS PERSONA_ID,
				PERSONA.PERS_VAPELLIDOPATERNO AS PERSONA_APE_PAT,
				PERSONA.PERS_VAPELLIDOMATERNO AS PERSONA_APE_MAT,
				PERSONA.PERS_VNOMBRES AS PERSONA_NOMBRES,
				PERSONA.PERS_VTELEFONO AS TELEFONO,
				PERSONA.PERS_DNACIMIENTOFECHA AS PERSONA_FECNAC,
				PERSONA.PERS_SESTADOCIVILID AS PERSONA_ESTCIVIL_ID, 
				PERSONA.PERS_SGENEROID AS PERSONA_GENERO_ID, 
				ISNULL(PERSONA.PERS_SMENOR_EDAD, 0) AS PERSONA_MENOR_EDAD,
				(SELECT TOP 1 PEID_IPERSONAIDENTIFICACIONID FROM PN_REGISTRO.RE_PERSONAIDENTIFICACION WITH(NOLOCK) WHERE PEID_IPERSONAID = PERSONA.PERS_IPERSONAID ORDER BY PEID_DFECHACREACION DESC) AS PERIDENT_ID, 
				PERSONA.PERS_SPAISID AS PAIS_ID,
				(SELECT PAIS_VNACIONALIDAD FROM PS_SISTEMA.SI_PAIS WITH(NOLOCK) WHERE PAIS_SPAISID = PERSONA.PERS_SPAISID) AS PAIS_NACIONALIDAD,
				(SELECT TOP 1 PERE_IPERSONA_RESIDENCIA_ID FROM PN_REGISTRO.RE_RESIDENCIA WITH(NOLOCK) INNER JOIN PN_REGISTRO.RE_PERSONARESIDENCIA WITH(NOLOCK) ON RESI_IRESIDENCIAID = PERE_IRESIDENCIAID
						WHERE PERE_IPERSONAID = PERSONA.PERS_IPERSONAID ORDER BY PERE_DFECHACREACION DESC) AS PERE_IPERSONA_RESIDENCIA_ID, 
				CARDIP.CAID_SCALIDAD_MIGRATORIAID AS CALMIG_PRI,
				CARDIP.CAID_SCALIDAD_MIGRATORIA_SEC_ID AS CALMIGSEC_SEC,
				(SELECT CAMI_SFLAG_TITULAR_DEPENDIENTE FROM SC_MAESTRO.MA_CALIDAD_MIGRATORIA WITH(NOLOCK) WHERE CAMI_SCALIDAD_MIGRATORIAID = CARDIP.CAID_SCALIDAD_MIGRATORIA_SEC_ID) AS CALMIGSEC_TITDEP,
				CARDIP.CAID_SOFICINA_CONSULAR_EXID AS OFCOEX_ID,
				(SELECT OFCE_SCATEGORIAID FROM PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA WITH(NOLOCK) WHERE OFCE_SOFICINACONSULAR_EXTRANJERAID = CARDIP.CAID_SOFICINA_CONSULAR_EXID) AS OFCOEX_CATEGORIA,
				CARDIP.CAID_ICARNE_IDENTIDADID AS CARDIP_ID,
				CARDIP.CAID_VRUTA_ARCHIVO_FOTO AS CARDIP_RUTA_ARCHIVO,
				CARDIP.CAID_VRUTA_ARCHIVO_FIRMA AS CARDIP_RUTA_ARCHIVO_FIRMA,
				CARDIP.CAID_VCARNE_NUMERO AS CARDIP_NUMERO_CARNE,
				CARDIP.CAID_DFECHA_EMISION AS CARDIP_FECHA_EMISION,
				CARDIP.CAID_DFECHA_VENCIMIENTO AS CARDIP_FECHA_VENC,
				CARDIP.CAID_BRENOVAR AS RENOVAR,
				CARDIP.CAID_BFLAG_CONTROL_CALIDAD AS FLAG_CONTROL_CALIDAD,
				CARDIP.CAID_VCONTROL_CALIDAD AS CONTROL_CALIDAD,
				ISNULL(CARDIP.CAID_VCONTROL_CALIDAD_DETALLE,'') AS CONTROL_CALIDAD_DETALLE,
				ISNULL(REGPREV.REPE_DFECHA_CONSULARES,CARDIP.CAID_DFECHACREACION) AS REGPREV_FECHACON,
				ISNULL(REGPREV.REPE_DFECHA_PRIVILEGIOS,CARDIP.CAID_DFECHACREACION) AS REGPREV_FECHAPRI,
				ISNULL(REGPREV.REPE_SREGISTRO_PREVIO_ID,0) AS REGPREV_ID,
				ISNULL(CARDIP.CAID_STIPO_ENTRADA,0) AS CARDIP_TIPO_ENTRADA,
				CAID_SESTADOID as ESTADOID,
				(Select ESTA_VDESCRIPCIONCORTA From SC_MAESTRO.MA_ESTADO(NoLock) Where ESTA_SESTADOID = CAID_SESTADOID) as ESTADO_DESCRIPCION
				FROM SC_CARDIP.CD_CARNE_IDENTIDAD (NoLock) CARDIP 
				INNER JOIN PN_REGISTRO.RE_PERSONA (NoLock) PERSONA ON CARDIP.CAID_IPERSONAID=PERSONA.PERS_IPERSONAID
				LEFT JOIN SC_CARDIP.CD_REGISTRO_PREVIO (NoLock) REGPREV ON CARDIP.CAID_SREGISTRO_PREVIO = REGPREV.REPE_SREGISTRO_PREVIO_ID
				WHERE CARDIP.CAID_ICARNE_IDENTIDADID=@P_CARNE_ID
					AND CARDIP.CAID_CESTADO='A')

				SELECT MESA_PARTES,NUMERO_IDENT, PERSONA_ID, PERSONA_APE_PAT, PERSONA_APE_MAT, PERSONA_NOMBRES, TELEFONO, PERSONA_FECNAC, PERSONA_ESTCIVIL_ID, PERSONA_GENERO_ID, 
					PERSONA_MENOR_EDAD, PERIDENT_ID,
					(SELECT PEID_SDOCUMENTOTIPOID FROM PN_REGISTRO.RE_PERSONAIDENTIFICACION WITH(NOLOCK) WHERE PEID_IPERSONAIDENTIFICACIONID = PERIDENT_ID) AS PERIDENT_TIPODOC_ID,
					(SELECT PEID_VDOCUMENTONUMERO FROM PN_REGISTRO.RE_PERSONAIDENTIFICACION WITH(NOLOCK) WHERE PEID_IPERSONAIDENTIFICACIONID = PERIDENT_ID) AS PERIDENT_NUMDOCIDENT,
					PAIS_ID, PAIS_NACIONALIDAD, DETALLE.PERE_IPERSONA_RESIDENCIA_ID AS PERES_ID, 
					PERES.PERE_IRESIDENCIAID AS PERES_RESI_ID,
					RESI.RESI_VRESIDENCIADIRECCION AS RESI_DIRECCION,
					UBIGEO.UBGE_CUBI01 AS UBIGEO_DEPARTAMENTO,
					UBIGEO.UBGE_CUBI02 AS UBIGEO_PROVINCIA,
					UBIGEO.UBGE_CUBI03 AS UBIGEO_DISTRITO,
					CALMIG_PRI, CALMIGSEC_SEC, CALMIGSEC_TITDEP, OFCOEX_ID, OFCOEX_CATEGORIA, CARDIP_ID, CARDIP_RUTA_ARCHIVO,CARDIP_RUTA_ARCHIVO_FIRMA, CARDIP_NUMERO_CARNE, CARDIP_FECHA_EMISION,
					CARDIP_FECHA_VENC, RENOVAR, FLAG_CONTROL_CALIDAD, CONTROL_CALIDAD, CONTROL_CALIDAD_DETALLE,
					REGPREV_FECHACON, REGPREV_FECHAPRI, REGPREV_ID, CARDIP_TIPO_ENTRADA,ESTADOID,ESTADO_DESCRIPCION
				FROM DETALLE WITH(NOLOCK)
				INNER JOIN PN_REGISTRO.RE_PERSONARESIDENCIA PERES WITH(NOLOCK) ON DETALLE.PERE_IPERSONA_RESIDENCIA_ID = PERES.PERE_IPERSONA_RESIDENCIA_ID
				INNER JOIN PN_REGISTRO.RE_RESIDENCIA RESI WITH(NOLOCK) ON PERES.PERE_IRESIDENCIAID = RESI.RESI_IRESIDENCIAID
				INNER JOIN PS_SISTEMA.SI_UBICACIONGEOGRAFICA UBIGEO WITH(NOLOCK) ON RESI.RESI_CRESIDENCIAUBIGEO = UBIGEO.UBGE_CCODIGO

		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END