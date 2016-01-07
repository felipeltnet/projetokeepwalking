<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmOpcionais.aspx.cs" Inherits="Projeto_Keep_Walking.frmOpcionais" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Opcionais"></asp:Label>
        :<asp:TextBox ID="txtOpcionais" runat="server"></asp:TextBox>
        <asp:Label ID="lblOpcionais" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
    
        <asp:GridView ID="gdvOpcionais" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvOpcionais_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
