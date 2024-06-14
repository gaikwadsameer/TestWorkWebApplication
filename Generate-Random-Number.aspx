<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generate-Random-Number.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGenerate" runat="server" Text="Generate Random Number" OnClick="btnGenerate_Click" />
            <br /><br />
            <asp:Label ID="lblRandomNumber" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
