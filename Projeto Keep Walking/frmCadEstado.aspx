<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadEstado.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadEstado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        id Região:<asp:TextBox ID="txtIdRegiao" runat="server"></asp:TextBox>
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Estado"></asp:Label>
        :<asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <asp:Label ID="lblEstado" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
        <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
        <br />
        <asp:GridView ID="gdvEstado" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvEstado_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
