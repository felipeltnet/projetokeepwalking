<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPublicidade.aspx.cs" Inherits="Projeto_Keep_Walking.frmPublicidade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="DataInicial: "></asp:Label>
        <asp:TextBox ID="txtDataInicial" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="DataFinal: "></asp:Label>
        <asp:TextBox ID="txtDataFinal" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Valor: "></asp:Label>
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPublicidade" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
        <br />
        <br />
        <asp:GridView ID="gdvPublicidade" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvPublicidade_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
