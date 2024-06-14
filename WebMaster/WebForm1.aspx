<%@ Page Title="" Language="C#" MasterPageFile="~/WebMaster/Demo.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebMaster.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--css--%>


    <%--js--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--head--%>
    <div>
    <h2>Change Password</h2>
    <asp:TextBox ID="label_username" runat="server" placeholder="username"></asp:TextBox><br />
    <asp:TextBox ID="textBox_Current" runat="server" TextMode="Password" placeholder="New Password"></asp:TextBox><br />
    <asp:TextBox ID="textBox_New" runat="server" TextMode="Password" placeholder="New Password"></asp:TextBox><br />
    <asp:TextBox ID="textBox_Verify" runat="server" TextMode="Password" placeholder="Confirm Password"></asp:TextBox><br />
    <asp:Button ID="btnChangePassword" runat="server" Text="Change Password"  />
</div>
    <%--main--%>

    <%--footer--%>
</asp:Content>
