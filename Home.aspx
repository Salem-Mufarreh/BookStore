
<%@ Page Language="C#"MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Home.aspx.cs" Inherits="BookStore.Home" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <!DOCTYPE html>

<html>
<head>
    <title>Home</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    
    <div class="gridHome">

            <asp:Repeater runat="server" ID="repeater1">
                <ItemTemplate>
                        <div class="card cardGridHome ">
                            <input type="hidden" value=<%#DataBinder.Eval(Container,"DataItem.Id") %> />
                            <img class="card-img-top" src="Uploaded/test.jpeg" style="width:20rem;height:17rem;align-self:center" alt="Card image cap" />
                            <div class="card-body">
                                <h5 class="card-title"> <%#DataBinder.Eval(Container,"DataItem.Title") %> </h5>
                                <h6 class="card-subtitle mb-2 text-muted"><%#DataBinder.Eval(Container,"DataItem.Author") %></h6>
                                <br />
                                <p id="status" style="color:white;" class="badge rounded-pill bg-success test"><%#DataBinder.Eval(Container,"DataItem.Status") %></p>
                                <p>In Stock: <%#DataBinder.Eval(Container,"DataItem.Quantity") %></p>
                                <a href="Details.aspx?id=<%#DataBinder.Eval(Container,"DataItem.Id") %> " class="btn btn-secondary" style="width:100%">Details</a>
                                
                                
                                
                                
                                
                            </div>
                        </div>     
                </ItemTemplate>
                              
            </asp:Repeater>
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
 

</body>
</html>
    </asp:Content>
