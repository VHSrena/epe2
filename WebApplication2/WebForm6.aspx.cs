using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        //variable estática, con static.
        static int variableEstatica = 30;

        //variable de instancia, sin static.
        int variableInstancia = 20;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            // Variable Local.
            int variableLocal = 10;

            // Mostrar los valores en los Labels
            label1.Text = "Variable Local: " + variableLocal.ToString();
            label2.Text = "Variable de Instancia: " + variableInstancia.ToString();
            label3.Text = "Variable Estática: " + variableEstatica.ToString();
        }
        protected void button6_click(object sender, EventArgs e)
        {
            // Redirige a la página Index.aspx
            Response.Redirect("WebForm3.aspx");
        }
    }
}