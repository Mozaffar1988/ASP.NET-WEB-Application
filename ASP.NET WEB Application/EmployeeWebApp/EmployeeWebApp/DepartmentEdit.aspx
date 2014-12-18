<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEdit.aspx.cs" Inherits="EmployeeWebApp.DepartmentEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                   ID
                </td>
                <td>
                    <asp:Label runat="server" ID="deptIdLabel"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                   Name
                </td>
                <td>
                    <asp:TextBox runat="server" ID="editNameTextBox"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                   Details
                </td>
                <td>
                    <asp:TextBox runat="server" ID="editDtailsTextBox"></asp:TextBox>
                </td>
            </tr>
            

            <tr>
                <td>
                    <asp:Button  ID="updateButton" runat="server" OnClick="updateButton_OnClick" Width="96px" Text="Update"/>
                    <asp:Label ID="updateMessage" runat="server" Text=""></asp:Label>
                    
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
