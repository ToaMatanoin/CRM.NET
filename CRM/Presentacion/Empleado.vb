Public Class Empleado
    Private TablaDatos As New DataTable
    Public Restriccion As New Conexion
    Public Bandera As New Boolean
    Public regrecargar As Integer = 0
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Emp_Nombre")
        Cmb_Buscar.Items.Add("Emp_Email")
        Cmb_Buscar.Text = "Emp_Nombre"
        TxtIDEmp.Enabled = False

        If regrecargar = 0 Then
            BtnCerrar.Visible = False
        ElseIf regrecargar = 1 Then
            BtnCerrar.Visible = True
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
        TxtIDEmp.Text = ""
        TxtNomEmp.Text = ""
        TxtTelEmp.Text = ""
        TxtEmailEmp.Text = ""
        TxtPasswordEmail.Text = ""
        TxtDireccion.Text = ""
        TxtCargo.Text = ""
        'Bandera = False

        BtnNuevo.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub Activar()
        TxtNomEmp.Enabled = True
        TxtTelEmp.Enabled = True
        TxtEmailEmp.Enabled = True
        TxtPasswordEmail.Enabled = True
        TxtDireccion.Enabled = True
        TxtCargo.Enabled = True
    End Sub

    Private Sub Desactivar()
        TxtNomEmp.Enabled = False
        TxtTelEmp.Enabled = False
        TxtEmailEmp.Enabled = False
        TxtPasswordEmail.Enabled = False
        TxtDireccion.Enabled = False
        TxtCargo.Enabled = False
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
        TxtIDEmp.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtNomEmp.Text = Dgv_Listado.SelectedCells.Item(2).Value
        TxtTelEmp.Text = Dgv_Listado.SelectedCells.Item(3).Value
        TxtEmailEmp.Text = Dgv_Listado.SelectedCells.Item(4).Value
        TxtPasswordEmail.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtDireccion.Text = Dgv_Listado.SelectedCells.Item(6).Value
        TxtCargo.Text = Dgv_Listado.SelectedCells.Item(7).Value
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtNomEmp.Text <> "" And TxtTelEmp.Text <> "" And TxtEmailEmp.Text <> "" And TxtPasswordEmail.Text <> "" And TxtDireccion.Text <> "" And TxtCargo.Text <> "" Then

            Try
                Dim TablaDatos As New eEmpleados
                Dim Funcion As New fEmpleados
                TablaDatos.pEmp_Nombre = TxtNomEmp.Text
                TablaDatos.pEmp_Telefono = TxtTelEmp.Text
                TablaDatos.pEmp_Email = TxtEmailEmp.Text
                TablaDatos.pEmp_Email_Pass = TxtPasswordEmail.Text
                TablaDatos.pEmp_Direccion = TxtDireccion.Text
                TablaDatos.pEmp_Cargo = TxtCargo.Text

                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("Empleado fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnIngresar.Visible = False
                Else
                    MessageBox.Show("Empleado no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Mostrar()
                Limpiar()
                BtnIngresar.Visible = False
                Desactivar()
                BtnNuevo.Text = "Nuevo Empleado"
            Catch Evento As Exception
                MsgBox(Evento.Message)
            End Try
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtNomEmp.Text <> "" And TxtTelEmp.Text <> "" And TxtEmailEmp.Text <> "" And TxtPasswordEmail.Text <> "" And
            TxtDireccion.Text <> "" And TxtCargo.Text <> "" Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim TablaDatos As New eEmpleados
                    Dim Funcion As New fEmpleados
                    TablaDatos.pID_Empleado = TxtIDEmp.Text
                    TablaDatos.pEmp_Nombre = TxtNomEmp.Text
                    TablaDatos.pEmp_Telefono = TxtTelEmp.Text
                    TablaDatos.pEmp_Email = TxtEmailEmp.Text
                    TablaDatos.pEmp_Email_Pass = TxtPasswordEmail.Text
                    TablaDatos.pEmp_Direccion = TxtDireccion.Text
                    TablaDatos.pEmp_Cargo = TxtCargo.Text
                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Empleado fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Empleado no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Empleado").Value)
                        Dim TablaDatos As New eEmpleados
                        Dim Funcion As New fEmpleados
                        Restriccion.ConexionDB()
                        Dim IDU As String = ""
                        IDU = Restriccion.Buscar_info(LlavePrimaria, "ID_Empleado", "ID_Usuario", "Usuarios")
                        Dim IDM As String = ""
                        IDM = Restriccion.Buscar_info(LlavePrimaria, "ID_Empleado", "ID_Marketing", "Marketing")
                        TablaDatos.pID_Empleado = LlavePrimaria

                        If IDU <> "" Then
                            Dim TablaDatos2 As New eUsuarios
                            Dim Funcion2 As New fUsuarios
                            TablaDatos2.pID_Usuario = IDU
                            If Funcion2.Eliminar(TablaDatos2) Then
                                MessageBox.Show("Usuario fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("ERROR en Eliminar Usuario", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If

                        If IDM <> "" Then
                            Dim TablaDatos2 As New eMarketing
                            Dim Funcion2 As New fMarketing
                            TablaDatos2.pID_Marketing = IDM
                            If Funcion2.Eliminar(TablaDatos2) Then
                                MessageBox.Show("El Marketing del producto correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("ERROR en Eliminar Marketing", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If

                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Empleado fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        'eliminar usuario


    End Sub
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        If BtnRegresar.Text = "Regresar" Then
            Inicio.Visible = True
            Me.Close()
        ElseIf BtnRegresar.Text = "Cargar" Then
            If TxtIDEmp.Text <> "" And TxtNomEmp.Text <> "" And TxtTelEmp.Text <> "" And TxtEmailEmp.Text <> "" And TxtPasswordEmail.Text <> "" And TxtDireccion.Text <> "" And TxtCargo.Text <> "" Then
                BtnCerrar.Visible = False
                regrecargar = 0
                BtnRegresar.Text = "Regresar"
                Me.Close()
            Else
                MessageBox.Show("ERROR, hay campos en blanco, llenelos antes de cargar", "ERROR cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        BtnRegresar.Text = "Regresar"
        BtnCerrar.Visible = False
        regrecargar = 0
        Limpiar()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        'Limpiar()
        'If Bandera Then
        '    BtnCerrar.Visible = True
        '    BtnRegresar.Visible = False
        'Else
        '    BtnCerrar.Visible = False
        '    BtnRegresar.Visible = True
        'End If
        'BtnIngresar.Visible = True
        If BtnNuevo.Text = "Nuevo Empleado" Then
            Activar()
            BtnIngresar.Visible = True
            BtnNuevo.Text = "Cancelar"
            Limpiar()
        ElseIf BtnNuevo.Text = "Cancelar" Then
            Desactivar()
            BtnIngresar.Visible = False
            Limpiar()
            BtnNuevo.Text = "Nuevo Empleado"
        End If
    End Sub

    Private Sub TxtNomEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomEmp.KeyPress
        Restriccion.RestringirLetras(e)
    End Sub
    Private Sub TxtTelEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelEmp.KeyPress
        Restriccion.RestringirNumero(e)
    End Sub
    Private Sub TxtCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCargo.KeyPress
        Restriccion.RestringirLetras(e)
    End Sub

    Private Sub BtnMinimizate_Click(sender As Object, e As EventArgs) Handles BtnMinimizate.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class