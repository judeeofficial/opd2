﻿<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="queueservicems.aspx.cs" Inherits="page_queueservicems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
          <center><k1>ระบบจัดการคิวการรักษา</k1></center> 
   <center> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
 
    <center>   <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="245px" Width="861px" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
              <Columns>
                  <asp:BoundField DataField="sequence_queue" HeaderText="ลำดับการให้บริการ" SortExpression="sequence_queue" />
                  <asp:BoundField DataField="NAME" HeaderText="ชื่อ" SortExpression="NAME" />
                  <asp:BoundField DataField="status_queue" HeaderText="สถานะคิว" SortExpression="status_queue" />
                  <asp:BoundField DataField="date_queue" HeaderText="วันที่รับบริการ" SortExpression="date_queue" />
                  <asp:BoundField DataField="time_queue" HeaderText="เวลาการให้บริการ" SortExpression="time_queue" />
                    <asp:ButtonField Text="คลิกที่นี้เพื่อซักประวัติคนไข้" CommandName="Select" />
            </Columns>
        
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />

        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT queue.sequence_queue,Patient.NAME,queue.status_queue,queue.date_queue,queue.time_queue FROM Patient,queue
WHERE Patient.Patient_id = queue.Patient_id

"></asp:SqlDataSource></center>

   </center>
    <asp:LinkButton ID="lblindex" runat="server" OnClick="lblindex_Click">กลับสู่หน้าแรก</asp:LinkButton>
</asp:Content>

