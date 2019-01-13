Imports BLL
Imports DAL
Imports LayerEntity
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Partial Class RegistroClientes
    Inherits System.Web.UI.Page
    Dim MiCliente As New LayerEntity.ClsCliente
    Dim BuscarCliente As New DAL.DALCliente
    Dim ModificarCliente As New DAL.DALCliente
    Dim EliminarCliente As New DAL.DALCliente

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Protected Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        MiCliente.ID_Cliente = TXT_IC.Text
        MiCliente.Nombre_C = TXT_NC.Text
        MiCliente.Sexo = TXT_SEXO.Text
        MiCliente.Edad = TXT_EDAD.Text
        MiCliente.Observaciones = TXT_OBS.Text

        Dim bllClientes As New BLL.BllCliente
        If bllClientes.AgregarCliente(MiCliente) Then
            MsgBox("Se agrego Correctamente: " + TXT_NC.Text)
        Else
            MsgBox("Error al agregar")
        End If
    End Sub

    Protected Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        TXT_EDAD.Text = 0
        BuscarCliente.BuscarCliente(TXT_IC.Text, TXT_NC.Text, TXT_SEXO.Text, TXT_EDAD.Text, TXT_OBS.Text)
        MsgBox("Se encontro el cliente")
    End Sub

    Protected Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        ModificarCliente.ModificarCliente(TXT_IC.Text, TXT_NC.Text, TXT_SEXO.Text, TXT_EDAD.Text, TXT_OBS.Text)
        MsgBox("Cliente modificado exitosamente")
    End Sub

    Protected Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        EliminarCliente.EliminarCliente(TXT_IC.Text, TXT_NC.Text, TXT_SEXO.Text, TXT_EDAD.Text, TXT_OBS.Text)
        MsgBox("Cliente eliminado exitosamente")
    End Sub

    Public Sub Limpiar()
        TXT_IC.Text = ""
        TXT_SEXO.Text = ""
        TXT_EDAD.Text = ""
        TXT_NC.Text = ""
        TXT_OBS.Text = ""
    End Sub

    Protected Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        Limpiar()
    End Sub
End Class
