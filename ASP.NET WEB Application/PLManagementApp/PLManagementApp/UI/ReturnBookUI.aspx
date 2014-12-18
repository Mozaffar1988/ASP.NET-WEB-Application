<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBookUI.aspx.cs" Inherits="PLManagementApp.UI.ReturnBookUI" %>

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
                       <asp:TextBox runat="server" ID="memberTextBox"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       
                   </td>
                   <td>
                       <asp:Button runat="server" ID="borrowButton" Text="Show Borrowed Books" OnClick="borrowButton_Click"/>
                   </td>
               </tr>
               <tr>
                   <td>
                       Borrowed BookList
                   </td>
                   <td>
                       <asp:DropDownList runat="server" ID="bookDropDownList" />
                   </td>                 
               </tr>
               <tr>
                   <td></td>
                   <td></td>
                   <td>
                       <asp:Button runat="server" ID="returnButton" Text="Return" OnClick="returnButton_Click"/>
                   </td>
                   <td>
                       <asp:Label runat="server" ID="messageLabel" ></asp:Label>
                   </td>
               </tr>
           </table>
    </div>
    </form>
</body>
</html>
