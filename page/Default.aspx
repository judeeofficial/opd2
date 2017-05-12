<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="page_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="lbllabel1" runat="server"></asp:Label>
    <asp:Button ID="btnNewWindow" Text="Open new Window" runat="server" OnClick="OpenWindow" />
</asp:Content>

