﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadMarca.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadMarca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nome da Marca:"></asp:Label>
        <asp:TextBox ID="txtNomeMarca" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
    
    </div>
    </form>
</body>
</html>