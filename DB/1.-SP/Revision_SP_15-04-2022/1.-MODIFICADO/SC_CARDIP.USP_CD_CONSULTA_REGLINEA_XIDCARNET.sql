USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_CONSULTA_REGLINEA_XIDCARNET]    Script Date: 15/04/2022 20:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [SC_CARDIP].[USP_CD_CONSULTA_REGLINEA_XIDCARNET]
--================================================================================
--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
--FECHA DE MODIFICACIÓN  : 13/04/2022
--MOTIVO				 : SE CAMBIA TIPO DE DATO SMALLINT A INT EN 
--PARAMETROS			 : @CAID_ICARNE_IDENTIDADID
--================================================================================
@CAID_ICARNE_IDENTIDADID    INT
AS
BEGIN
	BEGIN TRY
	
			SELECT	top 1	RELI_SREG_LINEA_ID AS REGLINEA_ID
			FROM		SC_REGLINEA.RL_REGISTRO_LINEA RL (NOLOCK)
			INNER JOIN [SC_CARDIP].[CD_CARNE_IDENTIDAD] caid (NOLOCK) on caid.[CAID_ICARNE_IDENTIDADID]=rl.RELI_ICARNE_IDENTIDAD_ID
			WHERE		caid.[CAID_ICARNE_IDENTIDADID]	=	@CAID_ICARNE_IDENTIDADID
			AND			RELI_CESTADO				=	'A'		
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS ErrorMessage;
	END CATCH
	RETURN @@IDENTITY
END

