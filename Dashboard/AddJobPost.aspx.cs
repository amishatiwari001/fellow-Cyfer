using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_AddJobPost : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.DataSource = dl.da.Company1Tables;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--Select Company Name--");


            DropDownList2.DataSource = dl.da.ITjobPostTables;
            DropDownList2.DataTextField = "Post";
            DropDownList2.DataValueField = "Id";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "--Select Job Post--");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        JobPostTable ct = new JobPostTable();
        ct.CompanyName = Convert.ToInt32(DropDownList1.SelectedValue);
        ct.PostName = Convert.ToInt32(DropDownList2.SelectedValue);
        ct.PublishDate = Convert.ToDateTime(TextBox3.Text);
        ct.LastDate = Convert.ToDateTime(TextBox4.Text);
        ct.Duration = TextBox5.Text;
        ct.Stipend = TextBox6.Text;
        ct.Description = TextBox7.Text;
        dl.da.JobPostTables.InsertOnSubmit(ct);
        dl.da.SubmitChanges();
        Response.Write("<script>alert('Details are Display!!!')</script>");
        TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = " ";
        DropDownList1.SelectedIndex = DropDownList2.SelectedIndex = 0;
    }
}