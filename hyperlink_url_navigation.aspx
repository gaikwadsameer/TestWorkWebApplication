<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hyperlink_url_navigation.aspx.cs" Inherits="WebApplication1.hyperlink_url_navigation" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="addresse" HeaderText="addresse" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:HyperLinkField DataNavigateUrlFields="addresse" DataNavigateUrlFormatString="Details.aspx?ID={0}" Text="Details" HeaderText="Details" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
