USE [BD_SGAC]
GO
/****** Object:  StoredProcedure [PN_REPORTES].[USP_RP_FORMATO_MINUTA_TESTIMONIO_ESCRITURA]    Script Date: 25/05/2022 10:24:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--====================================================================================================
-- Nombre: PN_REPORTES.USP_RP_FORMATO_MINUTA_TESTIMONIO_ESCRITURA
-- Descripción: OBTENER EL TEXTO DE UNA ESCRITURA PUBLICA
-- Fecha Creación: 10/04/2015
-- Fecha Modificacion: 10/04/2015
-- Descripción Parámetros:
-- Parámetro(s):
	-- @ancu_iActoNotarialId smallint	Identificador de acto notarial	

-- Autor: Sandro Guinet
-- Version: 1.0
-- Cambios Importantes:
--====================================================================================================
ALTER PROCEDURE [PN_REPORTES].[USP_RP_FORMATO_MINUTA_TESTIMONIO_ESCRITURA]
@ancu_iActoNotarialId bigint
AS
BEGIN

	SET NOCOUNT ON

	BEGIN TRY

	SELECT 
		ancu_vCuerpo
	FROM 
		PN_REGISTRO.RE_ACTONOTARIALCUERPO
	WHERE 
		ancu_iActoNotarialId = @ancu_iActoNotarialId AND 
		ancu_cEstado = 'A'

	END TRY

	BEGIN CATCH
		DECLARE @ErrorNumber INT = ERROR_NUMBER();
		DECLARE @ErrorMessage NVARCHAR(1000) = ERROR_MESSAGE() 
		RAISERROR('Error Number-%d : Error Message-%s', 16, 1, @ErrorNumber, @ErrorMessage)
			
	END CATCH

	SET NOCOUNT OFF

END
