<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmNewsLetter.aspx.cs" Inherits="Projeto_Keep_Walking.frmNewsLetter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Cadastrar NewsLetter<br />
        <br />
        E-mail:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
    </form>
</body>
</html>
