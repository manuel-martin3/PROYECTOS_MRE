USE [BD_CARDIP]
GO

ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD_SOLICITUD]  WITH CHECK ADD  CONSTRAINT [FK_CARNE_IDENTIDAD_SOLICITUD_CARNE_IDENTIDAD] FOREIGN KEY([CAIS_SCARNE_IDENTIDAD_ID])
REFERENCES [SC_CARDIP].[CD_CARNE_IDENTIDAD] ([CAID_ICARNE_IDENTIDADID])
GO

ALTER TABLE [SC_CARDIP].[CD_CARNE_IDENTIDAD_SOLICITUD] CHECK CONSTRAINT [FK_CARNE_IDENTIDAD_SOLICITUD_CARNE_IDENTIDAD]
GO
