USE [BD_SGAC]
GO
/****** Object:  StoredProcedure [PS_SISTEMA].[USP_SI_OFICINACONSULAR_CONSULTAR_CARGA_INICIAL_MRE]    Script Date: 05/05/2022 14:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ===================================================================================
--OBJETO			: PS_SISTEMA.USP_SI_OFICINACONSULAR_CONSULTAR_CARGA_INICIAL_MRE
--SISTEMA			: SISTEMA DE GESTIÓN DE AUTOADHESIVOS CONSULARES
--OBJETIVO			: Se obtiene las Oficinas Consulares para la carga inicial 
--CREADO			: MIGUEL MÁRQUEZ BELTRÁN
--FECHA     		: 07/11/2019
-- ===================================================================================
--Fecha:  17/11/2020
--Autor:  Pipa
--Motivo: se adiciona el filtro and o.ofco_vNombre not like '%ODE %' para no mostrar las ODES 
--        en el combo del form: ESTADO BANCARIO / LISTADO OFICINA CONSULAR   
-- ===================================================================================
ALTER PROCEDURE [PS_SISTEMA].[USP_SI_OFICINACONSULAR_CONSULTAR_CARGA_INICIAL_MRE]

AS
BEGIN

	SET NOCOUNT ON;

	BEGIN TRY

	-- Listado de Oficinas Consulares
	SELECT	
		o.ofco_sOficinaConsularId,ISNULL(o.ofco_vCodigo,'000') ofco_vCodigo,
		ISNULL(u.ubge_vDistrito,'') + ' - ' + ISNULL(o.ofco_vNombre, '') ofco_vNombre,			
		ISNULL(o.ofco_sReferenciaId,0) ofco_iReferenciaPadreId,
		ISNULL(o.ofco_bJefaturaFlag,0) ofco_iJefaturaFlag,ISNULL(o.ofco_bRemesaLimaFlag,0) ofco_IRemesaLimaFlag,substring(ofco_cUbigeoCodigo,1,2) as ofco_cUbigeoCodigo,
		substring(ofco_cUbigeoCodigo,3,2) as ofco_cUbigeoCodigoPais,
		ISNULL(u.ubge_vProvincia,'') AS vPaisNombre,
		substring(ofco_cUbigeoCodigo,5,2) as ofco_cUbigeoCodigoCiudad,
		p.para_vDescripcion as Categoria,o.ofco_sOficinaDependeDe
	FROM 
		PS_SISTEMA.SI_OFICINACONSULAR o	(NoLock)
		LEFT JOIN PS_SISTEMA.SI_UBICACIONGEOGRAFICA u (NoLock) ON o.ofco_cUbigeoCodigo = u.ubge_cCodigo	
		LEFT JOIN PS_SISTEMA.SI_PARAMETRO p (NoLock) ON o.ofco_sCategoriaId = p.para_sParametroId AND p.para_vGrupo= 'CONFIGURACIÓN-CATEGORÍA OFICINA CONSULAR'
	WHERE 
		o.ofco_cEstado = 'A' 
		AND ISNULL(ofco_sReferenciaId,0) <> 0
		AND O.OFCO_VNOMBRE NOT LIKE 'ODE %'
	ORDER BY
		3 ASC;


END TRY
	BEGIN CATCH
		DECLARE @ErrorNumber INT = ERROR_NUMBER();
		DECLARE @ErrorMessage NVARCHAR(1000) = ERROR_MESSAGE() 
		RAISERROR('Error Number-%d : Error Message-%s', 16, 1, @ErrorNumber, @ErrorMessage)					
	END CATCH

	SET NOCOUNT OFF;

END

