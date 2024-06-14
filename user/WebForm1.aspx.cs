using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.user
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeater();
            }
        }

        private void BindRepeater()
        {
            // Here you can bind the repeater with initial data if needed
            Repeater1.DataSource = new[] { new { } }; // Example data source
            Repeater1.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (RepeaterItem item in Repeater1.Items)
            {
                TextBox txtPhoneNumber = (TextBox)item.FindControl("txtPhoneNumber");
                DropDownList ddlDegree = (DropDownList)item.FindControl("ddlDegree");
                RadioButtonList rblGender = (RadioButtonList)item.FindControl("rblGender");
                CheckBox chkFullTime = (CheckBox)item.FindControl("chkFullTime");
                CheckBox chkPartTime = (CheckBox)item.FindControl("chkPartTime");

                string phoneNumber = txtPhoneNumber.Text;
                string degree = ddlDegree.SelectedValue;
                string gender = rblGender.SelectedValue;
                string employmentStatus = chkFullTime.Checked ? "Full Time" : chkPartTime.Checked ? "Part Time" : "None";

                SaveToDatabase(phoneNumber, degree, gender, employmentStatus);
            }
        }

        private void SaveToDatabase(string phoneNumber, string degree, string gender, string employmentStatus)
        {
            string connectionString = "ConnectionString";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (PhoneNumber, Degree, Gender, EmploymentStatus) VALUES (@PhoneNumber, @Degree, @Gender, @EmploymentStatus)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Degree", degree);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@EmploymentStatus", employmentStatus);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}