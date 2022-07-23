USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_REGLINEA].[USP_CD_CONSULTA_EXTERNA]    Script Date: 05/07/2021 06:56:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [SC_REGLINEA].[USP_CD_CONSULTA_EXTERNA]
--======================================================================
--SISTEMA		:	
--OBJETIVO		:	
--CREADO POR		:	
--FECHA			:	07/10/2019
--PARAMETROS		:	
--EJECUTAR		:	SC_REGLINEA.USP_CD_CONSULTA_EXTERNA '201900021'
--MODIFICACIONES
--AUTOR		FECHA		N° REQ		MOTIVO		
--======================================================================
--MODIFICADO POR: JONATAN SILVA CACHAY
--MOTIVO: SE AGREGA LOS NUEVOS CAMPOS
-- FECHA DE MODIFICACIÓN:16/09/2020
--======================================================================
--MODIFICADO POR: JONATAN SILVA CACHAY
--MOTIVO: SE AGREGA EL NUMERO DE CARNE y nuevos campos
-- FECHA DE MODIFICACIÓN:04/12/2020
--======================================================================
--MODIFICADO POR: VPIPA
--MOTIVO: se agrega un estado mas ESTADO_OBSERVADO en el filtro
-- FECHA DE MODIFICACIÓN:06/07/2021
--======================================================================
@P_RELI_VNUMERO_REG_LINEA      VARCHAR(9),
@P_RELI_DFECHA_CREACION_INI		DATETIME = NULL,
@P_RELI_DFECHA_CREACION_FIN		DATETIME = NULL
AS
BEGIN
	BEGIN TRY
	
		IF(@P_RELI_DFECHA_CREACION_INI IS NULL)
		BEGIN
			SELECT		RELI_SREG_LINEA_ID AS REGLINEA_ID,
						RELI_VDP_NUMERO_REG_LINEA AS RELI_NUMERO,
						ISNULL(RELI_ICARNE_IDENTIDAD_ID,0) AS RELI_CARDIP_ID,
						ISNULL(RELI_STIPO_EMISION,0) AS RELI_TIPO_EMISION,
						ISNULL(RELI_SDP_RELDEP_TITDEP,0) AS RELI_TITDEP,
						ISNULL(RELI_SDP_RELDEP_TITULAR,0) AS RELI_TITULAR,
						ISNULL(RELI_VDP_PRIMER_APELLIDO,'') AS RELI_PRIAPE,
						ISNULL(RELI_VDP_SEGUNDO_APELLIDO,'') AS RELI_SEGAPE,
						ISNULL(RELI_VDP_NOMBRES,'') AS RELI_NOMBRES,
						ISNULL(RELI_DDP_FECHA_NACIMIENTO,'') AS RELI_FECNAC,
						ISNULL(RELI_SDP_GENERO_ID,0) AS RELI_GENERO,
						ISNULL(RELI_SDP_ESTADO_CIVIL_ID,0) AS RELI_ESTCIVIL,
						ISNULL(RELI_SDP_TIPO_DOC_IDENTIDAD,0) AS RELI_TIPODOCIDENT,
						ISNULL(RELI_VDP_NUMERO_DOC_IDENTIDAD,'') AS RELI_NUMDOCIDENT,
						ISNULL(RELI_SDP_PAIS_NACIONALIDAD,0) AS RELI_NACIONALIDAD,
						ISNULL(RELI_VDP_DOMICILIO_PERU,'') AS RELI_DOMIPERU,
						ISNULL(RELI_CDP_UBIGEO,'000000') AS RELI_UBIGEO,
						ISNULL(RELI_VDP_CORREO_ELECTRONICO,'-') AS RELI_CORREO,
						ISNULL(RELI_VDP_NUMERO_TELEFONO,'-') AS RELI_TELEFONO,
						ISNULL(RELI_VDP_RUTA_ADJUNTO,'') AS RELI_ADJUNTO,
						ISNULL(RELI_SIN_TIPO_INSTITUCION,0) AS RELI_TIPOINST,
						ISNULL(RELI_VIN_NOMBRE_INSTITUCION,'') AS RELI_NOMINST,
						ISNULL(RELI_VIN_PERSONA_CONTACTO,'') AS RELI_PERCONTACTO,
						ISNULL(RELI_VIN_CARGO_CONTACTO,'') AS RELI_CARGOCONTACTO,
						ISNULL(RELI_VIN_CORREO_ELECTRONICO,'-') AS RELI_CORREOINST,
						ISNULL(RELI_VIN_NUMERO_TELEFONO,'-') AS RELI_TELEFONOINST,
						ISNULL(RELI_SIN_TIPO_CARGO,0) AS RELI_TIPOCARGO,
						ISNULL(RELI_VIN_CARGO_NOMBRE,'') AS RELI_NOMBRECARGO,
						ISNULL(CONVERT(VARCHAR,RELI_DFECHA_CREACION,103),'-') AS RELI_FECHACREA,
						ISNULL(CONVERT(VARCHAR,RELI_DFECHA_CREACION,108),'-') AS RELI_HORACREA,
						ISNULL(RELI_VDP_PRIMER_APELLIDO,'') + ' ' + ISNULL(RELI_VDP_SEGUNDO_APELLIDO,'') + ', ' + ISNULL(RELI_VDP_NOMBRES,'') AS RELI_NOMBRE_COMPLETO,
						
						(SELECT ESTA_VDESCRIPCIONCORTA FROM SC_MAESTRO.MA_ESTADO (NOLOCK) WHERE ESTA_SESTADOID = RL.RELI_SESTADO_ID) AS RELI_ESTADO_DESC,
						
						(SELECT ISNULL(PARA_VDESCRIPCION,'') FROM PS_SISTEMA.SI_PARAMETRO (NOLOCK) WHERE PARA_SPARAMETROID = RL.RELI_SDP_GENERO_ID) AS RELI_GENERO_DESC,
						
						(SELECT ISNULL(PARA_VDESCRIPCION,'') FROM PS_SISTEMA.SI_PARAMETRO (NOLOCK) WHERE PARA_SPARAMETROID = RL.RELI_SDP_ESTADO_CIVIL_ID) AS RELI_ESTADOC_DESC,
						
						(SELECT ISNULL(DOID_VDESCRIPCIONCORTA,'') FROM SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD (NOLOCK) WHERE DOID_STIPODOCUMENTOIDENTIDADID = RL.RELI_SDP_TIPO_DOC_IDENTIDAD) RELI_DOC_IDENT_DESC,
						(SELECT ISNULL(UBGE_VDEPARTAMENTO,'') FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA WHERE UBGE_CUBI01 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,1,2)) AND UBGE_CUBI02 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,3,2)) AND UBGE_CUBI03 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,5,2))) AS RELI_DEPARTAMENTO,
						(SELECT ISNULL(UBGE_VPROVINCIA,'') FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA WHERE UBGE_CUBI01 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,1,2)) AND UBGE_CUBI02 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,3,2)) AND UBGE_CUBI03 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,5,2))) AS RELI_PROVINCIA,
						(SELECT ISNULL(UBGE_VDISTRITO,'') FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA WHERE UBGE_CUBI01 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,1,2)) AND UBGE_CUBI02 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,3,2)) AND UBGE_CUBI03 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,5,2))) AS RELI_DISTRITO,
						
						(SELECT PARA_VDESCRIPCION FROM PS_SISTEMA.SI_PARAMETRO (NOLOCK) WHERE PARA_SPARAMETROID = RL.RELI_SDP_RELDEP_TITDEP) AS RELI_TITDEPDESC,
						ISNULL(CONVERT(VARCHAR,RELI_DDP_FECHA_NACIMIENTO,103),'-') AS RELI_FECNAC_STR,
						
						(SELECT PAIS_VNOMBRE FROM PS_SISTEMA.SI_PAIS (NOLOCK) WHERE PAIS_SPAISID = RL.RELI_SDP_PAIS_NACIONALIDAD) AS RELI_PAIS,
						
						(SELECT PARA_VDESCRIPCION FROM PS_SISTEMA.SI_PARAMETRO (NOLOCK) WHERE PARA_SPARAMETROID = RL.RELI_STIPO_EMISION) AS RELI_TIPOEMISION,
						ISNULL(RELI_VDP_RUTA_FIRMA,'') as RELI_VDP_RUTA_FIRMA,
						ISNULL(RELI_VDP_RUTA_PASAPORTE,'') as RELI_VDP_RUTA_PASAPORTE,
						ISNULL(RELI_VDP_RUTA_DEN_POLICIAL,'') as RELI_VDP_RUTA_DEN_POLICIAL,
						ISNULL(RELI_VDP_MOTIVO_DUPLICADO,'') as RELI_VDP_MOTIVO_DUPLICADO,
						ISNULL(RELI_VDP_RUTA_RESUMEN_ANEXOS,'') as RELI_VDP_RUTA_RESUMEN_ANEXOS,
						Isnull((select Top 1 CAID_VCARNE_NUMERO FROM [SC_CARDIP].[CD_CARNE_IDENTIDAD] (NOLOCK)
							Where CAID_ICARNE_IDENTIDADID = RELI_ICARNE_IDENTIDAD_ID),'') as NUMERO_CARNE,
						ISNULL(RELI_SIN_COD_INSTITUCION,0) as RELI_SIN_COD_INSTITUCION,
						ISNULL(RELI_SIN_COD_CATEGORIA_MISION,0) as RELI_SIN_COD_CATEGORIA_MISION,
						ISNULL(RELI_SIN_TIPO_CALIDAD_MIGRATORIA,0) as RELI_SIN_TIPO_CALIDAD_MIGRATORIA,
						ISNULL(RELI_SIN_COD_CARGO,0) as RELI_SIN_COD_CARGO,
						Isnull((select Top 1 CAID_VCARNE_NUMERO FROM [SC_CARDIP].[CD_CARNE_IDENTIDAD] (NOLOCK)
							Where CAID_ICARNE_IDENTIDADID = RELI_SDP_RELDEP_TITULAR),'') as NUMERO_CARNE_RELACION
			FROM		SC_REGLINEA.RL_REGISTRO_LINEA RL (NOLOCK)
			WHERE		RELI_VDP_NUMERO_REG_LINEA	=	@P_RELI_VNUMERO_REG_LINEA
			AND			RELI_CESTADO				=	'A'
			Order by REGLINEA_ID desc
		END
		ELSE
		BEGIN
			SET @P_RELI_DFECHA_CREACION_FIN = @P_RELI_DFECHA_CREACION_FIN + '23:59'

			DECLARE @ESTADO_ENVIADO SMALLINT
			DECLARE @ESTADO_APROBADO SMALLINT
			DECLARE @ESTADO_OBSERVADO SMALLINT

			Select @ESTADO_ENVIADO = ESTA_SESTADOID from SC_MAESTRO.MA_ESTADO  where ESTA_VDESCRIPCIONCORTA = 'ENVIADO' AND ESTA_VGRUPO = 'REG LINEA - ESTADO' and ESTA_CESTADO = 'A'
			Select @ESTADO_APROBADO = ESTA_SESTADOID from SC_MAESTRO.MA_ESTADO  where ESTA_VDESCRIPCIONCORTA = 'APROBADO' AND ESTA_VGRUPO = 'REG LINEA - ESTADO' and ESTA_CESTADO = 'A'
			Select @ESTADO_OBSERVADO = ESTA_SESTADOID from SC_MAESTRO.MA_ESTADO  where ESTA_VDESCRIPCIONCORTA = 'OBSERVADO' AND ESTA_VGRUPO = 'REG LINEA - ESTADO' and ESTA_CESTADO = 'A'

			
			SELECT		RELI_SREG_LINEA_ID AS REGLINEA_ID,
						RELI_VDP_NUMERO_REG_LINEA AS RELI_NUMERO,
						ISNULL(RELI_ICARNE_IDENTIDAD_ID,0) AS RELI_CARDIP_ID,
						ISNULL(RELI_STIPO_EMISION,0) AS RELI_TIPO_EMISION,
						ISNULL(RELI_SDP_RELDEP_TITDEP,0) AS RELI_TITDEP,
						ISNULL(RELI_SDP_RELDEP_TITULAR,0) AS RELI_TITULAR,
						ISNULL(RELI_VDP_PRIMER_APELLIDO,'') AS RELI_PRIAPE,
						ISNULL(RELI_VDP_SEGUNDO_APELLIDO,'') AS RELI_SEGAPE,
						ISNULL(RELI_VDP_NOMBRES,'') AS RELI_NOMBRES,
						ISNULL(RELI_DDP_FECHA_NACIMIENTO,'') AS RELI_FECNAC,
						
						ISNULL(RELI_SDP_GENERO_ID,0) AS RELI_GENERO,
						ISNULL(RELI_SDP_ESTADO_CIVIL_ID,0) AS RELI_ESTCIVIL,
						ISNULL(RELI_SDP_TIPO_DOC_IDENTIDAD,0) AS RELI_TIPODOCIDENT,
						ISNULL(RELI_VDP_NUMERO_DOC_IDENTIDAD,'') AS RELI_NUMDOCIDENT,
						ISNULL(RELI_SDP_PAIS_NACIONALIDAD,0) AS RELI_NACIONALIDAD,
						ISNULL(RELI_VDP_DOMICILIO_PERU,'') AS RELI_DOMIPERU,
						ISNULL(RELI_CDP_UBIGEO,'000000') AS RELI_UBIGEO,
						ISNULL(RELI_VDP_CORREO_ELECTRONICO,'-') AS RELI_CORREO,
						ISNULL(RELI_VDP_NUMERO_TELEFONO,'-') AS RELI_TELEFONO,
						ISNULL(RELI_VDP_RUTA_ADJUNTO,'') AS RELI_ADJUNTO,
						ISNULL(RELI_SIN_TIPO_INSTITUCION,0) AS RELI_TIPOINST,
						ISNULL(RELI_VIN_NOMBRE_INSTITUCION,'') AS RELI_NOMINST,
						ISNULL(RELI_VIN_PERSONA_CONTACTO,'') AS RELI_PERCONTACTO,
						ISNULL(RELI_VIN_CARGO_CONTACTO,'') AS RELI_CARGOCONTACTO,
						ISNULL(RELI_VIN_CORREO_ELECTRONICO,'-') AS RELI_CORREOINST,
						ISNULL(RELI_VIN_NUMERO_TELEFONO,'-') AS RELI_TELEFONOINST,
						ISNULL(RELI_SIN_TIPO_CARGO,0) AS RELI_TIPOCARGO,
						ISNULL(RELI_VIN_CARGO_NOMBRE,'') AS RELI_NOMBRECARGO,
						ISNULL(CONVERT(VARCHAR,RELI_DFECHA_CREACION,103),'-') AS RELI_FECHACREA,
						ISNULL(CONVERT(VARCHAR,RELI_DFECHA_CREACION,108),'-') AS RELI_HORACREA,
						ISNULL(RELI_VDP_PRIMER_APELLIDO,'') + ' ' + ISNULL(RELI_VDP_SEGUNDO_APELLIDO,'') + ', ' + ISNULL(RELI_VDP_NOMBRES,'') AS RELI_NOMBRE_COMPLETO,
		
						(SELECT ESTA_VDESCRIPCIONCORTA FROM SC_MAESTRO.MA_ESTADO (NOLOCK) WHERE ESTA_SESTADOID = RL.RELI_SESTADO_ID) AS RELI_ESTADO_DESC,

		
						(SELECT ISNULL(PARA_VDESCRIPCION,'') FROM PS_SISTEMA.SI_PARAMETRO (NOLOCK) WHERE PARA_SPARAMETROID = RL.RELI_SDP_GENERO_ID) AS RELI_GENERO_DESC,
						(SELECT ISNULL(PARA_VDESCRIPCION,'') FROM PS_SISTEMA.SI_PARAMETRO (NOLOCK) WHERE PARA_SPARAMETROID = RL.RELI_SDP_ESTADO_CIVIL_ID) AS RELI_ESTADOC_DESC,
						(SELECT ISNULL(DOID_VDESCRIPCIONCORTA,'') FROM SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD (NOLOCK) WHERE DOID_STIPODOCUMENTOIDENTIDADID = RL.RELI_SDP_TIPO_DOC_IDENTIDAD) RELI_DOC_IDENT_DESC,
						(SELECT ISNULL(UBGE_VDEPARTAMENTO,'') FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA WHERE UBGE_CUBI01 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,1,2)) AND UBGE_CUBI02 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,3,2)) AND UBGE_CUBI03 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,5,2))) AS RELI_DEPARTAMENTO,
						(SELECT ISNULL(UBGE_VPROVINCIA,'') FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA WHERE UBGE_CUBI01 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,1,2)) AND UBGE_CUBI02 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,3,2)) AND UBGE_CUBI03 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,5,2))) AS RELI_PROVINCIA,
						(SELECT ISNULL(UBGE_VDISTRITO,'') FROM PS_SISTEMA.SI_UBICACIONGEOGRAFICA WHERE UBGE_CUBI01 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,1,2)) AND UBGE_CUBI02 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,3,2)) AND UBGE_CUBI03 = (SELECT SUBSTRING(RELI_CDP_UBIGEO,5,2))) AS RELI_DISTRITO,
						
						(SELECT PARA_VDESCRIPCION FROM PS_SISTEMA.SI_PARAMETRO (NOLOCK) WHERE PARA_SPARAMETROID = RL.RELI_SDP_RELDEP_TITDEP) AS RELI_TITDEPDESC,
						ISNULL(CONVERT(VARCHAR,RELI_DDP_FECHA_NACIMIENTO,103),'-') AS RELI_FECNAC_STR,
						
						(SELECT PAIS_VNOMBRE FROM PS_SISTEMA.SI_PAIS (NOLOCK) WHERE PAIS_SPAISID = RL.RELI_SDP_PAIS_NACIONALIDAD) AS RELI_PAIS,
						(SELECT PARA_VDESCRIPCION FROM PS_SISTEMA.SI_PARAMETRO (NOLOCK) WHERE PARA_SPARAMETROID = RL.RELI_STIPO_EMISION) AS RELI_TIPOEMISION,
						ISNULL(RELI_VDP_RUTA_FIRMA,'') as RELI_VDP_RUTA_FIRMA,
						ISNULL(RELI_VDP_RUTA_PASAPORTE,'') as RELI_VDP_RUTA_PASAPORTE,
						ISNULL(RELI_VDP_RUTA_DEN_POLICIAL,'') as RELI_VDP_RUTA_DEN_POLICIAL,
						ISNULL(RELI_VDP_MOTIVO_DUPLICADO,'') as RELI_VDP_MOTIVO_DUPLICADO,
						ISNULL(RELI_VDP_RUTA_RESUMEN_ANEXOS,'') as RELI_VDP_RUTA_RESUMEN_ANEXOS,
						Isnull((select Top 1 CAID_VCARNE_NUMERO FROM [SC_CARDIP].[CD_CARNE_IDENTIDAD] (NOLOCK)
							Where CAID_ICARNE_IDENTIDADID = RELI_ICARNE_IDENTIDAD_ID),'') as NUMERO_CARNE,
						ISNULL(RELI_SIN_COD_INSTITUCION,0) as RELI_SIN_COD_INSTITUCION,
						ISNULL(RELI_SIN_COD_CATEGORIA_MISION,0) as RELI_SIN_COD_CATEGORIA_MISION,
						ISNULL(RELI_SIN_TIPO_CALIDAD_MIGRATORIA,0) as RELI_SIN_TIPO_CALIDAD_MIGRATORIA,
						ISNULL(RELI_SIN_COD_CARGO,0) as RELI_SIN_COD_CARGO,
						Isnull((select Top 1 CAID_VCARNE_NUMERO FROM [SC_CARDIP].[CD_CARNE_IDENTIDAD] (NOLOCK)
							Where CAID_ICARNE_IDENTIDADID = RELI_SDP_RELDEP_TITULAR),'') as NUMERO_CARNE_RELACION
			FROM		SC_REGLINEA.RL_REGISTRO_LINEA RL (NOLOCK)
			WHERE		RELI_VDP_NUMERO_REG_LINEA	=	CASE WHEN ISNULL(@P_RELI_VNUMERO_REG_LINEA,'') = '' THEN RELI_VDP_NUMERO_REG_LINEA ELSE @P_RELI_VNUMERO_REG_LINEA END
			AND			RELI_DFECHA_CREACION between @P_RELI_DFECHA_CREACION_INI and @P_RELI_DFECHA_CREACION_FIN
			AND			RELI_CESTADO				=	'A'
			AND			RELI_SESTADO_ID IN (@ESTADO_ENVIADO,@ESTADO_APROBADO,@ESTADO_OBSERVADO)
			Order by REGLINEA_ID desc
		END
		
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS ErrorMessage;
	END CATCH
	RETURN @@IDENTITY
END

