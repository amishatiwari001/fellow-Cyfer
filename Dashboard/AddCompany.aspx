<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/MasterPage.master" AutoEventWireup="true" CodeFile="AddCompany.aspx.cs" Inherits="Dashboard_AddCompany" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="#">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Add Company</li>
            </ol>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Add Company</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">New Company Details</div>
                    <div class="panel-body">
                        <div class="col-lg-12">
                            <form role="form" runat="server">
                                <div class="form-group">
                                    <label>Company Name</label>
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>Company Location</label>
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                </div>
                                <div class="form-group ">
                                    <label>no.of Employee</label>
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                </div>
                                <div class="form-group ">
                                    <label>Contact</label>
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                </div>
                                <div class="form-group ">
                                    <label>E-mail</label>
                                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                </div>
                                <div class="form-group ">
                                    <label>Websites_Link</label>
                                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" CssClass="btn btn-primary" />
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

