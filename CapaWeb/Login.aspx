<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100px;
        }
        .auto-style2 {
            width: 131px;
        }
        .auto-style3 {
            width: 364px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style3" rowspan="5">
                        <asp:ValidationSummary ID="ValSumLogin" runat="server" ShowMessageBox="True" ShowSummary="False" />
                    </td>
                    <td colspan="2"><h3>Login</h3></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="LblMensaje" runat="server" Text="Label" Visible="false"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Usuario:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RfvContraseña" runat="server" ErrorMessage="Usuario es obligatorio" ControlToValidate="TxtUsuario">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Contraseña:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RfvPass" runat="server" ErrorMessage="Contraseña es obligatorio" ControlToValidate="TxtPass">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="BtnLogin" runat="server" Text="Login" Width="103px" OnClick="BtnLogin_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
