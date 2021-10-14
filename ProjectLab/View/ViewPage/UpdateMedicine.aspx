<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMedicine.aspx.cs" Inherits="ProjectLab.View.ViewPage.UpdateMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnBack" runat="server" Text="Back to View Medicines" OnClick="btnBack_Click" /> <br /><br />
            <h1>Update Medicine</h1><br />
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update Medicine" OnClick="btnUpdate_Click"/><br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
