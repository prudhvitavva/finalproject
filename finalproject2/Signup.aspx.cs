using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalproject2
{
    public partial class _Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string FirstName = Request.Form["fname"];
            string LastName = Request.Form["lname"];
            string Email = Request.Form["email"];
            string Username = Request.Form["username"];
            string Password = Request.Form["passwrd"];
           
            string SQL = "Insert Into UsersTable Values('" + FirstName + "', '" + LastName + "','" + Email + "','" + Username + "','" + Password + "')";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.ExecuteNonQuery();
            if (cmd != null)
            {
                Response.Write("<h5>Login Successful...</h5>");
            }

            conn.Close();
            Response.Redirect("default.aspx");
        }


    }

}