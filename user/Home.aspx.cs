using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.user
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb1.Text = "WELLCOME :: " + Session["UserName"];
        }

        protected void lnk_changepassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("Changepassword.aspx");
        }
    }
}