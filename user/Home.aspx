<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.user.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label><br />
        </div>
        <asp:LinkButton ID="lnk_changepassword" runat="server"
            OnClick="lnk_changepassword_Click">Change Password</asp:LinkButton>
    </form>
</body>
</html>
