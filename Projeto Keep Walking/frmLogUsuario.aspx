<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogUsuario.aspx.cs" Inherits="Projeto_Keep_Walking.frmLogUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        E-mail:
        <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Senha:<asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" Width="69px" />
    
    </div>
    </form>
</body>
</html>
