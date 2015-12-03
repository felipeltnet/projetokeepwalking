<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadModelo.aspx.cs" Inherits="WebAppExercicio.frmCadModelo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label6" runat="server" Text="Descrição:"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        <asp:Label ID="lblModelo" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnInserir_Click" Text="Adicionar" />
    
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
    
        <br />
        <asp:GridView ID="gdvModelo" runat="server" AllowPaging="True" AutoGenerateSelectButton="True">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
