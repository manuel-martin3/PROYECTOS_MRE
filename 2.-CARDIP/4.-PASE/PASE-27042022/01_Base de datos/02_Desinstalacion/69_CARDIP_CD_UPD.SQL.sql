USE [BD_CARDIP]
GO

	DECLARE @CAMI_SREFERENCIA_ID SMALLINT
	SELECT @CAMI_SREFERENCIA_ID = CAMI_SCALIDAD_MIGRATORIAID FROM [SC_MAESTRO].[MA_CALIDAD_MIGRATORIA] WITH(NOLOCK) 
									WHERE CAMI_VNOMBRE = 'PRODUCCI�N ART�STICA'
									AND CAMI_CESTADO = 'A'

	UPDATE PS_SISTEMA.SI_PARAMETRO
	SET SI_PARAMETRO.PARA_CESTADO = 'E'
	WHERE SI_PARAMETRO.PARA_VDESCRIPCION = 'EQUIPO DE PRODUCCI�N' AND 
	SI_PARAMETRO.PARA_VREFERENCIA=@CAMI_SREFERENCIA_ID AND 
	SI_PARAMETRO.PARA_CESTADO = 'A'

GO