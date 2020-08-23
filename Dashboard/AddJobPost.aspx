<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/MasterPage.master" AutoEventWireup="true" CodeFile="AddJobPost.aspx.cs" Inherits="Dashboard_AddJobPost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="#">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Add JobPost</li>
            </ol>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Add Internship</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">New JobPost Details</div>
                    <div class="panel-body">
                        <div class="col-lg-12">
                            <form role="form" runat="server">
                                <div class="form-group">
                                    <label>Select Company</label>
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label>Post Name </label>
                                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group ">
                                        <p>Start Date</p>
                                        <asp:TextBox ID="TextBox3" TextMode="Date" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group ">
                                        <p>Last Date</p>
                                        <asp:TextBox ID="TextBox4" TextMode="Date" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6 form-left">
                                    <div class="form-group ">
                                        <label>Duration</label>
                                        <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6 form-left">
                                    <div class="form-group ">
                                        <label>Stipend</label>
                                        <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" placeholder="Company Name"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group ">
                                    <label>Description</label>
                                    <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" placeholder="Company Description"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="Button1" runat="server" Text="Post" OnClick="Button1_Click" CssClass="btn btn-primary" />
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>



