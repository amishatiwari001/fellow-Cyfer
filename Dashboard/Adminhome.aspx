<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/MasterPage.master" AutoEventWireup="true" CodeFile="Adminhome.aspx.cs" Inherits="Dashboard_Adminhome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="#">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Dashboard</li>
            </ol>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Dashboard</h1>
            </div>
        </div>
        <div class="panel panel-container">
            <div class="row">
                <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
                    <div class="panel panel-teal panel-widget border-right">
                        <div class="row no-padding">
                            <em class="fa fa-xl fa-building color-blue"></em>
                            <div class="large">
                                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                            </div>
                            <div class="text-muted">Total Companies</div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
                    <div class="panel panel-blue panel-widget border-right">
                        <div class="row no-padding">
                            <em class="fa fa-xl fa-briefcase color-orange"></em>
                            <div class="large">
                                <asp:Literal ID="Literal2" runat="server"></asp:Literal>

                            </div>
                            <div class="text-muted">Total Job Post</div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
                    <div class="panel panel-orange panel-widget border-right">
                        <div class="row no-padding">
                            <em class="fa fa-xl fa-comments-o color-teal"></em>
                            <div class="large">
                                <asp:Literal ID="Literal3" runat="server"></asp:Literal>

                            </div>
                            <div class="text-muted">Total Reviews</div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
                    <div class="panel panel-red panel-widget ">
                        <div class="row no-padding">
                            <em class="fa fa-xl fa-file-archive-o color-red"></em>
                            <div class="large">
                                <asp:Literal ID="Literal4" runat="server"></asp:Literal>
                            </div>
                            <div class="text-muted">New Uploaded Cvs</div>
                        </div>
                    </div>
                </div>
            </div>
            <!--/.row-->
        </div>
    </div>
</asp:Content>

