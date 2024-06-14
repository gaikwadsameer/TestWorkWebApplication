using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1.user
{
    public partial class Login : System.Web.UI.Page
    {
        string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string str = null;
        SqlCommand com;
        protected void btn_login_Click(object sender, EventArgs e)
        {
            object obj = null;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();

            Session["UserName"] = TextBox_user_name.Text;
            str = "select count(*) from login where UserName=@UserName and Password =@Password";
            com = new SqlCommand(str, con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@UserName", Session["UserName"]);
            com.Parameters.AddWithValue("@Password", TextBox_password.Text);
            obj = com.ExecuteScalar();
            if ((int)(obj) != 0)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                lb1.Text = "Invalid Username and Password";
            }
            con.Close();
        }
    }
}