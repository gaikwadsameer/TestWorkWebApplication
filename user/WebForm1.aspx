<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.user.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamic Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div>
                        <label>Phone Number:</label>
                        <asp:TextBox ID="txtPhoneNumber" runat="server" />
                        <label>Degree:</label>
                        <asp:DropDownList ID="ddlDegree" runat="server">
                            <asp:ListItem Value="Bachelors">Bachelors</asp:ListItem>
                            <asp:ListItem Value="Masters">Masters</asp:ListItem>
                            <asp:ListItem Value="PhD">PhD</asp:ListItem>
                        </asp:DropDownList>
                        <label>Gender:</label>
                        <asp:RadioButtonList ID="rblGender" runat="server">
                            <asp:ListItem Value="Male">Male</asp:ListItem>
                            <asp:ListItem Value="Female">Female</asp:ListItem>
                        </asp:RadioButtonList>
                        <label>Employment Status:</label>
                        <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
                        <asp:CheckBox ID="chkPartTime" runat="server" Text="Part Time" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>

