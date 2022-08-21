<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="BookStore.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/loginCss.css" rel="stylesheet" />
    <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">
</head>
<body>
   <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card border-0 shadow rounded-3 my-5">
          <div class="card-body p-4 p-sm-5">
            <h5 class="card-title text-center mb-5 fw-light fs-5">Sign In</h5>
                <form id="form1" runat="server">
                    <div class="form-floating mb-3">
                    <asp:TextBox ID="TextBox1" Cssclass="form-control" runat="server"></asp:TextBox>
                    <label for="floatingInput">Email address</label>
                    </div>

                    <div class="form-floating mb-3">
                    <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>
                    <label for="floatingPassword">Password</label>
                    </div>

                    <div class="form-check mb-3">
                    <input class="form-check-input" type="checkbox" value="" id="rememberPasswordCheck"/>
                    <label class="form-check-label" for="rememberPasswordCheck"> Remember password </label>
                    </div>
                  
                    <div class="d-grid">
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" class="btn btn-primary btn-login text-uppercase fw-bold"/>
                    </div>
                    
                </form>
              </div>
        </div>
      </div>
    </div>
  </div>
   
</body>
</html>
