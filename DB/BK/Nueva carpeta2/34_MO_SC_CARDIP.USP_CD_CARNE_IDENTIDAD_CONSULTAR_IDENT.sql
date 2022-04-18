USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_CONSULTAR_IDENT]    Script Date: 11/04/2022 19:49:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	ALTER PROCEDURE [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_CONSULTAR_IDENT]
	--================================================================================
	--SISTEMA			: SISTEMA CARNÉ PARA DIPLOMATICOS
	--OBJETIVO			: OBTIENE EL REGISTRO DE LA CABECERA Y EL DETALLE PARA GENERAR LA ORDEN DE PAGO
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 23/11/2014 18:47:27
	--PARAMETROS        :	@P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
	--EJECUTAR          : SC_CARDIP.USP_CD_CARNE_IDENTIDAD_CONSULTAR_IDENT 190
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================
	@P_CARNE_ID		SMALLINT
	AS
	BEGIN
		BEGIN TRY
			DECLARE @V_IDENT	VARCHAR(12)
			SELECT @V_IDENT = (CAST(CARDIP.CAID_IPERIODO AS varchar) + ' - ' + (RIGHT(REPLICATE('0',5) + CAST(CARDIP.CAID_IIDENT_NUMERO AS VARCHAR(5)),5))) 
								FROM	SC_CARDIP.CD_CARNE_IDENTIDAD CARDIP
								WHERE	CAID_ICARNE_IDENTIDADID=@P_CARNE_ID 
								AND		CAID_CESTADO='A'
			SELECT @V_IDENT AS IDENT
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END

