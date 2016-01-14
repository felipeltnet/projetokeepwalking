<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEnviarNewsLetter.aspx.cs" Inherits="Projeto_Keep_Walking.frmEnviarNewsLetter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Email Origin"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmailOrigin" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email Destino"></asp:Label>
        <asp:TextBox ID="txtEmailDestino" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Titulo Mensagem"></asp:Label>
        <asp:TextBox ID="txtTituloMensagem" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Corpo Mensagem:"></asp:Label>
        <asp:TextBox ID="txtCorpoMensagem" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
    
    </div>
    </form>
</body>
</html>
