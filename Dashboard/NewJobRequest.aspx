<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/MasterPage.master" AutoEventWireup="true" CodeFile="NewJobRequest.aspx.cs" Inherits="Dashboard_NewJobRequest" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="#">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Manage Employee</li>
            </ol>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Employee List</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading">All Employee Details</div>
                    <div class="panel-body">
                        <div class="col-lg-12">
                            <form role="form" runat="server">
                                <asp:MultiView ID="MultiView1" runat="server">
                                    <asp:View ID="View1" runat="server">
                                        <div class="table-responsive">
                                            <table class="table table-bordered table-hover" id="dataTable" width="100%" cellspacing="0">
                                                <thead>
                                                    <tr>
                                                        <th>User</th>
                                                        <th>Name</th>
                                                        <th>Company Name</th>
                                                        <th>Apply For</th>
                                                        <th>Contact</th>
                                                        <th>Email</th>
                                                        <th>Action</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <asp:Repeater ID="Repeater1" runat="server">
                                                        <ItemTemplate>
                                                            <tr>
                                                                <td class="text-center">
                                                                    <img src='<%# Eval("Upload_your_Pic") %>' class="img-circle img-responsive" style="height: 80px; width: 80px" />
                                                                </td>
                                                                <td><%# Eval("Full_Name") %></td>
                                                                <td><%# Eval("Name") %></td>
                                                                <td><%# Eval("Post") %></td>
                                                                <td><%# Eval("Phone") %></td>
                                                                <td><%# Eval("Email") %></td>
                                                                <td>
                                                                    <asp:LinkButton target="_blank" CssClass="btn btn-primary btn-circle" href='<%# Eval("Upload_your_resume") %>' ToolTip="View CV" ID="LinkButton1" runat="server"><i class="fa fa-file-archive-o"></i></asp:LinkButton>
                                                                    <asp:LinkButton OnClick="LinkButton2_Click" CssClass="btn btn-success btn-circle" CommandArgument='<%# Eval("Id") %>' ToolTip="View Complete Details" ID="LinkButton2" runat="server"><i class="fa fa-eye"></i></asp:LinkButton>
                                                                    <asp:LinkButton OnClick="LinkButton3_Click" CssClass="btn btn-warning btn-circle" CommandArgument='<%# Eval("Id") %>' ToolTip="Send Notification SMS" ID="LinkButton3" runat="server"><i class="fa fa-comment"></i></asp:LinkButton>
                                                                </td>
                                                            </tr>
                                                        </ItemTemplate>
                                                    </asp:Repeater>

                                                </tbody>
                                            </table>
                                        </div>
                                    </asp:View>
                                    <asp:View ID="View3" runat="server">
                                        <div class="row">
                                            <div class="col-lg-4">
                                                <ul class="list-group">
                                                    <li class="list-group-item">
                                                        <asp:Image ID="Image1" runat="server" class="img-thumbnail img-responsive" />
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="col-lg-8">
                                                <ul class="list-group">
                                                    <li class="list-group-item"><b>User Name&nbsp;:&nbsp;</b><asp:Literal ID="Literal1" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Apply for Company Name&nbsp;:&nbsp;</b><asp:Literal ID="Literal2" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Apply For&nbsp;:&nbsp;</b><asp:Literal ID="Literal3" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Address &nbsp;:&nbsp;</b><asp:Literal ID="Literal4" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Phone&nbsp;:&nbsp;</b><asp:Literal ID="Literal5" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item"><b>Email&nbsp;:&nbsp;</b><asp:Literal ID="Literal6" runat="server"></asp:Literal></li>
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
                                                        <i class="fa fa-comments-o text-warning fa-2x "></i>&nbsp;Send A Notification To User?
                                                    </li>
                                                    <li class="list-group-item">
                                                        <asp:Image ID="Image2" runat="server" class="img-thumbnail img-responsive" />

                                                    </li>

                                                    <li class="list-group-item"><b>Employee Name&nbsp;:&nbsp;</b><asp:Literal ID="Literal7" runat="server"></asp:Literal></li>
                                                    <li class="list-group-item">
                                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" TextMode="MultiLine" placeholder="Leave a Message"></asp:TextBox>
                                                    </li>
                                                    <li class="list-group-item">
                                                        <asp:LinkButton ID="LinkButton8" runat="server" CssClass="btn btn-primary btn-icon-split" OnClick="LinkButton8_Click">
                        <span class="icon text-white-50">
                            <i class="fa fa-envelope"></i>
                        </span>
                        <span class="text">Send SMS</span>
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


