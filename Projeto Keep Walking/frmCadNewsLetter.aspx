<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadNewsLetter.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadNewsLetter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        NewsLetter<br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email Origen"></asp:Label>
        :<asp:TextBox ID="txtEmailOrigen" runat="server" Width="203px"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Email Destino"></asp:Label>
        :<asp:TextBox ID="txtEmailDestino" runat="server" Width="194px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Titudo Mensagem"></asp:Label>
        :<asp:TextBox ID="txtTituloMsg" runat="server" Width="170px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Corpo Mensagem"></asp:Label>
        :<asp:TextBox ID="txtCorpoMsg" runat="server" Height="79px" Width="172px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" style="height: 26px" Text="Enviar" />
    
    </div>
    </form>
</body>
</html>
