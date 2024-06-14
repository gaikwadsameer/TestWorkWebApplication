using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generate a random 10-digit number
            Random random = new Random();
            string randomNumber = random.Next(1000000000, 1999999999).ToString();

            // Display the random number in the label
            lblRandomNumber.Text = "Generated Number: " + randomNumber;

            // Insert the random number into the database
            InsertRandomNumberIntoDatabase(randomNumber);
        }

        private void InsertRandomNumberIntoDatabase(string randomNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tab (phonen) VALUES (@phonen)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phonen", randomNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}