using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_15
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = "Welcome to Optimus " + Session["UserName"];

            if (Session["UserName"] == null)
            {
                btnLogout.Visible = false;              //Hide the logout & menu at login
                Menu1.Visible = false;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
            
            
        }
    }
}