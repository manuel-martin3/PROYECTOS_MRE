USE [BD_CARDIP]
GO


	UPDATE SC_MAESTRO.MA_CALIDAD_MIGRATORIA	
	SET MA_CALIDAD_MIGRATORIA.CAMI_CESTADO = 'E'
	WHERE MA_CALIDAD_MIGRATORIA.CAMI_VNOMBRE = 'T�CNICO' AND 
	MA_CALIDAD_MIGRATORIA.CAMI_SREFERENCIA_ID = 358 AND
	MA_CALIDAD_MIGRATORIA.CAMI_SFLAG_TITULAR_DEPENDIENTE=11209 AND 
	MA_CALIDAD_MIGRATORIA.CAMI_CESTADO = 'A' AND
	MA_CALIDAD_MIGRATORIA.CAMI_GENERO = 2001


GO