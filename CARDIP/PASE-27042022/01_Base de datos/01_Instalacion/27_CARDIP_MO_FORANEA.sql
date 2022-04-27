USE BD_CARDIP

DECLARE @FK_TABLE VARCHAR(MAX)='FK_HISTORICO_CARNE_IDENTIDAD_CARNE_IDENTIDAD_ID'
IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS C 
	WHERE C.CONSTRAINT_NAME = @FK_TABLE
	AND C.TABLE_NAME = 'CD_CARNE_IDENTIDAD_HISTORICO'
	AND C.CONSTRAINT_SCHEMA = 'SC_CARDIP'
	)
BEGIN

	ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD_HISTORICO]  WITH CHECK ADD  CONSTRAINT [FK_HISTORICO_CARNE_IDENTIDAD_CARNE_IDENTIDAD_ID] FOREIGN KEY([CIHI_ICARNE_IDENTIDADID])
	REFERENCES [SC_CARDIP].[CD_CARNE_IDENTIDAD] ([CAID_ICARNE_IDENTIDADID])

	ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD_HISTORICO] CHECK CONSTRAINT [FK_HISTORICO_CARNE_IDENTIDAD_CARNE_IDENTIDAD_ID]
			
	PRINT 'CONSTRAINT '+@FK_TABLE+' ��AFECTADO!!'
END

GO