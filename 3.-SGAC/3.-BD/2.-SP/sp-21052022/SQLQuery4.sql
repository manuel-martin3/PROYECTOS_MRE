/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [ancu_iActoNotarialCuerpoId]
      ,[ancu_iActoNotarialId]
      ,[ancu_vCuerpo]
      ,[ancu_vTextoCentral]
      ,[ancu_vTextoAdicional]
      ,[ancu_vFirmaIlegible]
      ,[ancu_bFlagExtraprotocolarCuerpo]
      ,[ancu_cEstado]
      ,[ancu_sUsuarioCreacion]
      ,[ancu_vIPCreacion]
      ,[ancu_dFechaCreacion]
      ,[ancu_sUsuarioModificacion]
      ,[ancu_vIPModificacion]
      ,[ancu_dFechaModificacion]
      ,[ancu_vTextoNormativo]
      ,[ancu_vDL1049Articulo55C]
  FROM [BD_SGAC].[PN_REGISTRO].[RE_ACTONOTARIALCUERPO]
 --WHERE  [ancu_vCuerpo] LIKE '%CONTRATOS Y PLENO CONOCIMIENTO DEL ACTO JURIDICO%'


 --8001






