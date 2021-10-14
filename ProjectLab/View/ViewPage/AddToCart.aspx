<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="ProjectLab.View.ViewPage.AddToCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label>
            <asp:Label ID="lblName" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label2" runat="server" Text="Description : "></asp:Label>
            <asp:Label ID="lblDesc" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label3" runat="server" Text="Stock : "></asp:Label>
            <asp:Label ID="lblStock" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label4" runat="server" Text="Price : "></asp:Label>
            <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label5" runat="server" Text="Quantity you want to buy"></asp:Label> 
            <asp:TextBox ID="txtSum" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add to Cart" OnClick="btnAdd_Click" /><br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
