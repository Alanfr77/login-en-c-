using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_authentication
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userAuth"] != null)
            {
                string userAuth = Session["userAuth"].ToString();
                Label1.Text = "Welcome" + " " + userAuth;
            }
            else
            {
                Response.Redirect("login_authentication.aspx");
            }
        }

        protected void closeSessionBTN_Click(object sender, EventArgs e)
        {
            Session.Remove("userAuth");
            Response.Redirect("login_authentication.aspx");
        }
    }
}