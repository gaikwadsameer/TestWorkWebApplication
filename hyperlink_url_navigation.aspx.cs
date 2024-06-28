using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class hyperlink_url_navigation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView(); // Call method to bind data to GridView
            }
        }

        private void BindGridView()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;"; // Replace with your actual connection string

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT addresse, name FROM Table_1", conn); // Replace with your actual query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        // Optional: Handle RowDataBound event for customizing each row
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Example: Change background color of rows based on data
                // Replace with your own logic
                if (e.Row.Cells[1].Text == "SomeCondition")
                {
                    e.Row.BackColor = System.Drawing.Color.Yellow;
                }
            }
        }

    }
}