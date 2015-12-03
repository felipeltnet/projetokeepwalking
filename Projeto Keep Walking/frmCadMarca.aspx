<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadMarca.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadMarca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nome da Marca:"></asp:Label>
        <asp:TextBox ID="txtNomeMarca" runat="server"></asp:TextBox>
        <asp:Label ID="lblMarca" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
    
        <br />
        <asp:GridView ID="gdvMarca" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvMarca_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
