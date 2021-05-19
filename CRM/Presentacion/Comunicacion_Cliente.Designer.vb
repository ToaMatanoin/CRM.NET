<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comunicacion_Cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.TxtCliCod = New System.Windows.Forms.TextBox()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAsunto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorreoCli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEscribir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnCliente)
        Me.GroupBox3.Controls.Add(Me.TxtCliCod)
        Me.GroupBox3.Controls.Add(Me.TxtMensaje)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtAsunto)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtCorreoCli)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(528, 328)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mensaje"
        '
        'BtnCliente
        '
        Me.BtnCliente.Location = New System.Drawing.Point(398, 21)
        Me.BtnCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(77, 24)
        Me.BtnCliente.TabIndex = 17
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'TxtCliCod
        '
        Me.TxtCliCod.Enabled = False
        Me.TxtCliCod.Location = New System.Drawing.Point(400, 24)
        Me.TxtCliCod.Name = "TxtCliCod"
        Me.TxtCliCod.Size = New System.Drawing.Size(35, 22)
        Me.TxtCliCod.TabIndex = 9
        Me.TxtCliCod.Visible = False
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Enabled = False
        Me.TxtMensaje.Location = New System.Drawing.Point(7, 102)
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(511, 220)
        Me.TxtMensaje.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Mensaje"
        '
        'TxtAsunto
        '
        Me.TxtAsunto.Enabled = False
        Me.TxtAsunto.Location = New System.Drawing.Point(65, 49)
        Me.TxtAsunto.Name = "TxtAsunto"
        Me.TxtAsunto.Size = New System.Drawing.Size(329, 22)
        Me.TxtAsunto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Asunto:"
        '
        'TxtCorreoCli
        '
        Me.TxtCorreoCli.Enabled = False
        Me.TxtCorreoCli.Location = New System.Drawing.Point(110, 21)
        Me.TxtCorreoCli.Name = "TxtCorreoCli"
        Me.TxtCorreoCli.Size = New System.Drawing.Size(284, 22)
        Me.TxtCorreoCli.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEnviar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnEscribir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 86)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Location = New System.Drawing.Point(136, 19)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(123, 51)
        Me.BtnEnviar.TabIndex = 3
        Me.BtnEnviar.Text = "Enviar Mensaje"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        Me.BtnEnviar.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnRegresar)
        Me.GroupBox2.Location = New System.Drawing.Point(391, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 86)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(6, 19)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(123, 51)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(265, 19)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(123, 51)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar Mensaje"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'BtnEscribir
        '
        Me.BtnEscribir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEscribir.Location = New System.Drawing.Point(7, 19)
        Me.BtnEscribir.Name = "BtnEscribir"
        Me.BtnEscribir.Size = New System.Drawing.Size(123, 51)
        Me.BtnEscribir.TabIndex = 0
        Me.BtnEscribir.Text = "Escribir Mensaje"
        Me.BtnEscribir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Aquamarine
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1042, 43)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Comunicacion con los Clientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.Dgv_Listado.Location = New System.Drawing.Point(560, 113)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(494, 353)
        Me.Dgv_Listado.TabIndex = 10
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 125
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.Location = New System.Drawing.Point(562, 90)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(62, 17)
        Me.Chk_Eliminar.TabIndex = 12
        Me.Chk_Eliminar.Text = "Eliminar"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(762, 52)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(294, 21)
        Me.Txt_Buscar.TabIndex = 15
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(608, 52)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(148, 21)
        Me.Cmb_Buscar.TabIndex = 14
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Location = New System.Drawing.Point(563, 54)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.Lb_Buscar.TabIndex = 13
        Me.Lb_Buscar.Text = "Buscar"
        '
        'Comunicacion_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 480)
        Me.Controls.Add(Me.Txt_Buscar)
        Me.Controls.Add(Me.Cmb_Buscar)
        Me.Controls.Add(Me.Lb_Buscar)
        Me.Controls.Add(Me.Chk_Eliminar)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Comunicacion_Cliente"
        Me.Text = "Comunicacion_Cliente"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtAsunto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCorreoCli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEscribir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMensaje As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Chk_Eliminar As CheckBox
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents TxtCliCod As TextBox
    Friend WithEvents BtnCliente As Button
End Class
