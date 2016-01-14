<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEsqueciMinhaSenha.aspx.cs" Inherits="Projeto_Keep_Walking.frmEsqueciMinhaSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
    </form>
</body>
</html>
