<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogUsuario.aspx.cs" Inherits="Projeto_Keep_Walking.frmLogUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>
        :
        <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Email"></asp:TextBox>
&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Senha"></asp:Label>
&nbsp;:<asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Entrar" />
    
    </div>
    </form>
</body>
</html>
