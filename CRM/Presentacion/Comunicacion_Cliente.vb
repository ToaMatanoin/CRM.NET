Public Class Comunicacion_Cliente

    Public nuevo As New Conexion
    Public Bandera As New Boolean
    Private Sub Comunicacion_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub BtnEscribir_Click(sender As Object, e As EventArgs) Handles BtnEscribir.Click
        Activar()
        Limpiar()
        BtnCliente.Enabled = True
        BtnEnviar.Enabled = True
    End Sub

    Private Sub Activar()
        TxtCorreoCli.Enabled = True
        TxtMensaje.Enabled = True
        TxtAsunto.Enabled = True
    End Sub

    Private Sub Limpiar()
        TxtCorreoCli.Text = ""
        TxtAsunto.Text = ""
        TxtMensaje.Text = ""

        BtnEscribir.Enabled = True
        BtnCliente.Enabled = False
        BtnEnviar.Enabled = False
    End Sub

    Private Sub desactivar()
        TxtCorreoCli.Enabled = False
        TxtAsunto.Enabled = False
        TxtMensaje.Enabled = False
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        enviarCorreo(IniciarSesion.EmailEMP, IniciarSesion.PassEMP, TxtMensaje.Text, TxtAsunto.Text, TxtCorreoCli.Text)
        Limpiar()
        desactivar()
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        CargarDatos.dato = "CLI"
        CargarDatos.ShowDialog()
    End Sub

End Class