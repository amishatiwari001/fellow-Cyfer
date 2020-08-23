using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Jobs : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        var q = from a in dl.da.Company1Tables.Where(k => k.Location.Contains(Request.QueryString["area"]))
                from b in dl.da.JobPostTables.Where(k => k.PostName == Convert.ToInt32(Request.QueryString["post"]) && k.CompanyName == a.Id)
                from c in dl.da.ITjobPostTables.Where(k => k.Id == b.PostName)
                select new
                {
                    a.Name,
                    a.Location,
                    a.Contact,
                    a.Email,
                    a.Website,
                    c.Post,
                    b.CompanyName,
                    PublishDate = b.PublishDate.Value.ToShortDateString(),
                    b.Duration,
                    b.Stipend,
                    b.LastDate,
                    Description = b.Description.Substring(0, 150),
                    b.Id,
                    cid = a.Id
                };
        Repeater1.DataSource = q;
        Repeater1.DataBind();
        Repeater2.DataSource = dl.da.ITjobPostTables;
        Repeater2.DataBind();
    }
}