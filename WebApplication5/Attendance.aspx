<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="WebApplication5.Attendance" %>
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
    <center>
    <br /><br /><br /><br /><br /><br /><br /><br /><br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    </center>
        <div class="floating" style="padding-left:100px; width: 50%;">
        <asp:Label ID="Label2" runat="server" Text="Course"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Short_Name" DataValueField="Short_Name" AutoPostBack="True" >
        </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT [Short_Name] FROM [MST_Course]"></asp:SqlDataSource>
        <br />
        <br />
        Sem&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class ="floating" style ="width: 50%;" >

        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" DataKeyNames="Student_ID">
            <AlternatingRowStyle BackColor="White" />
             
            <Columns>
                <asp:templatefield HeaderText="Select">
                        <itemtemplate>
                            <asp:checkbox ID="cbSelect" CssClass="gridCB" runat="server"></asp:checkbox>
                        </itemtemplate>
                    </asp:templatefield>
                <asp:BoundField DataField="Student_ID" HeaderText="Student_ID" SortExpression="Student_ID" ReadOnly="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                <asp:BoundField DataField="Current_sem" HeaderText="Current_sem" SortExpression="Current_sem" />
                <asp:BoundField DataField="Classes_Attended" HeaderText="Classes_Attended" SortExpression="Classes_Attended" />
                    <asp:BoundField DataField="Total_Classes" HeaderText="Total_Classes" SortExpression="Total_Classes" />
            </Columns>
             
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT [Student_ID], [Name], [Course], [Current_sem], [Classes_Attended], [Total_Classes] FROM [T16_mst_result] WHERE (([Course] = ?) AND ([Current_sem] = ?))">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Course" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList2" Name="Current_sem" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />

        <asp:Button ID="Button6" runat="server" CssClass="btn" Text="Submit" OnClick="Button6_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    </div>
    </div>
</asp:Content>
