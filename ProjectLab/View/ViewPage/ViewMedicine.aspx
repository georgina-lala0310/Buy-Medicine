<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMedicine.aspx.cs" Inherits="ProjectLab.View.ViewPage.ViewMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnHome" runat="server" Text="Home Page" OnClick="btnHome_Click" /> <br /><br />
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /> <br /><br />
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
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnInsert" runat="server" 
                                CommandArgument='<%# Eval("MedicineId") %>' Text="Insert"
                                 OnClick="btnInsert_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdate" runat="server" 
                                CommandArgument='<%# Eval("MedicineId") %>' Text="Update"
                                 OnClick="btnUpdate_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" 
                                CommandArgument='<%# Eval("MedicineId") %>' Text="Delete"
                                 OnClick="btnDelete_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
