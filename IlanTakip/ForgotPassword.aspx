<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="IlanTakip.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
    <meta name="generator" content="Hugo 0.88.1" />
    <meta name="theme-color" content="#7952b3" />

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#SignIn").click(function () {
                $("#myToast").toast("show");
            });
        });
    </script>
    <title>Signin Template · Bootstrap v5.1</title>

      <!-- Custom styles for this template -->
    <link href="Ninestars\assets\vendor\bootstrap\css\signin.css" rel="stylesheet" />
    <!-- Bootstrap core CSS -->
    <link href="Ninestars/assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />

    <!-- Favicons -->
    <style>
        body{
            justify-content:center;
        }
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <main class="form-signin">
            <h1 class="h3 mb-3 fw-normal">Şifrenini Sıfırlayınız.</h1>

            <div class="form-floating">
                <input type="email" class="form-control" id="Email" placeholder="name@example.com" runat="server" />
                <label for="floatingInput">Email address</label>
            </div>
            <div class="form-floating">
                <input type="password" class="form-control" id="Password" placeholder="Password" runat="server" />
                <label for="floatingPassword">Password</label>
            </div>

            <div class="checkbox mb-3">
                <label>
                    Yeni Şifrenizi Giriniz.
                </label>
            </div>
            <asp:Button class="mt-2 w-100 b" ID="ResetPassword" runat="server" Text="Şifreyi Sıfırla" OnClick="ResetPassword_Click" />

            <p class="mt-5 mb-3 text-muted">&copy; 2017–2021</p>
            <asp:Label class="checkbox mb-3" ID="Label1" runat="server" Text=""></asp:Label>
        </main>
        </div>
    </form>
</body>
</html>
