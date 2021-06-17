Public Class Inicio
    Public mostrar As New Integer

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub BtnOportunidades_Click(sender As Object, e As EventArgs) Handles BtnOportunidades.Click
        Me.Hide()
        Oportunidades.Show()
    End Sub

    Private Sub BtnComunicacion_Click(sender As Object, e As EventArgs) Handles BtnComunicacion.Click
        Comunicacion_Cliente.ShowDialog()
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
        Label1.Text = IniciarSesion.USUNOM

        Dim Dasboard As New Dashboard
        Dasboard.ProdPreferidos()
        Dasboard.dashboard()
    End Sub

    Private Sub Cerrar_Form(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Desea Cerrar Sesion?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            IniciarSesion.Show()
            IniciarSesion.IDUSU = ""
            IniciarSesion.IDEMP = ""
            IniciarSesion.ROLUSU = ""
            IniciarSesion.USUNOM = ""
            IniciarSesion.PassEMP = ""
            IniciarSesion.EmailEMP = ""
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnMinimizate.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Inicio_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim Dasboard As New Dashboard
        Dasboard.ProdPreferidos()
        Dasboard.dashboard()
    End Sub
End Class