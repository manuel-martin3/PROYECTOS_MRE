USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_CONSULTA_MENSAJE_ESTADO]    Script Date: 18/04/2022 11:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [SC_CARDIP].[USP_CD_CONSULTA_MENSAJE_ESTADO]
@CAID_ICARNE_IDENTIDADID    smallint,
@MEES_SESTADOID smallint
AS
BEGIN
	BEGIN TRY
			SELECT	me.MEES_VMENSAJE
			FROM	[SC_CARDIP].[CD_MENSAJE_ESTADO]	 me			
			WHERE	MEES_SESTADOID	=	@MEES_SESTADOID
			AND		MEES_CESTADO	=	'A'		
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS ErrorMessage;
	END CATCH
	RETURN @@IDENTITY
END



