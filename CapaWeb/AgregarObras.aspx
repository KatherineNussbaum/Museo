<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="AgregarObras.aspx.cs" Inherits="CapaWeb.AgregarObras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 144px;
        }
        .auto-style3 {
            width: 169px;
        }
        .auto-style4 {
            width: 144px;
            height: 26px;
        }
        .auto-style5 {
            width: 169px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Obras</h1>
    <asp:Panel ID="PnlAgregar" runat="server">
        <h3>Agregar Obras de Arte</h3>
        <asp:Label ID="LblMensaje" runat="server" Text="Label" Visible="false"></asp:Label>

        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Código:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtCodigo" runat="server" Width="170px" MaxLength="20"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RfvCodigo" runat="server" ErrorMessage="Código es obligatorio" ControlToValidate="TxtCodigo">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Artista:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DdlArtista" runat="server" Width="170px" DataSourceID="OdsArtistas" DataTextField="NombreCompleto" DataValueField="Rut">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RfvArtista" runat="server" ErrorMessage="Artista es obligatorio" ControlToValidate="DdlArtista">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Estilo:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtEstilo" runat="server" Width="170px" MaxLength="250"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Valor:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtValor" runat="server" TextMode="Number" Width="170px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Procedencia:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtProcedencia" runat="server" Width="170px" MaxLength="250"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Fecha de Ingreso:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtFechaIngreso" runat="server" TextMode="Date" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RfvFechaIngreso" runat="server" ControlToValidate="TxtFechaIngreso" ErrorMessage="Fecha de Ingreso es obligatorio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Ubicación:</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="DdlUbicacion" runat="server" Width="170px" DataSourceID="OdsUbicacion" DataTextField="Salon" DataValueField="Id">
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RfvUbicacion" runat="server" ErrorMessage="Ubicación es obligatorio" ControlToValidate="DdlUbicacion">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Dimensiones:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtDimensiones" runat="server" Height="46px" TextMode="MultiLine" MaxLength="250"></asp:TextBox>
                </td>
                <td rowspan="2">
                    <asp:ObjectDataSource ID="OdsArtistas" runat="server" SelectMethod="ListarArtistas" TypeName="CapaWeb.ArtistaServ.ServicioArtistaClient"></asp:ObjectDataSource>
                    <br />
                    <asp:ObjectDataSource ID="OdsUbicacion" runat="server" SelectMethod="ListarUbicaciones" TypeName="CapaWeb.UbicacionServ.ServicioUbicacionClient"></asp:ObjectDataSource>
                    <br />
                    <asp:ValidationSummary ID="ValSumObras" runat="server" Height="16px" ShowMessageBox="True" ShowSummary="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Cuidados Especiales:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtCuidadosEspeciales" runat="server" Height="52px" TextMode="MultiLine" MaxLength="250"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    
    </asp:Panel>
</asp:Content>
