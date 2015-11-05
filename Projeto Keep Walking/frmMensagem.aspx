<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMensagem.aspx.cs" Inherits="Projeto_Keep_Walking.frmMensagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Assunto :"></asp:Label>
        <asp:TextBox ID="txtAssunto" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Mensagem :"></asp:Label>
        <asp:TextBox ID="txtMensagem" runat="server" Height="18px"></asp:TextBox>
        <br />
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
    

    </div>
    </form>
</body>
</html>
