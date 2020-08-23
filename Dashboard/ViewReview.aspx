<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/MasterPage.master" AutoEventWireup="true" CodeFile="ViewReview.aspx.cs" Inherits="Dashboard_ViewReview" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="#">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">View Review</li>
            </ol>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Review List</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">All Review Details</div>
                    <div class="panel-body">
                        <div class="col-lg-12">
                            <form role="form" runat="server">
                                <div class="table-responsive">
                                    <table class="table table-bordered table-hover" id="dataTable" width="100%" cellspacing="0">
                                        <thead>
                                            <tr>
                                                <th>Name</th>
                                                <th>Email</th>
                                                <th>Subject</th>
                                                <th>Message</th>
                                                <th>Mobile</th>
                                                <th>Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td><%# Eval("Name") %></td>
                                                        <td><%# Eval("Email") %></td>
                                                        <td><%# Eval("Subject") %></td>
                                                        <td><%# Eval("Message") %></td>
                                                        <td><%# Eval("Telephone") %></td>
                                                        <td>
                                                            <asp:LinkButton OnClick="LinkButton3_Click"  CssClass="btn btn-danger btn-circle" CommandArgument=  '<%# Eval("Id") %>' ToolTip="Edit" ID="LinkButton3" runat="server"><i class="fa fa-trash"></i></asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>

                                        </tbody>
                                    </table>
                                </div>

                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

