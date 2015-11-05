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
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
    
    </div>
    </form>
</body>
</html>
