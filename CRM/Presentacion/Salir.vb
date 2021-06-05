Public Class Salir
    Public mostrar As New Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Clientes.Close()
        Comunicacion_Cliente.Close()
        Debolucion.Close()
        Empleado.Close()
        Inventario.Close()
        Marketing.Close()
        Oportunidades.Close()
        Usuarios.Close()
        Ventas.Close()
        Inicio.Close()
        IniciarSesion.Show()
    End Sub

End Class