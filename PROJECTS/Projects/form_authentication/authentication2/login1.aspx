<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login1.aspx.cs" Inherits="form_authentication.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table>
       <tr><td>Username</td> 
       <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
            <td>Password</td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
       <td>&nbsp;</td> 
        </tr>
            <tr>
            <td><asp:Button ID="Login" runat="server" OnClick="Login_Click" style="height: 29px" Text="Login" /></td>
          <td><asp:Label ID="Label3" runat="server" Text="[Label]" ForeColor="Red"></asp:Label></td>  
       
                </tr>
            </table>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 29px" Text="Register" />
        </p>
    </form>
</body>
</html>
