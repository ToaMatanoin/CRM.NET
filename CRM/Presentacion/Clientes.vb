Public Class Clientes

    Private TablaDatos As New DataTable
    Private Restriccion As New Conexion
    Public Bandera As New Boolean
    Public regrecargar As Integer = 0
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Cli_Nombre")
        Cmb_Buscar.Items.Add("Cli_NombreEmpresa")
        Cmb_Buscar.Text = "Cli_Nombre"

        If regrecargar = 0 Then
            BtnCargar.Visible = False
        ElseIf regrecargar = 1 Then
            BtnCargar.Visible = True
        End If
        'If Bandera Then
        '    BtnCerrar.Visible = True
        '    BtnRegresar.Visible = False
        'Else
        '    BtnCerrar.Visible = False
        '    BtnRegresar.Visible = True
        'End If
        Mostrar()
        Limpiar()
        BtnIngresar.Visible = False
    End Sub

    Private Sub Mostrar()
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
        TxtIDCliente.Text = ""
        TxtNomCli.Text = ""
        TxtTelCli.Text = ""
        TxtEmailCli.Text = ""
        TxtNomEmpresa.Text = ""
        TxtTelEmpresa.Text = ""
        TxtEmailEmpresa.Text = ""
        TxtRTN.Text = ""
        'Bandera = False
        BtnNuevo.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub Activar()
        TxtNomCli.Enabled = True
        TxtTelCli.Enabled = True
        TxtEmailCli.Enabled = True
        TxtNomEmpresa.Enabled = True
        TxtTelEmpresa.Enabled = True
        TxtEmailEmpresa.Enabled = True
        TxtRTN.Enabled = True
    End Sub

    Private Sub Desactivar()
        TxtNomCli.Enabled = False
        TxtTelCli.Enabled = False
        TxtEmailCli.Enabled = False
        TxtNomEmpresa.Enabled = False
        TxtTelEmpresa.Enabled = False
        TxtEmailEmpresa.Enabled = False
        TxtRTN.Enabled = False
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

    Private Sub TrasladoInformacion()
        TxtIDCliente.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtNomCli.Text = Dgv_Listado.SelectedCells.Item(2).Value
        TxtTelCli.Text = Dgv_Listado.SelectedCells.Item(3).Value
        TxtEmailCli.Text = Dgv_Listado.SelectedCells.Item(4).Value
        TxtNomEmpresa.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtTelEmpresa.Text = Dgv_Listado.SelectedCells.Item(6).Value
        TxtEmailEmpresa.Text = Dgv_Listado.SelectedCells.Item(7).Value
        TxtRTN.Text = Dgv_Listado.SelectedCells.Item(8).Value
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And TxtNomEmpresa.Text <> "" And TxtTelEmpresa.Text <> "" And TxtEmailEmpresa.Text <> "" And
            TxtRTN.Text <> "" Then

            Restriccion.ConexionDB()
            Dim comprobar As Boolean = Restriccion.ExistenciaTxt(TxtNomCli.Text, "Cli_Nombre", "Cliente")

            If comprobar = True Then
                MessageBox.Show("Nombre de Cliente ya existe", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    Dim TablaDatos As New eClientes
                    Dim Funcion As New fClientes
                    TablaDatos.pCli_Nombre = TxtNomCli.Text
                    TablaDatos.pCli_Telefono = TxtTelCli.Text
                    TablaDatos.pCli_Email = TxtEmailCli.Text
                    TablaDatos.pCli_NombreEmpresa = TxtNomEmpresa.Text
                    TablaDatos.pCli_TelEmpresa = TxtTelEmpresa.Text
                    TablaDatos.pCli_EmailEmpresa = TxtEmailEmpresa.Text
                    TablaDatos.pRTN = TxtRTN.Text

                    If Funcion.Insertar(TablaDatos) Then
                        MessageBox.Show("Cliente fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Cliente no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Mostrar()
                    Limpiar()
                    BtnIngresar.Visible = False
                    Desactivar()
                    BtnNuevo.Text = "Nuevo Cliente"
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            End If


        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And TxtNomEmpresa.Text <> "" And TxtTelEmpresa.Text <> "" And TxtEmailEmpresa.Text <> "" And
            TxtRTN.Text <> "" Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim TablaDatos As New eClientes
                    Dim Funcion As New fClientes
                    TablaDatos.pID_Cliente = TxtIDCliente.Text
                    TablaDatos.pCli_Nombre = TxtNomCli.Text
                    TablaDatos.pCli_Telefono = TxtTelCli.Text
                    TablaDatos.pCli_Email = TxtEmailCli.Text
                    TablaDatos.pCli_NombreEmpresa = TxtNomEmpresa.Text
                    TablaDatos.pCli_TelEmpresa = TxtTelEmpresa.Text
                    TablaDatos.pCli_EmailEmpresa = TxtEmailEmpresa.Text
                    TablaDatos.pRTN = TxtRTN.Text

                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Cliente fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Cliente no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        Desactivar()
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

    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
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
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Cliente").Value)
                        Dim TablaDatos As New eClientes
                        Dim Funcion As New fClientes

                        Restriccion.ConexionDB()
                        Dim IDM As String = ""
                        IDM = Restriccion.Buscar_info(LlavePrimaria, "ID_Cliente", "ID_Marketing", "Marketing")
                        TablaDatos.pID_Cliente = LlavePrimaria
                        If IDM <> "" Then
                            Dim TablaDatos2 As New eMarketing
                            Dim Funcion2 As New fMarketing
                            TablaDatos2.pID_Marketing = IDM
                            If Funcion2.Eliminar(TablaDatos2) Then
                            Else
                                MessageBox.Show("ERROR en Eliminar Marketing", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If

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
        'eliminar marketing

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        If TxtIDCliente.Text <> "" And TxtNomCli.Text <> "" And TxtTelCli.Text <> "" And TxtEmailCli.Text <> "" And TxtNomEmpresa.Text <> "" And
            TxtTelEmpresa.Text <> "" And TxtEmailEmpresa.Text <> "" And TxtRTN.Text <> "" Then
            regrecargar = 0
            Me.Close()
        Else
            MessageBox.Show("ERROR, hay campos en blanco, llenelos antes de cargar", "ERROR cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If BtnNuevo.Text = "Nuevo Cliente" Then
            Activar()
            BtnIngresar.Visible = True
            BtnNuevo.Text = "Cancelar"
            Limpiar()
        ElseIf BtnNuevo.Text = "Cancelar" Then
            Desactivar()
            BtnIngresar.Visible = False
            Limpiar()
            BtnNuevo.Text = "Nuevo Cliente"
        End If
    End Sub
    Private Sub TxtNomCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomCli.KeyPress
        Restriccion.RestringirLetras(e)
    End Sub
    Private Sub TxtTelCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelCli.KeyPress
        Restriccion.RestringirNumero(e)
    End Sub

    Private Sub TxtNomEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomEmpresa.KeyPress
        Restriccion.RestringirLetras(e)
    End Sub
    Private Sub TxtTelEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelEmpresa.KeyPress
        Restriccion.RestringirNumero(e)
    End Sub
    Private Sub TxtRTN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRTN.KeyPress
        Restriccion.RestringirNumero(e)
    End Sub

    Private Sub Btnregresar_Click_1(sender As Object, e As EventArgs) Handles Btnregresar.Click
        If BtnCargar.Visible Then
            regrecargar = 0
            Limpiar()
            Me.Close()
        Else
            Inicio.Visible = True
            Me.Close()
        End If
    End Sub

    Private Sub TxtNomCli_TextChanged(sender As Object, e As EventArgs) Handles TxtNomCli.TextChanged

    End Sub
End Class