using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_Employee : System.Web.UI.Page
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

        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        EmployeeTable ct = new EmployeeTable();
        ct.Cid = Convert.ToInt32(DropDownList1.SelectedValue);
        ct.EmpployeeName = TextBox1.Text;
        ct.JobProfile = TextBox2.Text;
        ct.Review = TextBox3.Text;
        ct.Linkedlink = TextBox4.Text;
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Dashboard/EmployeePic/" + FileUpload1.FileName));
            ct.EmpPic = "/Dashboard/EmployeePic/" + FileUpload1.FileName;
        }
        dl.da.EmployeeTables.InsertOnSubmit(ct);
        dl.da.SubmitChanges();
        Response.Write("<script>alert('Employees Details are Added !!!')</script>");
        TextBox3.Text = TextBox1.Text = TextBox2.Text = TextBox4.Text = " ";
    }
}
