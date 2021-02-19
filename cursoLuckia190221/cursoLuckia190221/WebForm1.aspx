<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="cursoLuckia190221.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSheet1.css"  runat="server"  rel="stylesheet" type="text/css" />
    <script src="Scripts/calculadora.js"></script>
    <div class="calculadora">
        <h2>Calculadora Masuo</h2>
        <!--<form accept-charset="UTF-8" >-->
        <div class="pantalla"></div>
        <div class="botonera">
            <div class="complejas">
                <button type=”button”>√</button>
                <button type=”button”>%</button>
                <button type=”button”>x!</button>
                <button type=”button”>^</button>
            </div>
            <div class="operaciones">
                <button type=”button”>+</button>
                <button type=”button”>-</button>
                <button type=”button”>x</button>
                <button type=”button”>÷</button>
                <button type=”button”>=</button>
            </div>
            <div class="numeros">
                <button type=”button”  >9</button>
                <button type=”button”  >8</button>
                <button type=”button”  >7</button>
                <button type=”button”  >6</button>
                <button type=”button”  >5</button>
                <button type=”button”  >4</button>
                <button type=”button”  >3</button>
                <button type=”button”  >2</button>
                <button type=”button”  >1</button>
                <button type=”button”  >0</button>
                <button type=”button”  >.</button>
                <button type=”button”  >C</button>
            </div>
        </div>
        <!--</form>-->
    </div>
</asp:Content>
