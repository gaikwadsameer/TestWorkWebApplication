<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Encrypt_Decrypt_Password.aspx.cs" Inherits="WebApplication1.Encrypt_Decrypt_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body { font-family: Arial; font-size: 10pt; }
        table { border: 1px solid #ccc; border-collapse: collapse; }
        table th { background-color: #F7F7F7; color: #333; font-weight: bold; }
        table th, table td { padding: 5px; border: 1px solid #ccc; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>Username:</td>
                <td><asp:TextBox ID="txtUsername" runat="server" /></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Submit" /></td>
            </tr>
        </table>
        <hr />
        <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="false" OnRowDataBound="OnRowDataBound">
            <Columns>
                <asp:BoundField DataField="Username" HeaderText="Username" />
                <asp:BoundField DataField="Password" HeaderText="Encrypted Password" />
                <asp:BoundField DataField="Password" HeaderText="Decrypted Password" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
