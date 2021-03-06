USE [BD_SGAC]
GO

DECLARE	@return_value int,
		@acpa_iActuacionParticipanteId bigint,
		@acpa_iPersonaId bigint

SELECT	@acpa_iPersonaId = 816176

EXEC	@return_value = [PN_REGISTRO].[USP_RE_ACTUACIONPARTICIPANTE_ADICIONAR]
		@acpa_iActuacionDetalleId = 190599,
		@acpa_sTipoParticipanteId = 4813,
		@acpa_sTipoDatoId = 0,
		@acpa_sTipoVinculoId = 0,
		@acpa_sUsuarioCreacion = 657,
		@acpa_vIPCreacion = N'::1',
		@acpa_sOficinaConsularId = 30,
		@acpa_vHostName = N'DESKTOP-9GQFTGC',
		@sTipoPersonaId = 2101,
		@sTipoDocumentoId = 1,
		@vNumeroDocumento = N'25564808',
		@sNacionalidadId = 2051,
		@vNombres = N'JENNY MAGALI',
		@vPrimerApellido = N'MOGOLLON',
		@vSegundoApellido = N'CARRASCO',
		@vDireccion = N'ST 121212 MIAMI',
		@cUbigeo = N'921317',
		@ICentroPobladoId = null,
		@pers_dNacimientoFecha = null,
		@pers_sGeneroId = null,
		@pers_cNacimientoLugar = null,
		@pers_bFallecidoFlag = false,
		@pers_dFechaDefuncion = null,
		@pers_cUbigeoDefuncion = null,
		@acpa_iResidenciaId = null,
		@pers_sEstadoCivilId = null,
		@acpa_iActuacionParticipanteId = @acpa_iActuacionParticipanteId OUTPUT,
		@acpa_iPersonaId = @acpa_iPersonaId OUTPUT,
		@pers_spaisid = null

SELECT	@acpa_iActuacionParticipanteId as N'@acpa_iActuacionParticipanteId',
		@acpa_iPersonaId as N'@acpa_iPersonaId'

SELECT	'Return Value' = @return_value

GO
