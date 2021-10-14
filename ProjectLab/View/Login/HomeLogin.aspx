<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeLogin.aspx.cs" Inherits="ProjectLab.View.LoginGeneral" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login for Administrator"></asp:Label>
            <asp:Button ID="btnLoginAdmin" runat="server" Text="Click Here for Admin" OnClick="btnLoginAdmin_Click"/> <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Login for Member"></asp:Label>
            <asp:Button ID="btnLoginMember" runat="server" Text="Click Here for Member" OnClick="btnLoginMember_Click"/> <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Login for Guest"></asp:Label>
            <asp:Button ID="btnLoginGuest" runat="server" Text="Click Here for Guest" OnClick="btnLoginGuest_Click"/> <br /><br />
        </div>
    </form>
</body>
</html>
