<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUI.aspx.cs" Inherits="EmployeeWebApp.EmployeeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            
    </div>
        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server" Width="214px"></asp:TextBox>
        <p>
            <asp:Label ID="Label" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTextBox" runat="server" Width="217px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="addressTextBox" runat="server" Width="198px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label>
            <asp:DropDownList ID="departmentDropDownList" runat="server" Width="221px" AutoPostBack="True" OnSelectedIndexChanged="departmentDropDownList_SelectedIndexChanged">
                
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Department Details"></asp:Label>
            <asp:TextBox ID="detailsTextBox" runat="server" Width="254px" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" Width="96px" />
            <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" Width="96px" />
            <asp:Button ID="editButton" runat="server" OnClick="editButton_Click" Text="Edit" Width="96px"/>
            <asp:Button ID="saveStateButton" runat="server" OnClick="saveStateButton_OnClick" Text="SaveState" Width="96px"/>
        </p>
        
         <p>
            <asp:Label ID="employeeMessage" runat="server" Text=" "></asp:Label>
            
        </p>
    </form>
</body>
</html>
