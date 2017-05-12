<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="register_doctor.aspx.cs" Inherits="page_register_doctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <link href="../css/bootstrap.min.css" rel="stylesheet">
   
        <link rel="stylesheet" href="../css/style.css">
    <center><P1>บันทึกข้อมูลแพทย์</P1></center>

      <table class="table table-condensed">
  <tr class="active">
      <td class="active" style="width: 230px">
        <k2>ชื่อแพทย์</k2>  
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
          กลุ่มโรคผู้เชี่ยวชาญ</td>
        <td class="active" style="width: 342px">
            <asp:DropDownList ID="DropDownList1"  class="form-control input-lg" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name_diagnose" DataValueField="Diagnose_group" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"  AppendDataBoundItems="True" >
                              <asp:ListItem>-กรุณาเลือก-</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT [Name_diagnose], [Diagnose_group] FROM [Diagnose_group]"></asp:SqlDataSource>
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
            <asp:TextBox ID="txtpassword" class="form-control"  runat="server" Height="41px" Width="438px" TextMode="Password"></asp:TextBox>
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

