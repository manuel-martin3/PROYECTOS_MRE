USE BD_CARDIP

DECLARE @COLUM VARCHAR(MAX)='CIHI_ICARNE_IDENTIDADID'
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS AS C
	WHERE C.TABLE_SCHEMA = 'SC_CARDIP'
	AND C.TABLE_NAME = 'CD_CARNE_IDENTIDAD_HISTORICO'
    AND C.COLUMN_NAME = 'CIHI_ICARNE_IDENTIDADID'
	)
BEGIN
	ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD_HISTORICO]
		ALTER COLUMN [CIHI_ICARNE_IDENTIDADID] INT;
	
	PRINT 'CAMPO '+@COLUM+' ĦĦAFECTADA!!'
END

GO



