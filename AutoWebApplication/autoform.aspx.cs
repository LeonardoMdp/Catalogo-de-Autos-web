using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AutoWebApplication
{
    public partial class autoform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            ddlColor.Items.Add("Rojo");
            ddlColor.Items.Add("Blanco");
            ddlColor.Items.Add("Negro");

           

            if (Request.QueryString["id"] != null)
            {

                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Auto> temporal = (List<Auto>)Session["listadeautos"];
                Auto Seleccionado = temporal.Find(x => x.id == id);

                txbId.Text = Seleccionado.id.ToString();
                txbModelo.Text = Seleccionado.Modelo;
                txbDescripcion.Text = Seleccionado.Descripcion;
                ddlColor.SelectedValue = Seleccionado.Color;
                TxbFecha.Text = Seleccionado.Fecha.ToString();
                chkUsado.Checked = Seleccionado.Usado;
                RadioButtonImportado.Checked = Seleccionado.Importado;

                btnEliminar.Visible = true;
                
            }
            else
            {
                btnEliminar.Visible = false;
                
            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Auto a = new Auto();

            a.id = int.Parse(txbId.Text);
            a.Modelo = txbModelo.Text;
            a.Descripcion = txbDescripcion.Text;
            a.Color = ddlColor.SelectedValue;
            a.Fecha = DateTime.Parse(TxbFecha.Text);
            a.Usado = chkUsado.Checked;

            if (RadioButtonImportado.Checked)
            {
                a.Importado = true;
            }
            else if ((RadioButtonNacional.Checked))
            {
                a.Importado = false;
            }

            List<Auto> temporal = (List<Auto>)Session["listadeautos"];
            temporal.Add(a);

            Response.Redirect("default.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(Request.QueryString["id"].ToString());
            List<Auto> temporal = (List<Auto>)Session["listadeautos"];
            Auto Seleccionado = temporal.Find(x => x.id == id);
            temporal.Remove(Seleccionado);



            Response.Redirect("default.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            List<Auto> temporal = (List<Auto>)Session["listadeautos"];

            Auto autoModificar = temporal.Find(x => x.id == id);

            autoModificar.Modelo = txbModelo.Text;
          

            // Guardar los cambios en la sesión
            Session["listadeautos"] = temporal;

            // Redirigir a la página principal
            Response.Redirect("default.aspx");
        }
    }
}