<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="caching.WebForm1" %>
<%@ OutputCache Duration="60" VaryByParam="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <table>
        <tr><td><asp:Label ID="Label1" runat="server" Text="server time"></asp:Label></td>
        <td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
           <td><asp:Label ID="Label2" runat="server" Text="client time"></asp:Label></td> 
           <td> <script> document.write(Date())
                </script></td>
                </tr>
        </table>
    </form>
</body>
</html>
