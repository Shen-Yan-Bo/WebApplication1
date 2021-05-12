using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                Response.Redirect("test2");
            }
            else
            {
                if (Request.Form["user"] != null && Request.Form["passwd"] != null)
                {

                    /*
                    if (Request.Form["user"] == "lccnet" && Request.Form["passwd"] == "123456")
                    {
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["name"] = Request.Form["name"];
                        Session["logined"] = "1";
                        Response.Redirect("test2");
                    }*/

                    string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["accountConnectionString"].ConnectionString;

                    SqlConnection connection = new SqlConnection(s_data);

                    string sql = $"insert into [accountInfomation](username,passwd,name) values('" + Request.Form["user"] + "','" + Request.Form["passwd"] + "','" + Request.Form["name"] + "')";

                    connection.Open();

                    SqlCommand Command = new SqlCommand(sql, connection);

                    Command.ExecuteNonQuery();

                    connection.Close();
                }
                else
                {
                    Response.Write("error");
                }
                
            }
        }
    } 
}
