<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmNewsLetter.aspx.cs" Inherits="Projeto_Keep_Walking.frmNewsLetter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        E-mail:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:Label ID="lblNewsLetter" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <br />
        <br />
        <asp:GridView ID="gdvNewsLetter" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="gdvNewsLetter_SelectedIndexChanged">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    </form>
</body>
</html>
