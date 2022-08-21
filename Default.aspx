<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookStore._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 

    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        
    </asp:Repeater>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationDBContext %>" SelectCommand="SELECT * FROM [Books]"></asp:SqlDataSource>
 

</asp:Content>
