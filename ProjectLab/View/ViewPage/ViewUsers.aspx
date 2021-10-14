<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="ProjectLab.View.ViewPage.ViewUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnHome" runat="server" Text="Home Page" OnClick="btnHome_Click" /> <br /><br />
             <asp:GridView ID="gvUsers" runat="server" OnRowDataBound="gvUsers_RowDataBound">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDel" runat="server" 
                                CommandArgument='<%# Eval("UserId") %>' Text="Delete User"
                                 OnClick="btnDel_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
             </asp:GridView>
        </div>
    </form>
</body>
</html>
