USE BD_CARDIP

DECLARE @FK_TABLE VARCHAR(MAX)='FK_MOVIMIENTO_CARNE_IDENTIDAD_CARNE_IDENTIDAD_ID'
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS C 
	WHERE C.CONSTRAINT_NAME = @FK_TABLE
	AND C.TABLE_NAME = 'CD_MOVIMIENTO_CARNE_IDENTIDAD'
	AND C.CONSTRAINT_SCHEMA = 'SC_CARDIP'
	)
BEGIN
	ALTER TABLE [SC_CARDIP].[CD_MOVIMIENTO_CARNE_IDENTIDAD]
		DROP CONSTRAINT [FK_MOVIMIENTO_CARNE_IDENTIDAD_CARNE_IDENTIDAD_ID];
	
	PRINT 'CONSTRAINT '+@FK_TABLE+' ĦĦAFECTADO!!'
END

GO



