USE [BD_SGAC]
GO

DECLARE	@return_value int

EXEC	@return_value = [PN_REGISTRO].[USP_RE_REGISTROCIVIL_OBTENER_PARTICIPANTES]
		@reci_iActuacionDetalleId = 190599

SELECT	'Return Value' = @return_value

GO
