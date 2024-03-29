﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGAC.Accesorios;
using SGAC.Registro.Actuacion.BL;
using SGAC.WebApp.Accesorios;

namespace SGAC.WebApp.Accesorios.SharedControls
{
    public partial class ctrlReimprimirbtn : System.Web.UI.UserControl
    {
        public delegate void OnButtonReimprimirClick();
        public event OnButtonReimprimirClick btnReimprimirHandler;
        
        public bool Activar
        {
            set { btnReimprimir.Enabled = value; }
            get { return btnReimprimir.Enabled; }
        }

        public string SeImprime
        {
            set {hSeImprime.Value = value; }
            get { return hSeImprime.Value; }
        }

        public string GUID
        {
            set { HFGUID.Value = value; }
            get { return HFGUID.Value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnReimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 iActuacionInsumoDetalleId = Convert.ToInt64(HttpContext.Current.Session[Constantes.CONST_ACTUACION_INSUMO_DETALLE_ID].ToString());
                ActuacionMantenimientoBL objAct = new ActuacionMantenimientoBL();
                String Msj = String.Empty;

                Int16 sOficinaConsularId = Convert.ToInt16(HttpContext.Current.Session[Constantes.CONST_SESION_OFICINACONSULAR_ID]);
                Int16 sUsuarioId = Convert.ToInt16(HttpContext.Current.Session[Constantes.CONST_SESION_USUARIO_ID]);
                objAct.USP_RE_ACTUACIONINSUMODETALLE_ACTUALIZAR_IMPRESION(iActuacionInsumoDetalleId, false, sUsuarioId, sOficinaConsularId, ref Msj);
                hSeImprime.Value = "OK";

                if (btnReimprimirHandler != null)
                {
                    btnReimprimirHandler();
                }
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("The operation is not valid for the state") || ex.ToString().Contains("La operación no es válida para el estado"))
                {
                    ScriptManager.RegisterStartupScript(Page, typeof(Page), "alerta", "HTTP 404 - intentelo de nuevo", true);
                }
                else
                {
                    Session["_LastException"] = ex;
                    Response.Redirect("../PageError/GenericErrorPage.aspx");
                }
            }
        }
    }
}