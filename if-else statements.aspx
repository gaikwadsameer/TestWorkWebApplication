<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="if-else statements.aspx.cs" Inherits="WebApplication1.if_else_statements" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample Data Display</title>
    <script runat="server">
        protected string GetOperationText(int value)
        {
            switch (value)
            {
                case 0:
                    return "Yes";
                case 1:
                    return "No";
                case 2:
                    return "Confirm";
                case 3:
                    return "Waiting";
                default:
                    return "Unknown";
            }
        }
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="itemId" HeaderText="itemID" SortExpression="itemID" />
                    <asp:BoundField DataField="itemname" HeaderText="itemname" SortExpression="itemname" />

                    <asp:TemplateField HeaderText="Operation">
                        <ItemTemplate>
                            <%# GetOperationText(Convert.ToInt32(Eval("Deleted"))) %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <%-- <asp:TemplateField HeaderText="Deleted">
                        <ItemTemplate>
                            <%# Eval("Deleted").ToString() == "0" ? "Yes" : "No" %>    -- only yes/no 
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT * FROM items" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
