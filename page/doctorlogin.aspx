<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="doctorlogin.aspx.cs" Inherits="page_doctorlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <link href="../css/bootstrap.min.css" rel="stylesheet">
       <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="../css/style.css">

<body>
  <div class="login-page">
  <div class="form">
      <k1>ระบบแพทย์</k1>
      <asp:TextBox ID="txtusername" placeholder="username" runat="server"></asp:TextBox>
         <asp:TextBox ID="txtpassword" placeholder="password" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="login" BackColor="#660033" OnClick="Button1_Click" />
      
      <p class="message">ถ้าไม่มีรหัสผ่านเข้าสู่ระบบโปรดแจ้งกับหัวหน้างาน <asp:LinkButton ID="LinkButton1" runat="server">ลงทะเบียน</asp:LinkButton></p>
    
  </div>
</div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script type="text/javascript" src="../js/index.js"></script>

</body>
</asp:Content>

