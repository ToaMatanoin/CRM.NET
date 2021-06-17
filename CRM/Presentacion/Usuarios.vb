Public Class Usuarios

    Private TablaDatos As New DataTable
    Public Bandera As New Boolean
    Public Restriccion As New Conexion

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Usu_Nombre")
        Cmb_Buscar.Items.Add("Emp_Nombre")
        Cmb_Buscar.Text = "Usu_Nombre"
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
            Dim Funcion As New fUsuarios
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
        TxtIDUsu.Text = ""
        TxtNomUsu.Text = ""
        TxtPassUsu.Text = ""
        TxtCargoEmp.Text = ""
        TxtNomEmpl.Text = ""

        BtnNuevo.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub Activar()
        TxtNomUsu.Enabled = True
        TxtPassUsu.Enabled = True
    End Sub

    Private Sub Desactivar()
        TxtNomUsu.Enabled = False
        TxtPassUsu.Enabled = False
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
                BtnEmpleado.Enabled = True
            End If
        End If
        BtnIngresar.Visible = False
    End Sub

    Private Sub TrasladoInformacion()
        TxtIDUsu.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtNomUsu.Text = Dgv_Listado.SelectedCells.Item(2).Value
        TxtCargoEmp.Text = Dgv_Listado.SelectedCells.Item(3).Value
        TxtPassUsu.Text = Dgv_Listado.SelectedCells.Item(4).Value
        TxtIDEmp.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtNomEmpl.Text = Dgv_Listado.SelectedCells.Item(6).Value
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtNomUsu.Text <> "" And TxtPassUsu.Text <> "" And TxtCargoEmp.Text <> "" And TxtIDEmp.Text <> "" And TxtNomEmpl.Text <> "" Then

            Restriccion.ConexionDB()
            Dim comprobar As Boolean = Restriccion.ExistenciaTxt(TxtNomUsu.Text, "Usu_Nombre", "Usuarios")
            If comprobar = True Then
                MessageBox.Show("Nombre de producto ya existe", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    Dim TablaDatos As New eUsuarios
                    Dim Funcion As New fUsuarios
                    TablaDatos.pUsu_Nombre = TxtNomUsu.Text
                    TablaDatos.pUsu_Contrasenha = TxtPassUsu.Text
                    TablaDatos.pUsu_Cargo = TxtCargoEmp.Text
                    TablaDatos.pID_Empleado = TxtIDEmp.Text

                    If Funcion.Insertar(TablaDatos) Then
                        MessageBox.Show("Usuario fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Usuario no fue registrado correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Mostrar()
                    Limpiar()
                    BtnIngresar.Visible = False
                    Desactivar()
                    BtnNuevo.Text = "   Nuevo Usuario"
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtNomUsu.Text <> "" And TxtPassUsu.Text <> "" And TxtCargoEmp.Text <> "" And TxtIDEmp.Text <> "" And TxtNomEmpl.Text <> "" Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos", "Actualizando Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim TablaDatos As New eUsuarios
                    Dim Funcion As New fUsuarios
                    TablaDatos.pID_Usuario = TxtIDUsu.Text
                    TablaDatos.pUsu_Nombre = TxtNomUsu.Text
                    TablaDatos.pUsu_Contrasenha = TxtPassUsu.Text
                    TablaDatos.pUsu_Cargo = TxtCargoEmp.Text
                    TablaDatos.pID_Empleado = TxtIDEmp.Text

                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Usuario fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Usuario no fue actualizado correctamente", "Actualizando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Usuario").Value)
                        Dim TablaDatos As New eUsuarios
                        Dim Funcion As New fUsuarios
                        Restriccion.ConexionDB()
                        Dim IDM As String = ""
                        IDM = Restriccion.Buscar_info(LlavePrimaria, "ID_Usuario", "ID_Marketing", "Marketing")
                        TablaDatos.pID_Usuario = LlavePrimaria

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
                            MessageBox.Show("Usuario fue eliminado correctamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        'eliminar oportunidades

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
        End If
    End Sub

    Private Sub Dgv_Listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellContentClick
        If e.ColumnIndex = Me.Dgv_Listado.Columns.Item("Eliminar").Index Then
            Dim ChkCell As DataGridViewCheckBoxCell = Me.Dgv_Listado.Rows(e.RowIndex).Cells("Eliminar")
            ChkCell.Value = Not ChkCell.Value
        End If
    End Sub
    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEmpleado.Click
        Empleado.regrecargar = 1
        Empleado.ShowDialog()

        TxtIDEmp.Text = Empleado.TxtIDEmp.Text
        TxtNomEmpl.Text = Empleado.TxtNomEmp.Text
        TxtCargoEmp.Text = Empleado.TxtCargo.Text
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If BtnNuevo.Text = "   Nuevo Usuario" Then
            Activar()
            BtnIngresar.Visible = True
            BtnEmpleado.Enabled = True
            BtnNuevo.Text = "Cancelar"
            Limpiar()
        ElseIf BtnNuevo.Text = "Cancelar" Then
            Desactivar()
            BtnIngresar.Visible = False
            BtnEmpleado.Enabled = False
            Limpiar()
            BtnNuevo.Text = "   Nuevo Usuario"
        End If
    End Sub

    Private Sub BtnMinimizate_Click(sender As Object, e As EventArgs) Handles BtnMinimizate.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class