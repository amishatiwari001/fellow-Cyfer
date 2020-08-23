using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JobDescription : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        var q = (from b in dl.da.JobPostTables.Where(k => k.Id == Convert.ToInt32(Request.QueryString["Jid"]))
                 from a in dl.da.Company1Tables.Where(k => k.Id == b.CompanyName)
                 from c in dl.da.ITjobPostTables.Where(k => k.Id == b.PostName)
                 select new
                 {
                     a.Name,
                     a.Location,
                     a.Contact,
                     a.EmployeeNo,
                     a.Email,
                     a.Website,
                     c.Post,
                     b.CompanyName,
                     PublishDate = b.PublishDate.Value.ToShortDateString(),
                     b.Duration,
                     b.Stipend,
                     b.LastDate,
                     Description = b.Description.Substring(0, 150),
                     b.Id
                 }).FirstOrDefault();
        Literal1.Text = q.Post;
        Literal2.Text = q.Name;
        Literal3.Text = q.Post;
        Literal4.Text = q.PublishDate;
        Literal5.Text = q.Stipend;
        Literal6.Text = q.Duration;
        Literal7.Text = q.Description;
        Literal8.Text = q.Email;
        Literal9.Text = q.LastDate.Value.ToShortDateString();
        Literal10.Text = q.Name;
        Literal11.Text = q.Location;
        Literal12.Text = q.EmployeeNo.ToString();
        Literal13.Text = q.Contact;
        Literal14.Text = q.Email;
        Literal15.Text = q.Website;

        var qq = (from b in dl.da.JobPostTables.Where(k => k.Id == Convert.ToInt32(Request.QueryString["Jid"]))
                  from a in dl.da.Company1Tables.Where(k => k.Id == b.CompanyName)
                  from c in dl.da.EmployeeTables.Where(k => k.Cid == a.Id)
                  select new
                  {
                      c.EmpployeeName,
                      c.JobProfile,
                      c.Linkedlink,
                      c.Review,
                      c.EmpPic,
                      a.Name

                  }).ToList();
        Repeater1.DataSource = qq;
        Repeater1.DataBind();

    }
}