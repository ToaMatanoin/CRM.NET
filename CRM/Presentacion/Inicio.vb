Public Class Inicio
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        openChildForm(New Clientes)
        mostrar(PSubClientes)
    End Sub

    Private Sub BtnOportunidades_Click(sender As Object, e As EventArgs) Handles BtnOportunidades.Click
        openChildForm(New Oportunidades)
        ocultar()
    End Sub

    Private Sub BtnComunicacion_Click(sender As Object, e As EventArgs) Handles BtnComunicacion.Click
        Comunicacion_Cliente.ShowDialog()
        ocultar()
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        openChildForm(New Inventario)
    End Sub

    Private Sub BtnMarketing_Click(sender As Object, e As EventArgs) Handles BtnMarketing.Click
        openChildForm(New Marketing)
        mostrar(PSubMarketing)
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        openChildForm(New Ventas)
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        openChildForm(New Usuarios)
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        openChildForm(New Empleado)
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (IniciarSesion.ROLUSU.Equals("Admin")) Then
            BtnUsuarios.Visible = True
            BtnEmpleados.Visible = True
            PDashboard.Visible = True
        End If
        If (IniciarSesion.ROLUSU.Equals("Gestión Ventas")) Then
            BtnVentas.Visible = True
        End If
        If (IniciarSesion.ROLUSU.Equals("Campañas Marketing")) Then
            BtnMarketing.Visible = True
        End If
        If (IniciarSesion.ROLUSU.Equals("Gestión Inventario")) Then
            BtnInventario.Visible = True
        End If
        If (IniciarSesion.ROLUSU.Equals("Gestión Clientes")) Then
            BtnClientes.Visible = True
        End If
        Label1.Text = IniciarSesion.USUNOM
        Dim Dasboard As New Dashboard
        Dasboard.ProdPreferidos()
        Dasboard.Dashboard()
        ocultar()
    End Sub

    Private Sub ocultar()
        PSubMarketing.Visible = False
        PSubClientes.Visible = False
    End Sub

    Public Sub mostrar(submenu As Panel)
        If submenu.Visible = False Then
            ocultar()
            submenu.Visible = True
        Else
            ocultar()
            submenu.Visible = False
        End If
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

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PContenido.Controls.Add(childForm)
        PContenido.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub BtnProyectos_Click(sender As Object, e As EventArgs) Handles BtnProyectos.Click
        Proyectos.Show()
    End Sub

    Private Sub BtnTareas_Click(sender As Object, e As EventArgs) Handles BtnTareas.Click
        Tareas.Show()
    End Sub

    Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
        Dim rutaEjecutable As String = System.IO.Directory.GetCurrentDirectory().ToString
        'Los archivos de la documentación HTML están en una carpeta llamada HTML
        System.Diagnostics.Process.Start(rutaEjecutable & "\HTML\Manual Usuario CRM.html")
    End Sub
End Class