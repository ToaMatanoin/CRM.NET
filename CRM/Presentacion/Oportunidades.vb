Public Class Oportunidades
    Private TablaDatos As New DataTable
    Public nuevo As New Conexion
    Public Restriccion As New Conexion

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Nombre_CliPoten")
        Cmb_Buscar.Items.Add("Posibi_Nego")
        Cmb_Buscar.Text = "Nombre_CliPoten"

        Mostrar()
        Limpiar()
        BtnIngresar.Enabled = False
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
            VistaDatos.RowFilter = "ID_Usuario = '" & IniciarSesion.IDUSU & "' And " & Cmb_Buscar.Text & " like '" & Txt_Buscar.Text & "%'"
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
        Dgv_Listado.Columns(2).Visible = False
        Dgv_Listado.Columns(3).Visible = False
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

        BtnNuevo.Enabled = True
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        btnConvertir.Enabled = False
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
        BtnModificar.Enabled = False
        If Chk_Eliminar.Checked Or Chk_Convertir.Checked Then
            'no mostrar modificar con el chek eliminar activo'
        Else
            BtnModificar.Enabled = True
            Activar()
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
            BtnEliminar.Enabled = True
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
            btnConvertir.Enabled = False
        End If
    End Sub

    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
        End If

        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Convertir").Index Then
            Dim ChkCell2 As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Convertir")
            ChkCell2.Value = Not ChkCell2.Value
        End If
    End Sub

    Private Sub TrasladoInformacion()
        TxtIDClientePot.Text = Dgv_Listado.SelectedCells.Item(2).Value
        TxtNomCli.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtTelCli.Text = Dgv_Listado.SelectedCells.Item(8).Value
        TxtEmailCli.Text = Dgv_Listado.SelectedCells.Item(9).Value
        TxtDescripcion.Text = Dgv_Listado.SelectedCells.Item(6).Value
        TxtPosibilidad.Text = Dgv_Listado.SelectedCells.Item(7).Value
    End Sub


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And TxtDescripcion.Text <> "" And TxtPosibilidad.Text <> "" Then

            Restriccion.ConexionDB()
            Dim comprobar As Boolean = Restriccion.ExistenciaTxt(TxtNomCli.Text, "Nombre_CliPoten", "Oportunidades")
            If comprobar = True Then
                MessageBox.Show("Nombre de Cliente potencial ya existe", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    Dim TablaDatos As New eOportunidades
                    Dim Funcion As New fOportunides
                    TablaDatos.pID_Usuario = IniciarSesion.IDUSU
                    TablaDatos.pCliPot_Nombre = TxtNomCli.Text
                    TablaDatos.pDescrip = TxtDescripcion.Text
                    TablaDatos.pPosibilidad = Convert.ToInt32(TxtPosibilidad.Text)
                    TablaDatos.pCliPot_Telefono = TxtTelCli.Text
                    TablaDatos.pCliPot_Email = TxtEmailCli.Text

                    If Funcion.Insertar(TablaDatos) Then
                        MessageBox.Show("Cliente Potencial fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Cliente Potencial no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Mostrar()
                    Limpiar()
                    Desactivar()
                    BtnIngresar.Enabled = False
                    BtnNuevo.Text = "   Nuevo Cliente"
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            End If
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
            BtnIngresar.Enabled = True
            BtnNuevo.Text = "Cancelar"
            Limpiar()
        ElseIf BtnNuevo.Text = "Cancelar" Then
            Desactivar()
            BtnIngresar.Enabled = False
            Limpiar()
            BtnNuevo.Text = "   Nuevo Cliente"
        End If
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        If TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And TxtDescripcion.Text <> "" And TxtPosibilidad.Text <> "" Then

            nuevo.ConexionDB()
            Dim comprobar As Boolean = nuevo.ExistenciaTxt(TxtNomCli.Text, "Cli_Nombre", "Cliente")

            If comprobar Then
                MessageBox.Show("El Cliente ya existe", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            Else
                Dim Resultad As DialogResult
                Resultad = MessageBox.Show("¿Desea Convirtir al cliente potencial a un cliente?", "Convertir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If Resultad = Windows.Forms.DialogResult.OK Then
                    Try

                        Dim TablaDatos As New eClientes
                        Dim Funcion As New fClientes
                        TablaDatos.pCli_Nombre = TxtNomCli.Text
                        TablaDatos.pCli_Telefono = TxtTelCli.Text
                        TablaDatos.pCli_Email = TxtEmailCli.Text
                        TablaDatos.pCli_NombreEmpresa = ""
                        TablaDatos.pCli_TelEmpresa = 0
                        TablaDatos.pCli_EmailEmpresa = ""
                        TablaDatos.pRTN = 0

                        If Funcion.Insertar(TablaDatos) Then
                            Try
                                For Each row As DataGridViewRow In Dgv_Listado.Rows
                                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Convertir").Value)
                                    If LineaMarca Then
                                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Oport").Value)
                                        Dim TablaDatos2 As New eOportunidades
                                        Dim Funcion2 As New fOportunides
                                        TablaDatos2.pID_ClientePot = LlavePrimaria
                                        If Funcion2.Eliminar(TablaDatos2) Then
                                            MessageBox.Show("Converción de cliente potencial a cliente, realizada correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Chk_Convertir.Checked = False
                                        Else
                                            MessageBox.Show("ERROR en eliminar Cliente Potencial", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If
                                    End If
                                Next
                            Catch Evento As Exception
                                MsgBox(Evento.Message)
                            End Try
                        Else
                            MessageBox.Show("Converción de cliente potencial a cliente, FALLO intentelo de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch Evento As Exception
                        MsgBox(Evento.Message)
                    End Try
                Else
                    MessageBox.Show("Cancelado por el usuario", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            btnConvertir.Enabled = True
            BtnEliminar.Enabled = False
            BtnNuevo.Enabled = False
            BtnModificar.Enabled = False
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
    End Sub

End Class