using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaDatos.clases;

namespace WebFerreteria
{
    public partial class Principal : System.Web.UI.Page
    {
        GestionBD objBD;
     
        //--BTN REGISTRAR--//
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            objBD = new GestionBD();
            Herramienta objherram = new Herramienta();
            objherram.idProducto = Convert.ToInt32(txtidProducto.Text);
            objherram.nombre = txtNomHerram.Text;
            objherram.costoUnit = Convert.ToInt32(txtCostoUnit.Text);
            objherram.marca = txtMarca.Text;
            objherram.tipoHerramienta = cmbTipoHerramienta.SelectedValue;

            bool resultado = objBD.registrarHerramie(objherram);

            if (resultado)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scr1", "Swal.fire('Registro con exito')", true);
                return;
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scr1", "alert('No se logro registrar')", true);

        }

        //--BTN MODIFICAR--//
        protected void btnModificar_Click(object sender, EventArgs e)
        {

            objBD = new GestionBD();
            Herramienta objherram = new Herramienta();
            objherram.idProducto = Convert.ToInt32(txtidProducto.Text);
            objherram.nombre = txtNomHerram.Text;
            objherram.costoUnit = Convert.ToInt32(txtCostoUnit.Text);
            objherram.marca = txtMarca.Text;
            objherram.tipoHerramienta = cmbTipoHerramienta.SelectedValue;

            bool resultado = objBD.ModificararHerramie(objherram);

            if (resultado)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scr1", "Swal.fire('Modifico con exito')", true);
                return;
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scr1", "alert('Error al modificar')", true);

        }

        //--BTN ELIMINAR--//
        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            objBD = new GestionBD();
            Herramienta objherram = new Herramienta();
            objherram.idProducto = Convert.ToInt32(txtidProducto.Text);
            
            bool resultado = objBD.EliminarHerramie(objherram);

            if (resultado)
            {
                //En la pagina web mostrar una alerta informando al usuario de algo.
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scr1", "Swal.fire('Eliminado con exito')", true);
                return;
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scr1", "alert('Error al Eliminar')", true);
        }
    }
}