Public Class Empleado
    Private TablaDatos As New DataTable
    Public Restriccion As New Conexion
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Emp_Nombre")
        Cmb_Buscar.Items.Add("Emp_Cargo")
        Cmb_Buscar.Text = "Emp_Nombre"
        TxtIDEmp.Enabled = False

        Mostrar()
        Limpiar()
        BtnIngresar.Enabled = False
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
        Dgv_Listado.Columns(5).Visible = False
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

        BtnNuevo.Enabled = True
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
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

        BtnModificar.Enabled = False

        If Chk_Eliminar.Checked Then
            'no mostrar modificar con el chek eliminar activo'
        Else
            BtnModificar.Enabled = True
            Activar()
        End If

        BtnIngresar.Enabled = False
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

            Restriccion.ConexionDB()
            Dim comprobar As Boolean = Restriccion.ExistenciaTxt(TxtNomEmp.Text, "Emp_Nombre", "Empleado")
            If comprobar = True Then
                MessageBox.Show("Nombre de Empleado ya existe", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
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
                        BtnIngresar.Enabled = False
                    Else
                        MessageBox.Show("Empleado no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Mostrar()
                    Limpiar()
                    BtnIngresar.Enabled = False
                    Desactivar()
                    BtnNuevo.Text = "Nuevo Empleado"
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtNomEmp.Text <> "" And TxtTelEmp.Text <> "" And TxtEmailEmp.Text <> "" And TxtPasswordEmail.Text <> "" And TxtDireccion.Text <> "" And TxtCargo.Text <> "" Then

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
            BtnEliminar.Enabled = True
            BtnModificar.Enabled = False
            BtnNuevo.Enabled = False
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
                        TablaDatos.pID_Empleado = LlavePrimaria

                        Restriccion.ConexionDB()
                        Dim IDU, IDM, IDV, IDO As String
                        Dim TM As String = ""
                        Dim TV As String = ""
                        Dim TOP As String = ""
                        IDU = Restriccion.Buscar_info(LlavePrimaria, "ID_Empleado", "ID_Usuario", "Usuarios")

                        If IDU <> "" Then
                            IDM = Restriccion.Buscar_info(IDU, "ID_Usuario", "ID_Marketing", "Marketing")
                            IDV = Restriccion.Buscar_info(IDU, "ID_Usuario", "ID_Venta", "Ventas")
                            IDO = Restriccion.Buscar_info(IDU, "ID_Usuario", "ID_Oport", "Oportunidades")

                            If IDM <> "" Or IDV <> "" Or IDO <> "" Then

                                If IDO <> "" Then
                                    TOP = "OPORTUNIDADES"
                                End If
                                If IDV <> "" Then
                                    TV = "VENTAS"
                                End If
                                If IDM <> "" Then
                                    TM = "MARKETING"
                                End If

                                MessageBox.Show("ERROR, No se puede Eliminar EMPLEADO porque su USUARIO esta siendo utilizado en " & TM & " " & TV & " " & TOP,
                                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Else
                                Dim TablaDatos2 As New eUsuarios
                                Dim Funcion2 As New fUsuarios
                                TablaDatos2.pID_Usuario = IDU
                                If Funcion2.Eliminar(TablaDatos2) Then
                                Else
                                    MessageBox.Show("ERROR en Eliminar Usuario", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If

                                If Funcion.Eliminar(TablaDatos) Then
                                    MessageBox.Show("EMPLEADO y su USUARIO fueron eliminados correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                        Else
                            If Funcion.Eliminar(TablaDatos) Then
                                MessageBox.Show("Empleado fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Cancelado por el Usuario", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                        Chk_Eliminar.Checked = False
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If BtnNuevo.Text = "Nuevo Empleado" Then
            Activar()
            BtnIngresar.Enabled = True
            BtnNuevo.Text = "Cancelar"
            Limpiar()
        ElseIf BtnNuevo.Text = "Cancelar" Then
            Desactivar()
            BtnIngresar.Enabled = False
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
End Class