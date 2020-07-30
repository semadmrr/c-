using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Deneme_Project1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Deneme_Project1\Deneme_Project1\App_Data\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string goster = @"SELECT ProductName,ProductDescription,ProductPrice from Categories1 INNER JOIN  Products1 ON Categories1.CategoryId = Products1.CategoryId WHERE Products1.CategoryId=1 ";
            SqlCommand cmd = new SqlCommand(goster, con);
            SqlDataReader reader = cmd.ExecuteReader();


            GridView1.DataSource = reader;
            GridView1.DataBind();

            con.Close();
        }

        protected void Button2_Click(object sender,EventArgs e)
        {
            con.Open();
            string goster1 = @"SELECT ProductName,ProductDescription,ProductPrice from Categories1 INNER JOIN Products1 ON Categories1.CategoryId = Products1.CategoryId WHERE Products1.CategoryId = 2 ";
            SqlCommand cmd1 = new SqlCommand(goster1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            GridView2.DataSource = reader1;
            GridView2.DataBind();

            con.Close();
        }

        protected void Button3_Click(object sender,EventArgs e)
        {
            con.Open();
            string goster2 = @"SELECT ProductName,ProductDescription,ProductPrice from Categories1 INNER JOIN Products1 ON Categories1.CategoryId = Products1.CategoryId WHERE Products1.CategoryId = 3 ";
            SqlCommand cmd2 = new SqlCommand(goster2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            GridView3.DataSource = reader2;
            GridView3.DataBind();

            con.Close();
        }
    }
}
