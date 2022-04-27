USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_DERIVAR_PARA_RENOVACION]    Script Date: 15/04/2022 20:30:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	ALTER PROCEDURE [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_DERIVAR_PARA_RENOVACION]
	--================================================================================
	--SISTEMA			: SISTEMA DE EMISIÓN DE CARNÉS PARA EXTRANJEROS
	--OBJETIVO			: DERIVA REGISTROS
	--CREADO			: JONATAN SILVA
	--FECHA     		: 16/12/2019
	--PARAMETROS        :	
	--EJECUTAR          : [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_DERIVAR_PARA_RENOVACION]
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================
	--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
	--FECHA DE MODIFICACIÓN  : 13/04/2022
	--MOTIVO				 : SE CAMBIA TIPO DE DATO SMALLINT A INT
	--PARAMETROS			 : @P_CARNE_IDENTIDAD_ID
	--================================================================================
	@P_CARNE_IDENTIDAD_ID		INT,
	@P_ESTADO_ID				SMALLINT,
	@P_REGISTRADOR_ID			SMALLINT,
	@P_USUARIO_MODIFICACION		SMALLINT,
	@P_IP_MODIFICACION			VARCHAR(50)
	AS
	BEGIN
		BEGIN TRY 
			BEGIN TRAN					
				-- CARNE DE IDENTIDAD
				IF(@P_REGISTRADOR_ID = 0)
					BEGIN
						UPDATE	SC_CARDIP.CD_CARNE_IDENTIDAD
						SET	CAID_SESTADOID				=	@P_ESTADO_ID,
                        CAID_BRENOVAR           = 1,
                        CAID_BDUPLICADO         = 0,
								CAID_SUSUARIOMODIFICACION	=	@P_USUARIO_MODIFICACION,
								CAID_VIPMODIFICACION		=	@P_IP_MODIFICACION,
								CAID_DFECHAMODIFICACION		=	GETDATE()
						WHERE	CAID_ICARNE_IDENTIDADID		=	@P_CARNE_IDENTIDAD_ID
					END
				ELSE
					BEGIN
						UPDATE	SC_CARDIP.CD_CARNE_IDENTIDAD
						SET	CAID_SESTADOID				=	@P_ESTADO_ID,
                        CAID_BRENOVAR           = 1,
                        CAID_BDUPLICADO         = 0,
								CAID_SUSUARIO_DERIVA		=	@P_REGISTRADOR_ID,
								CAID_SUSUARIOMODIFICACION	=	@P_USUARIO_MODIFICACION,
								CAID_VIPMODIFICACION		=	@P_IP_MODIFICACION,
								CAID_DFECHAMODIFICACION		=	GETDATE()
						WHERE	CAID_ICARNE_IDENTIDADID		=	@P_CARNE_IDENTIDAD_ID
					END
			COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END

