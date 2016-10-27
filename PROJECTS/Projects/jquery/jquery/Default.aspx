<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="jquery._Default" %>
<script>

    </script>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="d1">
        <asp:DropDownList ID="DropDownList1" runat="server" Width="176px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Aqua</asp:ListItem>
            <asp:ListItem>LightGreen</asp:ListItem>
            <asp:ListItem>Light cyan</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
    </div>
</asp:Content>
