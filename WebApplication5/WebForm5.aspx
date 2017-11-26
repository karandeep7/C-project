<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication5.WebForm5" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
         <center>
         <br/><br/><br/><br/><br/><br/><br/><br/><br/>
           hey there
             <br />
             <br />
             <asp:Label ID="Label2" runat="server" Text="Designation"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Desig_Name" DataValueField="Desig_Name" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
             </asp:DropDownList>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [Desig_Name] FROM [T09_mst_facultydesig]"></asp:SqlDataSource>
             <asp:EntityDataSource ID="EntityDataSource1" runat="server">
             </asp:EntityDataSource>
         </center>
     </div>
</asp:Content>
