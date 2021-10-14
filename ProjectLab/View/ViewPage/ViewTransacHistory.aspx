<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransacHistory.aspx.cs" Inherits="ProjectLab.View.ViewPage.ViewTransacHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvTransacHistory" runat="server" OnRowDataBound="gvTransacHistory_RowDataBound">

            </asp:GridView> <br />
            <asp:Label ID="Label1" runat="server" Text="Grand Total"></asp:Label>
            <asp:Label ID="lblGrand" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
