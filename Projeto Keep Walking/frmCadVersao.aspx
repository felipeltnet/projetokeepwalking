<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadVersao.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadVersao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Versão:"></asp:Label>
        <asp:TextBox ID="txtVersao" runat="server"></asp:TextBox>
        <asp:Label ID="lblVersao" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" style="height: 26px" />
        <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
        <asp:GridView ID="gdvVersao" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvPatrocinador_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
