<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="BookStore.Views.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Signup</title>
    <link type="text/css" rel="stylesheet" href="../Content/Site.css" />
    <script src="https://kit.fontawesome.com/06bbb10d94.js" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Create Account</h1>
        <div class="container">

            <div class="form-container signup-container">
                <div class="social-container">
                    <a href="#"><i class="fab fa-facebook-f"></i></a>
                    <a href="#"><i class="fab fa-google"></i></a>
                    <a href="#"><i class="fab fa-linkedin-in"></i></a>
                </div>
                <span>or use your email address for registration</span>
                <input type="text" id="txtName" runat="server" required="required" placeholder="Name" />
                <input type="email" required="required" runat="server" id="txtEmail" placeholder="Email" />
                <asp:TextBox ID="txtAddress" runat="server" TextMode="SingleLine" placeholder="Address"></asp:TextBox>
                <asp:TextBox runat="server" ID="txtPhone" TextMode="Phone" placeholder="Phone number"/>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="Password"/>
                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" placeholder="Confirm Password"></asp:TextBox>
                <asp:Button Text="Signup" ID="btnSignup" runat="server" />
            </div>

        </div>
    </form>
</body>
</html>
