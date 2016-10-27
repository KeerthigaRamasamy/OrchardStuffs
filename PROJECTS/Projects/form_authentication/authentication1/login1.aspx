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
        <p><asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>

        <p>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="RememberMe" runat="server" />
        <p>
            <asp:Button ID="Login" runat="server" OnClick="Login_Click" style="height: 29px" Text="Login" />
            <asp:Label ID="Label3" runat="server" Text="[Label]"></asp:Label>
        </p>
    </form>
</body>
</html>
