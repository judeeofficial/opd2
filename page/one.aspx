<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="one.aspx.cs" Inherits="page_one" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:Label ID="Label1" runat="server"></asp:Label>
     <br />
      <asp:RadioButton ID="RadioButton1" GroupName="Groupanswer" runat="server" Text="Yes" />
      <br />
      <asp:RadioButton ID="RadioButton2" GroupName="Groupanswer" runat="server" Text="No" />
      <br />
      <asp:Button ID="Button1" runat="server" Height="30px" Text="Button" Width="343px" OnClick="Button1_Click1" />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <br />
     <br />
     <asp:TextBox ID="TextBox1" runat="server" Width="326px"></asp:TextBox>
     <br />
     <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
     <br />
     <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Symptom_name" DataValueField="Symptoms_ID">
     </asp:DropDownList>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT * FROM [Symptoms]"></asp:SqlDataSource>
     <br />
     <br />
     <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
     <br />
     <br />
</asp:Content>

