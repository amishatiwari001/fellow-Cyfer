using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_Notification : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
            //DropDownList1.DataSource = dl.da.Company1Tables;
            //DropDownList1.DataTextField = "Name";
            //DropDownList1.DataValueField = "Email";
            //DropDownList1.DataBind();
            //DropDownList1.Items.Insert(0, "---Select User Name---");

        //}

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("fellowcyfer@gmail.com");
        msg.To.Add(TextBox1.Text);
        msg.Subject = TextBox2.Text;
        msg.Body = TextBox3.Text;
        msg.IsBodyHtml = true;

        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;

        NetworkCredential networkcred = new NetworkCredential();
        networkcred.UserName = "fellowcyfer@gmail.com";
        networkcred.Password = "amisha933";
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = networkcred;
        smtp.EnableSsl = true;
        smtp.Send(msg);
        Response.Write("<script>alert('Notification Send Successfully..!')</script>");
        TextBox2.Text = TextBox1.Text = "";
    }
}

