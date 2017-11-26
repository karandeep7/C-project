<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mastersite_Example.aspx.cs" Inherits="WebApplication5.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .dropdown {
            position: relative;
            display: inline-block;            
        }
        .dropdownbtn {
            background-color: #333333;
            color: #969696;
            font-size: 16px;
            cursor: pointer;
            padding: 5px 16px;
            font-family: Georgia, 'Times New Roman', Times, serif;
            border: none;
        }
        .dropdown-content {
            position: absolute;
            display: none;
            background-color: #9966CB;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.5);
            z-index: 1;
            min-width: 150px;
            color: white;
            opacity: 0.8;
            font-family: 'Monotype Corsiva';
            font-size: 20px;
        }
        .dropdown-content a {
                color: white;
                padding: 12px 16px;
                text-decoration: none;
                display: block;
                border-style: solid;
                border-width: 3px 0 0 0;
                border-top-color: #8C5ABD;
        }
        .dropdown-content a:hover {
            background-color: #A172D2;
            transition: background 0.3s;

        }
        .dropdown:hover .dropdown-content {
            display: block;            
        }
        .dropdown:hover .dropdownbtn {
            background-color: #9966CB;
            color: white;
            transition: background 0.3s;
        }
        .auto-style1 {
            width: 168px;
            height: 56px;
        }
    </style>
</head>
<body style="margin: 0; padding: 0;">
    <form id="form1" runat="server" style=" line-break:loose; margin: 0; padding: 0;">

        <div style="background-color: #333333; border-style: solid;display: inline; border-bottom-color: #9966CB; border-width: 0 0 5px 0;border-top-style:none; border-radius:10px;position: fixed;width: 100%;">
         <div style="background-color: #C63032; border-style: none;" aria-expanded="false" aria-live="off" aria-orientation="horizontal">

             <img alt="GIIT" class="auto-style1" src="Images/logo.jpg" style="border: none; box-sizing:border-box ;left: 0;"/>
             <h2 style="font-family:'Monotype Corsiva'; color:#9966CB;display:inline; margin-top: 0px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ATTENDANCE MANAGEMENT SYSTEM</h2> &nbsp;<center> </center>
            </div>
            <center>
            <div class="dropdown" aria-dropeffect="popup">
                <asp:Button ID="Button3" runat="server" Text="Home" class="dropdownbtn" />
            </div>
            <div class="dropdown" aria-dropeffect="popup" >
                <asp:Button ID="Button1" runat="server" Text="Forms" class="dropdownbtn" />
                <div class="dropdown-content">
                    <a href="WebForm1.aspx">Course Entry</a>
                    <a href="WebForm2.aspx">Session Entry</a>
                    <a href="WebForm3.aspx">Faculty Entry</a>
                </div>
            </div>
            <div class="dropdown" aria-dropeffect="popup">
                <asp:Button ID="Button2" runat="server" Text="Forms" class="dropdownbtn" />
                <div class="dropdown-content">
                    <a href="WebForm1.aspx">Course Entry</a>
                    <a href="WebForm2.aspx">Session Entry</a>
                    <a href="WebForm3.aspx">Faculty Entry</a>
                </div>
            </div>
                <asp:Label ID="Label1" runat="server" Text="Contact us: 0657-6510104, 9798365365" class="dropdownbtn" style="float: right; cursor: default;"></asp:Label>
            </center>
        </div>
        <br />
    </form>
</body>
</html>
