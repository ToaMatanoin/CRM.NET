Public Class Comunicacion_Cliente

    Private TablaDatos As New DataTable
    Public Bandera As New Boolean
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnEscribir_Click(sender As Object, e As EventArgs) Handles BtnEscribir.Click
        Limpiar()
        BtnEnviar.Visible = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea Eliminar el mensaje",
        "Eliminando Registro", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Email").Value)
                        Dim TablaDatos As New eComunicacion_Cliente
                        Dim Funcion As New fComunicacion_Cliente
                        TablaDatos.pID_Email = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("El Mensaje fue eliminado correctamente",
                    "Eliminando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Cancelado por el Usuario",
                    "Guardando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call Mostrar()
                Call Limpiar()
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el Usuario",
                    "Guardando Registro", MessageBoxButtons.OK,
                     MessageBoxIcon.Information)
            Call Mostrar()
            Call Limpiar()
        End If
    End Sub

    Private Sub Mostrar()
        Try
            Dim Funcion As New fComunicacion_Cliente
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

    Private Sub Buscar()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(TablaDatos.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = Cmb_Buscar.Text & " like '" & Txt_Buscar.Text & "%'"
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
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub

    Private Sub Limpiar()
        TxtCorreoUsu.Text = ""
        TxtCorreoCli.Text = ""
        TxtAsunto.Text = ""
        TxtMensaje.Text = ""

        BtnEscribir.Visible = True
        BtnEliminar.Visible = False
        BtnEnviar.Visible = False
    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()
    End Sub

    Private Sub TrasladoInformacion()
        TxtCorreoUsu.Text = Dgv_Listado.SelectedCells.Item(3).Value
        TxtCorreoCli.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtAsunto.Text = Dgv_Listado.SelectedCells.Item(6).Value
        TxtMensaje.Text = Dgv_Listado.SelectedCells.Item(7).Value
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        If Chk_Eliminar.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Limpiar()
        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = True
            BtnEliminar.Visible = True
            BtnEscribir.Visible = False
            BtnEnviar.Visible = False
        End If
    End Sub

    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
        End If
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If TxtCorreoUsu.Text <> "" And TxtCorreoCli.Text <> "" And TxtAsunto.Text <> "" And
            TxtMensaje.Text <> "" Then
            Dim fechaActual As Date = Date.Now
            Try
                Dim TablaDatos As New eComunicacion_Cliente
                Dim Funcion As New fComunicacion_Cliente
                TablaDatos.pEmail_Asunto = TxtAsunto.Text
                TablaDatos.pEmail_Cliente = TxtCorreoCli.Text
                TablaDatos.pEmail_Fecha = fechaActual
                TablaDatos.pEmail_Mensaje = TxtMensaje.Text
                TablaDatos.pEmail_usuario = TxtCorreoUsu.Text

                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("Mensaje enviado correctamente",
            "Guardando Registro", MessageBoxButtons.OK,
             MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Mensaje no pudo ser enviado correctamente",
            "Guardando Registro", MessageBoxButtons.OK,
             MessageBoxIcon.Error)
                End If
                Mostrar()
                Limpiar()
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Falta Informacion para almacenar",
            "Guardando Registro", MessageBoxButtons.OK,
             MessageBoxIcon.Information)
        End If
    End Sub
End Class