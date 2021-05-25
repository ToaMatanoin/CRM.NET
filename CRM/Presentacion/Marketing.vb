Public Class Marketing

    Public nuevo As New Conexion
    Private TablaDatos, tablaproy, tablatar As New DataTable
    Public Bandera, prueba As New Boolean
    Public marca As String

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        marca = "nada"

        If Bandera Then
            BtnRegresar.Visible = False
        Else
            BtnRegresar.Visible = True
        End If

        nuevo.ConexionDB()

        nuevo.llenado_cb(Cb_ID_Cli, "ID_Cliente", "Cliente")
        nuevo.llenado_cb(Cb_ID_prod, "ID_Producto", "Inventario")

        TxtIDUsuario.Text = IniciarSesion.IDUSU
        Mostrar()
        Limpiar()

    End Sub


    Private Sub Mostrar()
        Try
            Dim Funcion As New fMarketing
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
        Buscar()

    End Sub

    Private Sub Mostrarproy()
        Try
            Dim Funcion As New fProyectos_Marketing
            tablaproy = Funcion.Mostrar
            If tablaproy.Rows.Count <> 0 Then
                Dgvtp.DataSource = tablaproy
                Dgvtp.ColumnHeadersVisible = True
            Else
                Dgvtp.DataSource = Nothing
                Dgvtp.ColumnHeadersVisible = False
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
        Buscarproy()

    End Sub

    Private Sub Mostrartar()
        Try
            Dim Funcion As New fTareas_Marketing
            tablatar = Funcion.Mostrar
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
            VistaDatos.RowFilter = "ID_Marketing = '" & Dgv_Listado.SelectedCells.Item(1).Value & "'"
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

    Private Sub Buscarproy()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(tablaproy.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = "ID_Marketing = '" & Dgv_Listado.SelectedCells.Item(1).Value & "'"
            If VistaDatos.Count <> 0 Then
                Dgvtp.DataSource = VistaDatos
                OcultarColumnapr()
            Else
                Dgvtp.DataSource = Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(TablaDatos.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = "ID_Usuario = '" & TxtIDUsuario.Text & "'"
            If VistaDatos.Count <> 0 Then
                Dgv_Listado.DataSource = VistaDatos
                OcultarColumna()
            Else
                Dgv_Listado.DataSource = Nothing
            End If
        Catch Evento As Exception
            MsgBox(Evento.Message)
        End Try
    End Sub

    Private Sub OcultarColumna()
        Dgv_Listado.Columns(1).Visible = False
        Dgv_Listado.Columns(2).Visible = False
        Dgv_Listado.Columns(4).Visible = False
        Dgv_Listado.Columns(6).Visible = False
    End Sub

    Private Sub OcultarColumnapr()
        Dgvtp.Columns(1).Visible = False
        Dgvtp.Columns(2).Visible = False
    End Sub

    Private Sub OcultarColumnatar()
        Dgvtp.Columns(1).Visible = False
        Dgvtp.Columns(2).Visible = False
    End Sub

    Private Sub Limpiar()
        TxtID_Mark.Text = ""
        TxtDescripMarke.Text = ""
        TxtDescripProyecto.Text = ""
        Txt_Estrategia.Text = ""
        TxtNom_proyec.Text = ""
        Cb_ID_Cli.Text = ""
        Cb_ID_prod.Text = ""

        Rb_Proyecto.Checked = False
        Rb_tarea.Checked = False

        BtnIngresar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        Btn_Guardar_proy.Enabled = False

    End Sub

    Private Sub TrasladoInformacion()
        TxtID_Mark.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtIDUsuario.Text = Dgv_Listado.SelectedCells.Item(2).Value
        Cb_ID_prod.Text = Dgv_Listado.SelectedCells.Item(6).Value
        Cb_ID_Cli.Text = Dgv_Listado.SelectedCells.Item(4).Value
        Txt_Estrategia.Text = Dgv_Listado.SelectedCells.Item(8).Value
        TxtDescripMarke.Text = Dgv_Listado.SelectedCells.Item(9).Value
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Limpiar()

        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = True
            BtnEliminar.Visible = True
            BtnIngresar.Visible = False
        End If
    End Sub
    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
        End If
    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()
        If Bandera Then
            BtnModificar.Visible = False
        Else
            If Chk_Eliminar.Checked Then
                'no mostrar modificar con el chek eliminar activo'
            Else
                BtnModificar.Visible = True
            End If

        End If
        BtnIngresar.Visible = False
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If Txt_Estrategia.Text <> "" And TxtDescripMarke.Text <> "" And Cb_ID_Cli.SelectedIndex >= 0 And Cb_ID_prod.SelectedIndex >= 0 And TxtIDUsuario.Text >= 0 Then
            Try
                Dim TablaDatos As New eMarketing
                Dim Funcion As New fMarketing
                TablaDatos.pID_Usuario = TxtIDUsuario.Text
                TablaDatos.pID_Producto = Cb_ID_prod.Text
                TablaDatos.pID_Cliente = Cb_ID_Cli.Text
                TablaDatos.pEstrategia = Txt_Estrategia.Text
                TablaDatos.pDescripcion = TxtDescripMarke.Text

                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("Estrategia fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Estrategia no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Mostrar()
                Limpiar()
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If Txt_Estrategia.Text <> "" And TxtDescripMarke.Text <> "" And Cb_ID_Cli.SelectedIndex >= 0 And Cb_ID_prod.SelectedIndex >= 0 And TxtIDUsuario.Text >= 0 Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try

                    Dim TablaDatos As New eMarketing
                    Dim Funcion As New fMarketing
                    TablaDatos.pID_Marketing = TxtID_Mark.Text
                    TablaDatos.pID_Usuario = TxtIDUsuario.Text
                    TablaDatos.pID_Producto = Cb_ID_prod.Text
                    TablaDatos.pID_Cliente = Cb_ID_Cli.Text
                    TablaDatos.pEstrategia = Txt_Estrategia.Text
                    TablaDatos.pDescripcion = TxtDescripMarke.Text

                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Estrategia fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Estrategia no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Mostrar()
                    Limpiar()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_Guardar_proy_Click(sender As Object, e As EventArgs) Handles Btn_Guardar_proy.Click
        If TxtNom_proyec.Text <> "" And TxtDescripProyecto.Text <> "" Then

            If marca = "Proyecto" Then

                If TxtID_Mark.Text <> "" And Txt_Estrategia.Text <> "" And TxtDescripMarke.Text <> "" And Cb_ID_Cli.SelectedIndex >= 0 And Cb_ID_prod.SelectedIndex >= 0 And TxtIDUsuario.Text >= 0 Then
                    Try
                        Dim TablaDatos As New eProyectos_Marketing
                        Dim Funcion As New fProyectos_Marketing

                        TablaDatos.pID_Marketing = TxtID_Mark.Text
                        TablaDatos.pNombre_Proyecto = TxtNom_proyec.Text
                        TablaDatos.pDescripcion = TxtDescripProyecto.Text
                        TablaDatos.pFecha_Inicial = DTPFechaInicioProyecto.Text
                        TablaDatos.pFecha_Conclusion = DTPFechaFinalProyecto.Text

                        If Funcion.Insertar(TablaDatos) Then
                            MessageBox.Show("Proyecto fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Proyecto no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        Mostrar()
                        Limpiar()
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf marca = "Tarea" Then

                If TxtID_Mark.Text <> "" And Txt_Estrategia.Text <> "" And TxtDescripMarke.Text <> "" And Cb_ID_Cli.SelectedIndex >= 0 And Cb_ID_prod.SelectedIndex >= 0 And TxtIDUsuario.Text >= 0 Then
                    Try
                        Dim TablaDatos As New eTareas_Marketing
                        Dim Funcion As New fTareas_Marketing

                        TablaDatos.pID_Marketing = TxtID_Mark.Text
                        TablaDatos.pNombre_Tarea = TxtNom_proyec.Text
                        TablaDatos.pDescripcion = TxtDescripProyecto.Text
                        TablaDatos.pFecha_Inicial = DTPFechaInicioProyecto.Text
                        TablaDatos.pFecha_Conclusion = DTPFechaFinalProyecto.Text

                        If Funcion.Insertar(TablaDatos) Then
                            MessageBox.Show("Tarea  fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Tarea no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        Mostrar()
                        Limpiar()
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("No seleciono categoria", "Falta llenar campo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Rb_Proyecto_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Proyecto.CheckedChanged
        marca = "Proyecto"
        Btn_Guardar_proy.Enabled = True
        Mostrarproy()
    End Sub

    Private Sub Rb_tarea_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_tarea.CheckedChanged
        Btn_Guardar_proy.Enabled = True
        marca = "Tarea"
        Mostrartar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Limpiar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea Eliminar la Estrategia",
        "Eliminando Registro", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Marketing").Value)
                        Dim TablaDatos As New eMarketing
                        Dim Funcion As New fMarketing
                        TablaDatos.pID_Marketing = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Estrategia fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call Mostrar()
                Call Limpiar()
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Mostrar()
            Call Limpiar()
        End If
    End Sub
End Class