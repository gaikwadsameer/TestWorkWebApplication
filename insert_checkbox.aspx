<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert_checkbox.aspx.cs" Inherits="WebApplication1.insert_checkbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>Name:
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Ready to relocate:
                </td>
                <td>
                    <asp:CheckBox ID="chkRelocate" runat="server" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button Text="Submit" runat="server" OnClick="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
