<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.user.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Repeater Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater10" runat="server">
                <HeaderTemplate>
                    <table border="1">
                        <tr>
                            <th>TextBox</th>
                            <th>Dropdown</th>
                            <th>RadioButton</th>
                            <th>Checkbox</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("TextBoxValue") %>'></asp:TextBox>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Value="Option1" Text="Option 1"></asp:ListItem>
                                <asp:ListItem Value="Option2" Text="Option 2"></asp:ListItem>
                                <asp:ListItem Value="Option3" Text="Option 3"></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem Value="Yes" Text="Yes"></asp:ListItem>
                                <asp:ListItem Value="No" Text="No"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Full Time" />
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Part Time" />
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert Data" OnClick="btnInsert_Click" />
        </div>
    </form>
</body>
</html>

