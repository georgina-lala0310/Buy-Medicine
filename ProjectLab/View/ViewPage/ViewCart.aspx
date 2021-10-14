<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="ProjectLab.View.ViewPage.ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnHome" runat="server" Text="Home Page" OnClick="btnHome_Click" />
            <asp:GridView ID="gvCart" runat="server" OnRowDataBound="gvCart_RowDataBound" >
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnRemove" runat="server" 
                                CommandArgument='<%# Eval("MedicineId") %>' Text="Remove Item"
                                 OnClick="btnRemove_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
               <%-- <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="lblMedId" runat="server" 
                                Text='<%# Eval("MedicineId") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>--%>
               <%-- <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="lblMedName" runat="server" 
                                Text='<%# Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="lblMedPrice" runat="server" 
                                Text='<%# Eval("Price") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="lblQuantity" runat="server" 
                                Text='<%# Eval("Quantity") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="lblSubtotal" runat="server" 
                                Text='<%# Eval("Sub Total") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>--%>
            </asp:GridView> <br />
            <asp:Label ID="Label1" runat="server" Text="Grand total"></asp:Label>
            <asp:Label ID="lblGrand" runat="server" Text=""></asp:Label> <br /><br />
            <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" /> <br /><br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
