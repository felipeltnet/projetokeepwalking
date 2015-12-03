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
        <asp:Label ID="lblMensagem" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click1" Text="Adicionar" />
        <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
        <asp:GridView ID="gdvMensagem" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <br />
    

    </div>
    </form>
</body>
</html>
