using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.user
{
    public partial class dynamic_data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeater();
            }
        }

        public class FormData
        {
            public string TextboxValue { get; set; }
            public string DropdownValue { get; set; }
            public bool CheckboxValue { get; set; }
            public string RadioValue { get; set; }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var values = new List<Tuple<string, string>>();
            foreach (string key in Request.Form.Keys)
            {
                if (key.StartsWith("txt_"))
                {
                    string UserName = Request.Form[key];
                    string dropdownKey = "ddl_" + key.Substring(4);
                    string Password = Request.Form[dropdownKey];
                    values.Add(new Tuple<string, string>(UserName, Password));
                    //string checkboxValue = Request.Form["chk_" + index] == "on";
                    string radioValue = Request.Form["radGroup"]; // Radio buttons share the same name

                    //values.Add(new FormData
                    //{
                        //TextboxValue = UserName,
                        //DropdownValue = dropdownKey,
                        //CheckboxValue = checkboxValue,
                        //RadioValue = radioValue
                    //});
                }
            }

            SaveToDatabase(values);
            BindRepeater();
        }

        private void SaveToDatabase(List<Tuple<string, string>> values)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (var value in values)
                {
                    string query = "INSERT INTO login (UserName, Password, CheckboxValue, RadioValue) VALUES (@UserName, @Password, @CheckboxValue, @RadioValue)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserName", value.Item1);
                    cmd.Parameters.AddWithValue("@Password", value.Item2);
                    //cmd.Parameters.AddWithValue("@CheckboxValue", value.CheckboxValue);
                    //cmd.Parameters.AddWithValue("@RadioValue", value.RadioValue);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BindRepeater()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserName, Password , CheckboxValue, RadioValue FROM login";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                Repeater11.DataSource = reader;
                Repeater11.DataBind();
            }
        }

    }
}