USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_REGLINEA].[USP_RL_REGISTRO_LINEA_ACTUALIZAR]    Script Date: 10/06/2021 04:33:01 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [SC_REGLINEA].[USP_RL_REGISTRO_LINEA_ACTUALIZAR]
--======================================================================
--SISTEMA		:	
--OBJETIVO		:	
--CREADO POR		:	
--FECHA			:	07/10/2019
--PARAMETROS		:	
--EJECUTAR		:	SC_REGLINEA.USP_RL_REGISTRO_LINEA_ACTUALIZAR ,NULL,
--MODIFICACIONES
--AUTOR		FECHA		N° REQ		MOTIVO		
--======================================================================
--MODIFICADO POR: JONATAN SILVA CACHAY
--MOTIVO: SE AGREGA LOS NUEVOS CAMPOS
-- FECHA DE MODIFICACIÓN:16/09/2020
--======================================================================
--MODIFICADO POR: JONATAN SILVA CACHAY
--MOTIVO: SE AGREGA LOS NUEVOS CAMPOS
-- FECHA DE MODIFICACIÓN:11/12/2020
--======================================================================
--MODIFICADO POR: VPIPAU
--MOTIVO: SE AGREGA LOS NUEVOS CAMPOS REFERENTES A CALIDAD MIGRATORIA
-- FECHA DE MODIFICACIÓN:14/06/2021
--======================================================================


@P_RELI_IREGISTRO_LINEA_ID                  INT,
@P_RELI_ICARNE_IDENTIDAD_ID                 SMALLINT,
@P_RELI_STIPO_EMISION                       SMALLINT,
@P_RELI_SDP_RELDEP_TITDEP					SMALLINT,
@P_RELI_SDP_RELDEP_TITULAR					SMALLINT,
@P_RELI_VDP_PRIMER_APELLIDO                 VARCHAR(100),
@P_RELI_VDP_SEGUNDO_APELLIDO                VARCHAR(100),
@P_RELI_VDP_NOMBRES                         VARCHAR(100),
@P_RELI_DDP_FECHA_NACIMIENTO                DATETIME,
@P_RELI_SDP_GENERO_ID                       SMALLINT,
@P_RELI_SDP_ESTADO_CIVIL_ID                 SMALLINT,
@P_RELI_SDP_TIPO_DOC_IDENTIDAD              SMALLINT,
@P_RELI_VDP_NUMERO_DOC_IDENTIDAD            VARCHAR(20),
@P_RELI_SDP_PAIS_NACIONALIDAD               SMALLINT,
@P_RELI_VDP_DOMICILIO_PERU                  VARCHAR(500),
@P_RELI_CDP_UBIGEO                          CHAR(6),
@P_RELI_VDP_CORREO_ELECTRONICO              VARCHAR(50),
@P_RELI_VDP_NUMERO_TELEFONO                 VARCHAR(50),
@P_RELI_VDP_RUTA_ADJUNTO                    VARCHAR(250),
@P_RELI_SIN_TIPO_INSTITUCION                SMALLINT,
@P_RELI_VIN_NOMBRE_INSTITUCION              VARCHAR(250),
@P_RELI_VIN_PERSONA_CONTACTO                VARCHAR(250),
@P_RELI_VIN_CARGO_CONTACTO                  VARCHAR(250),
@P_RELI_VIN_CORREO_ELECTRONICO              VARCHAR(50),
@P_RELI_VIN_NUMERO_TELEFONO                 VARCHAR(50),
@P_RELI_SIN_TIPO_CARGO                      SMALLINT,
@P_RELI_VIN_CARGO_NOMBRE                    VARCHAR(150),
@P_RELI_VIP_MODIFICACION                    VARCHAR(50),
@P_RELI_VDP_RUTA_FIRMA                      VARCHAR(100),
@P_RELI_VDP_RUTA_PASAPORTE                  VARCHAR(100),
@P_RELI_VDP_RUTA_DEN_POLICIAL               VARCHAR(100),
@P_RELI_VDP_MOTIVO_DUPLICADO                VARCHAR(100),

@P_RELI_SIN_COD_INSTITUCION                 SMALLINT,
@P_RELI_SIN_COD_CATEGORIA_MISION            SMALLINT,
@P_RELI_SIN_TIPO_CALIDAD_MIGRATORIA         SMALLINT,
@P_RELI_SIN_COD_CARGO						SMALLINT,

@P_RELI_VTIPO_VISA							VARCHAR(2),
@P_RELI_VVISA								VARCHAR(5),
@P_RELI_VTITULARIDAD_FAMILIAR				VARCHAR(2),
@P_RELI_STIEMPO_PERMANENCIA                 SMALLINT
AS
BEGIN
	BEGIN TRY
		DECLARE
		@P_RELI_SUSUARIO SMALLINT = (SELECT USUA_SUSUARIOID FROM PS_SEGURIDAD.SE_USUARIO WITH(NOLOCK) WHERE USUA_VALIAS='USUARIO REG LINEA')
		
		UPDATE	SC_REGLINEA.RL_REGISTRO_LINEA
		SET		RELI_ICARNE_IDENTIDAD_ID			=	@P_RELI_ICARNE_IDENTIDAD_ID,
				RELI_STIPO_EMISION					=	@P_RELI_STIPO_EMISION,
				RELI_SDP_RELDEP_TITDEP				=	@P_RELI_SDP_RELDEP_TITDEP,
				RELI_SDP_RELDEP_TITULAR				=	@P_RELI_SDP_RELDEP_TITULAR,
				RELI_VDP_PRIMER_APELLIDO			=	@P_RELI_VDP_PRIMER_APELLIDO,
				RELI_VDP_SEGUNDO_APELLIDO			=	@P_RELI_VDP_SEGUNDO_APELLIDO,
				RELI_VDP_NOMBRES					=	@P_RELI_VDP_NOMBRES,
				RELI_DDP_FECHA_NACIMIENTO			=	@P_RELI_DDP_FECHA_NACIMIENTO,
				RELI_SDP_GENERO_ID					=	@P_RELI_SDP_GENERO_ID,
				RELI_SDP_ESTADO_CIVIL_ID			=	@P_RELI_SDP_ESTADO_CIVIL_ID,
				RELI_SDP_TIPO_DOC_IDENTIDAD			=	@P_RELI_SDP_TIPO_DOC_IDENTIDAD,
				RELI_VDP_NUMERO_DOC_IDENTIDAD		=	@P_RELI_VDP_NUMERO_DOC_IDENTIDAD,
				RELI_SDP_PAIS_NACIONALIDAD			=	@P_RELI_SDP_PAIS_NACIONALIDAD,
				RELI_VDP_DOMICILIO_PERU				=	@P_RELI_VDP_DOMICILIO_PERU,
				RELI_CDP_UBIGEO						=	@P_RELI_CDP_UBIGEO,
				RELI_VDP_CORREO_ELECTRONICO			=	@P_RELI_VDP_CORREO_ELECTRONICO,
				RELI_VDP_NUMERO_TELEFONO			=	@P_RELI_VDP_NUMERO_TELEFONO,
				RELI_VDP_RUTA_ADJUNTO				=	@P_RELI_VDP_RUTA_ADJUNTO,
				RELI_SIN_TIPO_INSTITUCION			=	@P_RELI_SIN_TIPO_INSTITUCION,
				RELI_VIN_NOMBRE_INSTITUCION			=	@P_RELI_VIN_NOMBRE_INSTITUCION,
				RELI_VIN_PERSONA_CONTACTO			=	@P_RELI_VIN_PERSONA_CONTACTO,
				RELI_VIN_CARGO_CONTACTO				=	@P_RELI_VIN_CARGO_CONTACTO,
				RELI_VIN_CORREO_ELECTRONICO			=	@P_RELI_VIN_CORREO_ELECTRONICO,
				RELI_VIN_NUMERO_TELEFONO			=	@P_RELI_VIN_NUMERO_TELEFONO,
				RELI_SIN_TIPO_CARGO					=	@P_RELI_SIN_TIPO_CARGO,
				RELI_VIN_CARGO_NOMBRE				=	@P_RELI_VIN_CARGO_NOMBRE,
				RELI_SUSUARIO_MODIFICACION			=	@P_RELI_SUSUARIO,
				RELI_VIP_MODIFICACION				=	@P_RELI_VIP_MODIFICACION,
				RELI_DFECHA_MODIFICACION			=	GETDATE(),
				RELI_VDP_RUTA_FIRMA					=	@P_RELI_VDP_RUTA_FIRMA,
				RELI_VDP_RUTA_PASAPORTE				=	@P_RELI_VDP_RUTA_PASAPORTE,
				RELI_VDP_RUTA_DEN_POLICIAL			=	@P_RELI_VDP_RUTA_DEN_POLICIAL,
				RELI_VDP_MOTIVO_DUPLICADO			=	@P_RELI_VDP_MOTIVO_DUPLICADO,				
				RELI_SIN_COD_INSTITUCION			=   @P_RELI_SIN_COD_INSTITUCION,
				RELI_SIN_COD_CATEGORIA_MISION		=	@P_RELI_SIN_COD_CATEGORIA_MISION,
				RELI_SIN_TIPO_CALIDAD_MIGRATORIA	=	@P_RELI_SIN_TIPO_CALIDAD_MIGRATORIA,
				RELI_SIN_COD_CARGO					=	@P_RELI_SIN_COD_CARGO,
				RELI_VTIPO_VISA						=   @P_RELI_VTIPO_VISA,
				RELI_VVISA							=   @P_RELI_VVISA,
				RELI_VTITULARIDAD_FAMILIAR			=   @P_RELI_VTITULARIDAD_FAMILIAR,
				RELI_STIEMPO_PERMANENCIA		   =    @P_RELI_STIEMPO_PERMANENCIA
		WHERE	RELI_SREG_LINEA_ID					=	@P_RELI_IREGISTRO_LINEA_ID
		AND		RELI_CESTADO						=	'A'

	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS ErrorMessage;
	END CATCH
END
