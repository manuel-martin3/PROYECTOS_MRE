USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_EXISTENCIA_CARNET_NOMBRES]    Script Date: 18/04/2022 11:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	ALTER PROCEDURE [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_EXISTENCIA_CARNET_NOMBRES]
	--================================================================================
	--SISTEMA			: SISTEMA DE ENVIO VIRTUAL DE DOCUMENTOS
	--OBJETIVO			: OBTIENE EL REGISTRO DE LA CABECERA Y EL DETALLE PARA GENERAR LA ORDEN DE PAGO
	--CREADO			   : JONATAN SILVA CACHAY
	--FECHA     		: 16/12/2019
	--PARAMETROS        :	@P_APELLIDO_PAT			
   --                      @P_NOMBRES
	--EJECUTAR          : [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_EXISTENCIA_CARNET_NOMBRES] 'SILVA','JONATAN'
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================

	@P_APELLIDO_PAT		VARCHAR(100),
	@P_NOMBRES			VARCHAR(100)
	AS
	BEGIN
		DECLARE @V_ESTADO VARCHAR(1)='A'
		SET NOCOUNT ON
		BEGIN TRY


			SELECT		CARDIP.CAID_ICARNE_IDENTIDADID AS CARDIP_ID
			FROM		SC_CARDIP.CD_CARNE_IDENTIDAD CARDIP (NOLOCK)
			INNER JOIN	PN_REGISTRO.RE_PERSONA PERSONA (NOLOCK) ON CARDIP.CAID_IPERSONAID=PERSONA.PERS_IPERSONAID
			WHERE		CARDIP.CAID_VCARNE_NUMERO IS NOT NULL
                  AND CARDIP.CAID_CESTADO=@V_ESTADO
                  AND PERSONA.PERS_VAPELLIDOPATERNO=@P_APELLIDO_PAT
						AND PERSONA.PERS_VNOMBRES=@P_NOMBRES
			ORDER BY 1 DESC

		
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END