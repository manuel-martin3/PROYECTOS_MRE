USE BD_CARDIP

DECLARE @FK_TABLE VARCHAR(MAX)='FK_CARNE_IDENTIDAD_TIT_DEP_CARNE_IDENTIDAD_DEP'
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS C 
	WHERE C.CONSTRAINT_NAME = @FK_TABLE
	AND C.TABLE_NAME = 'CD_CARNE_IDENTIDAD_RELACION_DEPENDENCIA'
	AND C.CONSTRAINT_SCHEMA = 'SC_CARDIP'
	)
BEGIN
	ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD_RELACION_DEPENDENCIA]
		DROP CONSTRAINT [FK_CARNE_IDENTIDAD_TIT_DEP_CARNE_IDENTIDAD_DEP];
	
	PRINT 'CONSTRAINT '+@FK_TABLE+' ĦĦAFECTADO!!'
END

GO



