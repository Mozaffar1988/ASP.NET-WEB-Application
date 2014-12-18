<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUI.aspx.cs" Inherits="StudentDepartmentApp.UI.EmployeeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First ASP.NET App</title>
    <link href="../CSS/reset.css" rel="stylesheet" />
    <link href="../CSS/style.css" rel="stylesheet" />
</head>
<body>
    <div class="wrapper">
        <header>
            <h1> First Web&nbsp; Application</h1>
        </header>
        <form id="form1" runat="server">
        <div class="box">
            <div class="text1">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>               
            </div>
            <div class="colon">
                <asp:Label ID="Label2" runat="server" Text=":"></asp:Label>
            </div>
            <div class="box1">
                <asp:TextBox ID="nameTextBox" runat="server" Width="188px"></asp:TextBox>
            </div>
            
            <div class="text1">
                <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>              
            </div>
            <div class="colon">                
                <asp:Label ID="Label9" runat="server" Text=":"></asp:Label>                
            </div>
            <div class="box1">                
                <asp:TextBox ID="emailTextBox" runat="server" Width="188px"></asp:TextBox>
            </div>
            
            <div class="text1">                            
                <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>                            
            </div>
            <div class="colon">
                <asp:Label ID="Label8" runat="server" Text=":"></asp:Label>
            </div>
            <div class="box1">                
                <asp:TextBox ID="addressTextBox" runat="server" Width="188px"></asp:TextBox>                
            </div>
            
            <div class="text1">
                <asp:Label ID="Label10" runat="server" Text="Department"></asp:Label>
            </div>
            <div class="colon">
                <asp:Label ID="Label12" runat="server" Text=":"></asp:Label>
            </div>
            <div class="box1"><asp:DropDownList runat="server" ID="departmentDropDownList" AutoPostBack="True" OnSelectedIndexChanged="departmentDropDownList_SelectedIndexChanged"></asp:DropDownList></div> 
            
            <div class="text1">
                <asp:Label ID="Label11" runat="server" Text="Department Details"></asp:Label>
            </div>
            <div class="colon">
                <asp:Label ID="Label13" runat="server" Text=":"></asp:Label>
            </div>
            <div class="box1">
                <asp:TextBox ID="detailsTextBox" runat="server" Width="188px"></asp:TextBox>
            </div>
            
            <br />
            
            <div class="button">
                <asp:Button ID="saveButton" runat="server" BackColor="#FF9900" BorderColor="Red" Font-Bold="True" Font-Size="Medium" ForeColor="#6600FF" Text="Save" Width="83px" OnClick="saveButton_Click" />
            </div>
            
            <div class="button">
                <asp:Button ID="showButton" runat="server" BackColor="Lime" BorderColor="#00CC00" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000"  Text="Show" Width="96px" OnClick="showButton_Click" />
            </div>
             <div class="button">
                <asp:Button ID="editButton" runat="server" BackColor="Lime" BorderColor="#00CC00" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000"  Text="Edit" Width="96px" OnClick="editButton_Click" />
            </div>
            
             <div class="button">
                <asp:Button ID="saveStateButton" runat="server" BackColor="Lime" BorderColor="#00CC00" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000"  Text="SaveState" Width="96px" OnClick="saveStateButton_Click" />
            </div>

            <div class="button"><asp:Label ID="employeeMessage" runat="server" Text="" ></asp:Label></div>
        </div>
        </form>
       
    </div>
</body>
</html>
