<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="ProjectLab.View.ViewPage.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnHome" runat="server" Text="Home Page" OnClick="btnHome_Click" /> <br /><br />
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:Label ID="lblName" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
            <asp:Label ID="lblGender" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label7" runat="server" Text="Phone"></asp:Label>
            <asp:Label ID="lblPhone" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label9" runat="server" Text="Address"></asp:Label>
            <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label> <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update Profile" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnChange" runat="server" Text="Change Password" OnClick="btnChange_Click" />
        </div>
    </form>
</body>
</html>
