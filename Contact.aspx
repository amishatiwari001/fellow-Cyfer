<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="inner_page_agile">
        <h3>Contact</h3>
        <p>Add Some Short Description</p>

    </div>
    <div class="services-breadcrumb_w3layouts">
        <div class="inner_breadcrumb">

            <ul class="short_w3ls">
                <li><a href="Default.aspx">Home</a><span>|</span></li>
                <li>Contact</li>
            </ul>
        </div>
    </div>
    <div class="inner_content_info_agileits">
        <div class="container">
            <div class="tittle_head_w3ls">
                <h3 class="tittle">Contact Us</h3>
            </div>
            <div class="inner_sec_grids_info_w3ls">
                <div class="col-md-4 agile_info_mail_img_info mt-2">
                    <div class="address-grid">
                        <h4>Contact <span>Info</span></h4>
                        <div class="mail-agileits-w3layouts">
                            <i class="fa fa-volume-control-phone" aria-hidden="true"></i>
                            <div class="contact-right">
                                <p>Telephone </p>
                                <span>+91 933521352</span>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="mail-agileits-w3layouts">
                            <i class="fa fa-envelope-o" aria-hidden="true"></i>
                            <div class="contact-right">
                                <p>Mail </p>
                                <a href="fellowcyfer@gmail.com">fellowcyfer@gmail.com</a>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="mail-agileits-w3layouts">
                            <i class="fa fa-map-marker" aria-hidden="true"></i>
                            <div class="contact-right">
                                <p>Location</p>
                                <span>Raja Ram Kumar Plaza,Hazratganj</span>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="agileits_w3layouts_nav_right contact">
                            <div class="social two">
                                <ul>
                                    <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                    <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                    <li><a href="#"><i class="fa fa-rss"></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-8" style="margin-top: -50px">
                    <div class="w3layouts_mail_grid">
                        <form class="user" runat="server">
                            <div class="form-group">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control form-control-user" placeholder="User Name"></asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is required" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtmail" runat="server" CssClass="form-control form-control-user" placeholder="enter email"></asp:TextBox>
                                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtmail" ErrorMessage="Invalid Email" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">**</asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtmail" ErrorMessage="Invalid Email" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control form-control-user" placeholder="Telephone number"></asp:TextBox>
                                 <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox3" ErrorMessage=" Number is required" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control form-control-user" placeholder="Subject"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control form-control-user" placeholder="Enter Message" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" />
                            </div>
                        </form>
                    </div>
                </div>
                <div class="clearfix"></div>

            </div>
        </div>
    </div>
    <div class="map">
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3559.784385675364!2d80.94247381487967!3d26.846809369387443!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x399bfd07c3c15643%3A0x867bb0de72c4c460!2sDigipodium!5e0!3m2!1sen!2sin!4v1556449097355!5m2!1sen!2sin" style="border: 0" allowfullscreen></iframe>
    </div>
</asp:Content>

