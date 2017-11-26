<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="WebApplication5.WebForm2" %>

<asp:Content ID="content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <title></title>
    <style>
        .floating {
            box-sizing: border-box;
            width: 50%;
            float: left;
        }
        .btn {
            border-radius: 10px;
        }
        .btn:hover {
            background-color: #FFA500;
            transform: scale(1.1,1.1);
        }
    </style>

    <div style="background-color: #66029F; color: #FFFFFF; width: 100%; height: 100%;">
        <br /><br /><br /><br /><br /><br />
        <center>
            <h1> Session Entry Form </h1> 
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </center>
        <div class="floating" style="padding-left: 200px;">
            <asp:Label ID="Label1" runat="server" Text="Session ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" BackColor="#639B4F" class="btn"/>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Session Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Short Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" BackColor="#639B4F" OnClick="Button5_Click" Text="Done" class="btn" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Start Year"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="End Year"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save" BackColor="#639B4F" class="btn" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Search" BackColor="#639B4F" class="btn" OnClick="Button3_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Update" BackColor="#639B4F" class="btn" OnClick="Button4_Click"/>
            <br />


            <br />
            <br />
        </div>
        <div class="floating">
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>


        </div>
    </div>
 </asp:Content>
