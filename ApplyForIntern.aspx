<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="ApplyForIntern.aspx.cs" Inherits="ApplyForIntern" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="inner_page_agile">
        <h3>Apply For Internship</h3>
        <p>Add Some Short Description</p>

    </div>
    <div class="services-breadcrumb_w3layouts">
        <div class="inner_breadcrumb">

            <ul class="short_w3ls">
                <li><a href="Default.aspx">Home</a><span>|</span></li>
                <li>Apply</li>
            </ul>
        </div>
    </div>
    <div>
        <div class="tittle_head_w3ls">
            <h3 class="tittle text-dark">Candidate Details</h3>
        </div>
        <div class="inner_sec_grids_info login-form">
            <form runat="server">
                <div class="col-md-6 form-left">
                    <div class="form-inputs email">
                        <label>Full name</label>
                        <i class="fa fa-user" aria-hidden="true"></i>
                        <asp:TextBox ID="Textbox1" runat="server" placeholder="Full Name"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="Textbox1" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is required" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>

                    <div class="form-inputs name">
                        <label>Email</label>
                        <i class="fa fa-envelope" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Email"></asp:TextBox>
                    </div>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="TextBox2" runat="server" ErrorMessage="Invalid Email" SetFocusOnError="True" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                     <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="Textbox2" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Invalid Email" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <div class="form-inputs">
                        <label>Company</label>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Select Company</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-6 form-right">
                    <div class="form-inputs name">
                        <label>Address</label>
                        <i class="fa fa-map-marker" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="Address"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox5" ErrorMessage="Address is required" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-inputs name">
                        <label>Phone</label>
                        <i class="fa fa-phone" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox6" runat="server" placeholder="Contact"></asp:TextBox>
                    </div>
                     <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox6" ErrorMessage="Number is required" Display="Dynamic" ForeColor="Red" SetFocusOnError="True">**</asp:RequiredFieldValidator>

                    <div class="form-inputs">
                        <label>Apply For</label>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem>Select Post</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="form-inputs upload">
                    <label class="text-left">Upload your Pic</label>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
                 <asp:RequiredFieldValidator runat="server" ControlToValidate="FileUpload1" ErrorMessage="Upload Passport Size Pic" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <div class="form-inputs upload">
                    <label class="text-left">Upload your resume</label>
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </div>
                 <asp:RequiredFieldValidator runat="server" ControlToValidate="FileUpload2" ErrorMessage="Upload Resume in Pdf" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:Button ID="Button1" runat="server" Text="Submit Details" OnClick="Button1_Click" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" />
            </form>

        </div>
    </div>
</asp:Content>

