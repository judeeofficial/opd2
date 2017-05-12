<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="Change_time.aspx.cs" Inherits="page_Change_time" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
<center><P2>ระบบเลื่อนเวลาการปฏิบัติงานแพทย์</P2></center>
    <table style="width: 100%;" class="table table-bordered">
           <tr>
            <td class="info" colspan="2">
             <P2>เลือกรายชื่อแพทย์</P2>
              <center> <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="249px" Width="841px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="รายชื่อแพทย์" SortExpression="name" />
                        <asp:BoundField DataField="Date_of_work" HeaderText="วันที่มาปฏิบัติงาน" SortExpression="Date_of_work" />
                        <asp:BoundField DataField="Time_of_work" HeaderText="เวลามาปฏิบัติงาน" SortExpression="Time_of_work" />
                        <asp:BoundField DataField="month" HeaderText="เวรประจำเดือน" SortExpression="month" />
                        <asp:ButtonField CommandName="select" Text="จัดเวรแพทย์" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT Employees.name,time_work.Date_of_work,time_work.Time_of_work,time_work.month
FROM Employees
LEFT JOIN time_work ON time_work.Employees_ID = Employees.Employees_id
WHERE Employees.Job_position = 'แพทย์'
">
                </asp:SqlDataSource></center> 
            </td>

        
        </tr>
      
    </table>
</asp:Content>

