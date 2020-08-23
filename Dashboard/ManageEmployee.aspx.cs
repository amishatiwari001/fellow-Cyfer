using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_ManageEmployee : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.ActiveViewIndex = 0;

            DropDownList1.DataSource = dl.da.Company1Tables;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--Select Company Name--");

            Bind();
        }
    }
    void Bind()
    {
        var q = (from b in dl.da.Company1Tables
                 from a in dl.da.EmployeeTables.Where(k => k.Cid == b.Id)
                 select new
                 {
                     a.Id,
                     a.EmpployeeName,
                     a.EmpPic,
                     a.JobProfile,
                     a.Review,
                     a.Linkedlink,
                     b.Name
                 }).ToList();
        Repeater1.DataSource = q;
        Repeater1.DataBind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        ViewState["a"] = ((LinkButton)sender).CommandArgument;
        MultiView1.ActiveViewIndex = 1;
        var q = (from a in dl.da.EmployeeTables.Where(k => k.Id == Convert.ToInt32(((LinkButton)sender).CommandArgument))
                 from b in dl.da.Company1Tables.Where(k => k.Id == a.Cid)
                 select new
                 {
                     a.Id,
                     a.EmpployeeName,
                     a.EmpPic,
                     a.JobProfile,
                     a.Review,
                     a.Linkedlink,
                     b.Name
                 }).FirstOrDefault();
        TextBox1.Text = q.EmpployeeName;
        TextBox3.Text = q.JobProfile;
        TextBox4.Text = q.Linkedlink;
        TextBox5.Text = q.Review;
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {

        MultiView1.ActiveViewIndex = 0;
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        var q = (from a in dl.da.EmployeeTables
                 where a.Id == Convert.ToInt32(ViewState["a"])
                 select a).FirstOrDefault();
        q.EmpployeeName = TextBox1.Text;
        q.Cid = Convert.ToInt32(DropDownList1.SelectedValue);
        q.JobProfile = TextBox3.Text;
        q.Linkedlink = TextBox4.Text;
        q.Review = TextBox5.Text;
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Dashboard/EmployeePic/" + FileUpload1.FileName));
            q.EmpPic = "/Dashboard/EmployeePic/" + FileUpload1.FileName;
        }
        dl.da.SubmitChanges();
        Bind();
        MultiView1.ActiveViewIndex = 0;
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        var q = (from a in dl.da.EmployeeTables.Where(k => k.Id == Convert.ToInt32(((LinkButton)sender).CommandArgument))
                 from b in dl.da.Company1Tables.Where(k => k.Id == a.Cid)
                 select new
                 {
                     a.Id,
                     a.EmpployeeName,
                     a.EmpPic,
                     a.JobProfile,
                     a.Review,
                     a.Linkedlink,
                     b.Name
                 }).FirstOrDefault();
        Image1.ImageUrl = q.EmpPic;
        Literal1.Text = q.EmpployeeName;
        Literal2.Text = q.Name;
        Literal3.Text = q.JobProfile;
        Literal4.Text = q.Linkedlink;
        Literal5.Text = q.Review;
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        var q = (from a in dl.da.EmployeeTables
                 where a.Id == Convert.ToInt32(ViewState["b"])
                 select a).FirstOrDefault();
        dl.da.EmployeeTables.DeleteOnSubmit(q);
        dl.da.SubmitChanges();
        Bind();
        MultiView1.ActiveViewIndex = 0;
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        ViewState["b"] = ((LinkButton)sender).CommandArgument;
        MultiView1.ActiveViewIndex = 3;
        var q = (from a in dl.da.EmployeeTables
                 where a.Id == Convert.ToInt32(((LinkButton)sender).CommandArgument)
                 select a).FirstOrDefault();
        Literal6.Text = q.EmpployeeName;
        Image2.ImageUrl = q.EmpPic;

    }
}