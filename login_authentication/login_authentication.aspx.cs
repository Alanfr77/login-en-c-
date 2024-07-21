using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace login_authentication
{
    public partial class login_authentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string patron = "authentication";
        protected void AuthenticationBTN_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SP_validationUser", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 50). Value = TextBox1.Text;
            cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 50). Value = TextBox2.Text;
            cmd.Parameters.Add("@patron", SqlDbType.VarChar, 50).Value = patron;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                // Creamos una sesion de usuario
                Session["userAuth"] = TextBox1.Text;
                Response.Redirect("index.aspx");
            }
            else
            {
                Label1.Text = "Error authentication";
            }
            cmd.Connection.Close();
        }
    }
}