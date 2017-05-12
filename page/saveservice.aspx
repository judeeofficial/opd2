<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="saveservice.aspx.cs" Inherits="page_saveservice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">

        <center>
            <k1>บันทึกการรักษา/ตรวจสอบประวัติการรักษา</k1></center>

    
    <table class="table table-condensed">
      
  <tr class="active">

      <td class="active" style="width: 230px">
        <k2>ชื่อคนไข้</k2>  
      </td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="TextBox1" class="form-control"  runat="server" Height="29px" Width="514px"></asp:TextBox>
      </td>
         <td class="active" colspan="3">
             <asp:Button ID="btnsurch" runat="server" class="btn btn-default"  Text="ค้นหา" Height="45px" Width="168px" />
      </td>
  </tr>
          <tr class="active">
     <!--   <td class="active" style="width: 230px" colspan="3">
       <div id="menu">
  <ul>
    <li><a href="../page/patientregister.aspx">กรอกประวัติคนไ</a>ช</li>


   
  </ul>
         
</div> 
      </td>-->
                    <td class="active" style="width: 230px" colspan="3">
                        ตรวจสอบข้อมูลผลอาการที่คาดว่าจะป่วย
                        <center>   <asp:GridView ID="GridView1" runat="server" CellPadding="3" GridLines="Vertical" Height="245px" Width="861px" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
        <AlternatingRowStyle BackColor="#DCDCDC" />
              <Columns>
                  <asp:BoundField DataField="NAME" HeaderText="ชื่อคนไข้" SortExpression="NAME" />
                  <asp:BoundField DataField="Diagnose_name" HeaderText="ผลที่คาดว่าจะเป็นโรค" SortExpression="Diagnose_name" />
                  <asp:BoundField DataField="sequence_queue" HeaderText="ลำดับคิว" SortExpression="sequence_queue" />
                  <asp:BoundField DataField="Treatment_Date" HeaderText="วันที่การรักษา" SortExpression="Treatment_Date" />
                  <asp:BoundField DataField="Comment" HeaderText="ความคิดเห็นของแพทย์ผู้ทำการรักษา" SortExpression="Comment" />
                    <asp:ButtonField CommandName="select" Text="ส่งข้อมูลสรุป" />
            </Columns>
        
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />

        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>

      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT Patient.NAME,Diagnose.Diagnose_name,Queue.sequence_queue,Treatment.Treatment_Date,Treatment.Comment 
FROM Patient
INNER JOIN Treatment ON Treatment.Patient_id = Patient.Patient_id 
INNER JOIN Diagnose ON Diagnose.Diagnose_ID= Treatment.Diagnose_ID
INNER JOIN Queue ON Patient.Patient_id = Queue.Patient_id;"></asp:SqlDataSource></center>
        
      </td>
     
  </tr>

         <tr class="active">

      <td class="active" style="width: 230px" colspan="3">
          <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1">กลับมาหน้าแรก</asp:LinkButton>
      </td>
     
  </tr>
    </table>
</asp:Content>

