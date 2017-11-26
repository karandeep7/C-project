<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="WebApplication5.Welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .pic {
            height: 188px;
            width: 512px;
            padding-left: 10px;
            padding-bottom: 15px;
        }
        .pic:hover {
            transform: scale(1.1,1.1);
            transform-style: flat;
            transform-origin: inherit;
        }
    </style>
    <div style="background-color: #66029F; color: white; width: 100%; height: auto; box-sizing: border-box;position:inherit; align-content: center;">
        <center>
            <br/><br/><br/><br/><br/><br/>
            <h1> Welcome </h1>
        </center>
        <br/><br/>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="Student" ImageUrl="~/Images/Student.JPG" style="margin-top: 0px" class="pic" PostBackUrl="~/Student.aspx" />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" ToolTip="Session" ImageUrl="~/Images/Session.JPG" class ="pic" PostBackUrl="~/Session.aspx" />

        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton3" runat="server" ToolTip="Faculty" ImageUrl="~/Images/Faculty.JPG"  class ="pic" PostBackUrl="~/Faculty.aspx"/>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton4" runat="server" ToolTip="Course" CssClass="pic" ImageUrl="~/Images/Course.JPG" PostBackUrl="~/Course.aspx" />

    </div>
</asp:Content>
