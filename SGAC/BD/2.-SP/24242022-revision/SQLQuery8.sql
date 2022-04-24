USE [BD_SGAC]
GO
/****** Object:  StoredProcedure [PN_REGISTRO].[USP_RE_REGISTROCIVIL_OBTENER_POR_ID]    Script Date: 24/04/2022 14:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--====================================================================================================
-- Nombre: PN_REGISTRO.USP_RE_REGISTROCIVIL_OBTENER_POR_ID
-- Descripción: CONSULTAR REGISTRO EN LA TABLA RE_REGISTROCIVIL
-- Fecha Creación:		26/12/2014
-- Fecha Modificacion:	06/03/2015 
-- Descripción Parámetros:
-- Parámetro(s):
	-- @reci_iRegistroCivilId		bigint		Id de registro civil
	-- @reci_iActuacionDetalleId	bigint		Id de detalle de actuación
-- Autor:	Margarita Díaz
-- Version: 2.0
-- Cambios Importantes:
--====================================================================================================
-- MODIFICADO POR: MIGUEL MÁRQUEZ BELTRÁN
-- FECHA: 18/10/2018
-- MOTIVO: SE ADICIONARON LOS CAMPOS: reci_cConCUI, reci_cReconocimientoAdopcion, 
--				reci_cReconstitucionReposicion, reci_iNumeroActaAnterior y reci_vTitular.
--====================================================================================================
-- MODIFICADO POR: MIGUEL MÁRQUEZ BELTRÁN
-- FECHA: 01/09/2021
-- MOTIVO: SE ADICIONA LA COLUMNA: reci_bInscripcionOficio.
--====================================================================================================

ALTER PROCEDURE [PN_REGISTRO].[USP_RE_REGISTROCIVIL_OBTENER_POR_ID]
	@reci_iRegistroCivilId    bigint = null,
	@reci_iActuacionDetalleId bigint = null
AS
BEGIN
	SET NOCOUNT ON

	BEGIN TRY	
		SELECT 
			RECI.reci_iRegistroCivilId,
			RECI.reci_iActuacionDetalleId,
			RECI.reci_sTipoActaId,
			RECI.reci_vNumeroCUI,
			RECI.reci_vNumeroActa,
			RECI.reci_dFechaRegistro,
			RECI.reci_cOficinaRegistralUbigeo,
			RECI.reci_iOficinaRegistralCentroPobladoId,
			RECI.reci_dFechaHoraOcurrenciaActo,
			RECI.reci_sOcurrenciaTipoId,
			RECI.reci_vOcurrenciaLugar,
			RECI.reci_cOcurrenciaUbigeo,
			RECI.reci_IOcurrenciaCentroPobladoId,
			RECI.reci_vNumeroExpedienteMatrimonio,
			RECI.reci_IAprobacionUsuarioId,
			RECI.reci_vIPAprobacion,
			RECI.reci_dFechaAprobacion,
			RECI.reci_bDigitalizadoFlag,
			RECI.reci_vCargoCelebrante,
			RECI.reci_vLibro,
			RECI.reci_bAnotacionFlag,
			RECI.reci_vObservaciones,
			RECI.reci_cEstado,
			RECI.reci_cConCUI,
			RECI.reci_cReconocimientoAdopcion,
			RECI.reci_cReconstitucionReposicion,
			RECI.reci_iNumeroActaAnterior,
			RECI.reci_vTitular,
			RECI.reci_bInscripcionOficio 

		FROM PN_REGISTRO.RE_REGISTROCIVIL RECI
		-- inner join  PN_REGISTRO.RE_ACTUACIONDETALLE ACDE on ACDE.acde_iActuacionDetalleId = RECI.reci_iActuacionDetalleId
		WHERE RECI.reci_iRegistroCivilId = coalesce(@reci_iRegistroCivilId, RECI.reci_iRegistroCivilId)
		AND	  RECI.reci_iActuacionDetalleId = coalesce(@reci_iActuacionDetalleId, RECI.reci_iActuacionDetalleId)
		AND	  RECI.reci_cEstado='A'


		DECLARE @COUNT INT
		SET @COUNT = ( select COUNT(acpa_iActuacionParticipanteId) from PN_REGISTRO.RE_ACTUACIONPARTICIPANTE where acpa_iActuacionDetalleId = @reci_iActuacionDetalleId and acpa_cEstado = 'A'
		AND acpa_sTipoParticipanteId IN (4812,4813,4814,4815,4816,4821,4824,4832,4833,4834,4835))

	

		SELECT
			TEMP01.iActuacionParticipanteId
			,TEMP01.iPersonaId
			,TEMP01.vApellidoPaterno
			,TEMP01.vApellidoMaterno
			,TEMP01.vNombres
			,TEMP01.sTipoParticipanteId
			,TEMP01.vTipoParticipante
			,TEMP01.sDocumentoTipoId
			,TEMP01.vDocumentoTipo
			,TEMP01.vDocumentoNumero
			,TEMP01.vDocumentoCompleto
			,TEMP01.sTipoDatoId
			,TEMP01.sTipoVinculoId
			,TEMP01.vNombreCompleto
			,TEMP01.pers_sNacionalidadId
			,TEMP01.pers_sGeneroId
			,TEMP01.pers_cNacimientoLugar
			,TEMP01.pers_dNacimientoFecha
			,TEMP01.pers_bFallecidoFlag
			,TEMP01.pers_cUbigeoDefuncion
			,TEMP01.pers_dFechaDefuncion
			,TEMP01.resi_cResidenciaUbigeo
			,TEMP01.resi_vResidenciaDireccion
			,TEMP01.pers_sEstadoCivilId
		FROM
			(
			SELECT	AP.acpa_iActuacionParticipanteId iActuacionParticipanteId, p.pers_iPersonaId iPersonaId, ISNULL(P.pers_vApellidoPaterno,'') vApellidoPaterno
			,ISNULL(P.pers_vApellidoMaterno,'') vApellidoMaterno, ISNULL(P.pers_vNombres,'') vNombres, ap.acpa_sTipoParticipanteId sTipoParticipanteId
			,pa.para_vDescripcion vTipoParticipante, pei.peid_sDocumentoTipoId sDocumentoTipoId, DI.doid_vDescripcionCorta vDocumentoTipo
			,pei.peid_vDocumentoNumero vDocumentoNumero, di.doid_vDescripcionCorta + ' - ' + pei.peid_vDocumentoNumero vDocumentoCompleto
			,AP.acpa_sTipoDatoId sTipoDatoId
			,			-- Lo adicione para civil "Frans Simon".
			AP.acpa_sTipoVinculoId sTipoVinculoId,  	-- Lo adicione para civil "Frans Simon".
			P.pers_vApellidoPaterno + ' ' + P.pers_vApellidoMaterno + ',' + P.pers_vNombres vNombreCompleto, 	-- Lo adicione para civil "Frans Simon".
			ISNULL(p.pers_sNacionalidadId,0) pers_sNacionalidadId, ISNULL(p.pers_sGeneroId,0) pers_sGeneroId,
			CASE WHEN not ap.acpa_sTipoParticipanteId in (4812,4814,4815,4816,4821,4824,4832,4833,4834,4835) then  ISNULL(p.pers_cNacimientoLugar,'')  else null end pers_cNacimientoLugar
			, pers_dNacimientoFecha,
			p.pers_bFallecidoFlag,
			p.pers_cUbigeoDefuncion,
			p.pers_dFechaDefuncion,
			p.pers_sEstadoCivilId,
			
			case when  ap.acpa_sTipoParticipanteId in (4812,4813,4814,4815,4816,4821,4824,4832,4833,4834,4835) then RESI.resi_cResidenciaUbigeo    else null  end resi_cResidenciaUbigeo,
			case when  ap.acpa_sTipoParticipanteId in (4812,4813,4814,4815,4816,4821,4824,4832,4833,4834,4835) then RESI.resi_iResidenciaId else null  end resi_iResidenciaId,
			case when  ap.acpa_sTipoParticipanteId in (4812,4813,4814,4815,4816,4821,4824,4832,4833,4834,4835) then RESI.resi_vResidenciaDireccion else null  end resi_vResidenciaDireccion

		FROM PN_REGISTRO.RE_REGISTROCIVIL RM
		INNER JOIN PN_REGISTRO.RE_ACTUACIONPARTICIPANTE AP ON RM.reci_iActuacionDetalleId = AP.acpa_iActuacionDetalleId AND acpa_cEstado = 'A'
		LEFT JOIN PS_SISTEMA.SI_PARAMETRO Pa ON AP.acpa_sTipoParticipanteId = Pa.para_sParametroId
		LEFT JOIN PN_REGISTRO.RE_PERSONA P ON AP.acpa_iPersonaId = P.pers_iPersonaId 
		LEFT JOIN PN_REGISTRO.RE_PERSONAIDENTIFICACION PEI ON P.pers_iPersonaId = PEI.peid_iPersonaId AND PEI.peid_bActivoEnRune = 1
		
		LEFT JOIN PN_REGISTRO.RE_PERSONARESIDENCIA PERE ON PERE.pere_iPersonaId = P.pers_iPersonaId
		LEFT JOIN (
					SELECT
					top (@COUNT)
					TEMP01.iPersonaId,
					TEMP01.acpa_iActuacionDetalleId,
					MAX(TEMP01.dFecha) DFECHA,
					MAX(TEMP01.resi_iResidenciaId)resi_iResidenciaId
					FROM
					(
					SELECT	
							p.pers_iPersonaId iPersonaId,
							RESI.resi_iResidenciaId,
							AP.acpa_iActuacionDetalleId,
							CASE WHEN PERE.PERE_dFechaModificacion IS NULL THEN PERE.PERE_dFechaCreacion ELSE  PERE.PERE_dFechaModificacion END dFecha	
							FROM PN_REGISTRO.RE_REGISTROCIVIL RM
							INNER JOIN PN_REGISTRO.RE_ACTUACIONPARTICIPANTE AP ON RM.reci_iActuacionDetalleId = AP.acpa_iActuacionDetalleId AND acpa_cEstado = 'A'
							INNER JOIN PN_REGISTRO.RE_ACTUACIONDETALLE ACDE ON ACDE.acde_iActuacionDetalleId = AP.acpa_iActuacionDetalleId 
 							INNER JOIN PN_REGISTRO.RE_ACTUACION ACT ON ACT.actu_iActuacionId =  ACDE.acde_iActuacionId
							LEFT JOIN PS_SISTEMA.SI_PARAMETRO Pa ON AP.acpa_sTipoParticipanteId = Pa.para_sParametroId
							LEFT JOIN PN_REGISTRO.RE_PERSONA P ON AP.acpa_iPersonaId = P.pers_iPersonaId --AND ACT.actu_iPersonaRecurrenteId = P.pers_iPersonaId
							LEFT JOIN PN_REGISTRO.RE_PERSONAIDENTIFICACION PEI ON P.pers_iPersonaId = PEI.peid_iPersonaId AND PEI.peid_bActivoEnRune = 1
							LEFT JOIN PN_REGISTRO.RE_PERSONARESIDENCIA PERE ON PERE.pere_iPersonaId = P.pers_iPersonaId
							LEFT JOIN PN_REGISTRO.RE_RESIDENCIA RESI ON RESI.resi_iResidenciaId = PERE.pere_iResidenciaId AND RESI.resi_sResidenciaTipoId = 2252 
							LEFT JOIN SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD DI ON PEI.peid_sDocumentoTipoId = DI.doid_sTipoDocumentoIdentidadId
						WHERE RM.reCi_iActuacionDetalleId = @reci_iActuacionDetalleId AND NOT RESI.resi_iResidenciaId IS NULL  
						GROUP BY 
						p.pers_iPersonaId,
						RESI.resi_iResidenciaId,
						AP.acpa_iActuacionDetalleId,
						CASE WHEN PERE.PERE_dFechaModificacion IS NULL THEN PERE.PERE_dFechaCreacion ELSE  PERE.PERE_dFechaModificacion END
						)TEMP01
						where TEMP01.iPersonaId in (select acpa_iPersonaId from PN_REGISTRO.RE_ACTUACIONPARTICIPANTE where acpa_iActuacionDetalleId = @reci_iActuacionDetalleId and acpa_cEstado = 'A'
						AND acpa_sTipoParticipanteId IN (4812,4813,4814,4815,4816,4821,4824,4832,4833,4834,4835))
						GROUP BY 
						TEMP01.iPersonaId,
						TEMP01.acpa_iActuacionDetalleId
						--TEMP01.resi_iResidenciaId
						order by 
						dFecha desc
						 
					)TEMP02 ON TEMP02.iPersonaId = P.pers_iPersonaId AND TEMP02.acpa_iActuacionDetalleId = AP.acpa_iActuacionDetalleId
					LEFT JOIN PN_REGISTRO.RE_RESIDENCIA RESI ON RESI.resi_iResidenciaId = TEMP02.resi_iResidenciaId  AND RESI.resi_sResidenciaTipoId = 2252 
		left JOIN SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD DI ON PEI.peid_sDocumentoTipoId = DI.doid_sTipoDocumentoIdentidadId
	WHERE RM.reCi_iActuacionDetalleId = @reci_iActuacionDetalleId
	)TEMP01
	WHERE TEMP01.sTipoParticipanteId NOT IN ('4817','4825','4836')
	GROUP BY
			TEMP01.iActuacionParticipanteId
			,TEMP01.iPersonaId
			,TEMP01.vApellidoPaterno
			,TEMP01.vApellidoMaterno
			,TEMP01.vNombres
			,TEMP01.sTipoParticipanteId
			,TEMP01.vTipoParticipante
			,TEMP01.sDocumentoTipoId
			,TEMP01.vDocumentoTipo
			,TEMP01.vDocumentoNumero
			,TEMP01.vDocumentoCompleto
			,TEMP01.sTipoDatoId
			,TEMP01.sTipoVinculoId
			,TEMP01.vNombreCompleto
			,TEMP01.pers_sNacionalidadId
			,TEMP01.pers_sGeneroId
			,TEMP01.pers_cNacimientoLugar
			,TEMP01.pers_dNacimientoFecha
			,TEMP01.pers_bFallecidoFlag
			,TEMP01.pers_cUbigeoDefuncion
			,TEMP01.pers_dFechaDefuncion
			,TEMP01.resi_cResidenciaUbigeo
			,TEMP01.resi_vResidenciaDireccion
			,TEMP01.pers_sEstadoCivilId

	DECLARE @viReferencaID int

		SELECT
		top 1
	 acde_iActuacionDetalleId
	,acde_iReferenciaId  
	,(SELECT 
			top 1
			reci_iRegistroCivilId 
		FROM PN_REGISTRO.RE_REGISTROCIVIL 
		WHERE reci_iActuacionDetalleId IN  (SELECT acde_iReferenciaId  
		FROM PN_REGISTRO.RE_ACTUACIONDETALLE ACDE
		WHERE ACDE.acde_iActuacionDetalleId = @reci_iActuacionDetalleId) ) reci_iRegistroCivilId_Referencia
	,RECI.reci_iRegistroCivilId
	FROM PN_REGISTRO.RE_ACTUACIONDETALLE ACDE
	 LEFT JOIN PN_REGISTRO.RE_REGISTROCIVIL RECI on ACDE.acde_iActuacionDetalleId = RECI.reci_iActuacionDetalleId
	 WHERE ACDE.acde_iActuacionDetalleId = @reci_iActuacionDetalleId 

	set @viReferencaID = (SELECT acde_iReferenciaId  FROM PN_REGISTRO.RE_ACTUACIONDETALLE WHERE acde_iActuacionDetalleId = @reci_iActuacionDetalleId)
	
	SELECT
			TEMP01.iActuacionParticipanteId
			,TEMP01.iPersonaId
			,TEMP01.vApellidoPaterno
			,TEMP01.vApellidoMaterno
			,TEMP01.vNombres
			,TEMP01.sTipoParticipanteId
			,TEMP01.vTipoParticipante
			,TEMP01.sDocumentoTipoId
			,TEMP01.vDocumentoTipo
			,TEMP01.vDocumentoNumero
			,TEMP01.vDocumentoCompleto
			,TEMP01.sTipoDatoId
			,TEMP01.sTipoVinculoId
			,TEMP01.vNombreCompleto
			,TEMP01.pers_sNacionalidadId
			,TEMP01.pers_sGeneroId
			,TEMP01.pers_cNacimientoLugar
			,TEMP01.pers_dNacimientoFecha
			,TEMP01.pers_bFallecidoFlag
			,TEMP01.pers_cUbigeoDefuncion
			,TEMP01.pers_dFechaDefuncion
			,TEMP01.resi_cResidenciaUbigeo
	FROM
		(
			SELECT AP.acpa_iActuacionParticipanteId iActuacionParticipanteId, 
			 p.pers_iPersonaId iPersonaId,
			 ISNULL(P.pers_vApellidoPaterno,'') vApellidoPaterno
			,ISNULL(P.pers_vApellidoMaterno,'') vApellidoMaterno
			,ISNULL(P.pers_vNombres,'') vNombres
			,ap.acpa_sTipoParticipanteId sTipoParticipanteId
			,pa.para_vDescripcion vTipoParticipante
			,pei.peid_sDocumentoTipoId sDocumentoTipoId
			,DI.doid_vDescripcionCorta vDocumentoTipo
			,pei.peid_vDocumentoNumero vDocumentoNumero
			,di.doid_vDescripcionCorta + ' - ' + pei.peid_vDocumentoNumero vDocumentoCompleto
			,AP.acpa_sTipoDatoId sTipoDatoId
			,			-- Lo adicione para civil "Frans Simon".
			AP.acpa_sTipoVinculoId sTipoVinculoId,  	-- Lo adicione para civil "Frans Simon".
			P.pers_vApellidoPaterno + ' ' + P.pers_vApellidoMaterno + ',' + P.pers_vNombres vNombreCompleto, 	-- Lo adicione para civil "Frans Simon".
			ISNULL(p.pers_sNacionalidadId,0) pers_sNacionalidadId, ISNULL(p.pers_sGeneroId,0) pers_sGeneroId,
			CASE WHEN not ap.acpa_sTipoParticipanteId in (4812,4814,4815,4816,4821,4824,4832,4833,4834,4835) then  ISNULL(p.pers_cNacimientoLugar,'')  else null end pers_cNacimientoLugar
			, pers_dNacimientoFecha,
			p.pers_bFallecidoFlag,
			p.pers_cUbigeoDefuncion,
			p.pers_dFechaDefuncion,
		 
			case when  ap.acpa_sTipoParticipanteId in (4812,4814,4815,4816,4821,4824,4832,4833,4834,4835) then RESI.resi_cResidenciaUbigeo    else null  end resi_cResidenciaUbigeo,
			case when  ap.acpa_sTipoParticipanteId in (4812,4814,4815,4816,4821,4824,4832,4833,4834,4835) then RESI.resi_iResidenciaId else null  end resi_iResidenciaId
	FROM PN_REGISTRO.RE_REGISTROCIVIL RM
		INNER JOIN PN_REGISTRO.RE_ACTUACIONPARTICIPANTE AP ON RM.reci_iActuacionDetalleId = AP.acpa_iActuacionDetalleId AND acpa_cEstado = 'A'
		LEFT JOIN PS_SISTEMA.SI_PARAMETRO Pa ON AP.acpa_sTipoParticipanteId = Pa.para_sParametroId
		LEFT JOIN PN_REGISTRO.RE_PERSONA P ON AP.acpa_iPersonaId = P.pers_iPersonaId 
		LEFT JOIN PN_REGISTRO.RE_PERSONAIDENTIFICACION PEI ON P.pers_iPersonaId = PEI.peid_iPersonaId AND PEI.peid_bActivoEnRune = 1
		
		LEFT JOIN PN_REGISTRO.RE_PERSONARESIDENCIA PERE ON PERE.pere_iPersonaId = P.pers_iPersonaId
		LEFT JOIN (
					SELECT
					top 1
					TEMP01.iPersonaId,
					TEMP01.acpa_iActuacionDetalleId,
					MAX(TEMP01.dFecha) DFECHA,
					TEMP01.resi_iResidenciaId
					FROM
					(
					SELECT	
							p.pers_iPersonaId iPersonaId,
							RESI.resi_iResidenciaId,
							AP.acpa_iActuacionDetalleId,
							CASE WHEN PERE.PERE_dFechaModificacion IS NULL THEN PERE.PERE_dFechaCreacion ELSE  PERE.PERE_dFechaModificacion END dFecha	
							FROM PN_REGISTRO.RE_REGISTROCIVIL RM
							INNER JOIN PN_REGISTRO.RE_ACTUACIONPARTICIPANTE AP ON RM.reci_iActuacionDetalleId = AP.acpa_iActuacionDetalleId AND acpa_cEstado = 'A'
							INNER JOIN PN_REGISTRO.RE_ACTUACIONDETALLE ACDE ON ACDE.acde_iActuacionDetalleId = AP.acpa_iActuacionDetalleId 
 							INNER JOIN PN_REGISTRO.RE_ACTUACION ACT ON ACT.actu_iActuacionId =  ACDE.acde_iActuacionId
							LEFT JOIN PS_SISTEMA.SI_PARAMETRO Pa ON AP.acpa_sTipoParticipanteId = Pa.para_sParametroId
							LEFT JOIN PN_REGISTRO.RE_PERSONA P ON AP.acpa_iPersonaId = P.pers_iPersonaId AND ACT.actu_iPersonaRecurrenteId = P.pers_iPersonaId
							LEFT JOIN PN_REGISTRO.RE_PERSONAIDENTIFICACION PEI ON P.pers_iPersonaId = PEI.peid_iPersonaId AND PEI.peid_bActivoEnRune = 1
							LEFT JOIN PN_REGISTRO.RE_PERSONARESIDENCIA PERE ON PERE.pere_iPersonaId = P.pers_iPersonaId
							LEFT JOIN PN_REGISTRO.RE_RESIDENCIA RESI ON RESI.resi_iResidenciaId = PERE.pere_iResidenciaId AND RESI.resi_sResidenciaTipoId = 2252 
							INNER JOIN SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD DI ON PEI.peid_sDocumentoTipoId = DI.doid_sTipoDocumentoIdentidadId
						WHERE RM.reCi_iActuacionDetalleId = @viReferencaID AND NOT RESI.resi_iResidenciaId IS NULL  
						GROUP BY 
						p.pers_iPersonaId,
						RESI.resi_iResidenciaId,
						AP.acpa_iActuacionDetalleId,
						CASE WHEN PERE.PERE_dFechaModificacion IS NULL THEN PERE.PERE_dFechaCreacion ELSE  PERE.PERE_dFechaModificacion END
						)TEMP01
						GROUP BY 
						TEMP01.iPersonaId,
						TEMP01.acpa_iActuacionDetalleId,
						TEMP01.resi_iResidenciaId
						order by 
						dFecha desc
						 
					)TEMP02 ON TEMP02.iPersonaId = P.pers_iPersonaId AND TEMP02.acpa_iActuacionDetalleId = AP.acpa_iActuacionDetalleId
					LEFT JOIN PN_REGISTRO.RE_RESIDENCIA RESI ON RESI.resi_iResidenciaId = TEMP02.resi_iResidenciaId  AND RESI.resi_sResidenciaTipoId = 2252 
		left JOIN SC_MAESTRO.MA_DOCUMENTO_IDENTIDAD DI ON PEI.peid_sDocumentoTipoId = DI.doid_sTipoDocumentoIdentidadId
	WHERE RM.reCi_iActuacionDetalleId = @viReferencaID
	)TEMP01
	GROUP BY
			TEMP01.iActuacionParticipanteId
			,TEMP01.iPersonaId
			,TEMP01.vApellidoPaterno
			,TEMP01.vApellidoMaterno
			,TEMP01.vNombres
			,TEMP01.sTipoParticipanteId
			,TEMP01.vTipoParticipante
			,TEMP01.sDocumentoTipoId
			,TEMP01.vDocumentoTipo
			,TEMP01.vDocumentoNumero
			,TEMP01.vDocumentoCompleto
			,TEMP01.sTipoDatoId
			,TEMP01.sTipoVinculoId
			,TEMP01.vNombreCompleto
			,TEMP01.pers_sNacionalidadId
			,TEMP01.pers_sGeneroId
			,TEMP01.pers_cNacimientoLugar
			,TEMP01.pers_dNacimientoFecha
			,TEMP01.pers_bFallecidoFlag
			,TEMP01.pers_cUbigeoDefuncion
			,TEMP01.pers_dFechaDefuncion
			,TEMP01.resi_cResidenciaUbigeo
	END TRY

	BEGIN CATCH
		DECLARE @ErrorNumber INT = ERROR_NUMBER();
		DECLARE @ErrorMessage NVARCHAR(1000) = ERROR_MESSAGE() 
		RAISERROR('Error Number-%d : Error Message-%s', 16, 1, @ErrorNumber, @ErrorMessage)		
	END CATCH

	SET NOCOUNT OFF
END

