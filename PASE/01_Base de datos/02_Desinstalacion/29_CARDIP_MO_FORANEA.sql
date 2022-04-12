USE BD_CARDIP

DECLARE @FK_TABLE VARCHAR(MAX)='FK_REGISTRO_LINEA_CARNE_IDENTIDAD'
IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS C 
	WHERE C.CONSTRAINT_NAME = @FK_TABLE
	AND C.TABLE_NAME = 'RL_REGISTRO_LINEA'
	AND C.CONSTRAINT_SCHEMA = 'SC_REGLINEA'
	)
BEGIN

	ALTER TABLE [SC_REGLINEA].[RL_REGISTRO_LINEA]  WITH CHECK ADD  CONSTRAINT [FK_REGISTRO_LINEA_CARNE_IDENTIDAD] FOREIGN KEY([RELI_ICARNE_IDENTIDAD_ID])
	REFERENCES [SC_CARDIP].[CD_CARNE_IDENTIDAD] ([CAID_ICARNE_IDENTIDADID])

	ALTER TABLE [SC_REGLINEA].[RL_REGISTRO_LINEA] CHECK CONSTRAINT [FK_REGISTRO_LINEA_CARNE_IDENTIDAD]
			
	PRINT 'CONSTRAINT '+@FK_TABLE+' ĦĦAFECTADO!!'
END

GO
