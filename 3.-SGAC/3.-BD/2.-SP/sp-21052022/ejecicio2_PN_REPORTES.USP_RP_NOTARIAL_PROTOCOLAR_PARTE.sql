USE [BD_SGAC]
GO

DECLARE	@return_value int

EXEC	@return_value = [PN_REPORTES].[USP_RP_NOTARIAL_PROTOCOLAR_PARTE]
		@acno_iActoNotarialId = 122727,
		@acno_sOficinaConsularId = 30,
		@acno_sNumeroParte = 1,
		@acno_vNumeroOficio = N'1009/22'

SELECT	'Return Value' = @return_value

GO
