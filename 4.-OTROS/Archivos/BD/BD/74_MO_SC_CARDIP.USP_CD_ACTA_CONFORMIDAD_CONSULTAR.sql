USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_ACTA_CONFORMIDAD_CONSULTAR]    Script Date: 15/04/2022 20:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



	ALTER PROCEDURE [SC_CARDIP].[USP_CD_ACTA_CONFORMIDAD_CONSULTAR]
	--================================================================================
	--SISTEMA			: SISTEMA CARNÉ PARA DIPLOMATICOS
	--OBJETIVO			: OBTIENE EL REGISTRO DE LA CABECERA Y EL DETALLE PARA GENERAR LA ORDEN DE PAGO
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 23/11/2014 18:47:27
	--PARAMETROS        : @P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
	--EJECUTAR          : SC_CARDIP.USP_CD_ACTA_CONFORMIDAD_CONSULTAR 5
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================
	--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
	--FECHA DE MODIFICACIÓN  : 15/04/2022
	--MOTIVO				 : SE AGREGA PALABRA CLAVE WITH(NOLOCK) A CONSULTAS
	--================================================================================
	@P_ACTA_CAB_ID		SMALLINT
	AS
	BEGIN
		BEGIN TRY
			SELECT ISNULL(ACCA_VOBSERVACION,'-') AS OBSERVACION,
			(SOLICITANTE.SOLI_VPRIMER_APELLIDO + ' ' + SOLICITANTE.SOLI_VSEGUNDO_APELLIDO + ' ' + SOLICITANTE.SOLI_VNOMBRES) AS SOLICITANTE,
			DOCIDENT.DOID_VDESCRIPCIONCORTA AS TIPO_DOC_IDENT,
			SOLICITANTE.SOLI_VNUMERO_DOCUMENTO_IDENTIDAD AS NUM_DOC_IDENT
			FROM SC_CARDIP.CD_ACTA_CONFORMIDAD_CABECERA ACTACAB WITH(NOLOCK)  
			INNER JOIN	PN_REGISTRO.RE_SOLICITANTE SOLICITANTE WITH(NOLOCK) ON ACTACAB.ACCA_SSOLICITANTE = SOLICITANTE.SOLI_SSOLICITANTE_ID
			INNER JOIN SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD AS DOCIDENT WITH(NOLOCK) ON SOLICITANTE.SOLI_STIPO_DOCUMENTO_IDENTIDAD_ID = DOCIDENT.DOID_STIPODOCUMENTOIDENTIDADID
			WHERE ACTACAB.ACCA_SACTA_CONFORMIDAD_CABECERA_ID = @P_ACTA_CAB_ID

			
			SELECT (PERSONA.PERS_VAPELLIDOPATERNO + ' ' + ISNULL(PERSONA.PERS_VAPELLIDOMATERNO,'') + ' ' + PERSONA.PERS_VNOMBRES) AS TITULAR_CARNE,
			CARDIP.CAID_VCARNE_NUMERO AS CARNE_NUMERO,
			OFCOEX.OFCE_SOFICINACONSULAR_EXTRANJERAID AS OFCOEX_ID
			FROM SC_CARDIP.CD_ACTA_CONFORMIDAD_DETALLE ACTADET WITH(NOLOCK)  
			INNER JOIN	SC_CARDIP.CD_CARNE_IDENTIDAD CARDIP WITH(NOLOCK) ON ACTADET.ACDE_SCARNE_IDENTIDAD_ID = CARDIP.CAID_ICARNE_IDENTIDADID
			INNER JOIN	PN_REGISTRO.RE_PERSONA PERSONA WITH(NOLOCK) ON CARDIP.CAID_IPERSONAID = PERSONA.PERS_IPERSONAID
			INNER JOIN	PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX WITH(NOLOCK) ON CARDIP.CAID_SOFICINA_CONSULAR_EXID = OFCOEX.OFCE_SOFICINACONSULAR_EXTRANJERAID
			WHERE ACTADET.ACDE_SACTA_CONFORMIDAD_CAB_ID = @P_ACTA_CAB_ID
			

			SELECT DISTINCT(OFCOEX.OFCE_VNOMBRE) AS OFCO_NOMBRE, 
			OFCOEX.OFCE_SOFICINACONSULAR_EXTRANJERAID AS OFCO_ID
			FROM SC_CARDIP.CD_ACTA_CONFORMIDAD_DETALLE ACTADET WITH(NOLOCK)  
			INNER JOIN SC_CARDIP.CD_CARNE_IDENTIDAD CARDIP WITH(NOLOCK)ON ACTADET.ACDE_SCARNE_IDENTIDAD_ID = CARDIP.CAID_ICARNE_IDENTIDADID
			INNER JOIN PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX WITH(NOLOCK)ON CARDIP.CAID_SOFICINA_CONSULAR_EXID = OFCOEX.OFCE_SOFICINACONSULAR_EXTRANJERAID
			WHERE ACTADET.ACDE_SACTA_CONFORMIDAD_CAB_ID = @P_ACTA_CAB_ID
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END


