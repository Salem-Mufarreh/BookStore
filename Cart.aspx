<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="BookStore.Cart" MasterPageFile="~/Site.Master" %>

<asp:Content ClientIDMode="AutoID" ContentPlaceHolderID="MainContent" runat="server">
    <script src="https://kit.fontawesome.com/06bbb10d94.js" crossorigin="anonymous"></script>
    <link href="Content/CartStyleSheet.css" rel="stylesheet" />
    <div class="header">
        <h2><i class="fa-solid fa-bag-shopping"></i>My Cart</h2>
    </div>
    <div class="row">
        <div class="col-lg-8">
            <hr />
            <div class="cardItems">
                <asp:Repeater runat="server" ID="Repeater1">
                    <ItemTemplate>
                        <div class="row">
                            <div class="col">
                                <img src="Uploaded/error-image.png" alt="Alternate Text" />
                            </div>
                            <div class="col cardItem">
                                <asp:Label Text="Titasbdmasbdhadaghasdgbhjadle" ID="labelTitle" runat="server" />
                                <asp:Label Text="Author" ID="labelAuthor" runat="server" />
                                <asp:Label Text="In Stock" ID="labelStock" runat="server" />
                            </div>
                            <div class="col-2 cardItem">
                                <asp:Label Text="Quantity" runat="server" />
                                <asp:TextBox TextMode="Number" runat="server" minValue="1" value="1"></asp:TextBox>
                            </div>
                            <div class="col cardItem">
                                <asp:Label Text="Total" runat="server" />
                                <asp:Label Text="$320" ID="labelTotal" runat="server" />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>


            </div>

        </div>
        <div class="col-1">
        </div>
        <div class="col">
            <hr />
            <div class="cardItem">
                <asp:Label Text="Add PromoCode" runat="server" />
            </div>
            <div class="row">
                <div class="col" style="padding-left: 1rem; padding-right: 0;">
                    <asp:TextBox runat="server" CssClass="promo" />
                </div>
                <div class="col" style="padding: 0">
                    <asp:Button Text="text" runat="server" CssClass="btn btn-dark btnPromo" />
                </div>
            </div>
            <div class="ChecoutItems">
                <label>Shipping Coast</label>
                <asp:Label Text="12$" runat="server" />
            </div>
            <div class="ChecoutItems">
                <label>Discount</label>
                <asp:Label Text="-0$" runat="server" />
            </div>
            <div class="ChecoutItems">
                <label>Tax</label>
                <asp:Label Text="12$" runat="server" />
            </div>
            <div class="ChecoutItems">
                <label>Total</label>
                <asp:Label Text="120$" runat="server" />
            </div>
            <div>
                <asp:Button Text="Checkout" runat="server" CssClass="btn btn-warning btnCheckout" ForeColor="white" />
            </div>
        </div>
    </div>


</asp:Content>

