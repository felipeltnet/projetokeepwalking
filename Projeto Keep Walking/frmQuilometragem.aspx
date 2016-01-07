<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmQuilometragem.aspx.cs" Inherits="Projeto_Keep_Walking.frmQuilometragem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Quilometragem :"></asp:Label>
        <asp:TextBox ID="txtQuilometragem" runat="server" OnTextChanged="txtQuilometragem_TextChanged" Width="58px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
        <asp:Label ID="lblQuilometragem" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />

        <asp:GridView ID="gdvQuilometragem" runat="server" AllowPaging="True" OnSelectedIndexChanged="gdvCategoria_SelectedIndexChanged" AutoGenerateSelectButton="True">
        </asp:GridView>
    
    </form>
</body>
</html>
