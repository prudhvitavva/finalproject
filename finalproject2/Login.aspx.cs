using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;

namespace finalproject2
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button2_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            
            string Email = Request.Form["email"];
            string Password = Request.Form["passwrd"];

            SqlCommand cmd = new SqlCommand("SELECT Email,Password FROM UsersTable WHERE Email= '" + Email + "' and Password= '" + Password + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = conn;

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
               MessageBox.Show("Invalid email or password");

            }
            conn.Close();
        }
    }
}