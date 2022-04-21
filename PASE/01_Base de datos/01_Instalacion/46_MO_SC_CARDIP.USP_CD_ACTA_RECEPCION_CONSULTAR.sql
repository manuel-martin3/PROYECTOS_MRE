USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_ACTA_RECEPCION_CONSULTAR]    Script Date: 15/04/2022 19:50:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



	ALTER PROCEDURE [SC_CARDIP].[USP_CD_ACTA_RECEPCION_CONSULTAR]
	--================================================================================
	--SISTEMA			: SISTEMA CARNÉ PARA DIPLOMATICOS
	--OBJETIVO			: OBTIENE EL REGISTRO DE LA CABECERA Y EL DETALLE DE LA RECEPCION
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 23/11/2014 18:47:27
	--PARAMETROS        : @P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
	--EJECUTAR          : SC_CARDIP.USP_CD_ACTA_RECEPCION_CONSULTAR 6
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================
	--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
	--FECHA DE MODIFICACIÓN  : 15/04/2022
	--MOTIVO				 : SE AGREGA PALABRA CLAVE WITH(NOLOCK) A CONSULTAS
	--================================================================================
	@P_ACTA_REC_CAB_ID		SMALLINT
	AS
	BEGIN
		BEGIN TRY
			SELECT ISNULL(ACRE_VOBSERVACION,'-') AS OBSERVACION,
			(SOLICITANTE.SOLI_VPRIMER_APELLIDO + ' ' + SOLICITANTE.SOLI_VSEGUNDO_APELLIDO + ' ' + SOLICITANTE.SOLI_VNOMBRES) AS SOLICITANTE,
			DOCIDENT.DOID_VDESCRIPCIONCORTA AS TIPO_DOC_IDENT,
			SOLICITANTE.SOLI_VNUMERO_DOCUMENTO_IDENTIDAD AS NUM_DOC_IDENT
			FROM SC_CARDIP.CD_ACTA_RECEPCION_CABECERA ACTAREC_CAB WITH(NOLOCK)
			INNER JOIN	PN_REGISTRO.RE_SOLICITANTE SOLICITANTE WITH(NOLOCK) ON ACTAREC_CAB.ACRE_SSOLICITANTE_ID = SOLICITANTE.SOLI_SSOLICITANTE_ID
			INNER JOIN SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD AS DOCIDENT WITH(NOLOCK) ON SOLICITANTE.SOLI_STIPO_DOCUMENTO_IDENTIDAD_ID = DOCIDENT.DOID_STIPODOCUMENTOIDENTIDADID
			WHERE		ACTAREC_CAB.ACRE_SACTA_RECEPCION_ID = @P_ACTA_REC_CAB_ID

			
			SELECT (REGPREV.REPE_VPRIMER_APELLIDO + ' ' + ISNULL(REGPREV.REPE_VSEGUNDO_APELLIDO,'') + ' ' + REGPREV.REPE_VNOMBRES) AS TITULAR_CARNE,
			(CAST(CARDIP.CAID_IPERIODO AS varchar) + ' - ' + (RIGHT(REPLICATE('0',5) + CAST(CARDIP.CAID_IIDENT_NUMERO AS VARCHAR(5)),5))) AS NUMERO_IDENT
			FROM SC_CARDIP.CD_ACTA_RECEPCION_DETALLE ACTAREC_DET WITH(NOLOCK)
			INNER JOIN	SC_CARDIP.CD_CARNE_IDENTIDAD CARDIP WITH(NOLOCK) ON ACTAREC_DET.ACRD_SCARNE_IDENTIDAD_ID = CARDIP.CAID_ICARNE_IDENTIDADID
			LEFT JOIN	PN_REGISTRO.RE_PERSONA PERSONA WITH(NOLOCK) ON CARDIP.CAID_IPERSONAID = PERSONA.PERS_IPERSONAID
			LEFT JOIN	PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX WITH(NOLOCK) ON CARDIP.CAID_SOFICINA_CONSULAR_EXID = OFCOEX.OFCE_SOFICINACONSULAR_EXTRANJERAID
			INNER JOIN	SC_CARDIP.CD_REGISTRO_PREVIO REGPREV WITH(NOLOCK) ON CARDIP.CAID_SREGISTRO_PREVIO = REGPREV.REPE_SREGISTRO_PREVIO_ID
			WHERE		ACTAREC_DET.ACRD_SACTA_RECEPCION_CAB_ID = @P_ACTA_REC_CAB_ID
			
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END


