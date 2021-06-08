Public Class Oportunidades
    Private TablaDatos As New DataTable
    Public Bandera As New Boolean
    Public Restriccion As New Conexion

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Nombre_CliPoten")
        Cmb_Buscar.Items.Add("Posibi_Nego")
        Cmb_Buscar.Items.Add("Email_CliPoten")
        Cmb_Buscar.Text = "Nombre_CliPoten"

        If Bandera Then
            BtnRegresar.Visible = False
        Else
            BtnRegresar.Visible = True
        End If
        Mostrar()
        Limpiar()
        BtnIngresar.Visible = False
    End Sub

    Private Sub Mostrar()
        Try
            Dim Funcion As New fOportunides
            TablaDatos = Funcion.Mostrar
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Dgv_Listado.Columns.Item("Convertir").Visible = False
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
        Dgv_Listado.Columns(2).Visible = False
    End Sub

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub

    Private Sub Limpiar()
        TxtIDClientePot.Text = ""
        TxtNomCli.Text = ""
        TxtTelCli.Text = ""
        TxtEmailCli.Text = ""
        TxtDescripcion.Text = ""
        TxtPosibilidad.Text = ""

        BtnNuevo.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        btnConvertir.Visible = False
    End Sub

    Private Sub Activar()
        TxtNomCli.Enabled = True
        TxtTelCli.Enabled = True
        TxtEmailCli.Enabled = True
        TxtDescripcion.Enabled = True
        TxtPosibilidad.Enabled = True
    End Sub

    Private Sub Desactivar()
        TxtNomCli.Enabled = False
        TxtTelCli.Enabled = False
        TxtEmailCli.Enabled = False
        TxtDescripcion.Enabled = False
        TxtPosibilidad.Enabled = False
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
                Activar()
            End If
        End If
        BtnIngresar.Visible = False
    End Sub

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        Desactivar()
        If Chk_Eliminar.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Eliminar").Visible = False
            Limpiar()
        Else
            Dgv_Listado.Columns.Item("Eliminar").Visible = True
            BtnEliminar.Visible = True
            BtnNuevo.Visible = False
            BtnModificar.Visible = False
            btnConvertir.Visible = False
        End If
    End Sub

    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
        End If
    End Sub

    Private Sub TrasladoInformacion()
        TxtIDClientePot.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtNomCli.Text = Dgv_Listado.SelectedCells.Item(4).Value
        TxtTelCli.Text = Dgv_Listado.SelectedCells.Item(7).Value
        TxtEmailCli.Text = Dgv_Listado.SelectedCells.Item(8).Value
        TxtDescripcion.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtPosibilidad.Text = Dgv_Listado.SelectedCells.Item(6).Value
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And TxtDescripcion.Text <> "" And TxtPosibilidad.Text <> "" Then

            Try
                Dim TablaDatos As New eOportunidades
                Dim Funcion As New fOportunides
                TablaDatos.pID_Usuario = IniciarSesion.IDUSU
                TablaDatos.pCliPot_Nombre = TxtNomCli.Text
                TablaDatos.pDescrip = TxtDescripcion.Text
                TablaDatos.pPosibilidad = TxtPosibilidad.Text
                TablaDatos.pCliPot_Telefono = TxtTelCli.Text
                TablaDatos.pCliPot_Email = TxtEmailCli.Text

                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("Cliente Potencial fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cliente Potencial no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Mostrar()
                Limpiar()
                BtnIngresar.Visible = False
                BtnNuevo.Text = "   Nuevo Cliente"
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And
             TxtDescripcion.Text <> "" And TxtPosibilidad.Text <> "" Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim TablaDatos As New eOportunidades
                    Dim Funcion As New fOportunides
                    TablaDatos.pID_ClientePot = TxtIDClientePot.Text
                    TablaDatos.pID_Usuario = IniciarSesion.IDUSU
                    TablaDatos.pCliPot_Nombre = TxtNomCli.Text
                    TablaDatos.pDescrip = TxtDescripcion.Text
                    TablaDatos.pPosibilidad = TxtPosibilidad.Text
                    TablaDatos.pCliPot_Telefono = TxtTelCli.Text
                    TablaDatos.pCliPot_Email = TxtEmailCli.Text
                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Cliente Potencial fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Cliente Potencial no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Mostrar()
                    Limpiar()
                    Desactivar()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea Eliminar los datos", "Eliminando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Oport").Value)
                        Dim TablaDatos As New eOportunidades
                        Dim Funcion As New fOportunides
                        TablaDatos.pID_ClientePot = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Cliente fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If BtnNuevo.Text = "   Nuevo Cliente" Then
            Activar()
            BtnIngresar.Visible = True
            BtnNuevo.Text = "Cancelar"
            Limpiar()
        ElseIf BtnNuevo.Text = "Cancelar" Then
            Desactivar()
            BtnIngresar.Visible = False
            Limpiar()
            BtnNuevo.Text = "   Nuevo Cliente"
        End If
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        If TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And TxtDescripcion.Text <> "" And TxtPosibilidad.Text <> "" Then

            Dim Resultad As DialogResult
            Resultad = MessageBox.Show("Desea Devolver una compra", "Devolucion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultad = Windows.Forms.DialogResult.OK Then
                Try

                    Dim TablaDatos As New eClientes
                    Dim Funcion As New fClientes

                    TablaDatos.pCli_Nombre = TxtNomCli.Text
                    TablaDatos.pCli_Telefono = TxtTelCli.Text
                    TablaDatos.pCli_Email = TxtEmailCli.Text
                    TablaDatos.pCli_NombreEmpresa = "-"
                    TablaDatos.pCli_TelEmpresa = "0"
                    TablaDatos.pCli_EmailEmpresa = "-"
                    TablaDatos.pRTN = "0"

                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Converción de cliente potencial a cliente, realizada correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Converción de cliente potencial a cliente, FALLO intento de nuevo", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el usuario", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'eliminar cliente potencial
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea Eliminar los datos", "Eliminando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Convertir").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Oport").Value)
                        Dim TablaDatos As New eVentas
                        Dim Funcion As New fVentas
                        TablaDatos.pID_Ventas = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Cliente fue eliminado correctamente", "Cliente Potencial", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Chk_Convertir.Checked = False
                        Else
                            MessageBox.Show("Cancelado por el Usuario", "Cliente Potencial", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Cancelado por el Usuario", "Cliente Potencial", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Desactivar()
        Call Mostrar()
        Call Limpiar()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Convertir.CheckedChanged
        Desactivar()
        If Chk_Convertir.CheckState = CheckState.Unchecked Then
            Dgv_Listado.Columns.Item("Convertir").Visible = False
            Limpiar()
        Else
            Dgv_Listado.Columns.Item("Convertir").Visible = True
            btnConvertir.Visible = True
            BtnEliminar.Visible = False
            BtnNuevo.Visible = False
            BtnModificar.Visible = False
        End If
    End Sub

    Private Sub TxtNomCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomCli.KeyPress
        Restriccion.RestringirLetras(e)
    End Sub

    Private Sub TxtTelCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelCli.KeyPress
        Restriccion.RestringirNumero(e)
    End Sub

    Private Sub TxtPosibilidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPosibilidad.KeyPress
        Restriccion.RestringirNumero(e)
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub
End Class