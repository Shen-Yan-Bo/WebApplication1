<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test2.aspx.cs" Inherits="WebApplication1.test2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/scissors.png" OnClick="Button_Click" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/stone.png" OnClick="Button_Click" />
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/paper.png" OnClick="Button_Click" />
    </br>
    <asp:Label ID="userResult" runat="server"></asp:Label>
    </br>
    <asp:Image ID="computerImage" runat="server" BorderStyle="None" Height="138px" Width="153px" />
    </br>
    <asp:Label ID="computerResult" runat="server"></asp:Label>
    </br>
    <asp:Label ID="final" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </br>
    <asp:Button ID="Logout" runat="server" Text="登出" OnClick="Logout_Click" />
</asp:Content>
