<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="Result_diagnose.aspx.cs" Inherits="page_Result_diagnose" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <link href="../css/bootstrap.min.css" rel="stylesheet">
   
        <link rel="stylesheet" href="../css/style.css">
     <center><k1>ผลการวินิจฉัยโรค ของคุณ 
            <asp:Label ID="lblpattient" runat="server"></asp:Label>
            <br />    
          <asp:Label ID="lbldiagnose" runat="server"></asp:Label>
         <br />

       
     </k1>
         <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">ย้อนหลับไปเมนู</asp:LinkButton>
        
</center> 

</asp:Content>

