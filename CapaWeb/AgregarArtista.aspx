<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="AgregarArtista.aspx.cs" Inherits="CapaWeb.AgregarArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 92px;
        }
        .auto-style5 {
            width: 8px;
        }
        .auto-style6 {
            width: 130px;
        }
        .auto-style9 {
            width: 130px;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
        .auto-style11 {
            width: 6px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artistas</h1>
    <asp:Panel ID="PnlAgregar" runat="server">
        <h3>Agregar Artista</h3>
        <asp:Label ID="LblMensaje" runat="server" Text="Label" Visible="false"></asp:Label>


        <table style="width: 100%;">
            <tr>
                <td class="auto-style6">Rut:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtRut" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style5">-</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TxtDv" runat="server" Width="16px" MaxLength="1"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RdfRut" runat="server" ControlToValidate="TxtRut" ErrorMessage="Rut es obligatorio">*</asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RdfDv" runat="server" ControlToValidate="TxtDv" ErrorMessage="Digito Verificador es obligatorio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Nombres:</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtNombres" runat="server" Width="160px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RdfNombres" runat="server" ControlToValidate="TxtNombres" ErrorMessage="Nombres es obligatorio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Apellido Paterno:</td>
                <td colspan="3" class="auto-style10">
                    <asp:TextBox ID="TxtApPaterno" runat="server" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:RequiredFieldValidator ID="RdfApPaterno" runat="server" ControlToValidate="TxtApPaterno" ErrorMessage="Apellido Paterno es obligatorio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Apellido Materno:</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtApMaterno" runat="server" Width="160px"></asp:TextBox>
                </td>
                <td rowspan="7">
                    <asp:ValidationSummary ID="ValSumObligatorios" runat="server" Height="24px" ShowMessageBox="True" ShowSummary="False" Width="201px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Sexo:</td>
                <td colspan="3">
                    <asp:RadioButton ID="RdbFemenino" runat="server" Text="Femenino" GroupName="Sexo" />
                    <asp:RadioButton ID="RdbMasculino" runat="server" Text="Masculino" GroupName="Sexo" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Fecha Nacimiento:</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtFechaNacimiento" runat="server" TextMode="Date" Width="160px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Domicilio:</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtDomicilio" runat="server" Height="39px" TextMode="MultiLine" Width="162px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Fono:</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtFono" runat="server" Width="160px" TextMode="Phone"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">E-mail:</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtEmail" runat="server" Width="160px" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td colspan="3">
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>

</asp:Content>
