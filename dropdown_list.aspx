<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdown_list.aspx.cs" Inherits="WebApplication1.dropdown_list" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Dropdown Form16 Table</title>
    <style>
        .Form16-table {
            display: none;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <h1>Form16 Table Based on Dropdown</h1>
    <label for="Form16Dropdown">Select a Form16:</label>
    <select id="Form16Dropdown" onchange="showForm16Table()">
        <option value="">--Select--</option>
        <option value="Form16A">Form16 A</option>
        <option value="Form16B">Form16 B</option>
        <option value="Form16C">Form16 C</option>
    </select>

    <%--Form 16A, Form 16B and Form 16C--%>

    <div id="Form16A" class="Form16-table">
        <h2>Form16 A Table</h2>
        <table border="1">
            <tr>
                <th><a href="https://www.Form16.com/">Visit Form16.com!</a></th>
                <th>download</th>
            </tr>
        </table>
    </div>

    <div id="Form16B" class="Form16-table">
        <h2>Form16 B Table</h2>
        <table border="1">
            <tr>
              <th><a href="https://www.Form16.com/">Visit Form16.com!</a></th>
              <th>download</th>
            </tr>
        </table>
    </div>

    <div id="Form16C" class="Form16-table">
        <h2>Form16 C Table</h2>
        <table border="1">
            <tr>
                <th><a href="https://www.Form16.com/">Visit Form16.com!</a></th>
                <th>download</th>
            </tr>
        </table>
    </div>

    <script>
        function showForm16Table() {
            var dropdown = document.getElementById("Form16Dropdown");
            var selectedValue = dropdown.value;

            var tables = document.getElementsByClassName("Form16-table");
            for (var i = 0; i < tables.length; i++) {
                tables[i].style.display = "none";
            }

            if (selectedValue) {
                document.getElementById(selectedValue).style.display = "block";
            }
        }
    </script>
</body>
</html>

