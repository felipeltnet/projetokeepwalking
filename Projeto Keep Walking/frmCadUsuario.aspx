<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadUsuario.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Cadastrar Usuario"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="E-mail:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
    
    </div>
    </form>
</body>
</html>
