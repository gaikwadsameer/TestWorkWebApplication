using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace WebApplication1.user
{
    public partial class Default : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeater();
            }
        }

        private void BindRepeater()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM login", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    rptFormElements.DataSource = reader;
                    rptFormElements.DataBind();
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (RepeaterItem item in rptFormElements.Items)
            {
                // Assuming the IDs are prefixed based on their type (txt, ddl, chk, rdo)
                string elementType = (item.FindControl("lblElement") as Label).Text;
                string elementID = elementType.ToLower();

                string value = string.Empty;

                switch (elementType)
                {
                    case "TextBox":
                        value = (item.FindControl("txt" + elementID) as TextBox)?.Text;
                        break;
                    case "DropDownList":
                        value = (item.FindControl("ddl" + elementID) as DropDownList)?.SelectedValue;
                        break;
                    case "CheckBox":
                        value = (item.FindControl("chk" + elementID) as CheckBox)?.Checked.ToString();
                        break;
                    case "RadioButton":
                        value = (item.FindControl("rdo" + elementID) as RadioButton)?.Checked.ToString();
                        break;
                }

                SaveFormData(elementID, value);
            }
        }

        private void SaveFormData(string elementID, string value)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO login (UserName, Password) VALUES (@UserName, @Password)", con))
                {
                    cmd.Parameters.AddWithValue("@UserName", elementID);
                    cmd.Parameters.AddWithValue("@Password", value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
