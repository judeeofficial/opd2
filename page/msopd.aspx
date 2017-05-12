<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="msopd.aspx.cs" Inherits="page_msopd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <link href="../css/bootstrap.min.css" rel="stylesheet">
   
        <link rel="stylesheet" href="../css/style.css">
       <center><k1>งานเวชระเบียน</k1></center> 
    <table class="table table-condensed">
      
  <tr class="active">
      <td class="active" style="width: 230px">
        <k2>ชื่อคนไข้</k2>  
      </td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtpatient" class="form-control"  runat="server" Width="255px"></asp:TextBox>
      </td>
         <td class="active" colspan="3">
             <asp:Button ID="btnsurch" runat="server" class="btn btn-default"  Text="ค้นหา" Height="45px" Width="168px" OnClick="btnsurch_Click" />
      </td>
  </tr>
          <tr class="active">
      <td class="active" style="width: 108px" colspan="3">
         <div id="menu">
  <ul>
    <li><a href="../page/patientregister.aspx">กรอกประวัติคนไข้</a></li>

       <li>
           <asp:LinkButton ID="lbllogout" runat="server" OnClick="lbllogout_Click">ออกจากระบบ</asp:LinkButton></li>

   
  </ul>
</div>
         
      </td>
                    <td class="active" style="width: 230px" colspan="3">
                  
                     
                              <asp:GridView ID="GridView1" runat="server" Height="217px" OnRowDataBound="GridView1_RowDataBound" Width="1087px" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderWidth="1px" CellPadding="3" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataSourceID="SqlDataSource1" BorderStyle="None" CellSpacing="2">
                     <Columns>
                          <asp:BoundField DataField="Patient_id" HeaderText="รหัสคนไข้" SortExpression="Patient_id" />
                         <asp:BoundField DataField="NAME" HeaderText="ชื่อคนไข้" SortExpression="NAME" />
                         <asp:BoundField DataField="birthday" HeaderText="วันเดือนปีเกิด" SortExpression="birthday" />
                         <asp:BoundField DataField="belong_to" HeaderText="สังกัด" SortExpression="belong_to" />
                         <asp:BoundField DataField="Address" HeaderText="ที่อยู่" SortExpression="Address" />
                         <asp:BoundField DataField="Tel_working" HeaderText="เบอร์โทรที่ทำงาน" SortExpression="Tel_working" />
                         <asp:BoundField DataField="Age" HeaderText="อายุ" SortExpression="Age" />
                         <asp:BoundField DataField="Tel_myself" HeaderText="เบอร์โทร" SortExpression="Tel_myself" />
                         <asp:ButtonField CommandName="Select" Text="ส่งข้อมูลให้พยาบาล" />
            </Columns>
                            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                            <SelectedRowStyle BackColor="#738A9C" ForeColor="White" Font-Bold="True" />
                            <SortedAscendingCellStyle BackColor="#FFF1D4" />
                            <SortedAscendingHeaderStyle BackColor="#B95C30" />
                            <SortedDescendingCellStyle BackColor="#F1E5CE" />
                            <SortedDescendingHeaderStyle BackColor="#93451F" />
                        </asp:GridView>
           
                       
                     
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT [Patient_id],[NAME], [birthday], [belong_to], [Address], [Tel_working], [Age], [Tel_myself] FROM Patient"></asp:SqlDataSource>
                     
                 
           
                       
                     
      </td>
         
     
  </tr>
          <tr class="active">
              <td>แสดงลำดับของคิว</td>
              <td colspan="3"> <center><asp:ListBox ID="lbltoken" class="form-control" runat="server" Height="107px" Width="543px"></asp:ListBox>
                  <asp:Button ID="Btntoken" runat="server" class="btn btn-default"  Text="สร้างคิวการให้บริการคนไข้" OnClick="Btntoken_Click" />
                  <asp:Label ID="lblstatus" runat="server"></asp:Label>
                  <asp:Button ID="Button1" class="btn btn-default"  runat="server" Text="ลบคิวการให้บริการคนไข้" OnClick="Button1_Click" />
                  </center></td>

          </tr>
                    </table>
</asp:Content>

