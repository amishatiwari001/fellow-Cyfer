<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/MasterPage.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="Dashboard_Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="#">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Employee Details </li>
            </ol>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Add Employee</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">New Employee Details</div>
                    <div class="panel-body">
                        <div class="col-lg-12">
                            <form role="form" runat="server">
                                <div class="form-group">
                                    <label>Choose Company</label>
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label>Employee Name</label>
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Employee Name"></asp:TextBox>
                                </div>
                                <div class="row">
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label>Job Post</label>
                                            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Job Profile"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label>Employee Pic</label>
                                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"/>
                                        </div>
                                    </div>

                                </div>

                                <div class="form-group">
                                    <label>Review</label>
                                    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" CssClass="form-control" placeholder="Review"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>Linked In Profile</label>
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="linked profile link"></asp:TextBox>
                                </div>

                                <asp:Button ID="Button1" runat="server" Text="Add Employee" OnClick="Button1_Click" CssClass="btn btn-primary" />
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>





</asp:Content>









