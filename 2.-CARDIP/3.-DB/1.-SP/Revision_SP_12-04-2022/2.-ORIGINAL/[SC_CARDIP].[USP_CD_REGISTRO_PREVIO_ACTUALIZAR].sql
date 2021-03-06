USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_REGISTRO_PREVIO_ACTUALIZAR]    Script Date: 11/04/2022 20:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	ALTER PROCEDURE [SC_CARDIP].[USP_CD_REGISTRO_PREVIO_ACTUALIZAR]
	--================================================================================
	--SISTEMA			: SISTEMA DE ENVIO VIRTUAL DE DOCUMENTOS
	--OBJETIVO			: OBTIENE EL REGISTRO DE LA CABECERA Y EL DETALLE PARA GENERAR LA ORDEN DE PAGO
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 23/11/2014 18:47:27
	--PARAMETROS        :	@P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
	--EJECUTAR          : [SC_CARDIP].[USP_CD_REGISTRO_PREVIO_ACTUALIZAR] 'NUNJA','ASTACIO','MANUEL',2001,1890,393,2018,1,1,'0.0.0.0'
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--================================================================================
	@P_REGISTRO_PREVIO_ID		SMALLINT,
	@P_CARNE_IDENTIDAD_ID		SMALLINT,
	@P_PRIMER_APELLIDO			VARCHAR(100),
	@P_SEGUNDO_APELLIDO			VARCHAR(100),
	@P_NOMBRES					VARCHAR(100),
	@P_GENERO					SMALLINT,
	@P_OFICINA_CONSULAR_EX		SMALLINT,
	@P_CALIDAD_MIGRATORIA		SMALLINT,
	@P_FECHA_CON				DATETIME,
	@P_FECHA_PRI				DATETIME,
	@P_USUARIO_MODIFICACION		SMALLINT,
	@P_IP_MODIFICACION			VARCHAR(50),
	@P_TIPO_ENTRADA				SMALLINT
	AS
	BEGIN
		BEGIN TRY 
			BEGIN TRAN
				-- REGISTRO PREVIO
				UPDATE	SC_CARDIP.CD_REGISTRO_PREVIO 
				SET		REPE_VPRIMER_APELLIDO			=	@P_PRIMER_APELLIDO,
						REPE_VSEGUNDO_APELLIDO			=	@P_SEGUNDO_APELLIDO,
						REPE_VNOMBRES					=	@P_NOMBRES,
						REPE_SGENERO_ID					=	@P_GENERO,
						REPE_SOFICINA_CONSULAR_EX_ID	=	@P_OFICINA_CONSULAR_EX,
						REPE_SCALIDAD_MIGRATORIA		=	@P_CALIDAD_MIGRATORIA,
						REPE_DFECHA_CONSULARES			=	@P_FECHA_CON,
						REPE_DFECHA_PRIVILEGIOS			=	@P_FECHA_PRI,
						REPE_SUSUARIO_MODIFICACION		=	@P_USUARIO_MODIFICACION,
						REPE_VIP_MODIFICACION			=	@P_IP_MODIFICACION,
						REPE_DFECHA_MODIFICACION		=	GETDATE()
				WHERE	REPE_SREGISTRO_PREVIO_ID		=	@P_REGISTRO_PREVIO_ID
					
				-- CARNE DE IDENTIDAD
				UPDATE	SC_CARDIP.CD_CARNE_IDENTIDAD
				SET		CAID_STIPO_ENTRADA			=	@P_TIPO_ENTRADA,
						CAID_SUSUARIOMODIFICACION	=	@P_USUARIO_MODIFICACION,
						CAID_VIPMODIFICACION		=	@P_IP_MODIFICACION,
						CAID_DFECHAMODIFICACION		=	GETDATE()
				WHERE	CAID_ICARNE_IDENTIDADID		=	@P_CARNE_IDENTIDAD_ID
					
			COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END



	/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_REGISTRO_PREVIO_CONSULTAR]    Script Date: 21/05/2018 11:25:22 a.m. ******/
SET ANSI_NULLS ON
