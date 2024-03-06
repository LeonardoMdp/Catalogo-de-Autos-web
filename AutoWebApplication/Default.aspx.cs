using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace AutoWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            autoNegocio negocio = new autoNegocio();

            if(Session["listadeautos"] == null)
            {
                Session.Add("listadeautos", negocio.Listar());
            }

            dgwAutos.DataSource = Session["listadeautos"];
            dgwAutos.DataBind(); 
        }

        protected void dgwAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = dgwAutos.SelectedDataKey.Value.ToString();
            Response.Redirect("autoform.aspx?id=" + Id);
        }
    }
}