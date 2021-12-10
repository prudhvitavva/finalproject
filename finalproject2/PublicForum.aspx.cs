using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Web.UI.WebControls;

namespace finalproject2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "SELECT * FROM Forum"; //change when table is created
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GridView2.DataSource = reader;
                GridView2.DataBind();
            }
            conn.Close();
        }

        protected void btnAddRating_Click(object sender, EventArgs e)
        {
            string username = Request.Form["ctl00$MainContent$txtusername"];
            string date = Request.Form["ctl00$MainContent$txtDate"];
            string state = Request.Form["ctl00$MainContent$txtState"];
            string rating = Request.Form["ctl00$MainContent$txtRating"];
            int rating1 = Int32.Parse(rating);

            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "INSERT INTO Forum Values('" + username + "', '" + date + "', '" + state + "', " + rating1 + ")";
            SqlCommand command = new SqlCommand(sql, conn);

            command.ExecuteNonQuery();

            conn.Close();
        }
    }
}