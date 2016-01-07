<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCombustivel.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadCombustivel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Tipo de combustível:"></asp:Label>
        <asp:TextBox ID="txtCombustivel" runat="server"></asp:TextBox>
        <asp:Label ID="lblCombustivel" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" />
        <br />

        <asp:GridView ID="gdvCombustivel" runat="server" AllowPaging="True" OnSelectedIndexChanged="gdvCategoria_SelectedIndexChanged" AutoGenerateSelectButton="True">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
