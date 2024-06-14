using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace WebApplication1.user
{
    public partial class ChangeConfirmPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string str = "Data Source=.;Initial Catalog=DB name;Integrated Security=True;MultipleActiveResultSets=True";
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True");
            connect.Open();
            string username = label_username.Text;
            string password = textBox_Current.Text;
            string newPassword = textBox_New.Text;
            string confirmPassword = textBox_Verify.Text;
            string sqlquery = "UPDATE login SET Password=@newpass where Username=@username";
            SqlCommand cmd = new SqlCommand(sqlquery, connect);
            cmd.Parameters.AddWithValue("@newpass", textBox_Verify.Text);
            cmd.Parameters.AddWithValue("@username", label_username.Text);
            cmd.Parameters.AddWithValue("@password", textBox_Current.Text);
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
            //sqlDataReader reader = null;
            //reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    if ((textBox_New.Text == reader["newPassword"].ToString()) & (textBox_Verify.Text == (reader["confirmPassword"].ToString()))) { }
            //}
            //MessageBox.Show("Password Changed Successfully!");
            //this.Close();
        }
    }
 }
