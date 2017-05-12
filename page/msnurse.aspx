<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="msnurse.aspx.cs" Inherits="page_msnurse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <link rel="stylesheet" href="../css/menuli.css">
               <link rel="stylesheet" href="../css/Style1.css">
                
        <ul class="v_menu" style="float: left; height: 109px;">      
    <li><a href="#">ตารางเวรแพทย์</a></li>  
    <li><a href="queueservicems.aspx">ซักประวติคนไข้</a></li>  
    <li><a href="#">รายงานการวินิจฉัยโรค</a>
         <ul>
            <li><a href="#">ข้อมูลโรครายเดือน</a></li>
            <li><a href="#">ข้อมูลกลุ่มโรครายเดือน</a></li>      
            <li><a href="#">ข้อมูลกลุ่มโรครายรายปี</a></li>                    
        </ul>     
    </li>     
             <li>
                 <asp:LinkButton ID="lbllogout" runat="server" OnClick="lbllogout_Click">ออกจากระบบ</asp:LinkButton></li>  

</ul> 
     <div class="lo">
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
           </a></asp:Content>

