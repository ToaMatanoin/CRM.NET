Public Class Empleado
    Private TablaDatos As New DataTable
    Public Bandera As New Boolean
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Emp_Nombre")
        Cmb_Buscar.Items.Add("Emp_Telefono")
        Cmb_Buscar.Items.Add("Emp_Email")
        Cmb_Buscar.Text = "Emp_Nombre"
        TxtIDEmp.Enabled = False

        If Bandera Then
            BtnCerrar.Visible = True
            BtnRegresar.Visible = False
        Else
            BtnCerrar.Visible = False
            BtnRegresar.Visible = True
        End If
        Mostrar()
        Limpiar()
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
        TxtDireccion.Text = ""
        TxtCargo.Text = ""

        BtnIngresar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()
        If Bandera Then
            BtnModificar.Visible = False
        Else
            BtnModificar.Visible = True
        End If
        BtnIngresar.Visible = False
    End Sub

    Private Sub TrasladoInformacion()
        TxtIDEmp.Text = Dgv_Listado.SelectedCells.Item(1).Value
        TxtNomEmp.Text = Dgv_Listado.SelectedCells.Item(2).Value
        TxtTelEmp.Text = Dgv_Listado.SelectedCells.Item(3).Value
        TxtEmailEmp.Text = Dgv_Listado.SelectedCells.Item(4).Value
        TxtDireccion.Text = Dgv_Listado.SelectedCells.Item(5).Value
        TxtCargo.Text = Dgv_Listado.SelectedCells.Item(6).Value
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtNomEmp.Text <> "" And TxtTelEmp.Text <> "" And TxtEmailEmp.Text <> "" And
            TxtDireccion.Text <> "" And TxtCargo.Text <> "" Then

            Try
                Dim TablaDatos As New eEmpleados
                Dim Funcion As New fEmpleados
                TablaDatos.pEmp_Nombre = TxtNomEmp.Text
                TablaDatos.pEmp_Telefono = TxtTelEmp.Text
                TablaDatos.pEmp_Email = TxtEmailEmp.Text
                TablaDatos.pEmp_Direccion = TxtDireccion.Text
                TablaDatos.pEmp_Cargo = TxtCargo.Text


                If Funcion.Insertar(TablaDatos) Then
                    MessageBox.Show("Empleado fue registrado correctamente",
            "Guardando Registro", MessageBoxButtons.OK,
             MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Empleado no fue registrado correctamente",
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtNomEmp.Text <> "" And TxtTelEmp.Text <> "" And TxtEmailEmp.Text <> "" And
            TxtDireccion.Text <> "" And TxtCargo.Text <> "" Then

            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("Desea Modificar los datos",
            "Actualizando Registro", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question)
            If Resultado = Windows.Forms.DialogResult.OK Then
                Try
                    Dim TablaDatos As New eEmpleados
                    Dim Funcion As New fEmpleados
                    TablaDatos.pID_Empleado = TxtIDEmp.Text
                    TablaDatos.pEmp_Nombre = TxtNomEmp.Text
                    TablaDatos.pEmp_Telefono = TxtTelEmp.Text
                    TablaDatos.pEmp_Email = TxtEmailEmp.Text
                    TablaDatos.pEmp_Direccion = TxtDireccion.Text
                    TablaDatos.pEmp_Cargo = TxtCargo.Text
                    If Funcion.Actualizar(TablaDatos) Then
                        MessageBox.Show("Empleado fue actualizado correctamente",
                     "Actualizando Registro", MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Empleado no fue actualizado correctamente",
                     "Actualizando Registro", MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
                    End If
                    Mostrar()
                    Limpiar()
                Catch Evento As Exception
                    MsgBox(Evento.Message)
                End Try
            Else
                MessageBox.Show("Cancelado por el Usuario",
                      "Guardando Registro", MessageBoxButtons.OK,
                       MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Falta Informacion para almacenar",
                      "Guardando Registro", MessageBoxButtons.OK,
                       MessageBoxIcon.Information)
        End If
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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Desea Eliminar los datos",
        "Eliminando Registro", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question)
        If Resultado = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Dgv_Listado.Rows
                    Dim LineaMarca As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If LineaMarca Then
                        Dim LlavePrimaria As Integer = Convert.ToInt32(row.Cells("ID_Empleado").Value)
                        Dim TablaDatos As New eEmpleados
                        Dim Funcion As New fEmpleados
                        TablaDatos.pID_Empleado = LlavePrimaria
                        If Funcion.Eliminar(TablaDatos) Then
                            MessageBox.Show("Empleado fue eliminado correctamente",
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
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class