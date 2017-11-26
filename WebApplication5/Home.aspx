<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication5.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        .login {
            width: 374px;
            height: 247px;
            background-color: #111111;
            opacity: 0.8;
            margin-left: 486px;
            margin-top: 22px;
            color: aqua;
            border-radius: 4px;
        }
    </style>
    <title></title>
</head>
<body style="background-image: url('Images/Immagine%20the%20possibilities.JPG'); background-repeat: no-repeat; background-size: cover; height: 460px;">
    <form id="form1" runat="server">
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div class="login" >
        <div>
        <asp:Label ID="Label1" runat="server" Text="Admin Login" Font-Bold="True" Font-Names="Bradley Hand ITC" Font-Size="X-Large" style="font-size: 26pt"></asp:Label>
        
        <br />
            <br />
            <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Names="Bradley Hand ITC" Text="Username" Font-Bold="True"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Bradley Hand ITC" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#33CC33" Font-Bold="True" Font-Names="Bradley Hand ITC" Font-Overline="False" Font-Size="Large" ForeColor="Yellow" Text="Login" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
