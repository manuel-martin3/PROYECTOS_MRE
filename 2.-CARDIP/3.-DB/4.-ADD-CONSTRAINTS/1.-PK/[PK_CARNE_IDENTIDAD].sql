USE [BD_CARDIP]
GO

/****** Object:  Index [PK_CARNE_IDENTIDAD]    Script Date: 08/04/2022 9:04:06 ******/
ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD] ADD  CONSTRAINT [PK_CARNE_IDENTIDAD] PRIMARY KEY CLUSTERED 
(
	[CAID_ICARNE_IDENTIDADID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO


