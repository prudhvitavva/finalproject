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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "SELECT * FROM Final$"; //change when table is created
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
            conn.Close();
        }

        //protected void btnsort_Click(object sender, EventArgs e)
        //{
            //string expression = "";
            //SortDirection direction;

            //expression = sortby.SelectedValue;

    //        switch (sortby.SelectedValue)
    //        {
    //            case "Ascending":
    //                direction = SortDirection.Ascending;
    //                break;
    //            case "Descending":
    //                direction = SortDirection.Descending;
    //                break;
    //            default:
    //                direction = SortDirection.Ascending;
    //                break;
    //        }
    //        GridView1.Sort(expression, direction);
    //    }
    }
}