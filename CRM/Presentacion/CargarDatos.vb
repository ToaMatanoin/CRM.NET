Public Class CargarDatos
    Private TablaDatos As New DataTable
    Public dato As String = ""
    Private Sub CargarDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        If dato.Equals("EMP") Then
            Cmb_Buscar.Items.Add("Emp_Nombre")
            Cmb_Buscar.Items.Add("Emp_Cargo")
            Cmb_Buscar.Text = "Emp_Nombre"

            MostrarEMP()
        ElseIf dato.Equals("CLI") Then
            Cmb_Buscar.Items.Add("Cli_Nombre")
            Cmb_Buscar.Items.Add("Cli_NombreEmpresa")
            Cmb_Buscar.Text = "Cli_Nombre"

            MostrarCLI()
        End If
    End Sub

    Private Sub MostrarCLI()
        Try
            Dim Funcion As New fClientes
            TablaDatos = Funcion.Mostrar
            Dgv_Listado.Columns.Item("eliminar").Visible = False
            If TablaDatos.Rows.Count <> 0 Then
                Dgv_Listado.DataSource = TablaDatos
                Dgv_Listado.ColumnHeadersVisible = True
            Else
                Dgv_Listado.DataSource = Nothing
                Dgv_Listado.ColumnHeadersVisible = False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
        BuscarCLI()
    End Sub

    Private Sub BuscarCLI()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(TablaDatos.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = Cmb_Buscar.Text & " like '" & Txt_Buscar.Text & "%'"
            If VistaDatos.Count <> 0 Then
                Dgv_Listado.DataSource = VistaDatos
                OcultarColumnaCLI()
            Else
                Dgv_Listado.DataSource = Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
    End Sub

    Private Sub OcultarColumnaCLI()
        Dgv_Listado.Columns(1).Visible = False
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        If dato.Equals("EMP") Then
            BuscarEMP()
        ElseIf dato.Equals("CLI") Then
            BuscarCLI()
        End If
    End Sub

    Private Sub Limpiar()
        TxtEmailCli.Text = ""
        TxtIDEmp.Text = ""
        TxtNomEmpl.Text = ""
        TxtCargoEmp.Text = ""
    End Sub

    Private Sub TrasladoInformacion()
        TxtEmailCli.Text = Dgv_Listado.SelectedCells.Item(4).Value
        TxtIDEmp.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtNomEmpl.Text = Dgv_Listado.SelectedCells.Item(2).Value
        TxtCargoEmp.Text = Dgv_Listado.SelectedCells.Item(7).Value
    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()
    End Sub

    Private Sub MostrarEMP()
        Try
            Dim Funcion As New fEmpleados
            TablaDatos = Funcion.Mostrar
            Dgv_Listado.Columns.Item("eliminar").Visible = False
            If TablaDatos.Rows.Count <> 0 Then
                Dgv_Listado.DataSource = TablaDatos
                Dgv_Listado.ColumnHeadersVisible = True
            Else
                Dgv_Listado.DataSource = Nothing
                Dgv_Listado.ColumnHeadersVisible = False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
        BuscarEMP()
    End Sub

    Private Sub BuscarEMP()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(TablaDatos.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = Cmb_Buscar.Text & " like '" & Txt_Buscar.Text & "%'"
            If VistaDatos.Count <> 0 Then
                Dgv_Listado.DataSource = VistaDatos
                OcultarColumnaEMP()
            Else
                Dgv_Listado.DataSource = Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
    End Sub

    Private Sub OcultarColumnaEMP()
        Dgv_Listado.Columns(1).Visible = False
        Dgv_Listado.Columns(5).Visible = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        If dato.Equals("CLI") Then
            Comunicacion_Cliente.TxtCorreoCli.Text = TxtEmailCli.Text
            dato = ""
            Me.Close()
        End If

        If dato.Equals("EMP") Then

            dato = ""
            Me.Close()
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Limpiar()
        Me.Close()
    End Sub
End Class