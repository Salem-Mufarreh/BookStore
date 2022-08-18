<%@ Page Title="Users" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Users.aspx.cs" Inherits="BookStore.Users" %>


<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <% BookStore.Models.LoggedInUser user = (BookStore.Models.LoggedInUser)Session["LoggedInUser"];
        if(user == null || user.Role != BookStore.Models.SD.Admin )
        {
            Response.Redirect(nameof(BookStore.Home));
        }
        %>
    <!DOCTYPE html>
    <link href="https://cdn.datatables.net/1.12.1/css/dataTables.bootstrap5.min.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.css">
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.js"></script>
    <script>
        $(function () {
            $("#MainContent_UserGrid").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
        });
    </script>
<div>
    <br />
    
    <asp:GridView runat="server" ID="UserGrid" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
            <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
            <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
            <asp:BoundField DataField="Active" HeaderText="Active" />
        </Columns>

    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationDBContext %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
</div>
        
</asp:Content>
