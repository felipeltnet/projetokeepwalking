<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadUsuario.aspx.cs" Inherits="Projeto_Keep_Walking.frmCadUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Cadastrar Usuario"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="E-mail:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        CPF:<asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
        <br />
        Sexo:<asp:DropDownList ID="txtSexo" runat="server">
            <asp:ListItem>Masculino</asp:ListItem>
            <asp:ListItem>Feminino</asp:ListItem>
        </asp:DropDownList>
        <br />
        Data de Nascimento:<asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>
        &nbsp;obs: DD/MM/AAAA<br />
        Telefone:
        <asp:TextBox ID="txtDDD" runat="server" Width="23px"></asp:TextBox>
        &nbsp;&nbsp; -&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
        <br />
        Cidade:<asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
        <br />
        Estado:<asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <br />
        Endereço:
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        <br />
        Complemento:
        <asp:TextBox ID="txtComplemento" runat="server"></asp:TextBox>
        <br />
        CEP:
        <asp:TextBox ID="txtCEP" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
        &nbsp;<asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" />
&nbsp;<asp:Button ID="btnAlterar" runat="server" Text="Alterar" />
&nbsp;<asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
        <br />
        <br />
        <asp:GridView ID="gdvUsuario" runat="server" AllowPaging="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
