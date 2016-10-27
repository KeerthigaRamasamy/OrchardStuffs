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
       <tr><td><asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label></td> 
       <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
        <p>
            <td><asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </p>
                </tr>
            <tr>
       <td><asp:CheckBox ID="RememberMe" runat="server" /></td> 
        <p>
            <td><asp:Button ID="Login" runat="server" OnClick="Login_Click" style="height: 29px" Text="Login" /></td>
          <td><asp:Label ID="Label3" runat="server" Text="[Label]"></asp:Label></td>  
        </p>
                </tr>
            </table>
    </form>
</body>
</html>
