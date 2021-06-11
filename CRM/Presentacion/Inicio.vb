Imports System.Data.SqlClient
Imports System.Collections
Public Class Inicio
    Public mostrar As New Integer
    Private conexion As New Conexion
    Dim ComandoSQL As New SqlCommand
    Dim dr As SqlDataReader
    Dim nomprod As String()
    Dim cantprod As Integer()
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub BtnOportunidades_Click(sender As Object, e As EventArgs) Handles BtnOportunidades.Click
        Me.Hide()
        Oportunidades.Show()
    End Sub

    Private Sub BtnComunicacion_Click(sender As Object, e As EventArgs) Handles BtnComunicacion.Click
        'Me.Hide()
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

        'ProdPreferidos()
        'dashboard()
    End Sub

    Private Sub ProdPreferidos()
        Try
            ComandoSQL = New SqlCommand("prodpreferidos")
            ComandoSQL.CommandType = CommandType.StoredProcedure
            'ComandoSQL.Connection = Connect
            conexion.ConexionDB()
            dr = ComandoSQL.ExecuteReader
            Dim i As Integer = 0
            While (dr.Read())
                nomprod(i) = dr.GetString(0)
                cantprod(i) = dr.GetInt32(1)
                i = i + 1
            End While
            chartProdPreferidos.Series(0).Points.DataBindXY(nomprod, cantprod)
            dr.Close()
        Catch Evento As Exception
            MsgBox(Evento.Message)
        Finally
            conexion.DesconexionDB()
        End Try
    End Sub

    Private Sub dashboard()
        ComandoSQL = New SqlCommand("DashboardDatos")
        ComandoSQL.CommandType = CommandType.StoredProcedure

        Dim total As New SqlParameter("@totVentas", 0)
        total.Direction = ParameterDirection.Output
        Dim nprod As New SqlParameter("@nprod", 0)
        nprod.Direction = ParameterDirection.Output
        Dim nemp As New SqlParameter("@nemp", 0)
        nemp.Direction = ParameterDirection.Output
        Dim ncli As New SqlParameter("@ncli", 0)
        ncli.Direction = ParameterDirection.Output
        Dim nclipo As New SqlParameter("@nclipo", 0)
        nclipo.Direction = ParameterDirection.Output

        ComandoSQL.Parameters.Add(total)
        ComandoSQL.Parameters.Add(nprod)
        ComandoSQL.Parameters.Add(nemp)
        ComandoSQL.Parameters.Add(ncli)
        ComandoSQL.Parameters.Add(nclipo)

        conexion.ConexionDB()
        ComandoSQL.ExecuteNonQuery()
        lblventas.Text = ComandoSQL.Parameters("@totVentas").Value.ToString()
        lblproductos.Text = ComandoSQL.Parameters("@nprod").Value.ToString()
        lblempleados.Text = ComandoSQL.Parameters("@nemp").Value.ToString()
        lblclientes.Text = ComandoSQL.Parameters("@ncli").Value.ToString()
        lbloportunidades.Text = ComandoSQL.Parameters("@nclipo").Value.ToString()

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

End Class