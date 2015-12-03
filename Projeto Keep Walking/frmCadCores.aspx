<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCores.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadCores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Cadastro de Cores<br />
        <br />
        Nome da cor:
        <asp:TextBox ID="txtNomeCor" runat="server"></asp:TextBox>
        <asp:Label ID="lblCores" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnCadastrar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
    
        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
        <asp:GridView ID="gdvCores" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvCores_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
