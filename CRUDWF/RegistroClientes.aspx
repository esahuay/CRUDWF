<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="RegistroClientes.aspx.vb" Inherits="RegistroClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p><H1>REGISTRO CLIENTES</H1>
    <table style="width: 100%;">
        <tr>
            <td style="width: 250px">ID CLIENTE</td>
            <td>
                <asp:TextBox ID="TXT_IC" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 250px">NOMBRE COMPLETO</td>
            <td>
                <asp:TextBox ID="TXT_NC" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 250px">SEXO</td>
            <td>
                <asp:TextBox ID="TXT_SEXO" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 250px">EDAD</td>
            <td>
                <asp:TextBox ID="TXT_EDAD" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 250px">OBSERVACIONES</td>
            <td>
                <asp:TextBox ID="TXT_OBS" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" />
                <asp:Button ID="Btn_Modificar" runat="server" Text="Modificar" />
                <asp:Button ID="Btn_Eliminar" runat="server" Text="Eliminar" />
                <asp:Button ID="Btn_Buscar" runat="server" Text="Buscar" />
                <asp:Button ID="Btn_Limpiar" runat="server" Text="Limpiar" />
            </td>
        </tr>
    </table>
    </p>
    
</asp:Content>

