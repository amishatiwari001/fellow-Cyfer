using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ContactTable ct = new ContactTable();
        ct.Name = TextBox1.Text;
        ct.Email = txtmail.Text;
        ct.Telephone = TextBox3.Text;
        ct.Subject = TextBox4.Text;
        ct.Message = TextBox5.Text;
        dl.da.ContactTables.InsertOnSubmit(ct);
        dl.da.SubmitChanges();
        Response.Write("<script>alert('Thanks For Contac With US')</script>");
        TextBox3.Text = TextBox4.Text = TextBox5.Text = txtmail.Text = TextBox1.Text = " ";
    }
}