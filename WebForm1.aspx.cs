using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tab values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Data has been inserted";
            //GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tab set names='" + TextBox2.Text + "', adds='" + TextBox3.Text + "' where Id='" + TextBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Data has been Updated";
            //GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from tab where Id='" + Convert.ToInt32(TextBox1.Text).ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Data has been Deleted";
            //GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string find = "select * from tab where (Id like '%' +@Id+ '%')";
            SqlCommand cmd = new SqlCommand(find, con);
            cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = DropDownList1.SelectedValue;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Id");

            DropDownList1.DataSourceID = null;
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();

            con.Close();
            Label1.Text = "data has been selected";

        }

        
    }
}