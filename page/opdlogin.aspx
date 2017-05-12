<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="opdlogin.aspx.cs" Inherits="page_opdlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <div class="login-page">
  <div class="form">
      <k1>ระบบงานเวชระเบียน</k1>
     <asp:TextBox ID="txtusername" placeholder="username" runat="server"></asp:TextBox>
   <asp:TextBox ID="txtpassword" placeholder="password" runat="server" TextMode="Password"></asp:TextBox>

    <asp:Button ID="btnlogin" runat="server" class="btn btn-primary" Text="login" BackColor="#660033" OnClick="btnlogin_Click" />
      
        <p class="message">ถ้าไม่มีรหัสผ่านเข้าสู่ระบบโปรดแจ้งกับหัวหน้างาน</p>
    
    
  </div>
</div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script type="text/javascript" src="../js/index.js"></script>

</body>
</asp:Content>

