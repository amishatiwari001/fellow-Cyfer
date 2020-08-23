using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApplyForIntern : System.Web.UI.Page
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
        CVTable cv = new CVTable();
        cv.Full_Name = Textbox1.Text;
        cv.Email = TextBox2.Text;
        cv.Address = TextBox5.Text;
        cv.Phone = TextBox6.Text;
        cv.Company = DropDownList1.SelectedValue.ToString();
        cv.Apply_For = DropDownList2.SelectedValue.ToString();
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Dashboard/StudentPic/" + FileUpload1.FileName));
            cv.Upload_your_Pic = "/Dashboard/StudentPic/" + FileUpload1.FileName;
        }
        if (FileUpload2.HasFile)
        {
            FileUpload2.SaveAs(Server.MapPath("~/Dashboard/Studentcv/" + FileUpload2.FileName));
            cv.Upload_your_resume = "/Dashboard/Studentcv/" + FileUpload2.FileName;
        }
        dl.da.CVTables.InsertOnSubmit(cv);
        dl.da.SubmitChanges();
        Response.Write("<script>alert('Apply Successfull..!')</script>");
        Textbox1.Text = TextBox2.Text = TextBox5.Text = TextBox6.Text = "";
        DropDownList1.SelectedIndex = DropDownList2.SelectedIndex = 0;


    }
}