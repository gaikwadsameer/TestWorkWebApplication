<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.user.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamic Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="rptFormElements" runat="server">
            <ItemTemplate>
                <asp:Label ID="lblElement" runat="server" Text='<%# Eval("ElementType") %>'></asp:Label>
                <asp:TextBox ID='TextBox1' runat="server" Visible='<%# Eval("ElementType").ToString() == "TextBox" %>'></asp:TextBox>
                <asp:DropDownList ID='DropDownList1' runat="server" Visible='<%# Eval("ElementType").ToString() == "DropDownList" %>'>
                    <asp:ListItem Text="Option 1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Option 2" Value="2"></asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBox ID='CheckBox1' runat="server" Visible='<%# Eval("ElementType").ToString() == "CheckBox" %>' />
                <asp:RadioButton ID='RadioButton1' runat="server" Visible='<%# Eval("ElementType").ToString() == "RadioButton" %>' GroupName="radioGroup" />
            </ItemTemplate>
        </asp:Repeater>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
