USE [BD_CARDIP]
GO

ALTER TABLE [SC_CARDIP].[CD_ACTA_CONFORMIDAD_DETALLE]  WITH CHECK ADD  CONSTRAINT [FK_ACTA_CONFORMIDAD_DETALLE_CARNE_IDENTIDAD] FOREIGN KEY([ACDE_SCARNE_IDENTIDAD_ID])
REFERENCES [SC_CARDIP].[CD_CARNE_IDENTIDAD] ([CAID_ICARNE_IDENTIDADID])
GO

ALTER TABLE [SC_CARDIP].[CD_ACTA_CONFORMIDAD_DETALLE] CHECK CONSTRAINT [FK_ACTA_CONFORMIDAD_DETALLE_CARNE_IDENTIDAD]
GO
