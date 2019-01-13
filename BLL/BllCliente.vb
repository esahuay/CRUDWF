Public Class BllCliente
    Dim MiDalCliente As New DAL.DALCliente

    Public Function AgregarCliente(MiCliente As LayerEntity.ClsCliente) As Boolean
        Return MiDalCliente.AgregarCliente(MiCliente)
    End Function
End Class
