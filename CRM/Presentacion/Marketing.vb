Public Class Marketing

    Public nuevo As New Conexion
    Private TablaDatos As New DataTable
    Public Bandera, prueba As New Boolean
    Public marca As String


    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Buscar.Items.Add("Cli_Nombre")
        Cmb_Buscar.Items.Add("Pro_Nombre")
        Cmb_Buscar.Text = "Cli_Nombre"

        nuevo.ConexionDB()
        nuevo.llenado_cb(Cb_ID_Cli, "Cli_NombreEmpresa", "Cliente")
        nuevo.llenado_cb(Cb_ID_prod, "Pro_Nombre", "Inventario")

        Mostrar()
        Limpiar()
        BtnIngresar.Enabled = False
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


    Private Sub Buscar()
        Try
            Dim ConjuntoDatos As New DataSet
            ConjuntoDatos.Tables.Add(TablaDatos.Copy)
            Dim VistaDatos As New DataView(ConjuntoDatos.Tables(0))
            VistaDatos.RowFilter = "ID_Usuario = '" & IniciarSesion.IDUSU & "' AND " & Cmb_Buscar.Text & " like '" & Txt_Buscar.Text & "%'"
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

    Private Sub Txt_Buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Buscar.TextChanged
        Buscar()
    End Sub


    Private Sub OcultarColumna()
        Dgv_Listado.Columns(2).Visible = False
        Dgv_Listado.Columns(4).Visible = False
        Dgv_Listado.Columns(6).Visible = False
    End Sub


    Private Sub Limpiar()
        TxtID_Mark.Text = ""
        TxtDescripMarke.Text = ""
        Txt_Estrategia.Text = ""
        Cb_ID_Cli.Text = ""
        TxtIDCliente.Text = ""
        Cb_ID_prod.Text = ""
        TxtIDProducto.Text = ""
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False

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

    Private Sub Chk_Eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Eliminar.CheckedChanged
        DesactivarM()
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

    Private Sub Dgv_Listado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listado.CellClick
        TrasladoInformacion()

        If Bandera Then
            BtnModificar.Enabled = False
        Else
            If Chk_Eliminar.Checked Then
                'no mostrar modificar con el chek eliminar activo'
            Else
                BtnModificar.Enabled = True
                ActivarM()
            End If
        End If
        BtnIngresar.Enabled = False
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
                BtnIngresar.Enabled = False
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

    Private Sub Cb_ID_Cli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_ID_Cli.SelectedIndexChanged
        nuevo.ConexionDB()
        TxtIDCliente.Text = nuevo.Buscar_info(Cb_ID_Cli.Text, "Cli_NombreEmpresa", "ID_Cliente", "Cliente")
    End Sub

    Private Sub Cb_ID_prod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_ID_prod.SelectedIndexChanged
        nuevo.ConexionDB()
        TxtIDProducto.Text = nuevo.Buscar_info(Cb_ID_prod.Text, "Pro_Nombre", "ID_Producto", "Inventario")
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If BtnNuevo.Text = "Nuevo Marketing" Then
            ActivarM()
            BtnIngresar.Enabled = True
            BtnNuevo.Text = "Cancelar"
        ElseIf BtnNuevo.Text = "Cancelar" Then
            DesactivarM()
            BtnIngresar.Enabled = False
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