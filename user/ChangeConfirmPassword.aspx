<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeConfirmPassword.aspx.cs" Inherits="WebApplication1.user.ChangeConfirmPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Change Password</h2>
            <asp:TextBox ID="label_username" runat="server" placeholder="username"></asp:TextBox><br />
            <asp:TextBox ID="textBox_Current" runat="server" TextMode="Password" placeholder="New Password"></asp:TextBox><br />
            <asp:TextBox ID="textBox_New" runat="server" TextMode="Password" placeholder="New Password"></asp:TextBox><br />
            <asp:TextBox ID="textBox_Verify" runat="server" TextMode="Password" placeholder="Confirm Password"></asp:TextBox><br />
            <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnChangePassword_Click" />
        </div>
    </form>
</body>
</html>
