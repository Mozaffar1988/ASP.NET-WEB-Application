<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowUI.aspx.cs" Inherits="PLManagementApp.UI.BorrowUI" %>

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
                    Enter Member No
                </td>
                <td>
                    <asp:TextBox runat="server" ID="memberTexBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Select a Book
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="titleDropDownList" AutoPostBack="True" OnSelectedIndexChanged="titleDropDownList_OnSelectedIndexChanged"/>
                </td>
            </tr>
            <tr>
                <td>
                    Author
                </td>
                <td>
                    <asp:TextBox runat="server" ID="authorTexBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Publisher
                </td>
                <td>
                    <asp:TextBox runat="server" ID="publisherTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button runat="server" ID="borrowButton" Text="Borrow" OnClick="borrowButton_Click"/>
                </td>
                <td>
                    <asp:Label runat="server" ID="messageconfirm"  Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
