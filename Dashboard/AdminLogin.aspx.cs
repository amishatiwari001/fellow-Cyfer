using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_AdminLogin : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    

    protected void Button1_Click1(object sender, EventArgs e)
    {
        var q = (from a in dl.da.AdminTables
                 where a.AdminEmail == TextBox1.Text & a.Password == TextBox2.Text
                 select a).FirstOrDefault();
        if (q != null)
        {
            Response.Redirect("~/Dashboard/Adminhome.aspx");


        }
        else
        {
            Response.Write("<script>alert('Email or Password is invalid')</script>");
        }

    }
}