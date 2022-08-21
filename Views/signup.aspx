<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="BookStore.Views.WebForm2" %>

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
                    <asp:TextBox ID="name_txt" Cssclass="form-control" runat="server" ></asp:TextBox>
                    <label for="floatingInput">Name</label>
                    </div>
                    <div class="form-floating mb-3">
                        <asp:TextBox ID="email_txt" Cssclass="form-control" runat="server"></asp:TextBox>
                        <label for="floatingInput">Email address</label>            
                    </div>
                    <div class="form-floating mb-3">
                        <asp:TextBox ID="phoneNumber_txt" Cssclass="form-control" runat="server"></asp:TextBox>
                        <label for="floatingInput">Phone Number</label>
                    </div>
                    <div class="form-floating mb-3">
                        <asp:TextBox ID="address_txt" Cssclass="form-control" runat="server"></asp:TextBox>
                        <label for="floatingInput">Address</label>
                    </div>

                   <div class="form-floating mb-3">
                        <asp:TextBox ID="password_txt" Cssclass="form-control" runat="server"></asp:TextBox>
                        <label for="floatingInput">Password</label>
                    </div>
                     <div class="d-grid">
                        <asp:Button ID="signup_btn" runat="server" OnClick="signup_Click" Text="SignUp" class="btn btn-primary btn-login text-uppercase fw-bold" />
                    </div>
    </form>
               </div>
        </div>
      </div>
    </div>
  </div>
</body>
</html>
