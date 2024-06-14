using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;

namespace WebApplication1
{
    public partial class email_insert_OR_update : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
            
            TextBox TextBox1 = (TextBox)FindControl("TextBox1");
            TextBox TextBox2 = (TextBox)FindControl("TextBox2");
            DropDownList DropDownList1 = (DropDownList)FindControl("DropDownList1");
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Table_1 where name='" + this.TextBox1.Text.ToString() + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string sql1 = "update Table_1 set phone='" + TextBox2.Text.ToString() + "' , addresse='" + DropDownList1.Text.ToString() + "'  where name='" + TextBox1.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string sql = "insert into Table_1(name,phone,addresse) values(" + TextBox1.Text.ToString() + ",'" + TextBox2.Text.ToString() + "','" + DropDownList1.Text.ToString() + "')";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        //public void Button1_Click(object sender, EventArgs e)
        //{
        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    if (uniqueEmail() == true)
        //    {
        //        cmd.CommandText = "update Table_1 set name='" + TextBox1.Text + "', phone='" + TextBox2.Text + "' where name='" + TextBox1.Text + "'";
        //    }
        //    else
        //    {
        //        cmd.CommandText = "insert into Table_1(name, phone) values('" + TextBox1.Text + "', '" + TextBox2.Text + "')";
        //    }
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        //public bool uniqueEmail()
        //{
        //    string stremail;
        //    string querye = "select count(name) as name from Table_1";
        //    SqlCommand cmd = new SqlCommand(querye, con);
        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        try
        //        {
        //            stremail = dr["name"].ToString();
        //            return (stremail != "0");
        //            if (stremail != "0")
        //            {
        //                //errlblemail.Text = "email already exist";
        //                return false;
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            string message = "error";
        //            message += e.Message;
        //        }
        //        finally
        //        {
        //            dr.Close();
        //        }
        //    }
        //    return true;
        //}
    }
}