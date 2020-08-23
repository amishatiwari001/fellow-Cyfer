<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="Dashboard_AdminLogin" %>

<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Fello Cyfer - Admin Login</title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/datepicker3.css" rel="stylesheet">
    <link href="css/styles.css" rel="stylesheet">
</head>
<body>
    <div class="row">
        <div class="col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4">
            <h2 class="text-primary text-center">Fello Cyfer: Admin Login</h2>
            <br />
            <div class="login-panel panel panel-default">
                <div class="panel-heading">Log in</div>
                <div class="panel-body">
                    <form role="form" runat="server">
                        <fieldset>
                            <div class="form-group">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="TextBox2" TextMode="Password" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
                            </div>
                            
                            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-primary btn-block" OnClick="Button1_Click1" />
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
        <!-- /.col-->
    </div>
    <script src="js/jquery-1.11.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
