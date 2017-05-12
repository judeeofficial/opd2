<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="employee_create.aspx.cs" Inherits="page_employee_create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <link href="../css/bootstrap.min.css" rel="stylesheet">
   
        <link rel="stylesheet" href="../css/style.css">
    <center><P1>บันทึกข้อมูลบุคลากร</P1></center>

      <table class="table table-condensed">
  <tr class="active">
      <td class="active" style="width: 230px">
        <k2>ชื่อพนักงาน</k2>  
      </td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtempname" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          ที่อยู่</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtaddress" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
     <td class="active" style="width: 230px">
          ตำแหน่ง</td>
        <td class="active" style="width: 342px">
            <asp:DropDownList ID="ddlworktype"  class="form-control" runat="server">
                <asp:ListItem>หัวหน้า</asp:ListItem>
                <asp:ListItem>เจ้าหน้าที่เวชระเบียน</asp:ListItem>
                <asp:ListItem>พยาบาล</asp:ListItem>
            </asp:DropDownList>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          เบอร์โทรศัพท์</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txttelemployees" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          Username</td>
        <td class="active" style="width: 342px">
                 <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="txtName"  class="form-control" runat="server" AutoPostBack="True" 
                        ontextchanged="txtName_TextChanged" Width="443px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtName" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
<br />
                    <asp:Label ID="lblCheck" runat="server"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <asp:Label ID="lblShow" runat="server" Text="กำลังตรวจสอบ"></asp:Label>
                </ProgressTemplate>
            </asp:UpdateProgress>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          Password</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtpassword" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
           
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <k2><asp:Button ID="btnsubmit" runat="server" class="btn btn-default" Text="submit" OnClick="btnsubmit_Click"></asp:Button></k2>  
      </td>
        
        
  </tr>
    </table>

</body>
</asp:Content>

