using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEmpleadosCrut_2_.App
{
    public partial class Listar : System.Web.UI.Page
    {

        GestionDatos datos = new GestionDatos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //en una lista invocamos el objeto para listar todos los empleados 
                List<Empleado> listaEmpleado = datos.LeerTodos();
                // Volcamos la gv
                gvDatos.DataSource = listaEmpleado;
                gvDatos.DataBind();
            }
        }

        protected void tnListar_Click(object sender, EventArgs e)
        {
            //en una lista invocamos el objeto para listar todos los empleados 
            List<Empleado> listaEmpleado = datos.LeerTodos();
            // Volcamos la gv
            gvDatos.DataSource = listaEmpleado;
            gvDatos.DataBind();
        }

        protected void gvDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDatos.PageIndex = e.NewPageIndex;
            List<Empleado> listaEmpleado = datos.LeerTodos();
            gvDatos.DataSource = listaEmpleado;
            gvDatos.DataBind();
        }

        protected void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            if (datos.ExisteEmpleado(inCodigoBuscar.Text))
            {
                Response.Redirect("Formulario.aspx?id=" + inCodigoBuscar.Text);
            }
            else
            {
                LabelBuscar.Text = "No existe codigo en la base de datos";
            }

        }

        protected void gvDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "select")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                string valor = Convert.ToString(gvDatos.DataKeys[indice].Value);
                //Response.Write("Valor de fila" + indice);
                //Response.Write("Valor Celda" + valor);
                Response.Redirect("Formulario.aspx?id=" + valor);

            }
        }
    }
}