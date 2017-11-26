<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="WebApplication5.Practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Student_ID" DataSourceID="SqlDataSource1">
            <Columns>
                 <asp:templatefield HeaderText="Select">
                        <itemtemplate>
                            <asp:checkbox ID="cbSelect" CssClass="gridCB" runat="server"></asp:checkbox>
                        </itemtemplate>
                    </asp:templatefield>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Student_ID" HeaderText="Student_ID" ReadOnly="True" SortExpression="Student_ID" />
                <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                <asp:BoundField DataField="Current_sem" HeaderText="Current_sem" SortExpression="Current_sem" />
                 
                <asp:BoundField DataField="Classes_Attended"  HeaderText="Classes_Attended" SortExpression="Classes_Attended" />
                <asp:BoundField DataField="Total_Classes" HeaderText="Total_Classes" SortExpression="Total_Classes" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT [Name], [Student_ID], [Course], [Current_sem], [Classes_Attended], [Total_Classes] FROM [T16_mst_result]"></asp:SqlDataSource>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
