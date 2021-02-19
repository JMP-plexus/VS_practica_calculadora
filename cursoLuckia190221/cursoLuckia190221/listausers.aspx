<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listausers.aspx.cs" Inherits="cursoLuckia190221.listausers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>table, th, td {
  border: 2px solid red;
    padding: 12px 15px;
}

    </style>
    <h1>Lista de Usuarios</h1>
     <asp:Table id="Table1" 
        GridLines="Both" 
        HorizontalAlign="Center" 
        Font-Names="Verdana" 
        Font-Size="8pt" 
        CellPadding="30" 
        CellSpacing="4" 
        Runat="server"/>
</asp:Content>
