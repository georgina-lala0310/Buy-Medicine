<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectLab.View.Home.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnViewMedicine" runat="server" Text="View Medicine" OnClick="btnViewMedicine_Click" />
            <asp:Button ID="btnProfile" runat="server" Text="View Profile" OnClick="btnProfile_Click" />
            <%--Member--%>
            <asp:Button ID="btnCart" runat="server" Text="View Cart" Visible="false" OnClick="btnCart_Click" />
            <asp:Button ID="btnTransacHistory" runat="server" Text="View Transaction History" Visible="false" OnClick="btnTransacHistory_Click" />
            <%--Admin--%>
            <asp:Button ID="btnInsertMed" runat="server" Text="Insert Medicine" Visible="false"  OnClick="btnInsertMed_Click" />
            <asp:Button ID="btnViewUsers" runat="server" Text="View Users" Visible="false" OnClick="btnViewUsers_Click"/>
            <asp:Button ID="btnViewTransacReport" runat="server" Text="View Transaction Report" Visible="false" OnClick="btnViewTransacReport_Click" />
            
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            <br /><br />
            Recommendations<br />
            <asp:GridView ID="gvMed" runat="server" OnRowDataBound="gvMed_RowDataBound">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnAdd" runat="server" 
                                CommandArgument='<%# Eval("MedicineId") %>' Text="Add to Cart"
                                 OnClick="btnAdd_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            
        </div>
    </form>
</body>
</html>
