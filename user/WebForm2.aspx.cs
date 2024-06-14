using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.user
{
    public partial class WebForm2 : System.Web.UI.Page
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
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserInputs";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Repeater10.DataSource = reader;
                Repeater10.DataBind();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            foreach (RepeaterItem item in Repeater10.Items)
            {
                TextBox textBox = (TextBox)item.FindControl("TextBox1");
                DropDownList dropdown = (DropDownList)item.FindControl("DropDownList1");
                RadioButtonList radioButtonList = (RadioButtonList)item.FindControl("RadioButtonList1");
                CheckBox chkFullTime = (CheckBox)item.FindControl("chkFullTime");
                CheckBox chkPartTime = (CheckBox)item.FindControl("chkPartTime");

                string textBoxValue = textBox.Text;
                string dropdownValue = dropdown.SelectedValue;
                string radioButtonValue = radioButtonList.SelectedValue;
               
                string checkBoxValue = chkFullTime.Checked ? "Full Time" : chkPartTime.Checked ? "Part Time" : "None";

                InsertData(textBoxValue, dropdownValue, radioButtonValue, checkBoxValue);
            }

            // Rebind the Repeater to reflect the inserted data
            BindRepeater();
        }

        private void InsertData(string textBoxValue, string dropdownValue, string radioButtonValue, string checkBoxValue)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserInputs (TextBoxValue, DropdownValue, RadioButtonValue, CheckboxValue) VALUES (@TextBoxValue, @DropdownValue, @RadioButtonValue, @CheckboxValue)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TextBoxValue", textBoxValue);
                cmd.Parameters.AddWithValue("@DropdownValue", dropdownValue);
                cmd.Parameters.AddWithValue("@RadioButtonValue", radioButtonValue);
                cmd.Parameters.AddWithValue("@CheckboxValue", checkBoxValue);
                                
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}