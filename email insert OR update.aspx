<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="email insert OR update.aspx.cs" Inherits="WebApplication1.email_insert_OR_update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label2" runat="server" Text="phone"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>mumbai</asp:ListItem>
                <asp:ListItem>pune</asp:ListItem>
                <asp:ListItem>hyd</asp:ListItem>
                <asp:ListItem>blo</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
