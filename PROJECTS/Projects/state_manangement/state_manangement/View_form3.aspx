<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_form3.aspx.cs" Inherits="state_manangement.View_form3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Server control textbox"></asp:Label>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="html textbox"></asp:Label>
        <p>
            <input id="html_text" type="text" /></p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
