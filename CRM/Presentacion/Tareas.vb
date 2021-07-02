Public Class Tareas

    Public nuevo As New Conexion
    Private tablatar As New DataTable
    Public IDMarketing As Integer

    Private Sub Tareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Nombre_Tarea")
        Cmb_Buscar.Items.Add("Descripcion")
        Cmb_Buscar.Text = "Nombre_Tarea"

        DTPFechaInicioProyecto.Value = Date.Now
        DTPFechaFinalProyecto.Value = Date.Today.AddDays(1)

        Btn_ingresarPT.Enabled = False
        txtidmark.Text = InputBox("Introduzca codigo del Marketing con el que va a trabajar", "Información")
        If txtidmark.Text = "" Then
            Me.Close()
        Else
            Dim idm As Integer = 0
            nuevo.ConexionDB()
            idm = nuevo.Buscar_info(txtidmark.Text, "ID_Marketing", "ID_Marketing", "Marketing")

            If idm = Convert.ToInt32(txtidmark.Text) Then
                Mostrartar()
                LimpiarPT()
            Else
                MessageBox.Show("ERROR, el Codigo Marketing ingresado no existe", "Error Marketing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ValidarFechaFin()

        If DTPFechaFinalProyecto.Value < DTPFechaInicioProyecto.Value Then
            MessageBox.Show("Ingrese la fecha final de manera correcta", "Error fecha final", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DTPFechaFinalProyecto.Value = Date.Today.AddDays(1)
        End If

    End Sub

    Private Sub DTPFechaFinalProyecto_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaFinalProyecto.ValueChanged
        ValidarFechaFin()
    End Sub

    Private Sub Mostrartar()
        Try
            Dim Funcion As New fTareas_Marketing
            tablatar = Funcion.Mostrar
            'Dgvtp.Columns.Item("Eliminar").Visible = False
            If tablatar.Rows.Count <> 0 Then
                Dgvtp.DataSource = tablatar
                Dgvtp.ColumnHeadersVisible = True
            Else
                Dgvtp.DataSource = Nothing
                Dgvtp.ColumnHeadersVisible = False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
        Buscartar()

    End Sub

    Private Sub Buscartar()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(tablatar.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = "ID_Marketing = '" & txtidmark.Text & "' AND " & Cmb_Buscar.Text & " like '" & Txt_Buscar.Text & "%'"
            If VistaDatos.Count <> 0 Then
                Dgvtp.DataSource = VistaDatos
                OcultarColumnatar()
            Else
                Dgvtp.DataSource = Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscartar()
    End Sub

    Private Sub OcultarColumnatar()
        Dgvtp.Columns(1).Visible = False
        Dgvtp.Columns(2).Visible = False
    End Sub

    Private Sub LimpiarPT()
        txt_idproy.Text = ""
        TxtDescripProyecto.Text = ""
        TxtNom_proyec.Text = ""
        Btn_NuevoPT.Enabled = True
        Btn_ModificarPT.Enabled = False
        Btn_EliminarPT.Enabled = False
    End Sub

    Private Sub ActivarPT()
        TxtDescripProyecto.Enabled = True
        TxtNom_proyec.Enabled = True
        DTPFechaInicioProyecto.Enabled = True
        DTPFechaFinalProyecto.Enabled = True
    End Sub

    Private Sub DesactivarPT()
        TxtDescripProyecto.Enabled = False
        TxtNom_proyec.Enabled = False

        DTPFechaInicioProyecto.Enabled = False
        DTPFechaFinalProyecto.Enabled = False
    End Sub

    Private Sub TrasladoInformacionPT()
        txt_idproy.Text = Dgvtp.SelectedCells.Item(1).Value
        TxtNom_proyec.Text = Dgvtp.SelectedCells.Item(4).Value
        TxtDescripProyecto.Text = Dgvtp.SelectedCells.Item(5).Value
        DTPFechaInicioProyecto.Value = DateTime.Parse(Dgvtp.SelectedCells.Item(6).Value.ToString)
        DTPFechaFinalProyecto.Value = DateTime.Parse(Dgvtp.SelectedCells.Item(7).Value.ToString)
    End Sub

    Private Sub Chb_eliminarPT_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_eliminarPT.CheckedChanged
        DesactivarPT()
        If Chb_eliminarPT.CheckState = CheckState.Unchecked Then
            Dgvtp.Columns.Item(0).Visible = False
            LimpiarPT()
        Else
            Dgvtp.Columns.Item(0).Visible = True
            Btn_EliminarPT.Enabled = True
            Btn_NuevoPT.Enabled = False
            Btn_ModificarPT.Enabled = False
        End If
    End Sub

    Private Sub Dgvtp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvtp.CellContentClick
        If e.ColumnIndex = Me.Dgvtp.Columns.Item(0).Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgvtp.Rows(e.RowIndex).Cells(0)
            ChkCell.Value = Not ChkCell.Value
        End If
    End Sub

    Private Sub Dgvtp_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvtp.CellClick
        TrasladoInformacionPT()
        'If Bandera Then
        Btn_ModificarPT.Enabled = False
        'Else
        If Chb_eliminarPT.Checked Then
            'no mostrar modificar con el chek eliminar activo'
        Else
            Btn_ModificarPT.Enabled = True
            ActivarPT()
        End If

        'End If
        Btn_ingresarPT.Enabled = False
    End Sub

    Private Sub Btn_NuevoPT_Click(sender As Object, e As EventArgs) Handles Btn_NuevoPT.Click
        If Btn_NuevoPT.Text = "Nuevo Tarea" Then
            ActivarPT()
            Btn_ingresarPT.Enabled = True
            Btn_NuevoPT.Text = "Cancelar"
            LimpiarPT()
        ElseIf Btn_NuevoPT.Text = "Cancelar" Then
            DesactivarPT()
            Btn_ingresarPT.Enabled = False
            LimpiarPT()
            Btn_NuevoPT.Text = "Nuevo Tarea"
        End If
    End Sub

    Private Sub Btn_ingresar_Click(sender As Object, e As EventArgs) Handles Btn_ingresarPT.Click
        If TxtNom_proyec.Text <> "" And TxtDescripProyecto.Text <> "" Then
            Try
                Dim TablaDatos As New eTareas_Marketing
                Dim Funcion As New fTareas_Marketing

                TablaDatos.pID_Marketing = txtidmark.Text
                TablaDatos.pNombre_Tarea = TxtNom_proyec.Text
                TablaDatos.pDescripcion = TxtDescripProyecto.Text
                TablaDatos.pFecha_Inicial = DTPFechaInicioProyecto.Text
                TablaDatos.pFecha_Conclusion = DTPFechaFinalProyecto.Text

                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("Tarea  fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Tarea no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Mostrartar()
                LimpiarPT()
                Btn_ingresarPT.Enabled = False
                DesactivarPT()
                Btn_NuevoPT.Text = "Nuevo Tarea"
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_ModificarPT.Click
        If TxtNom_proyec.Text <> "" And TxtDescripProyecto.Text <> "" Then
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim TablaDatos As New eTareas_Marketing
                    Dim Funcion As New fTareas_Marketing

                    TablaDatos.pID_Tarea = txt_idproy.Text
                    TablaDatos.pID_Marketing = txtidmark.Text
                    TablaDatos.pNombre_Tarea = TxtNom_proyec.Text
                    TablaDatos.pDescripcion = TxtDescripProyecto.Text
                    TablaDatos.pFecha_Inicial = DTPFechaInicioProyecto.Text
                    TablaDatos.pFecha_Conclusion = DTPFechaFinalProyecto.Text

                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Tarea fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Tarea no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Mostrartar()
                    LimpiarPT()
                    DesactivarPT()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_EliminarPT.Click

        If TxtNom_proyec.Text <> "" And TxtDescripProyecto.Text <> "" Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Eliminar la Estrategia", "Eliminando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In Dgvtp.Rows
                        Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells(0).Value)
                        If LineaMarca Then
                            Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Tarea").Value)
                            Dim TablaDatos As New eTareas_Marketing
                            Dim Funcion As New fTareas_Marketing
                            TablaDatos.pID_Tarea = LlavePrimaria
                            If Funcion.Eliminar(TablaDatos) Then
                                MessageBox.Show("Estrategia fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Else
                                MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                        Chb_eliminarPT.Checked = False
                    Next
                    Call Mostrartar()
                    DesactivarPT()
                    LimpiarPT()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Mostrartar()
                Call LimpiarPT()
            End If
        End If

    End Sub
End Class