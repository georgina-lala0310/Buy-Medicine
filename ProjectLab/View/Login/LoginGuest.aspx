<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginGuest.aspx.cs" Inherits="ProjectLab.View.LoginGuest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox> <br />
            <asp:Button ID="btnLoginGuest" runat="server" Text="Login" OnClick="btnLoginGuest_Click"/> <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Don't have an account? Sign up as member"></asp:Label>
            <asp:Button ID="btnRegister" runat="server" Text="Sign Up" OnClick="btnRegister_Click"/> <br /><br />
            <asp:CheckBox ID="chRemember" runat="server" />
            <asp:Label ID="Label4" runat="server" Text="Remember Me"></asp:Label><br /><br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
