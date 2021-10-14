<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMedicine.aspx.cs" Inherits="ProjectLab.View.ViewPage.InsertMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnHome" runat="server" Text="Home Page" OnClick="btnHome_Click"/><br />
            <h1>Insert Medicine</h1><br />
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert Medicine" OnClick="btnInsert_Click"/><br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
