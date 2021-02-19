<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="cursoLuckia190221.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h1>Insertar Usuarios</h1>
    <div>
        <label for="usuario">Usuario</label>
    </div>
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="nombre">Nombre</label>
    </div>
    <div>
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>
        <div>
        <label for="apellido">Apellido</label>
    </div>
    <div>
         <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </div>
        <div>
        <label for="email">Email</label>
    </div>
    <div>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </div>
        <div>
        <label for="direccion">Direccion</label>
    </div>
    <div>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </div>
        <div>
        <label for="contraseña">Contraseña</label>
    </div>
    <div>
         <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
    </div>

</asp:Content>
