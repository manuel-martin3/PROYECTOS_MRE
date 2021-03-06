
use BD_CARDIP
GO
--====================================================================================================
	-- SISTEMA				: SISTEMA DE CITAS
	-- OBJETIVO				: INSERTA LA INFORMACION DE ERRORES DE LA APLICACION CARDIP EN LINEA
	-- CREADO POR			: VIDAL PIPA
	-- FECHA				: 15/06/2021
	-- PARÁMETRO(S):
		--@LOER_VNOMFORMULARIO	
		--@LOER_VERROR
		--@LOER_VDETALLEERROR
		--@LOER_VMETODO
		--@LOER_SUSUARIOCREACION
		--@LOER_VIPCREACION 
--EJECUTAR	: EXEC SC_REGLINEA.SC_LOG_ERRORES_REGISTRAR_LOG '--','ERROR','DETALLE DE ERROR','--','',''
--==================================================================================================== 
IF NOT EXISTS (SELECT OBJECT_ID FROM SYS.OBJECTS WHERE OBJECT_ID = OBJECT_ID(N'[SC_REGLINEA].[SC_LOG_ERRORES_REGISTRAR_LOG]') AND TYPE IN (N'P', N'PC'))
BEGIN
EXEC DBO.SP_EXECUTESQL @STATEMENT = N'CREATE PROCEDURE [SC_REGLINEA].[SC_LOG_ERRORES_REGISTRAR_LOG] AS' 
END
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  PROCEDURE [SC_REGLINEA].[SC_LOG_ERRORES_REGISTRAR_LOG]
	(
		@LOER_VNOMFORMULARIO	VARCHAR(100) = NULL,
		@LOER_VERROR          VARCHAR(500) = NULL,
		@LOER_VDETALLEERROR          VARCHAR(1000) = NULL,
		@LOER_VMETODO         VARCHAR(100) = NULL,
		@LOER_SUSUARIOCREACION SMALLINT =  NULL,
		@LOER_VIPCREACION     VARCHAR(20) = NULL
   )
AS
BEGIN
SET NOCOUNT ON;

	BEGIN TRY
       DECLARE @FECHA DATETIME = GETDATE()

		INSERT INTO SC_REGLINEA.RE_LOG_ERRORES(LOER_VNOMFORMULARIO,LOER_VERROR,LOER_VDETALLEERROR,LOER_VMETODO,
			LOER_SUSUARIOCREACION,LOER_VIPCREACION,LOER_DFECHACREACION)

		SELECT @LOER_VNOMFORMULARIO,@LOER_VERROR,@LOER_VDETALLEERROR,@LOER_VMETODO,@LOER_SUSUARIOCREACION,@LOER_VIPCREACION,@FECHA

	END TRY
	BEGIN CATCH
		SELECT ERROR_NUMBER() AS ERRORNUMBER,ERROR_SEVERITY() AS ERRORSEVERITY,
		 ERROR_STATE() AS ERRORSTATE,ERROR_PROCEDURE() AS ERRORPROCEDURE,
		ERROR_LINE() AS ERRORLINE,ERROR_MESSAGE() AS ERRORMESSAGE;
	END CATCH
	SET NOCOUNT OFF;
END

go
--================================================================================
--SISTEMA			: CARDIP LINEA
--OBJETIVO			: insertar detalle de estado
--CREADO			: vpipa
--FECHA     		: 05/07/2021 18:47:27
--PARAMETROS        :	@P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
--EJECUTAR          :SC_REGLINEA].[USP_RL_REGISTRO_LINEA_ACTUALIZAR_DETALLEESTADO_ENVIADO]
--MODIFICACIONES
--AUTOR                       FECHA      N° REQ.      MOTIVO
--================================================================================
IF NOT EXISTS (SELECT OBJECT_ID FROM SYS.OBJECTS WHERE OBJECT_ID = OBJECT_ID(N'[SC_REGLINEA].[USP_RL_REGISTRO_LINEA_ACTUALIZAR_DETALLEESTADO_ENVIADO]') AND TYPE IN (N'P', N'PC'))
BEGIN
EXEC DBO.SP_EXECUTESQL @STATEMENT = N'CREATE PROCEDURE [SC_REGLINEA].[USP_RL_REGISTRO_LINEA_ACTUALIZAR_DETALLEESTADO_ENVIADO] AS' 
END
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO	
ALTER PROCEDURE [SC_REGLINEA].[USP_RL_REGISTRO_LINEA_ACTUALIZAR_DETALLEESTADO_ENVIADO]
@P_RELI_IREGISTRO_LINEA_ID      INT,
@P_RELI_SESTADO_ID				SMALLINT
AS
BEGIN
	BEGIN TRY
		
		----INSERTA EL DETALLE en el estado
		IF NOT EXISTS(SELECT DERE_SCODIGO FROM SC_REGLINEA.RL_DETALLE_REGISTRO_LINEA WITH(NOLOCK)
						WHERE DERE_SREG_LINEA_ID=@P_RELI_IREGISTRO_LINEA_ID AND DERE_SESTADO_ID=@P_RELI_SESTADO_ID)BEGIN
			DECLARE @NUEVO_DERE_SCODIGO SMALLINT
			
			SELECT @NUEVO_DERE_SCODIGO= (ISNULL(MAX(DERE_SCODIGO),0)+1) FROM SC_REGLINEA.RL_DETALLE_REGISTRO_LINEA WITH(NOLOCK)
				WHERE DERE_SREG_LINEA_ID=@P_RELI_IREGISTRO_LINEA_ID
			
			INSERT INTO  SC_REGLINEA.RL_DETALLE_REGISTRO_LINEA(DERE_SREG_LINEA_ID, DERE_SCODIGO, DERE_SESTADO_ID, DERE_VOBSERVACION,DERE_FECHACREACION)
			VALUES (@P_RELI_IREGISTRO_LINEA_ID, @NUEVO_DERE_SCODIGO,@P_RELI_SESTADO_ID, '',GETDATE())
		END
			
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS ErrorMessage;
	END CATCH
END
