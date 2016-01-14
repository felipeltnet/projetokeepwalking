<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCidade.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadCidade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Cidade: "></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
        <asp:Label ID="lblCidade" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="lblAdicionar" runat="server" OnClick="lblAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" style="height: 26px" Text="Alterar" />
        <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
        <br />
        <asp:GridView ID="gdvCidade" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvCidade_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
