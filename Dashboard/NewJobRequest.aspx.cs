using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_NewJobRequest : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
            MultiView1.ActiveViewIndex = 0;
        }
    }
    void Bind()
    {
        var q = (from b in dl.da.Company1Tables
                 from c in dl.da.ITjobPostTables
                 from a in dl.da.CVTables.Where(k => k.Company == b.Id.ToString() && k.Apply_For == c.Id.ToString())
                 select new
                 {
                     a.Id,
                     a.Full_Name,
                     a.Email,
                     b.Name,
                     a.Phone,
                     c.Post,
                     a.Upload_your_Pic,
                     a.Upload_your_resume
                 }).ToList();
        Repeater1.DataSource = q;
        Repeater1.DataBind();
    }


    protected void LinkButton4_Click(object sender, EventArgs e)
    {

        MultiView1.ActiveViewIndex = 0;
    }


    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        var q = (from b in dl.da.Company1Tables
                 from c in dl.da.ITjobPostTables
                 from a in dl.da.CVTables.Where(k => k.Company == b.Id.ToString() && k.Apply_For == c.Id.ToString())
                 select new
                 {
                     a.Id,
                     a.Full_Name,
                     a.Email,
                     b.Name,
                     a.Phone,
                     c.Post,
                     a.Address,
                     a.Upload_your_Pic,
                     a.Upload_your_resume,

                 }).FirstOrDefault();
        Image1.ImageUrl = q.Upload_your_Pic;
        Literal1.Text = q.Full_Name;
        Literal2.Text = q.Name;
        Literal3.Text = q.Post;
        Literal4.Text = q.Address;
        Literal5.Text = q.Phone;
        Literal6.Text = q.Email;
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        var q = (from a in dl.da.CVTables
                 where a.Id == Convert.ToInt32(ViewState["b"])
                 select a).FirstOrDefault();
        string destinationaddr = "91" + q.Phone;
        string message = TextBox1.Text;

        String message1 = HttpUtility.UrlEncode(message);
        using (var wb = new WebClient())
        {
            byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new System.Collections.Specialized.NameValueCollection()
                {
                {"apikey" , "8GwB0UYwCBE-kWa9pPEQW8b4r64y4opUmAxL2IiDK3"},
                {"numbers" , destinationaddr},
                {"message" , message1},
                {"sender" , "TXTLCL"}
                });
            string result = System.Text.Encoding.UTF8.GetString(response);
        }
        TextBox1.Text = "";
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        ViewState["b"] = ((LinkButton)sender).CommandArgument;
        MultiView1.ActiveViewIndex = 2;
        var q = (from a in dl.da.CVTables
                 where a.Id == Convert.ToInt32(((LinkButton)sender).CommandArgument)
                 select a).FirstOrDefault();
        Literal7.Text = q.Full_Name;
        Image2.ImageUrl = q.Upload_your_Pic;

    }
}