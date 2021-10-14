<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePass.aspx.cs" Inherits="ProjectLab.View.ViewPage.ChangePass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Old password"></asp:Label>
            <asp:TextBox ID="txtOld" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label2" runat="server" Text="New password"></asp:Label>
            <asp:TextBox ID="txtNew" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Label3" runat="server" Text="Confirm password"></asp:Label>
            <asp:TextBox ID="txtConf" runat="server"></asp:TextBox> <br />
            <asp:Button ID="btnChange" runat="server" Text="Button" OnClick="btnChange_Click" /><br /><br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
