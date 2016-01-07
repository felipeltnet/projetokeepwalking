<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadRegiao.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadRegiao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Região"></asp:Label>
        :<asp:TextBox ID="txtRegiao" runat="server"></asp:TextBox>
        <asp:Label ID="lblRegiao" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar" OnClick="btnAdicionar_Click1" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click1" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click1" />
    
        <asp:GridView ID="gdvRegiao" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvRegiao_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
