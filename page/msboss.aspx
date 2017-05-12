<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="msboss.aspx.cs" Inherits="page_msboss" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
        <link rel="stylesheet" href="../css/menuli.css">
               <link rel="stylesheet" href="../css/Style1.css">
    <ul class="v_menu" style="float: left; height: 109px;">  
    <li><a href="employee_create.aspx">บันทึกข้อมูลบุคลากร</a></li>   
    <li><a href="check_emp.aspx">ตรวจสอบข้อมูลบุคลากร</a></li>  
    <li><a href="time_work_register.aspx">ตารางงานแพทย์</a></li>  
           <li><asp:LinkButton ID="lbllogout" runat="server" OnClick="lbllogout_Click">ออกจากระบบ</asp:LinkButton></li> 
</ul> 
       <div class="lo1">
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

