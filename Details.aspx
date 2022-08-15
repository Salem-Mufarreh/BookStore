<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="BookStore.Details" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

    
    
        <div>
            <div class="card">
                <div class="card-header">
                    <asp:Label runat="server" ID="txtName" CssClass="card-title" Font-Size="X-Large">Name</asp:Label>
                    <br />
                    <span>By:</span>
                    <asp:Label ID="txtAuthor" runat="server">Author</asp:Label>
                </div>
                <div class="card-body">
                    <div class="col-sm-3"><img src="Uploaded/test.jpeg" height="220" /></div>

                    <h6 class="card-card-subtitle">ISBN: <asp:Label runat="server" ID="txtISBN">isban</asp:Label></h6>
                    <h6 class="card-card-subtitle">Price: <asp:Label runat="server" ID="txtPrice">100</asp:Label></h6>
                    <div class="card-card-text">
                        <asp:Label runat="server" ID="txtDescription"></asp:Label>
                    </div>
                    <h5>Count:</h5>
                    <asp:TextBox runat="server" ID="txtCount" type="number" min="1" Text="1" />
                </div>
                <div class="card-footer">
                    <div style="float:right">
                    <asp:Button CssClass="btn btn-default" runat="server" ID="btnBack" OnClick="btnBack_Click" Text="BACK TO HOME" ></asp:Button>
                    <asp:Button runat="server" ID="btnCart" CssClass="btn btn-primary"  Text="ADD TO CART"></asp:Button>
                    </div>
                    
                </div>
            </div>
        </div>
    
</asp:Content>