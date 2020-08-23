using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_Adminhome : System.Web.UI.Page
{
    DataLayer dl = new DataLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        Literal1.Text = dl.da.Company1Tables.Count().ToString();
        Literal2.Text = dl.da.JobPostTables.Count().ToString();
        Literal3.Text = dl.da.ContactTables.Count().ToString();
        Literal4.Text = dl.da.CVTables.Count().ToString();

    }
}