<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="time_work_register.aspx.cs" Inherits="page_time_work_register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <link href="../css/bootstrap.min.css" rel="stylesheet">
        <link rel="stylesheet" href="../css/menuli.css">
               <link rel="stylesheet" href="../css/Style1.css">
     <center><k1>ระบบจัดการข้อมูลแพทย์</k1></center>
    <ul class="v_menu" style="float: left; height: 109px;">  
 
    <li><a href="register_doctor.aspx">บันทึกข้อมูลแพทย์</a></li>  
          <li><a href="time_work_table.aspx">ตารางงานแพทย์</a></li>  
            <li><a href="Change_time.aspx">เลื่อนวันปฏิบัติงานแพทย์</a></li>  
         
</ul> 
       
      <div >
              <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="304px" NextPrevFormat="FullMonth" Width="1063px" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" >
                  <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                  <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                  <OtherMonthDayStyle ForeColor="#999999" />
                  <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                  <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                  <TodayDayStyle BackColor="#CCCCCC" />
              </asp:Calendar>
            </div>

        <table style="width: 100%;">
        <tr>
          
        </tr>
        <tr>
           
        </tr>
        <tr>
          
        </tr>
                 <tr>
       
        </tr>
        <tr>
           
        </tr>
        <tr>
          
        </tr>
                 <tr>
         
        </tr>
        <tr>
        
        </tr>
        <tr>
        
        </tr>
                 <tr>
         
        </tr>
        <tr>
     
        </tr>
        <tr>
          
        </tr>
    </table>

</asp:Content>

