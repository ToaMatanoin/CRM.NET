Public Class Salir
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
        IniciarSesion.Close()
        Inicio.Close()
    End Sub

End Class