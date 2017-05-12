<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="page_test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div>
      <asp:Label ID="Label1" runat="server"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <asp:RadioButton ID="RadioButton1" GroupName="Groupanswer" runat="server" Text="Yes" />
      <asp:RadioButton ID="RadioButton2" GroupName="Groupanswer" runat="server" Text="No" />
      <asp:Button ID="Button1" runat="server" Height="30px" Text="Button" Width="343px" OnClick="Button1_Click1" />
      <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </div>
    </form>
</body>
</html>
