<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="msqueue.aspx.cs" Inherits="page_msqueue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
          <center><k1>รายชื่อคนไข้ในการขอรับบริการ</k1></center> 
    <table style="width: 100%;">
        <tr>
            <td><b>counter 1</b></td>
           <td><b>counter 2</b></td>
         <td><b>counter 3</b></td>
        </tr>
        <tr>
             <td><asp:TextBox ID="txtcounter1" runat="server"></asp:TextBox></td>
              <td><asp:TextBox ID="txtcouter2" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="counter3" runat="server" Width="128px"></asp:TextBox></td>
        </tr>
        <tr>
         <td>
                <asp:Button ID="btncouter1" runat="server" Text="btncouter1" OnClick="btncouter1_Click" />
            </td>
          <td>
                <asp:Button ID="btncouter2" runat="server" Text="Button" OnClick="btncouter2_Click" />
            </td>
            <td>
                <asp:Button ID="btncouter3" runat="server" Text="Button" OnClick="btncouter3_Click" />
            </td>
        </tr>
      
          <tr>
            <td colspan =" 5">
                <asp:TextBox ID="txtdisplay" runat="server" Width="796px"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td colspan =" 5">
                <asp:ListBox ID="listtoken" runat="server"></asp:ListBox>
            </td>
        </tr>
           <tr>
            <td colspan =" 5">
                <asp:Button ID="btntoken" runat="server" Text="Button" OnClick="btntoken_Click" />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </td>
        </tr>
         <tr>
            <td colspan =" 5">
                <asp:Label ID="lblstatus" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
  
</asp:Content>


