USE [BD_SGAC]
GO

DECLARE	@return_value int

EXEC	@return_value = [PN_REGISTRO].[USP_RE_ACTONOTARIALPROTOCOLAR_OBTENER_PARA_CUERPO]
		@acno_iActoNotarialId = 20678,
		@acno_sOficinaConsularId = null

SELECT	'Return Value' = @return_value

GO
