USE [BD_CARDIP]
GO

	DECLARE @PARA_VDESCRIPCION VARCHAR(MAX) = 'ARTISTA'

	IF NOT EXISTS (SELECT 1 FROM SC_MAESTRO.MA_CALIDAD_MIGRATORIA
	WHERE MA_CALIDAD_MIGRATORIA.CAMI_VNOMBRE = @PARA_VDESCRIPCION AND 
		MA_CALIDAD_MIGRATORIA.CAMI_SREFERENCIA_ID = 358 AND
		MA_CALIDAD_MIGRATORIA.CAMI_SFLAG_TITULAR_DEPENDIENTE=11209 AND 
		MA_CALIDAD_MIGRATORIA.CAMI_CESTADO = 'A' AND
		MA_CALIDAD_MIGRATORIA.CAMI_GENERO = 2002)
	BEGIN
		INSERT INTO[SC_MAESTRO].[MA_CALIDAD_MIGRATORIA]([CAMI_VNUMERO_ORDEN],[CAMI_SFLAG_TITULAR_DEPENDIENTE],[CAMI_SFLAG_NIVEL_CALIDAD],[CAMI_SREFERENCIA_ID],[CAMI_VNOMBRE],[CAMI_VDEFINICION],[CAMI_CESTADO],[CAMI_SUSUARIOCREACION],[CAMI_VIPCREACION],[CAMI_DFECHACREACION],[CAMI_SUSUARIOMODIFICACION],[CAMI_VIPMODIFICACION],[CAMI_DFECHAMODIFICACION],[CAMI_GENERO])
		VALUES(NULL,11209,1,358,@PARA_VDESCRIPCION,NULL,'A',1,'0.0.0.0',GETDATE(),NULL,NULL,NULL,2002)
				
		PRINT 'PARAMETRO '+ @PARA_VDESCRIPCION +' SE AGREG� CORRECTAMENTE'

	END


GO



