<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [tab]"></asp:SqlDataSource>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <%--<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>--%>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"/><br />
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click"/><br />
            <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click"/><br />
        </div>
    </form>
</body>
</html>
