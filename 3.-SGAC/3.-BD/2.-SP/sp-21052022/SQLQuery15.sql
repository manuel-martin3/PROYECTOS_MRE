USE [BD_SGAC]
GO
/****** Object:  UserDefinedFunction [PS_ACCESORIOS].[FN_OBTENER_FECHAACTUAL]    Script Date: 20/05/2022 18:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [PS_ACCESORIOS].[FN_OBTENER_FECHAACTUAL] (@ofco_sOficinaConsularId smallint)
RETURNS DATETIME
WITH SCHEMABINDING AS
BEGIN
	DECLARE @dFechaActual as DATETIME

	IF @ofco_sOficinaConsularId <> 0 
	BEGIN
		SELECT @dFechaActual = 
			dateadd(HOUR, (ISNULL(ofco_fDiferenciaHoraria,0) + ISNULL(ofco_sHorarioVerano,0)), GETUTCDATE())
		FROM PS_SISTEMA.SI_OFICINACONSULAR
		WHERE ofco_sOficinaConsularId = @ofco_sOficinaConsularId;
	END
	ELSE
	BEGIN
			SELECT @dFechaActual = GETUTCDATE()
	END
	RETURN @dFechaActual;
END


