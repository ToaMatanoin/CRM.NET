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


        DTPFechaInicioProyecto.Value = Date.Now
        DTPFechaFinalProyecto.Value = Date.Today.AddDays(1)

        nuevo.ConexionDB()


        nuevo.llenado_cb(Cb_ID_Cli, "Cli_NombreEmpresa", "Cliente")
        nuevo.llenado_cb(Cb_ID_prod, "Pro_Nombre", "Inventario")

        Mostrar()
        Limpiar()
        LimpiarPT()
        BtnIngresar.Visible = False
        Btn_ingresarPT.Visible = False
    End Sub

    Private Sub ValidarFechaFin()

        If DTPFechaFinalProyecto.Value < DTPFechaInicioProyecto.Value Then
            MessageBox.Show("Ingrese la fecha final de manera correcta", "Error fecha final",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DTPFechaFinalProyecto.Value = Date.Today.AddDays(1)
        End If

    End Sub

    Private Sub DTPFechaFinalProyecto_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaFinalProyecto.ValueChanged
        ValidarFechaFin()
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
            'Dgvtp.Columns.Item("eliminar").Visible = False
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
            'Dgvtp.Columns.Item("eliminar").Visible = False
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
            If TxtID_Mark.Text <> "" Then
                VistaDatos.RowFilter = "ID_Marketing = '" & TxtID_Mark.Text & "'"
            End If
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
            If TxtID_Mark.Text <> "" Then
                VistaDatos.RowFilter = "ID_Marketing = '" & TxtID_Mark.Text & "'"
            End If
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
            VistaDatos.RowFilter = "ID_Usuario = '" & IniciarSesion.IDUSU & "'"
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
        txt_idproy.Text = ""
        TxtID_Mark.Text = ""
        TxtDescripMarke.Text = ""
        TxtDescripProyecto.Text = ""
        Txt_Estrategia.Text = ""
        TxtNom_proyec.Text = ""
        Cb_ID_Cli.Text = ""
        TxtIDCliente.Text = ""
        Cb_ID_prod.Text = ""
        TxtIDProducto.Text = ""

        Rb_Proyecto.Checked = False
        Rb_tarea.Checked = False

        Dgvtp.Enabled = False
        Dgvtp.DataSource = Nothing

        BtnNuevo.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False

    End Sub

    Private Sub LimpiarPT()
        TxtDescripProyecto.Text = ""
        TxtNom_proyec.Text = ""



        Btn_NuevoPT.Visible = True
        Btn_ModificarPT.Visible = False
        Btn_EliminarPT.Visible = False
    End Sub

    Private Sub ActivarM()
        Cb_ID_Cli.Enabled = True
        Cb_ID_prod.Enabled = True
        Txt_Estrategia.Enabled = True
        TxtDescripMarke.Enabled = True
    End Sub

    Private Sub DesactivarM()
        Cb_ID_Cli.Enabled = False
        Cb_ID_prod.Enabled = False
        Txt_Estrategia.Enabled = False
        TxtDescripMarke.Enabled = False
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

    Private Sub TrasladoInformacion()
        TxtID_Mark.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtIDProducto.Text = Dgv_Listado.SelectedCells.Item(6).Value
        nuevo.ConexionDB()
        Cb_ID_prod.Text = nuevo.Buscar_info(TxtIDProducto.Text, "ID_Producto", "Pro_Nombre", "Inventario")
        TxtIDCliente.Text = Dgv_Listado.SelectedCells.Item(4).Value
        Cb_ID_Cli.Text = nuevo.Buscar_info(TxtIDCliente.Text, "ID_Cliente", "Cli_NombreEmpresa", "Cliente")
        Txt_Estrategia.Text = Dgv_Listado.SelectedCells.Item(8).Value
        TxtDescripMarke.Text = Dgv_Listado.SelectedCells.Item(9).Value
    End Sub

    Private Sub TrasladoInformacionPT()
        txt_idproy.Text = Dgvtp.SelectedCells.Item(1).Value
        TxtNom_proyec.Text = Dgvtp.SelectedCells.Item(4).Value
        TxtDescripProyecto.Text = Dgvtp.SelectedCells.Item(5).Value
        DTPFechaInicioProyecto.Value = DateTime.Parse(Dgvtp.SelectedCells.Item(6).Value.ToString)
        DTPFechaFinalProyecto.Value = DateTime.Parse(Dgvtp.SelectedCells.Item(7).Value.ToString)
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        DesactivarM()
        If Chk_Eliminar.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Limpiar()
        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = True
            BtnEliminar.Visible = True
            BtnModificar.Visible = False
            BtnNuevo.Visible = False
        End If
    End Sub

    Private Sub Chb_eliminarPT_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_eliminarPT.CheckedChanged
        DesactivarPT()
        If Chb_eliminarPT.CheckState = CheckState.Unchecked Then
            Dgvtp.Columns.Item(0).Visible = False
            LimpiarPT()
        Else
            Dgvtp.Columns.Item(0).Visible = True
            Btn_EliminarPT.Visible = True
            Btn_NuevoPT.Visible = False
            Btn_ModificarPT.Visible = False
        End If
    End Sub

    Private Sub Dgvtp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvtp.CellContentClick
        If e.ColumnIndex = Me.Dgvtp.Columns.Item(0).Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgvtp.Rows(e.RowIndex).Cells(0)
            ChkCell.Value = Not ChkCell.Value
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
                ActivarM()
                Rb_Proyecto.Enabled = True
                Rb_tarea.Enabled = True
            End If
        End If
        BtnIngresar.Visible = False
    End Sub

    Private Sub Dgvtp_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvtp.CellClick
        TrasladoInformacionPT()
        If Bandera Then
            Btn_ModificarPT.Visible = False
        Else
            If Chb_eliminarPT.Checked Then
                'no mostrar modificar con el chek eliminar activo'
            Else
                Btn_ModificarPT.Visible = True
                ActivarPT()
            End If

        End If
        Btn_ingresarPT.Visible = False
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If Txt_Estrategia.Text <> "" And TxtDescripMarke.Text <> "" And Cb_ID_Cli.SelectedIndex >= 0 And Cb_ID_prod.SelectedIndex >= 0 Then
            Try
                Dim TablaDatos As New eMarketing
                Dim Funcion As New fMarketing
                TablaDatos.pID_Usuario = IniciarSesion.IDUSU
                TablaDatos.pID_Producto = TxtIDProducto.Text
                TablaDatos.pID_Cliente = TxtIDCliente.Text
                TablaDatos.pEstrategia = Txt_Estrategia.Text
                TablaDatos.pDescripcion = TxtDescripMarke.Text

                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("Estrategia fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Estrategia no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Mostrar()
                Limpiar()
                BtnIngresar.Visible = False
                DesactivarM()
                BtnNuevo.Text = "Nuevo Marketing"
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If Txt_Estrategia.Text <> "" And TxtDescripMarke.Text <> "" And Cb_ID_Cli.SelectedIndex >= 0 And Cb_ID_prod.SelectedIndex >= 0 Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try

                    Dim TablaDatos As New eMarketing
                    Dim Funcion As New fMarketing
                    TablaDatos.pID_Marketing = TxtID_Mark.Text
                    TablaDatos.pID_Usuario = IniciarSesion.IDUSU
                    TablaDatos.pID_Producto = TxtIDProducto.Text
                    TablaDatos.pID_Cliente = TxtIDCliente.Text
                    TablaDatos.pEstrategia = Txt_Estrategia.Text
                    TablaDatos.pDescripcion = TxtDescripMarke.Text

                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Estrategia fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Estrategia no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Mostrar()
                    Limpiar()
                    DesactivarM()
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

    Private Sub Rb_Proyecto_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Proyecto.CheckedChanged
        marca = "Proyecto"
        'Btn_ingresar.Enabled = True
        Btn_NuevoPT.Enabled = True
        Dgvtp.Enabled = True
        Chb_eliminarPT.Enabled = True
        Mostrarproy()
    End Sub

    Private Sub BtnMinimizate_Click(sender As Object, e As EventArgs) Handles BtnMinimizate.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_ingresar_Click(sender As Object, e As EventArgs) Handles Btn_ingresarPT.Click
        If TxtNom_proyec.Text <> "" And TxtDescripProyecto.Text <> "" Then

            If marca = "Proyecto" Then

                If TxtID_Mark.Text <> "" And Txt_Estrategia.Text <> "" And TxtDescripMarke.Text <> "" And Cb_ID_Cli.SelectedIndex >= 0 And Cb_ID_prod.SelectedIndex >= 0 Then
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
                        Btn_ingresarPT.Visible = False
                        DesactivarPT()
                        DesactivarM()
                        Btn_NuevoPT.Text = "Nuevo"
                        Btn_NuevoPT.Enabled = False
                        Chb_eliminarPT.Enabled = False
                        Rb_Proyecto.Enabled = False
                        Rb_tarea.Enabled = False
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf marca = "Tarea" Then

                If TxtID_Mark.Text <> "" And Txt_Estrategia.Text <> "" And TxtDescripMarke.Text <> "" And Cb_ID_Cli.SelectedIndex >= 0 And Cb_ID_prod.SelectedIndex >= 0 Then
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
                        Btn_ingresarPT.Visible = False
                        DesactivarPT()
                        DesactivarM()
                        Btn_NuevoPT.Text = "Nuevo"
                        Btn_NuevoPT.Enabled = False
                        Chb_eliminarPT.Enabled = False
                        Rb_Proyecto.Enabled = False
                        Rb_tarea.Enabled = False
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

    Private Sub Btn_NuevoPT_Click(sender As Object, e As EventArgs) Handles Btn_NuevoPT.Click
        If Btn_NuevoPT.Text = "Nuevo" Then
            ActivarPT()
            Btn_ingresarPT.Visible = True
            Btn_NuevoPT.Text = "Cancelar"
            LimpiarPT()
        ElseIf Btn_NuevoPT.Text = "Cancelar" Then
            DesactivarPT()
            Btn_ingresarPT.Visible = False
            LimpiarPT()
            Btn_NuevoPT.Text = "Nuevo"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_ModificarPT.Click
        If TxtNom_proyec.Text <> "" And TxtDescripProyecto.Text <> "" Then

            If marca = "Proyecto" Then

                Dim Resultado As DialogResult
                Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If Resultado = Windows.Forms.DialogResult.OK Then
                    Try
                        Dim TablaDatos As New eProyectos_Marketing
                        Dim Funcion As New fProyectos_Marketing

                        TablaDatos.pID_Proyecto = txt_idproy.Text
                        TablaDatos.pID_Marketing = TxtID_Mark.Text
                        TablaDatos.pNombre_Proyecto = TxtNom_proyec.Text
                        TablaDatos.pDescripcion = TxtDescripProyecto.Text
                        TablaDatos.pFecha_Inicial = DTPFechaInicioProyecto.Text
                        TablaDatos.pFecha_Conclusion = DTPFechaFinalProyecto.Text

                        If Funcion.Actualizar(TablaDatos) Then
                            MessageBox.Show("Proyecto fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Proyecto no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        Mostrar()
                        Limpiar()
                        LimpiarPT()
                        DesactivarPT()
                        DesactivarM()
                        Btn_NuevoPT.Enabled = False
                        Chb_eliminarPT.Enabled = False
                        Rb_Proyecto.Enabled = False
                        Rb_tarea.Enabled = False
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf marca = "Tarea" Then

                Dim Resultado As DialogResult
                Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If Resultado = Windows.Forms.DialogResult.OK Then
                    Try
                        Dim TablaDatos As New eTareas_Marketing
                        Dim Funcion As New fTareas_Marketing

                        TablaDatos.pID_Tarea = txt_idproy.Text
                        TablaDatos.pID_Marketing = TxtID_Mark.Text
                        TablaDatos.pNombre_Tarea = TxtNom_proyec.Text
                        TablaDatos.pDescripcion = TxtDescripProyecto.Text
                        TablaDatos.pFecha_Inicial = DTPFechaInicioProyecto.Text
                        TablaDatos.pFecha_Conclusion = DTPFechaFinalProyecto.Text

                        If Funcion.Actualizar(TablaDatos) Then
                            MessageBox.Show("Tarea fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Tarea no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        Mostrar()
                        Limpiar()
                        LimpiarPT()
                        DesactivarPT()
                        DesactivarM()
                        Btn_NuevoPT.Enabled = False
                        Chb_eliminarPT.Enabled = False
                        Rb_Proyecto.Enabled = False
                        Rb_tarea.Enabled = False
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If



            Else
                MessageBox.Show("No seleciono categoria", "Falta llenar campo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_EliminarPT.Click

        If TxtNom_proyec.Text <> "" And TxtDescripProyecto.Text <> "" Then

            If marca = "Proyecto" Then

                Dim Resultado As DialogResult
                Resultado = MessageBox.Show("Desea Eliminar la Estrategia",
                "Eliminando Registro", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question)
                If Resultado = Windows.Forms.DialogResult.OK Then
                    Try
                        For Each row As DataGridViewRow In Dgvtp.Rows
                            Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells(0).Value)
                            If LineaMarca Then
                                Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Proyecto").Value)
                                Dim TablaDatos As New eProyectos_Marketing
                                Dim Funcion As New fProyectos_Marketing
                                TablaDatos.pID_Proyecto = LlavePrimaria
                                If Funcion.Eliminar(TablaDatos) Then
                                    MessageBox.Show("Estrategia fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                            Chb_eliminarPT.Checked = False
                        Next
                        Call Mostrar()
                        Call Limpiar()
                        DesactivarPT()
                        DesactivarM()
                        LimpiarPT()
                        Btn_NuevoPT.Enabled = False
                        Chb_eliminarPT.Enabled = False
                        Rb_Proyecto.Enabled = False
                        Rb_tarea.Enabled = False
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Mostrar()
                    Call Limpiar()
                End If

            ElseIf marca = "Tarea" Then

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
                        Call Mostrar()
                        Call Limpiar()
                        DesactivarPT()
                        DesactivarM()
                        LimpiarPT()
                        Btn_NuevoPT.Enabled = False
                        Chb_eliminarPT.Enabled = False
                        Rb_Proyecto.Enabled = False
                        Rb_tarea.Enabled = False
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Mostrar()
                    Call Limpiar()
                End If


            Else
                MessageBox.Show("No seleciono categoria", "Falta llenar campo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub Cb_ID_Cli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_ID_Cli.SelectedIndexChanged
        nuevo.ConexionDB()
        TxtIDCliente.Text = nuevo.Buscar_info(Cb_ID_Cli.Text, "Cli_NombreEmpresa", "ID_Cliente", "Cliente")
    End Sub

    Private Sub Cb_ID_prod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_ID_prod.SelectedIndexChanged
        nuevo.ConexionDB()
        TxtIDProducto.Text = nuevo.Buscar_info(Cb_ID_prod.Text, "Pro_Nombre", "ID_Producto", "Inventario")
    End Sub

    Private Sub TxtID_Mark_TextChanged(sender As Object, e As EventArgs) Handles TxtID_Mark.TextChanged
        If marca = "Proyecto" Then
            Buscarproy()
        End If

        If marca = "Tarea" Then
            Buscartar()
        End If

    End Sub

    Private Sub Rb_tarea_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_tarea.CheckedChanged
        'Btn_ingresar.Enabled = True
        marca = "Tarea"
        Btn_NuevoPT.Enabled = True
        Dgvtp.Enabled = True
        Chb_eliminarPT.Enabled = True
        Mostrartar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If BtnNuevo.Text = "Nuevo Marketing" Then
            ActivarM()
            BtnIngresar.Visible = True
            BtnNuevo.Text = "Cancelar"
            Limpiar()
            Btn_NuevoPT.Enabled = False
            Chb_eliminarPT.Enabled = False
            Rb_Proyecto.Enabled = False
            Rb_tarea.Enabled = False
        ElseIf BtnNuevo.Text = "Cancelar" Then
            DesactivarM()
            BtnIngresar.Visible = False
            Limpiar()
            BtnNuevo.Text = "Nuevo Marketing"
        End If
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
                            Chk_Eliminar.Checked = False
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