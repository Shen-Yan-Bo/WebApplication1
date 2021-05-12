using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                Response.Redirect("test2");
            }
            else
            {
                if (Request.Form["user"] != null && Request.Form["passwd"] != null)
                {
                    if (Request.Form["user"] == "lccnet" && Request.Form["passwd"] == "123456")
                    {
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["name"] = Request.Form["name"];
                        Session["logined"] = "1";
                        Response.Redirect("test2");
                    }
                }
                else
                {
                    Response.Write("error");
                }
            }
        }
        

    }
}