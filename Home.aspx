
<%@ Page Title="Home" Language="C#"MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Home.aspx.cs" Inherits="BookStore.Home" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <!DOCTYPE html>


<br />    
    <div class="gridHome">
        <%if(Session["Message"] !=null)
            {
                BookStore.Models.ToastrNotifications notifications = (BookStore.Models.ToastrNotifications)Session["Message"];
                Response.Write("<script>toastr."+notifications.Type+"('" + notifications.Message + "');</script>");
                notifications = null;
                Session["Message"] =notifications ;
            } %>
        
            <asp:Repeater runat="server" ID="repeater1" DataSourceID="SqlDataSource1">
                
                <ItemTemplate>
                        <div class="card cardGridHome ">
                            <input type="hidden" value=<%#DataBinder.Eval(Container,"DataItem.Id") %> />
                            &nbsp
                            <img class="card-img-top" src="Uploaded/<%#DataBinder.Eval(Container,"DataItem.Title") %>-<%#DataBinder.Eval(Container,"DataItem.Author") %>.jpeg" style="width:20rem;height:17rem;align-self:center" alt="Card image cap" onerror="imgError(this);" />
                            <div class="card-body">
                                <h5 class="card-title"> <%#DataBinder.Eval(Container,"DataItem.Title") %> </h5>
                                <h6 class="card-subtitle mb-2 text-muted"><%#DataBinder.Eval(Container,"DataItem.Author") %></h6>
                                <br />
                                <p id="status" style="color:white;" class="badge rounded-pill bg-success test"><%#DataBinder.Eval(Container,"DataItem.Status") %></p>
                                <p>In Stock: <%#DataBinder.Eval(Container,"DataItem.Quantity") %></p>
                                <a href="Details.aspx?id=<%#DataBinder.Eval(Container,"DataItem.Id") %> " class="btn btn-secondary" style="width:100%">Details</a>
                                
                                <script>
                                    function imgError(image) {
                                        image.onerror = "";
                                        image.src = "/Uploaded/error-image.png";
                                        return true;
                                    }
                                </script>
                                
                                
                                
                            </div>
                        </div>     
                </ItemTemplate>
                              
            </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationDBContext %>" SelectCommand="SELECT * FROM [Books]"></asp:SqlDataSource>
        <script>
            var list = document.getElementsByClassName("test");
            for (let item of list) {
                if (item.innerHTML == "Not Available") {
                    item.classList.remove("bg-success");
                    item.classList.add("bg-danger");
                }
            }

            
        </script>
    </div>
 
    </asp:Content>
