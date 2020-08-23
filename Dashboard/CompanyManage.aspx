<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/MasterPage.master" AutoEventWireup="true" CodeFile="CompanyManage.aspx.cs" Inherits="Dashboard_CompanyManage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="#">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Manage Company</li>
            </ol>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Company List</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">All Company Details</div>
                    <div class="panel-body">
                        <div class="col-lg-12">
                            <form role="form" runat="server">
                                <asp:MultiView ID="MultiView1" runat="server">
                                    <asp:View ID="View1" runat="server">
                                        <div class="table-responsive">
                                            <table class="table table-bordered table-hover" id="dataTable" width="100%" cellspacing="0">
                                                <thead>
                                                    <tr>
                                                        <th>Name</th>
                                                        <th>Location</th>
                                                        <th>no.of Employee</th>
                                                        <th>Contact</th>
                                                        <th>Email</th>
                                                        <th>Websites_Link</th>
                                                        <th>Action</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <asp:Repeater ID="Repeater1" runat="server">
                                                        <ItemTemplate>
                                                            <tr>
                                                                <td><%# Eval("Name") %></td>
                                                                <td><%# Eval("Location") %></td>
                                                                <td><%# Eval("EmployeeNo") %></td>
                                                                <td><%# Eval("Contact") %></td>
                                                                <td><%# Eval("Email") %></td>
                                                                <td><%# Eval("Website") %></td>
                                                                <td>
                                                                    <asp:LinkButton OnClick="LinkButton1_Click" CssClass="btn btn-primary btn-circle" CommandArgument='<%# Eval("Id") %>' ToolTip="Edit" ID="LinkButton1" runat="server"><i class="fa fa-edit"></i></asp:LinkButton>
                                                                    <asp:LinkButton OnClick="LinkButton2_Click" CssClass="btn btn-success btn-circle" CommandArgument='<%# Eval("Id") %>' ToolTip="Edit" ID="LinkButton2" runat="server"><i class="fa fa-eye"></i></asp:LinkButton>
                                                                    <asp:LinkButton OnClick="LinkButton3_Click" CssClass="btn btn-danger btn-circle" CommandArgument='<%# Eval("Id") %>' ToolTip="Edit" ID="LinkButton3" runat="server"><i class="fa fa-trash"></i></asp:LinkButton>

                                                                </td>

                                                            </tr>
                                                        </ItemTemplate>
                                                    </asp:Repeater>

                                                </tbody>
                                            </table>
                                        </div>
                                    </asp:View>
                                    <asp:View ID="View2" runat="server">
                                        <div class="row">
                                            <div class="col-lg-4">
                                                <div class="form-group">
                                                    <label>Customer Name</label>
                                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-4">
                                                <div class="form-group">
                                                    <label>Location</label>
                                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Location"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-4">
                                                <div class="form-group">
                                                    <label>no.ofEmployee</label>
                                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Qty"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-12">
                                                <div class="form-group">
                                                    <label>Contact</label>
                                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Deatils..."></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-lg-12">
                                                <div class="form-group">
                                                    <label>Email</label>
                                                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" />
                                                </div>
                                            </div>
                                            <div class="col-lg-12">
                                                <div class="form-group">
                                                    <label>Websites_Link</label>
                                                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" />
                                                </div>
                                            </div>
                                        </div>
                                        <asp:LinkButton ID="LinkButton5" runat="server" CssClass="btn btn-primary btn-icon-split" OnClick="LinkButton5_Click">
                        <span class="icon text-white-50">
                            <i class="fa fa-check"></i>
                        </span>
                        <span class="text">Update Info</span>
                                        </asp:LinkButton>

                                        <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-warning btn-icon-split" OnClick="LinkButton4_Click">
                        <span class="icon text-white-50">
                            <i class="fa fa-backward"></i>
                        </span>
                        <span class="text">Back To List</span>
                                        </asp:LinkButton>

                                    </asp:View>
                                    <asp:View ID="View3" runat="server">
                                        <div class="row">
                                            <div class="col-lg-8">
                                                <ul class="list-group">
                                                    <li class="list-group-item"><b>Name&nbsp;:&nbsp;</b><asp:Literal ID="Literal1" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Location&nbsp;:&nbsp;</b><asp:Literal ID="Literal2" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>no.of Employee&nbsp;:&nbsp;</b><asp:Literal ID="Literal3" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Contact&nbsp;:&nbsp;</b><asp:Literal ID="Literal4" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Email&nbsp;:&nbsp;</b><asp:Literal ID="Literal6" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Websites Link&nbsp;:&nbsp;</b><asp:Literal ID="Literal7" runat="server"></asp:Literal></li>


                                                    <li class="list-group-item">
                                                        <asp:LinkButton ID="LinkButton6" runat="server" CssClass="btn btn-warning btn-icon-split" OnClick="LinkButton4_Click">
                        <span class="icon text-white-50">
                            <i class="fa fa-backward"></i>
                        </span>
                        <span class="text">Back To List</span>
                                                        </asp:LinkButton>
                                                    </li>
                                                </ul>
                                            </div>

                                        </div>
                                    </asp:View>
                                    <asp:View ID="View4" runat="server">
                                        <div class="row">
                                            <div class="col-lg-6">
                                                <ul class="list-group">
                                                    <li class="list-group-item">

                                                        <i class="fa fa-exclamation-triangle text-danger fa-2x "></i>&nbsp;Are Your Sure To Delete This?

                                                    </li>

                                                   
                                                    <li class="list-group-item"><b>Company Name&nbsp;:&nbsp;</b><asp:Literal ID="Literal5" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item">
                                                        <asp:LinkButton ID="LinkButton8" runat="server" CssClass="btn btn-danger btn-icon-split" OnClick="LinkButton8_Click">
                        <span class="icon text-white-50">
                            <i class="fa fa-trash"></i>
                        </span>
                        <span class="text">Delete</span>
                                                        </asp:LinkButton>


                                                        <asp:LinkButton ID="LinkButton7" runat="server" CssClass="btn btn-warning btn-icon-split" OnClick="LinkButton4_Click">
                        <span class="icon text-white-50">
                            <i class="fa fa-backward"></i>
                        </span>
                        <span class="text">Back To List</span>
                                                        </asp:LinkButton>
                                                    </li>
                                                </ul>
                                            </div>

                                        </div>
                                    </asp:View>
                                </asp:MultiView>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

