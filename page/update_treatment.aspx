<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="update_treatment.aspx.cs" Inherits="page_update_treatment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
      <center><k1>บันทึกการรักษา</k1></center> 
    <table style="width: 100%;" class="table table-hover">
        <tr>
            <td class="active">ชื่อคนไข้</td>
            <td class="active"><asp:textbox runat="server" class="form-control"  Width="563px" disabled ID="txtnamepatient"></asp:textbox></td>
         
        </tr>
        <tr>
            <td>ผลที่คาดว่าวินิจฉัยโรค</td>
            <td><asp:textbox runat="server" class="form-control"  Width="563px" disabled ID="txtdiagnose"></asp:textbox></td>
  
          
        </tr>
          <tr>
            <td>วันที่การรักษา</td>
            <td><asp:textbox runat="server" class="form-control"  Width="563px" disabled ID="txtdate"></asp:textbox></td>
          
        </tr>
         <tr>
            <td>บันทึกความคิดเห็นของแพทย์</td>
            <td><asp:textbox runat="server" class="form-control" Width="605px" Height="80px" TextMode="MultiLine" ID="txtarria"></asp:textbox></td>
          
        </tr>

              <tr>
            <td colspan="2">
                <asp:Button ID="btnsubmit" runat="server" class="btn btn-default"  Text="submit" OnClick="btnsubmit_Click" style="width: 83px" />
                  </td>
       
          
        </tr>
    </table>


</asp:Content>

