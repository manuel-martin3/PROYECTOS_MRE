USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_ACTA_CONFORMIDAD_DETALLE_ADICIONAR]    Script Date: 07/04/2022 14:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



	ALTER PROCEDURE [SC_CARDIP].[USP_CD_ACTA_CONFORMIDAD_DETALLE_ADICIONAR]
	--================================================================================
	--SISTEMA			: SISTEMA DE EMISION DE CARNÉS
	--OBJETIVO			: GENERA EL DETALLE DEL ACTA DE CONFORMIDAD
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 09/05/2018 18:47:27
	--PARAMETROS        :				
	--EJECUTAR          : [SC_CARDIP].[USP_CD_ACTA_CONFORMIDAD_CABECERA_ADICIONAR]
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================
	@P_ACTA_CONF_CAB_ID			SMALLINT,
	@P_CARNE_IDENTIDAD_ID		INT,
	@P_USUARIO_CREACION			SMALLINT,
	@P_IP_CREACION				VARCHAR(50)
	AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN
				INSERT INTO SC_CARDIP.CD_ACTA_CONFORMIDAD_DETALLE(ACDE_SACTA_CONFORMIDAD_CAB_ID,ACDE_SCARNE_IDENTIDAD_ID,ACDE_SUSUARIO_CREACION,ACDE_VIP_CREACION,ACDE_DFECHA_CREACION)
				VALUES (@P_ACTA_CONF_CAB_ID,@P_CARNE_IDENTIDAD_ID,@P_USUARIO_CREACION,@P_IP_CREACION,GETDATE())

				UPDATE	SC_CARDIP.CD_CARNE_IDENTIDAD
				SET		CAID_BFLAG_ENTREGADO	= 1
				WHERE	CAID_ICARNE_IDENTIDADID	= @P_CARNE_IDENTIDAD_ID
				AND		CAID_CESTADO			= 'A'
			COMMIT TRAN
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
		RETURN @@IDENTITY
	END


