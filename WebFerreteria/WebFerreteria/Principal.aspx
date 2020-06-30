<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="WebFerreteria.Principal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <table>
              <tr>
                    <td>
                        <asp:Label runat="server" Text="Codigo Producto"></asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtidProducto"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Nombre Herramienta"></asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtNomHerram"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Costo Unitario"></asp:Label></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCostoUnit"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Marca" /></td>
                    <td>
                        <asp:TextBox runat="server" ID="txtMarca"></asp:TextBox></td>
                </tr>
              
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Tipo herramienta" /></td>
                    <td>
                        <asp:DropDownList runat="server" ID="cmbTipoHerramienta">
                            <asp:ListItem Text="casa" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Mecanica" Value="2"></asp:ListItem>
                        </asp:DropDownList></td>
                </tr>

            </table>
        </div>
         <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="btnRegistrar_Click"/>
         <asp:Button ID="Button2" runat="server" Text="Modificar" OnClick="btnModificar_Click"/>
         <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>
    </form>
</body>
</html>
