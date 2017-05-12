<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="save_time.aspx.cs" Inherits="page_save_time" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
      <center><k1>จัดเวรแพทย์ประจำเดือน <asp:Label ID="lblmonth" runat="server"></asp:Label></k1>
</center> 
        <table style="width: 100%;" class="table table-bordered">
      <tr>
            <td class="info">ชื่อแพทย์</td>
      <td class="info">
          <asp:TextBox ID="txtdoctor"  class="form-control" disabled  runat="server" Width="451px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="info">วันที่ปฏิบัติงาน</td>
    <td class="info">   <asp:ImageButton ID="btbirthday" runat="server" Height="77px" ImageUrl="~/image/image3.png" Width="88px" OnClick="btbirthday_Click" />
            <asp:Label ID="lblwork" runat="server"></asp:Label>
            <asp:Calendar id="Calendarbirthday" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendarbirthday_SelectionChanged" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar></td>
        </tr>
        <tr>
            <td class="info">ช่วงเวลาในการปฏิบัติงาน</td>
     <td class="info">
                  <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
         <asp:DropDownList ID="DropDownList1"  class="form-control"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
             <asp:ListItem>กรุณาเลือกเวลา</asp:ListItem>
             <asp:ListItem>8.30-11.30</asp:ListItem>
             <asp:ListItem>11.30-13.00</asp:ListItem>
             <asp:ListItem>13.00-15.30</asp:ListItem>
             <asp:ListItem>15.30-16.30</asp:ListItem>
         </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
<br />
                    <asp:Label ID="lblCheck" runat="server"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <asp:Label ID="lblShow" runat="server" Text="กำลังตรวจสอบ"></asp:Label>
                </ProgressTemplate>
            </asp:UpdateProgress>
                    </td>
        </tr>
          <tr>
            <td class="info" colspan="2">
                <asp:Button ID="btnsubmit" class="btn btn-default" runat="server" Text="Submit" Width="238px" OnClick="btnsubmit_Click" /></td>

        </tr>
                  
    </table>
</asp:Content>

