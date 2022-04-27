USE BD_CARDIP

DECLARE @COLUM VARCHAR(MAX)='CATD_SCARNE_IDENTIDAD_TIT_ID'
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS AS C
	WHERE C.TABLE_SCHEMA = 'SC_CARDIP'
	AND C.TABLE_NAME = 'CD_CARNE_IDENTIDAD_RELACION_DEPENDENCIA'
    AND C.COLUMN_NAME = @COLUM
	)
BEGIN
	ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD_RELACION_DEPENDENCIA]
		ALTER COLUMN [CATD_SCARNE_IDENTIDAD_TIT_ID] INT;
	
	PRINT 'CAMPO '+@COLUM+' ĦĦAFECTADA!!'
END

GO



