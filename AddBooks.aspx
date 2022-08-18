<%@ Page Title="Insert Book" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AddBooks.aspx.cs" Inherits="BookStore.AddBooks" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/toastr.css" rel="stylesheet" />
    <br />
     <% BookStore.Models.LoggedInUser user = (BookStore.Models.LoggedInUser)Session["LoggedInUser"];
        if(user == null || user.Role != BookStore.Models.SD.Admin )
        {
            Response.Redirect(nameof(BookStore.Home));
        }
        %>
    <%if(Session["Message"] != null)
        {
            BookStore.Models.ToastrNotifications notifications = (BookStore.Models.ToastrNotifications)Session["Message"];
            Response.Write("<script>toastr." + notifications.Type + "('" + notifications.Message + "')</script>");
        } %>
         <div>
                <div class="card">
                    <div class="card-header">
                        <asp:Label runat="server"  CssClass="card-title" Font-Size="X-Large">Insert Book Details</asp:Label>
                        <br />
                    </div>
                    <div class="card-body">
                        <label class="card-subtitle">Title</label><br />
                        <asp:TextBox runat="server" ID="txtTitle" type="Text" placeHolder="Title"></asp:TextBox>
                        <br />
                        <label class="card-subtitle">Author</label><br />
                        <asp:TextBox runat="server" ID="txtAuthor2"  placeHolder="Author"></asp:TextBox>
                        <br />
                        <label class="card-subtitle">Price:</label><br />
                        <asp:TextBox runat="server" ID="txtPrice2" type="number" min="1" />
                        <div class="card-text">
                            <Label class="card-subtitle">Description:</Label><br />
                            <asp:TextBox TextMode="MultiLine" runat="server" ID="txtDescription2"></asp:TextBox>
                        </div>
                        <label>Count:</label><br />
                        <asp:TextBox TextMode="Number" runat="server" ID="txtStock" min="1" value="1"></asp:TextBox>
                        <div>
                            <label class="card-subtitle">Upload Cover</label>
                            <asp:FileUpload  runat="server" ID="Upload" />
                        </div>
                    </div>
                    <div class="card-footer">
                        <div style="float:right">
                        <asp:Button runat="server" ID="btnReset" CssClass="btn btn-danger"  Text="CANCEL" OnClick="btnReset_Click" ></asp:Button>
                        <asp:Button runat="server" ID="btnCart" CssClass="btn btn-primary"  Text="SUBMIT" OnClick="btnCart_Click"></asp:Button>
                        </div>
                        
                    
                    </div>
                </div>
            </div>
    
</asp:Content>
