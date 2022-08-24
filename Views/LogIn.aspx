<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="BookStore.Views.WebForm1" MasterPageFile="~/Site.Master" %>



<asp:Content runat="server" ClientIDMode="AutoID" ContentPlaceHolderID="MainContent">
    <link href="../Content/loginCss.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>

   <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card border-0 shadow rounded-3 my-5">
          <div class="card-body p-4 p-sm-5">
            <h5 class="card-title text-center mb-5 fw-light fs-5">Sign In</h5>
                    <div class="form-floating mb-3">
                    <asp:TextBox ID="TextBox1" Cssclass="form-control" runat="server"></asp:TextBox>
                    <label for="floatingInput">Email address</label>
                    </div>

                    <div class="form-floating mb-3">
                    <asp:TextBox ID="TextBox2" class="form-control" TextMode="Password" runat="server"></asp:TextBox>
                    <label for="floatingPassword">Password</label>
                    </div>

                    <div class="form-check mb-3">
                    <input class="form-check-input" type="checkbox" value="" id="rememberPasswordCheck"/>
                    <label class="form-check-label" for="rememberPasswordCheck"> Remember password </label>
                    </div>
                  
                    <div class="d-grid">
                         <%if(Session["Message"] !=null)
                            {
                                BookStore.Models.ToastrNotifications notifications = (BookStore.Models.ToastrNotifications)Session["Message"];
                                Response.Write("<script>toastr."+notifications.Type+"('" + notifications.Message + "');</script>");
                                notifications = null;
                                Session["Message"] =notifications ;
                            } %>
                        
                    <asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button1_Click" class="btn btn-primary btn-login text-uppercase fw-bold"/>
                    </div>
                    
              </div>
        </div>
      </div>
    </div>
  </div>
   
</asp:Content>