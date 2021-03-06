USE BD_CARDIP

DECLARE @FK_TABLE VARCHAR(MAX)='FK_MOVIMIENTO_CARNE_IDENTIDAD_CARNE_IDENTIDAD_ID'
IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS C 
	WHERE C.CONSTRAINT_NAME = @FK_TABLE
	AND C.TABLE_NAME = 'CD_MOVIMIENTO_CARNE_IDENTIDAD'
	AND C.CONSTRAINT_SCHEMA = 'SC_CARDIP'
	)
BEGIN

	ALTER TABLE [SC_CARDIP].[CD_MOVIMIENTO_CARNE_IDENTIDAD]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTO_CARNE_IDENTIDAD_CARNE_IDENTIDAD_ID] FOREIGN KEY([MOCI_ICARNE_IDENTIDADID])
	REFERENCES [SC_CARDIP].[CD_CARNE_IDENTIDAD] ([CAID_ICARNE_IDENTIDADID])

	ALTER TABLE [SC_CARDIP].[CD_MOVIMIENTO_CARNE_IDENTIDAD] CHECK CONSTRAINT [FK_MOVIMIENTO_CARNE_IDENTIDAD_CARNE_IDENTIDAD_ID]
			
	PRINT 'CONSTRAINT '+@FK_TABLE+' ĦĦAFECTADO!!'
END

GO
