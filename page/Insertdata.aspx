<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="Insertdata.aspx.cs" Inherits="page_Insertdata" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <link href="../css/bootstrap.min.css" rel="stylesheet">
   
        <link rel="stylesheet" href="../css/style.css">
       <center><k1>ข้อมูลอาการ</k1></center> 

    <table style="width: 100%;">
        <tr>
            <td>อาการหลัก</td>
            <td>
                <asp:TextBox ID="TextBox1"  class="form-control" runat="server" Width="390px"></asp:TextBox></td>
       
        </tr>
        <tr>
            <td>อาการย่อย</td>
            <td>
                <asp:TextBox ID="TextBox2"  class="form-control" runat="server" Width="391px"></asp:TextBox></td>
       
        </tr>
           <tr>
            <td>Comment อาการ</td>
            <td>
                <asp:TextBox ID="TextBox3"  class="form-control" runat="server" Width="391px"></asp:TextBox></td>
       
        </tr>
        <tr>
            <td>หัวข้ออาการ</td>
            <td>
                <asp:DropDownList ID="DropDownList1" class="form-control input-lg"  runat="server" Width="231px" DataSourceID="SqlDataSource1" DataTextField="Symptom_name" DataValueField="Symptoms_ID"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT * FROM [Symptoms]"></asp:SqlDataSource>
            </td>
       
        </tr>
           <tr>
            <td>โรค</td>
            <td>
                <asp:DropDownList ID="DropDownList2" class="form-control input-lg" runat="server" Width="234px" DataSourceID="SqlDataSource2" DataTextField="Diagnose_name" DataValueField="Diagnose_ID"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT * FROM [Diagnose] Order by Diagnose_name ASC"></asp:SqlDataSource>
               </td>
       
        </tr>
         <tr>
            <td colspan="2">
                <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="บันทึกข้อมูล" OnClick="Button1_Click" /></td>
          
       
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Symptoms_detail_ID" DataSourceID="SqlDataSource3" Height="247px" Width="726px">
                    <Columns>
                        <asp:BoundField DataField="Symptoms_detail_ID" HeaderText="Symptoms_detail_ID" InsertVisible="False" ReadOnly="True" SortExpression="Symptoms_detail_ID" />
                        <asp:BoundField DataField="Symptoms_host" HeaderText="Symptoms_host" SortExpression="Symptoms_host" />
                        <asp:BoundField DataField="Sub_Symtoms" HeaderText="subSymtoms" SortExpression="subSymtoms" />
                        <asp:BoundField DataField="Symptoms_ID" HeaderText="Symptoms_ID" SortExpression="Symptoms_ID" />
                        <asp:BoundField DataField="Diagnose_ID" HeaderText="Diagnose_ID" SortExpression="Diagnose_ID" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT * FROM [Symptoms_detail]"></asp:SqlDataSource>
            </td>
        </tr>   

    </table>


</asp:Content>

