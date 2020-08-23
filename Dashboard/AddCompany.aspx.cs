using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_AddCompany : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Company1Table ct = new Company1Table();
        ct.Name = TextBox1.Text;
        ct.Location = TextBox2.Text;
        ct.EmployeeNo = Convert.ToInt32(TextBox3.Text);
        ct.Email = TextBox5.Text;
        ct.Contact = TextBox4.Text;
        ct.Website = TextBox6.Text;
        dl.da.Company1Tables.InsertOnSubmit(ct);
        dl.da.SubmitChanges();
        Response.Write("<script>alert('Details are Display!!!')</script>");
        TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = " ";
    }
}