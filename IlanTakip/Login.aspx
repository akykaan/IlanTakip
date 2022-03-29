<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IlanTakip.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors" />
    <meta name="generator" content="Hugo 0.88.1" />
    <meta name="theme-color" content="#7952b3" />

    <title>Signin Template · Bootstrap v5.1</title>
    <!-- Bootstrap core CSS -->
    <link href="Ninestars/assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />

    <!-- Favicons -->
    <style>
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

    <!-- Custom styles for this template -->
    <link href="Ninestars\assets\vendor\bootstrap\css\signin.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form id="form1" runat="server">
        <main class="form-signin">
            <h1 class="h3 mb-3 fw-normal">Please sign in</h1>

            <div class="form-floating">
                <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com" />
                <label for="floatingInput">Email address</label>
            </div>
            <div class="form-floating">
                <input type="password" class="form-control" id="floatingPassword" placeholder="Password" />
                <label for="floatingPassword">Password</label>
            </div>

            <div class="checkbox mb-3">
                <label>
                    <input type="checkbox" value="remember-me" />
                    Remember me
                </label>
            </div>
            <asp:Button class="w-100 btn btn-lg btn-primary" ID="SignIn" runat="server" Text="SignIn" OnClick="SignIn_Click" />
            <p class="mt-5 mb-3 text-muted">&copy; 2017–2021</p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </main>
    </form>
</body>
</html>
