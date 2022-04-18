USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_MOVIMIENTO_CARNE_IDENTIDAD_ADICIONAR]    Script Date: 18/04/2022 11:29:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	ALTER PROCEDURE [SC_CARDIP].[USP_CD_MOVIMIENTO_CARNE_IDENTIDAD_ADICIONAR]
	--================================================================================
	--SISTEMA			: MÓDULO DE CARNET PARA DIPLOMÁTICOS
	--OBJETIVO			: OBTIENE EL REGISTRO DE LA CABECERA Y EL DETALLE PARA GENERAR LA ORDEN DE PAGO
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 23/11/2014 18:47:27
	--PARAMETROS        :	@P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
	--EJECUTAR          : [SC_CARDIP].[USP_CD_GENERALES_MRE]
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================
	@P_CARNE_IDENTIDAD_ID		SMALLINT,
	@P_ESTADO_ID				SMALLINT,
	@P_OFICNA_MOVIMIENTO		SMALLINT,
	@P_OBSERVACION_TIPO			SMALLINT,
	@P_OBSERVACION_DETALLE		VARCHAR(250),
	@P_USUARIO_CREACION			SMALLINT,
	@P_IP_CREACION				VARCHAR(50)

	AS
	BEGIN
		BEGIN TRY
			INSERT INTO SC_CARDIP.CD_MOVIMIENTO_CARNE_IDENTIDAD (MOCI_ICARNE_IDENTIDADID,MOCI_DFECHA_MOVIMIENTO,MOCI_SESTADOID,MOCI_SOFICINACONSULARID,MOCI_SOBSERVACION_TIPO,MOCI_VOBSERVACION_DETALLE,MOCI_SUSUARIOCREACION,MOCI_VIPCREACION,MOCI_DFECHACREACION)
			VALUES (@P_CARNE_IDENTIDAD_ID,GETDATE(),@P_ESTADO_ID,@P_OFICNA_MOVIMIENTO,@P_OBSERVACION_TIPO,@P_OBSERVACION_DETALLE,@P_USUARIO_CREACION,@P_IP_CREACION,GETDATE())
		END TRY
		BEGIN CATCH
			DECLARE @ERROR VARCHAR(200)
			SELECT @ERROR = ERROR_MESSAGE()
			RAISERROR(@ERROR, 16, 1) 
		END CATCH
		RETURN @@IDENTITY
	END


