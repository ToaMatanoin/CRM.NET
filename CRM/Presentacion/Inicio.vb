Public Class Inicio

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        IniciarSesion.Visible = True
        Me.Close()
        IniciarSesion.IDUSU = ""
        IniciarSesion.IDEMP = ""
        IniciarSesion.ROLUSU = ""
    End Sub

    Private Sub BtnOportunidades_Click(sender As Object, e As EventArgs) Handles BtnOportunidades.Click
        Me.Hide()
        Oportunidades.Show()
    End Sub

    Private Sub BtnComunicacion_Click(sender As Object, e As EventArgs) Handles BtnComunicacion.Click
        Me.Hide()
        Comunicacion_Cliente.Show()
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        Me.Hide()
        Inventario.Show()
    End Sub

    Private Sub BtnMarketing_Click(sender As Object, e As EventArgs) Handles BtnMarketing.Click
        Me.Hide()
        Marketing.Show()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Me.Hide()
        Usuarios.Show()
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        Me.Hide()
        Empleado.Show()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (IniciarSesion.ROLUSU.Equals("Admin") Or IniciarSesion.ROLUSU.Equals("admin") Or IniciarSesion.ROLUSU.Equals("ADMIN")) Then
            BtnUsuarios.Visible = True
            BtnEmpleados.Visible = True
        End If
    End Sub

End Class