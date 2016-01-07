<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCategoria.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nome da Categoria:"></asp:Label>
        <asp:TextBox ID="txtNomeCategoria" runat="server"></asp:TextBox>
        <asp:Label ID="lblCategoria" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />

        <asp:GridView ID="gdvCategoria" runat="server" AllowPaging="True" OnSelectedIndexChanged="gdvCategoria_SelectedIndexChanged" AutoGenerateSelectButton="True">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
