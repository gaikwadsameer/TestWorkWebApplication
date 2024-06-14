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
    public partial class Changepassword : System.Web.UI.Page
    {
        string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string str = null;
        SqlCommand com;
        byte up;
        protected void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            str = "select * from login ";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                if (txt_cpassword.Text == reader["Password"].ToString())
                {
                    up = 1;
                }
            }
            reader.Close();
            con.Close();
            if (up == 1)
            {
                con.Open();
                str = "update login set Password=@Password where UserName='" + Session["UserName"].ToString() + "'";
                com = new SqlCommand(str, con);
                com.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
                com.Parameters["@Password"].Value = txt_npassword.Text;
                com.ExecuteNonQuery();
                con.Close();
                lbl_msg.Text = "Password changed Successfully";
            }
            else
            {
                lbl_msg.Text = "Please enter correct Current password";
            }
        }
    }
}