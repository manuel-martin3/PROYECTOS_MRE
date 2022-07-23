USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_REGISTRO_PREVIO_CONSULTAR]    Script Date: 15/04/2022 19:55:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	ALTER PROCEDURE [SC_CARDIP].[USP_CD_REGISTRO_PREVIO_CONSULTAR]
	--================================================================================
	--SISTEMA			: SISTEMA DE EMISION DE CARNES
	--OBJETIVO			: CONSULTA REGISTRO PREVIO
	--CREADO			: MANUEL NUNJA
	--FECHA     		: 09/04/2018 
	--PARAMETROS        :				
	--EJECUTAR          : [SC_CARDIP].[USP_CD_REGISTRO_PREVIO_CONSULTAR] 0,0,'20180025','','','','01/01/1900','01/01/1900',0,0,0,0,1,15
	--MODIFICACIONES
	--AUTOR                       FECHA      N° REQ.      MOTIVO
	--MANUEL NUNJA				20180524	-				VALIDACION EN JOIN DE ESTADO('A') EN ACTA CONFORMIDAD Y RECEPCION DETALLE
	--================================================================================
	--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
	--FECHA DE MODIFICACIÓN  : 15/04/2022
	--MOTIVO				 : SE AGREGA PALABRA CLAVE WITH(NOLOCK) A CONSULTAS
	--================================================================================

	@P_PERIODO				INT,
	@P_NUMERO_IDENT			INT,
	@P_NUMERO_CARNE			VARCHAR(8),
	@P_APELLIDO_PAT			VARCHAR(100),
	@P_APELLIDO_MAT			VARCHAR(100),
	@P_NOMBRES				VARCHAR(100),
	@P_FECHA_REGISTRO_DESDE	DATETIME,
	@P_FECHA_REGISTRO_HASTA	DATETIME,
	@P_TIPO_ENTRADA			SMALLINT,
	@P_CALIDAD_MIG			SMALLINT,
	@P_OFICINA_CON_EX		SMALLINT,
	@P_ESTADO				SMALLINT,
	/*VARIABLES DE PAGINACION*/
	@P_NUM_PAG				BIGINT,
	@P_CANT_REG_PAG			BIGINT
	AS
	BEGIN
		BEGIN TRY 
			DECLARE	@V_TOTAL_REG BIGINT =	(
									SELECT COUNT(CARDIP.CAID_ICARNE_IDENTIDADID)
									FROM SC_CARDIP.CD_CARNE_IDENTIDAD CARDIP WITH(NOLOCK)
									LEFT JOIN SC_MAESTRO.MA_ESTADO ESTADO WITH(NOLOCK) ON CARDIP.CAID_SESTADOID = ESTADO.ESTA_SESTADOID
									LEFT JOIN PS_SISTEMA.SI_PARAMETRO TIPOENT WITH(NOLOCK) ON CARDIP.CAID_STIPO_ENTRADA = TIPOENT.PARA_SPARAMETROID
									LEFT JOIN SC_CARDIP.CD_REGISTRO_PREVIO REGPREV WITH(NOLOCK) ON CARDIP.CAID_SREGISTRO_PREVIO = REGPREV.REPE_SREGISTRO_PREVIO_ID
									LEFT JOIN PN_REGISTRO.RE_PERSONA PERSONA WITH(NOLOCK) ON CARDIP.CAID_IPERSONAID = PERSONA.PERS_IPERSONAID
									LEFT JOIN PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX_CI WITH(NOLOCK) ON CARDIP.CAID_SOFICINA_CONSULAR_EXID = OFCOEX_CI.OFCE_SOFICINACONSULAR_EXTRANJERAID
									LEFT JOIN PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX WITH(NOLOCK) ON REGPREV.REPE_SOFICINA_CONSULAR_EX_ID = OFCOEX.OFCE_SOFICINACONSULAR_EXTRANJERAID
									LEFT JOIN SC_MAESTRO.MA_CALIDAD_MIGRATORIA CALMIG WITH(NOLOCK) ON REGPREV.REPE_SCALIDAD_MIGRATORIA = CALMIG.CAMI_SCALIDAD_MIGRATORIAID
									LEFT JOIN SC_MAESTRO.MA_CALIDAD_MIGRATORIA CALMIG_CI WITH(NOLOCK) ON CARDIP.CAID_SCALIDAD_MIGRATORIAID = CALMIG_CI.CAMI_SCALIDAD_MIGRATORIAID
									LEFT JOIN SC_CARDIP.CD_ACTA_CONFORMIDAD_DETALLE ACTACON_DETALLE WITH(NOLOCK) ON CARDIP.CAID_ICARNE_IDENTIDADID = ACTACON_DETALLE.ACDE_SCARNE_IDENTIDAD_ID AND ACTACON_DETALLE.ACDE_CESTADO='A'
									LEFT JOIN SC_CARDIP.CD_ACTA_CONFORMIDAD_CABECERA ACTACON_CAB WITH(NOLOCK) ON ACTACON_DETALLE.ACDE_SACTA_CONFORMIDAD_CAB_ID = ACTACON_CAB.ACCA_SACTA_CONFORMIDAD_CABECERA_ID
									LEFT JOIN SC_CARDIP.CD_ACTA_RECEPCION_DETALLE ACTAREC_DETALLE WITH(NOLOCK) ON CARDIP.CAID_ICARNE_IDENTIDADID = ACTAREC_DETALLE.ACRD_SCARNE_IDENTIDAD_ID AND ACTAREC_DETALLE.ACRD_CESTADO='A'
									LEFT JOIN SC_CARDIP.CD_ACTA_RECEPCION_CABECERA ACTAREC_CAB WITH(NOLOCK) ON ACTAREC_DETALLE.ACRD_SACTA_RECEPCION_CAB_ID = ACTAREC_CAB.ACRE_SACTA_RECEPCION_ID
									WHERE (@P_PERIODO=0 OR CARDIP.CAID_IPERIODO=@P_PERIODO)
										AND (@P_NUMERO_IDENT=0 OR CARDIP.CAID_IIDENT_NUMERO=@P_NUMERO_IDENT)
										AND (@P_NUMERO_CARNE='' OR CARDIP.CAID_VCARNE_NUMERO=@P_NUMERO_CARNE)
										AND (@P_APELLIDO_PAT='' OR REGPREV.REPE_VPRIMER_APELLIDO=@P_APELLIDO_PAT)
										AND (@P_APELLIDO_MAT='' OR REGPREV.REPE_VSEGUNDO_APELLIDO=@P_APELLIDO_MAT)
										AND (@P_NOMBRES='' OR REGPREV.REPE_VNOMBRES=@P_NOMBRES)
										AND (@P_TIPO_ENTRADA=0 OR CARDIP.CAID_STIPO_ENTRADA=@P_TIPO_ENTRADA)
										AND (YEAR(@P_FECHA_REGISTRO_DESDE)=1900 OR (CAST(FLOOR(CAST(CARDIP.CAID_DFECHACREACION AS float)) AS DATETIME))>=@P_FECHA_REGISTRO_DESDE)
										AND (YEAR(@P_FECHA_REGISTRO_HASTA)=1900 OR (CAST(FLOOR(CAST(CARDIP.CAID_DFECHACREACION AS float)) AS DATETIME))<=@P_FECHA_REGISTRO_HASTA)
										AND (@P_CALIDAD_MIG=0 OR REGPREV.REPE_SCALIDAD_MIGRATORIA=@P_CALIDAD_MIG)
										AND (@P_OFICINA_CON_EX=0 OR REGPREV.REPE_SOFICINA_CONSULAR_EX_ID=@P_OFICINA_CON_EX)
										AND (@P_ESTADO=0 OR CARDIP.CAID_SESTADOID=@P_ESTADO)
									)

			SELECT CAST(CARDIP.CAID_IPERIODO AS varchar) + ' - ' + (RIGHT(REPLICATE('0',5) + CAST(CARDIP.CAID_IIDENT_NUMERO AS VARCHAR(5)),5)) AS IDENT,
				ISNULL(TIPOENT.PARA_VDESCRIPCION,'-') AS TIPO_ENTRADA,
				(
					CASE 
						WHEN CARDIP.CAID_VCARNE_NUMERO IS NULL
							THEN  '[ NO GENERADO ]' 
						ELSE  CARDIP.CAID_VCARNE_NUMERO
					END
				)AS CARNE_NUMERO,
				ESTADO.ESTA_VDESCRIPCIONCORTA AS ESTADO,
				ISNULL((REGPREV.REPE_VPRIMER_APELLIDO + ' ' + ISNULL(REGPREV.REPE_VSEGUNDO_APELLIDO,'') + ' ' + REGPREV.REPE_VNOMBRES),
				PERSONA.PERS_VAPELLIDOPATERNO + ' ' + ISNULL(PERSONA.PERS_VAPELLIDOMATERNO,'') + ' ' + PERSONA.PERS_VNOMBRES) AS NOMBRE_COMPLETO,
				ISNULL(OFCOEX.OFCE_VNOMBRE,OFCOEX_CI.OFCE_VNOMBRE) AS OFCO_NOMBRE,
				ISNULL(CALMIG.CAMI_VNOMBRE,ISNULL(CALMIG_CI.CAMI_VNOMBRE,'-')) AS CALIDAD_MIGRATORIA,
				ISNULL(CONVERT(VARCHAR,CARDIP.CAID_DFECHACREACION,103),'-') AS FECHA_INSCRIPCION,
				ISNULL(CONVERT(VARCHAR,CARDIP.CAID_DFECHA_EMISION,103),'-') AS FECHA_EMISION,
				ISNULL(CONVERT(VARCHAR,CARDIP.CAID_DFECHA_VENCIMIENTO,103),'-') AS FECHA_VENCIMIENTO,
				ISNULL(CONVERT(VARCHAR,REGPREV.REPE_DFECHA_CONSULARES,103),'-') AS FECHA_CON,
				ISNULL(CONVERT(VARCHAR,REGPREV.REPE_DFECHA_PRIVILEGIOS,103),'-') AS FECHA_PRI,
				CARDIP.CAID_ICARNE_IDENTIDADID AS CARDIP_ID,
				ISNULL(REGPREV.REPE_SREGISTRO_PREVIO_ID,0) AS REGPREV_ID,
				CARDIP.CAID_BFLAG_REGISTRO_COMPLETO AS FLAG_REGCOMP,
				ISNULL(CARDIP.CAID_SUSUARIO_DERIVA,0) AS REGISTRADOR_ID,
				CARDIP.CAID_BFLAG_ENTREGADO AS FLAG_ENTREGADO,
				ISNULL(ACTACON_CAB.ACCA_SACTA_CONFORMIDAD_CABECERA_ID,0) AS ACTACONCAB_ID,
				ISNULL(ACTAREC_CAB.ACRE_SACTA_RECEPCION_ID,0) AS ACTARECCAB_ID
			FROM SC_CARDIP.CD_CARNE_IDENTIDAD CARDIP WITH(NOLOCK)
			LEFT JOIN SC_MAESTRO.MA_ESTADO ESTADO WITH(NOLOCK) ON CARDIP.CAID_SESTADOID = ESTADO.ESTA_SESTADOID
			LEFT JOIN PS_SISTEMA.SI_PARAMETRO TIPOENT WITH(NOLOCK) ON CARDIP.CAID_STIPO_ENTRADA = TIPOENT.PARA_SPARAMETROID
			LEFT JOIN SC_CARDIP.CD_REGISTRO_PREVIO REGPREV WITH(NOLOCK) ON CARDIP.CAID_SREGISTRO_PREVIO = REGPREV.REPE_SREGISTRO_PREVIO_ID
			LEFT JOIN PN_REGISTRO.RE_PERSONA PERSONA WITH(NOLOCK) ON CARDIP.CAID_IPERSONAID = PERSONA.PERS_IPERSONAID
			LEFT JOIN PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX_CI WITH(NOLOCK) ON CARDIP.CAID_SOFICINA_CONSULAR_EXID = OFCOEX_CI.OFCE_SOFICINACONSULAR_EXTRANJERAID
			LEFT JOIN PS_SISTEMA.SI_OFICINACONSULAR_EXTRANJERA OFCOEX WITH(NOLOCK) ON REGPREV.REPE_SOFICINA_CONSULAR_EX_ID = OFCOEX.OFCE_SOFICINACONSULAR_EXTRANJERAID
			LEFT JOIN SC_MAESTRO.MA_CALIDAD_MIGRATORIA CALMIG WITH(NOLOCK) ON REGPREV.REPE_SCALIDAD_MIGRATORIA = CALMIG.CAMI_SCALIDAD_MIGRATORIAID
			LEFT JOIN SC_MAESTRO.MA_CALIDAD_MIGRATORIA CALMIG_CI WITH(NOLOCK) ON CARDIP.CAID_SCALIDAD_MIGRATORIAID = CALMIG_CI.CAMI_SCALIDAD_MIGRATORIAID
			LEFT JOIN SC_CARDIP.CD_ACTA_CONFORMIDAD_DETALLE ACTACON_DETALLE WITH(NOLOCK) ON CARDIP.CAID_ICARNE_IDENTIDADID = ACTACON_DETALLE.ACDE_SCARNE_IDENTIDAD_ID AND ACTACON_DETALLE.ACDE_CESTADO='A'
			LEFT JOIN SC_CARDIP.CD_ACTA_CONFORMIDAD_CABECERA ACTACON_CAB WITH(NOLOCK) ON ACTACON_DETALLE.ACDE_SACTA_CONFORMIDAD_CAB_ID = ACTACON_CAB.ACCA_SACTA_CONFORMIDAD_CABECERA_ID
			LEFT JOIN SC_CARDIP.CD_ACTA_RECEPCION_DETALLE ACTAREC_DETALLE WITH(NOLOCK) ON CARDIP.CAID_ICARNE_IDENTIDADID = ACTAREC_DETALLE.ACRD_SCARNE_IDENTIDAD_ID AND ACTAREC_DETALLE.ACRD_CESTADO='A'
			LEFT JOIN SC_CARDIP.CD_ACTA_RECEPCION_CABECERA ACTAREC_CAB WITH(NOLOCK) ON ACTAREC_DETALLE.ACRD_SACTA_RECEPCION_CAB_ID = ACTAREC_CAB.ACRE_SACTA_RECEPCION_ID
			WHERE (@P_PERIODO=0 OR CARDIP.CAID_IPERIODO=@P_PERIODO)
				AND (@P_NUMERO_IDENT=0 OR CARDIP.CAID_IIDENT_NUMERO=@P_NUMERO_IDENT)
				AND (@P_NUMERO_CARNE='' OR CARDIP.CAID_VCARNE_NUMERO=@P_NUMERO_CARNE)
				AND (@P_APELLIDO_PAT='' OR REGPREV.REPE_VPRIMER_APELLIDO=@P_APELLIDO_PAT)
				AND (@P_APELLIDO_MAT='' OR REGPREV.REPE_VSEGUNDO_APELLIDO=@P_APELLIDO_MAT)
				AND (@P_NOMBRES='' OR REGPREV.REPE_VNOMBRES=@P_NOMBRES)
				AND (@P_TIPO_ENTRADA=0 OR CARDIP.CAID_STIPO_ENTRADA=@P_TIPO_ENTRADA)
				AND (YEAR(@P_FECHA_REGISTRO_DESDE)=1900 OR (CAST(FLOOR(CAST(CARDIP.CAID_DFECHACREACION AS float)) AS DATETIME))>=@P_FECHA_REGISTRO_DESDE)
				AND (YEAR(@P_FECHA_REGISTRO_HASTA)=1900 OR (CAST(FLOOR(CAST(CARDIP.CAID_DFECHACREACION AS float)) AS DATETIME))<=@P_FECHA_REGISTRO_HASTA)
				AND (@P_CALIDAD_MIG=0 OR REGPREV.REPE_SCALIDAD_MIGRATORIA=@P_CALIDAD_MIG)
				AND (@P_OFICINA_CON_EX=0 OR REGPREV.REPE_SOFICINA_CONSULAR_EX_ID=@P_OFICINA_CON_EX)
				AND (@P_ESTADO=0 OR CARDIP.CAID_SESTADOID=@P_ESTADO)
			ORDER BY 1 DESC

			OFFSET (@P_NUM_PAG - 1) * @P_CANT_REG_PAG ROWS
				FETCH NEXT @P_CANT_REG_PAG ROWS ONLY

				SELECT	(@V_TOTAL_REG / @P_CANT_REG_PAG) AS TOTALPAG,
					(@V_TOTAL_REG % @P_CANT_REG_PAG) AS RESIDUO,
					@V_TOTAL_REG AS TOTALREGISTROS
		END TRY
		BEGIN CATCH
			SELECT ERROR_MESSAGE() AS ErrorMessage;
		END CATCH
	END


	/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_CONSULTAR_REGISTRO_EDICION]    Script Date: 24/05/2018 02:23:10 p.m. ******/
SET ANSI_NULLS ON
