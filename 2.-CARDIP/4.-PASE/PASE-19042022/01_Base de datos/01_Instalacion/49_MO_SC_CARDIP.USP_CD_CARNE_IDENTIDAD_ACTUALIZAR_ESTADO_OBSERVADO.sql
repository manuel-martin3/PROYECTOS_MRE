USE [BD_CARDIP]
GO
/****** Object:  StoredProcedure [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_ACTUALIZAR_ESTADO_OBSERVADO]    Script Date: 15/04/2022 20:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [SC_CARDIP].[USP_CD_CARNE_IDENTIDAD_ACTUALIZAR_ESTADO_OBSERVADO]
--================================================================================
--MODIFICADO POR		 : MARTÍN MUÑOZ SELMI
--FECHA DE MODIFICACIÓN  : 15/04/2022
--MOTIVO				 : SE AGREGA PALABRA CLAVE WITH(NOLOCK) A CONSULTAS
--================================================================================
@RELI_SREG_LINEA_ID		SMALLINT,
@P_ESTADO_ID				SMALLINT,
@P_OBSERVACION	VARCHAR(250),
@CAID_SUSUARIOMODIFICACION smallint
AS
BEGIN
	BEGIN TRY    
			BEGIN	

				DECLARE @NUEVO_DERE_SCODIGO SMALLINT, @DERE_SESTADO_ID SMALLINT

				SELECT @NUEVO_DERE_SCODIGO= (ISNULL(MAX(DERE_SCODIGO),0)+1) FROM SC_REGLINEA.RL_DETALLE_REGISTRO_LINEA WITH(NOLOCK) WHERE DERE_SREG_LINEA_ID=@RELI_SREG_LINEA_ID
				SELECT @DERE_SESTADO_ID= ESTA_SESTADOID  FROM SC_MAESTRO.MA_ESTADO AS ES WITH(NOLOCK) WHERE ES.ESTA_CESTADO='A' AND ES.ESTA_VGRUPO='REG LINEA - ESTADO' AND ESTA_VDESCRIPCIONCORTA='OBSERVADO'
				
				----ACTUALIZA LA CABECERA
				UPDATE SC_REGLINEA.RL_REGISTRO_LINEA SET RELI_SESTADO_ID=@DERE_SESTADO_ID, RELI_DFECHA_MODIFICACION=GETDATE() WHERE RELI_SREG_LINEA_ID=@RELI_SREG_LINEA_ID
				
				----INSERTA EL DETALLE
				INSERT INTO  SC_REGLINEA.RL_DETALLE_REGISTRO_LINEA(DERE_SREG_LINEA_ID, DERE_SCODIGO, DERE_SESTADO_ID, DERE_VOBSERVACION,DERE_FECHACREACION)
				VALUES (@RELI_SREG_LINEA_ID, @NUEVO_DERE_SCODIGO,@DERE_SESTADO_ID, @P_OBSERVACION,GETDATE())				
		
			END
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS ERRORMESSAGE;
	END CATCH
END

