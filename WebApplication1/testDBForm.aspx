<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testDBForm.aspx.cs" Inherits="WebApplication1.testDBForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:accountConnectionString %>" SelectCommand="SELECT * FROM [accountInfomation]"></asp:SqlDataSource>
    </form>
</body>
</html>
