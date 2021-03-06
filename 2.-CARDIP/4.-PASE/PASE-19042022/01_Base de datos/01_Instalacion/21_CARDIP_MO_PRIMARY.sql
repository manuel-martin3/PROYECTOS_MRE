USE BD_CARDIP

DECLARE @PK_TABLE VARCHAR(MAX)='PK_CARNE_IDENTIDAD'
IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS C 
	WHERE C.CONSTRAINT_NAME = @PK_TABLE
	AND C.TABLE_NAME = 'CD_CARNE_IDENTIDAD'
	AND C.CONSTRAINT_SCHEMA = 'SC_CARDIP'
	)
BEGIN

	ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD] ADD  CONSTRAINT [PK_CARNE_IDENTIDAD] PRIMARY KEY CLUSTERED 
	(
		[CAID_ICARNE_IDENTIDADID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
			
	PRINT 'CONSTRAINT '+@PK_TABLE+' ĦĦAFECTADO!!'
END

GO
