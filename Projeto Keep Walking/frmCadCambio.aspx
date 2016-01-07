<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCambio.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadCambio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label6" runat="server" Text="Tipo de câmbio:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtCambio" runat="server" ></asp:TextBox>
        <asp:Label ID="lblCambio" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnInserir_Click" Text="Adicionar" />
    
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
    
        <br />
        <asp:GridView ID="gdvCambio" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gdvCambio_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
