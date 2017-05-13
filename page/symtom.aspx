<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="symtom.aspx.cs" Inherits="page_symtom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
          <center><k1>ระบบการซักประวัติ</k1>
                   <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                  
    <asp:DropDownList ID="DropDownListdiagnose"  ClientIDMode="Static" runat="server" class="form-control input-lg" Height="48px" Width="650px" DataSourceID="SqlDataSource1" DataTextField="Symptom_name" DataValueField="Symptoms_ID"  AutoPostBack="True" AppendDataBoundItems="True" OnSelectedIndexChanged="DropDownListdiagnose_SelectedIndexChanged" >
                      <asp:ListItem>-กรุณาเลือกอาการที่ซักเบื้องต้น-</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT * FROM [Symptoms]"></asp:SqlDataSource></center> 
                    
                        
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <asp:Label ID="lblShow" runat="server" Text="กำลังตรวจสอบ"></asp:Label>
                </ProgressTemplate>
            </asp:UpdateProgress>
</asp:Content>

