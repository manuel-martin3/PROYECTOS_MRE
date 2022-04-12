USE BD_CARDIP

DECLARE @COLUM VARCHAR(MAX)='RELI_ICARNE_IDENTIDAD_ID'
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS AS C
	WHERE C.TABLE_SCHEMA = 'SC_REGLINEA'
	AND C.TABLE_NAME = 'RL_REGISTRO_LINEA'
    AND C.COLUMN_NAME = @COLUM
	)
BEGIN
	ALTER TABLE [SC_REGLINEA].[RL_REGISTRO_LINEA]
		ALTER COLUMN [RELI_ICARNE_IDENTIDAD_ID] INT;
	
	PRINT 'CAMPO '+@COLUM+' ĦĦAFECTADA!!'
END

GO



