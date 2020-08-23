using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.DataSource = dl.da.ITjobPostTables;
            DropDownList1.DataTextField = "Post";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--Select Category--");

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Jobs.aspx?area=" + TextBox2.Text + "&post=" + DropDownList1.SelectedValue);
    }
}