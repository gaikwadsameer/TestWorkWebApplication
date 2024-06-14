using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class insert_checkbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string Dropdownvalue = chkRelocate.Checked ? "yes" : "no";
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (Degree,Gender) VALUES (@Degree,@Gender)", con);
            cmd.Parameters.AddWithValue("@Degree", name);
            cmd.Parameters.AddWithValue("@Gender", Dropdownvalue);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           
        }
    }
}