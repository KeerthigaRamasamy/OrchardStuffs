<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="authentication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     
    <form id="form1" runat="server">
        <table>
        <tr>
       <td> UserName</td>
       <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        
        </tr>
            <tr>
       <td>Password</td> 
          <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td> 
        </tr>
            <tr>
           <td> ConfirmPassword</td>
      <td> <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td> 
        </tr>
        
          </table>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" style="height: 29px" />
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Label"></asp:Label>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="UserName is required" BorderColor="Red" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Confirm password is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
    </form>
       
</body>
</html>
