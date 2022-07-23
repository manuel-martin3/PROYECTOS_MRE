USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_MOVIMIENTO_CARNE_IDENTIDAD_CONSULTAR]    Script Date: 15/04/2022 20:42:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	ALTER PROCEDURE [SC_CARDIP].[USP_CD_MOVIMIENTO_CARNE_IDENTIDAD_CONSULTAR]
	--================================================================================
	--SISTEMA			: SISTEMA CARNÉ PARA DIPLOMATICOS
	--OBJETIVO			: OBTIENE EL REGISTRO DE LA CABECERA Y EL DETALLE PARA GENERAR LA ORDEN DE PAGO
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 23/11/2014 18:47:27
	--PARAMETROS        :	@P_ID_SOLICITUD			IDENTIFICADOR DE LA TABLA
	--EJECUTAR          : [SC_CARDIP].[USP_CD_MOVIMIENTO_CARNE_IDENTIDAD_CONSULTAR] 29
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	-- MANUEL NUNJA					20180222	-		MODIFICACION PARA VALIDAR EL CAMPO CESTADO
	--================================================================================
	--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
	--FECHA DE MODIFICACIÓN  : 13/04/2022
	--MOTIVO				 : SE CAMBIA TIPO DE DATO SMALLINT A INT
	--PARAMETROS			 : @P_CARNE_IDENTIDAD_ID
	--================================================================================
	--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
	--FECHA DE MODIFICACIÓN  : 15/04/2022
	--MOTIVO				 : SE AGREGA PALABRA CLAVE WITH(NOLOCK) A CONSULTAS
	--================================================================================
	@P_CARNE_IDENTIDAD_ID		INT

	AS
	BEGIN
		BEGIN TRY
			SELECT		(USUARIO.USUA_VAPELLIDOPATERNO + ' ' + USUARIO.USUA_VAPELLIDOMATERNO + ', ' + USUARIO.USUA_VNOMBRES) AS MOV_USUARIO,
						CONVERT(VARCHAR,MOCI.MOCI_DFECHA_MOVIMIENTO,103) AS MOV_FECHA,
						CONVERT(VARCHAR,MOCI.MOCI_DFECHA_MOVIMIENTO,108) AS MOV_HORA,
						ESTADO.ESTA_VDESCRIPCIONCORTA AS MOV_ESTADO,
						OFCO.OFCO_VSIGLAS AS MOV_OFICINA,
						ISNULL(TIPOOBS.PARA_VDESCRIPCION,'-') AS MOV_TIPOOBS,
						ISNULL(MOCI.MOCI_VOBSERVACION_DETALLE,'-') AS MOV_OBSDESC
			FROM		SC_CARDIP.CD_MOVIMIENTO_CARNE_IDENTIDAD MOCI WITH(NOLOCK)
			INNER JOIN	SC_MAESTRO.MA_ESTADO ESTADO WITH(NOLOCK) ON MOCI.MOCI_SESTADOID = ESTADO.ESTA_SESTADOID
			INNER JOIN	PS_SISTEMA.SI_OFICINACONSULAR OFCO WITH(NOLOCK) ON MOCI.MOCI_SOFICINACONSULARID = OFCO.OFCO_SOFICINACONSULARID
			LEFT JOIN	PS_SISTEMA.SI_PARAMETRO TIPOOBS WITH(NOLOCK) ON MOCI.MOCI_SOBSERVACION_TIPO = TIPOOBS.PARA_SPARAMETROID
			INNER JOIN	PS_SEGURIDAD.SE_USUARIO USUARIO WITH(NOLOCK) ON MOCI.MOCI_SUSUARIOCREACION = USUARIO.USUA_SUSUARIOID
			WHERE		MOCI.MOCI_ICARNE_IDENTIDADID=@P_CARNE_IDENTIDAD_ID
			AND			MOCI.MOCI_CESTADO='A'
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
		RETURN @@IDENTITY
	END

/****** Object:  StoredProcedure [SC_GENERAL].[USP_GR_OBTENER_INFO_USUARIOS]    Script Date: 23/02/2018 10:56:18 a.m. ******/
SET ANSI_NULLS ON
