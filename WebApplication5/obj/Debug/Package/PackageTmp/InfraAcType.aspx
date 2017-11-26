<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InfraAcType.aspx.cs" Inherits="WebApplication5.InfraAcType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
        .floating {
            box-sizing: border-box;
            width: 40%;
            float: left;
        }
        .btn {
            border-radius: 10px;
            background-color: #639B4F;
        }
        .btn:hover {
            background-color: #FFA500;
            transform: scale(1.1,1.1);
        }
    </style>
    <div style="background-color: #66029F; color: #FFFFFF; width: 100%; height: inherit;">
        <br /><br /><br /><br /><br /><br />
        <center>
            <h1> Infrastructure AC Entry Form </h1> 
            <br /> <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
        </center>
        <div class="floating" style="padding-left: 100px; width: 60%;">
            
            <asp:Label ID="Label2" runat="server" Text="AC ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" CssClass="btn" Text="Add" OnClick="Button4_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="AC Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" CssClass="btn" Text="Done" OnClick="Button8_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" CssClass="btn" Text="Save" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" CssClass="btn" Text="Search" OnClick="Button6_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" CssClass="btn" Text="Update" OnClick="Button7_Click" />
            
        </div>
        <div class="floating">
            
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            
        </div>
</asp:Content>
