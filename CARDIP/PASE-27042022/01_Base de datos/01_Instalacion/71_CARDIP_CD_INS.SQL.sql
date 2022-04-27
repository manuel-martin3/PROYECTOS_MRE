USE [BD_CARDIP]
GO

	DECLARE @PARA_VDESCRIPCION VARCHAR(MAX) = 'ARTISTA'
	DECLARE @CAMI_SFLAG_TITULAR_DEPENDIENTE SMALLINT
	DECLARE @CAMI_SREFERENCIA_ID SMALLINT

	SELECT @CAMI_SFLAG_TITULAR_DEPENDIENTE = PARA_SPARAMETROID FROM [PS_SISTEMA].[SI_PARAMETRO]
												WHERE PARA_VGRUPO = 'CALIDAD MIG - TITULAR DEPENDIENTE'
												AND PARA_VDESCRIPCION = 'TITULAR'
												AND PARA_CESTADO = 'A'

	SELECT @CAMI_SREFERENCIA_ID = CAMI_SCALIDAD_MIGRATORIAID FROM [SC_MAESTRO].[MA_CALIDAD_MIGRATORIA]
	WHERE CAMI_VNOMBRE = 'PRODUCCI�N ART�STICA'
	AND CAMI_CESTADO = 'A'

	IF NOT EXISTS (SELECT 1 FROM SC_MAESTRO.MA_CALIDAD_MIGRATORIA
	WHERE MA_CALIDAD_MIGRATORIA.CAMI_VNOMBRE = @PARA_VDESCRIPCION AND 
		MA_CALIDAD_MIGRATORIA.CAMI_SREFERENCIA_ID = @CAMI_SREFERENCIA_ID AND
		MA_CALIDAD_MIGRATORIA.CAMI_SFLAG_TITULAR_DEPENDIENTE=@CAMI_SFLAG_TITULAR_DEPENDIENTE AND 
		MA_CALIDAD_MIGRATORIA.CAMI_CESTADO = 'A' AND
		MA_CALIDAD_MIGRATORIA.CAMI_GENERO = 2001)
	BEGIN
		INSERT INTO[SC_MAESTRO].[MA_CALIDAD_MIGRATORIA]([CAMI_VNUMERO_ORDEN],[CAMI_SFLAG_TITULAR_DEPENDIENTE],[CAMI_SFLAG_NIVEL_CALIDAD],[CAMI_SREFERENCIA_ID],[CAMI_VNOMBRE],[CAMI_VDEFINICION],[CAMI_CESTADO],[CAMI_SUSUARIOCREACION],[CAMI_VIPCREACION],[CAMI_DFECHACREACION],[CAMI_SUSUARIOMODIFICACION],[CAMI_VIPMODIFICACION],[CAMI_DFECHAMODIFICACION],[CAMI_GENERO])
		VALUES(NULL,@CAMI_SFLAG_TITULAR_DEPENDIENTE,1,@CAMI_SREFERENCIA_ID,@PARA_VDESCRIPCION,NULL,'A',1,'0.0.0.0',GETDATE(),NULL,NULL,NULL,2001)
				
		PRINT 'PARAMETRO '+ @PARA_VDESCRIPCION +' SE AGREG� CORRECTAMENTE'

	END


GO




