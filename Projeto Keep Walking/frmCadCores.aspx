<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCores.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadCores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Cadastro de Cores<br />
        <br />
        Nome da cor:
        <asp:TextBox ID="txtNomeCor" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" />
    
    </div>
    </form>
</body>
</html>
