<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dynamic_data.aspx.cs" Inherits="WebApplication1.user.dynamic_data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamic Form</title>
    <script type="text/javascript">
        function addElement() {
            var container = document.getElementById("container");
            var count = container.childElementCount;

            // Create textbox
            var textbox = document.createElement("input");
            textbox.type = "text";
            textbox.id = "txt_" + count;
            textbox.name = "txt_" + count;
            container.appendChild(textbox);

            // Create dropdown
            var dropdown = document.createElement("select");
            dropdown.id = "ddl_" + count;
            dropdown.name = "ddl_" + count;

            var option1 = document.createElement("option");
            option1.value = "Option1";
            option1.text = "Option1";
            dropdown.appendChild(option1);

            var option2 = document.createElement("option");
            option2.value = "Option2";
            option2.text = "Option2";
            dropdown.appendChild(option2);

            container.appendChild(dropdown);


            // Create checkbox
            var checkbox = document.createElement("input");
            checkbox.type = "checkbox";
            checkbox.id = "chk_" + count;
            checkbox.name = "chk_" + count;
            container.appendChild(checkbox);

            // Create radio button
            var radio = document.createElement("input");
            radio.type = "radio";
            radio.id = "rad_" + count;
            radio.name = "radGroup";
            radio.value = count; // Value to identify the radio button
            container.appendChild(radio);


            container.appendChild(document.createElement("br"));
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container"></div>
        <button type="button" onclick="addElement()">Add Element</button>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

        <asp:Repeater ID="Repeater11" runat="server">
            <ItemTemplate>
                <%# Eval("UserName") %> - <%# Eval("Password") %><br />
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
