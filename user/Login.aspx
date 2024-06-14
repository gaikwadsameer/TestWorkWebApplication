<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.user.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name" Font-Bold="True"
                Width="100px" BackColor="#FFFF66" ForeColor="#FF3300"></asp:Label>
            <asp:TextBox ID="TextBox_user_name" runat="server" ForeColor="#993300" Width="100px"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True"
                Width="100px" BackColor="#FFFF66" ForeColor="#FF3300"></asp:Label>
            <asp:TextBox ID="TextBox_password" runat="server" ForeColor="#CC6600"
                TextMode="Password" Width="100px"></asp:TextBox><br />
            <asp:Button ID="btn_login" runat="server" Text="Login" Font-Bold="True"
                BackColor="#CCFF99" OnClick="btn_login_Click" /><br />
            <asp:Label ID="lb1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        </div>
    </form>
</body>
</html>
