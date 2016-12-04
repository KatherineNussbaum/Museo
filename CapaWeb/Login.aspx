<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 123px;
        }
        .auto-style2 {
            width: 333px;
        }
        .auto-style3 {
            width: 86px;
        }
        .auto-style4 {
            width: 333px;
            height: 25px;
        }
        .auto-style5 {
            width: 86px;
            height: 25px;
        }
        .auto-style6 {
            width: 123px;
            height: 25px;
        }
        .auto-style7 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3"></td>
                <td class="auto-style1"><h3>Login</h3></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td colspan="3">
                    <asp:Label ID="LblMensaje" Visible="false" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">Usuario:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RfvUsuario" runat="server" ErrorMessage="Usuario es obligatorio" Text="*" ControlToValidate="TxtUsuario"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" rowspan="2">
                    <asp:ValidationSummary ID="ValSumLogin" runat="server" ShowMessageBox="True" ShowSummary="False" />
                </td>
                <td class="auto-style3">Contraseña:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtPass" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RfvPass" runat="server" ErrorMessage="Contraseña es obligatorio" ControlToValidate="TxtPass">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" Width="123px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
