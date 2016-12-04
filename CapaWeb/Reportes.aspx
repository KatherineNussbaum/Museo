<%@ Page Title="" Language="C#" MasterPageFile="~/Temnplate.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="CapaWeb.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 207px;
        }
        .auto-style2 {
            width: 231px;
            height: 46px;
        }
        .auto-style3 {
            width: 236px;
            height: 46px;
        }
        .auto-style4 {
            height: 46px;
        }
        .auto-style5 {
            width: 214px;
        }
        .auto-style6 {
            width: 100%;
            height: 2px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Reportes</h1>
        <asp:Panel ID="PnlMenu" runat="server">
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1"><asp:Button ID="BtnMenu365" runat="server" Text="Obras del último año" OnClick="BtnMenu365_Click" /></td>
                    <td><asp:Button ID="BtnMenuArtistaObra" runat="server" Text="Obras por Artista" OnClick="BtnMenuArtistaObra_Click" /></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        
        <asp:Panel ID="Pnl365" runat="server" Visible="false">
            <h3>Ingreso de Obras del último año</h3>
            <asp:ObjectDataSource ID="Ods365" runat="server" SelectMethod="ListarObrasCompleto365" TypeName="CapaWeb.ObraCompletoServ.ServicioObraCompletoClient"></asp:ObjectDataSource>
        
            <asp:GridView ID="Obras365" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="Ods365" Width="991px">
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                    <asp:BoundField DataField="FechaIngreso" HeaderText="FechaIngreso" SortExpression="FechaIngreso" />
                    <asp:BoundField DataField="Artista" HeaderText="Artista" SortExpression="Artista" />
                    <asp:BoundField DataField="Estilo" HeaderText="Estilo" SortExpression="Estilo" />
                    <asp:BoundField DataField="Salon" HeaderText="Salon" SortExpression="Salon" />
                    <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
                    <asp:BoundField DataField="Dimensiones" HeaderText="Dimensiones" SortExpression="Dimensiones" />
                    <asp:BoundField DataField="Procedencia" HeaderText="Procedencia" SortExpression="Procedencia" />
                    <asp:BoundField DataField="CuidadosEspeciales" HeaderText="CuidadosEspeciales" SortExpression="CuidadosEspeciales" />
                </Columns>
            </asp:GridView>
        </asp:Panel>

    <asp:Panel ID="PnlArtistaObras" runat="server" Visible="false">
        <h3>Obras por Artista</h3>
        <table class="auto-style6">
            <tr>
                <td class="auto-style2">Eliga Artista para ver sus obras:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DdlArtistas" runat="server" DataSourceID="OdsArtistaObras" DataTextField="NombreCompleto" DataValueField="Rut" Height="16px" Width="272px" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style5"><asp:ObjectDataSource ID="OdsArtistaObras" runat="server" SelectMethod="ListarArtistas" TypeName="CapaWeb.ArtistaServ.ServicioArtistaClient"></asp:ObjectDataSource></td>
                <td class="auto-style4"><asp:ObjectDataSource ID="OdsObrasDeArtista" runat="server" SelectMethod="ListarObrasCompletoArtista" TypeName="CapaWeb.ObraCompletoServ.ServicioObraCompletoClient">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DdlArtistas" Name="rut" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
        </table>

        <asp:GridView ID="GvObrasDeArtista" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="OdsObrasDeArtista" Width="954px">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha Ingreso" SortExpression="FechaIngreso" />
                <asp:BoundField DataField="Estilo" HeaderText="Estilo" SortExpression="Estilo" />
                <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
                <asp:BoundField DataField="Dimensiones" HeaderText="Dimensiones" SortExpression="Dimensiones" />
                <asp:BoundField DataField="Procedencia" HeaderText="Procedencia" SortExpression="Procedencia" />
                <asp:BoundField DataField="Salon" HeaderText="Ubicación" SortExpression="Salon" />
                <asp:BoundField DataField="CuidadosEspeciales" HeaderText="Cuidados Especiales" SortExpression="CuidadosEspeciales" />
            </Columns>
        </asp:GridView>

    </asp:Panel>



</asp:Content>
