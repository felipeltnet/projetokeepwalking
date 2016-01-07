﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCambio.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadCambio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Tipo de Câmbio"></asp:Label>
        <asp:TextBox ID="txtCambio" runat="server"></asp:TextBox>
        <asp:Label ID="lblCambio" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
        <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
        <br />
        <br />
        <asp:GridView ID="gdvCambio" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvModelo_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
