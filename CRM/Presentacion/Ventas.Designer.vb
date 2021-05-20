<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Cb_producto = New System.Windows.Forms.ComboBox()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtpreciounidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdclli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_ID_Venta = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnDevolucion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Rd_contado = New System.Windows.Forms.RadioButton()
        Me.Rd_credito = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Rd_tercera_no = New System.Windows.Forms.RadioButton()
        Me.Rd_tercera_si = New System.Windows.Forms.RadioButton()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Cb_producto)
        Me.GroupBox4.Controls.Add(Me.Txtcantidad)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Txtpreciounidad)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(939, 68)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(319, 133)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Información Compra"
        '
        'Cb_producto
        '
        Me.Cb_producto.FormattingEnabled = True
        Me.Cb_producto.Location = New System.Drawing.Point(139, 31)
        Me.Cb_producto.Margin = New System.Windows.Forms.Padding(4)
        Me.Cb_producto.Name = "Cb_producto"
        Me.Cb_producto.Size = New System.Drawing.Size(160, 27)
        Me.Cb_producto.TabIndex = 6
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(167, 100)
        Me.Txtcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(132, 26)
        Me.Txtcantidad.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad:"
        '
        'Txtpreciounidad
        '
        Me.Txtpreciounidad.Location = New System.Drawing.Point(167, 68)
        Me.Txtpreciounidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtpreciounidad.Name = "Txtpreciounidad"
        Me.Txtpreciounidad.Size = New System.Drawing.Size(132, 26)
        Me.Txtpreciounidad.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Precio unidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Producto:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dtp_fecha)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtIdclli)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 68)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(365, 113)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información Cliente"
        '
        'Dtp_fecha
        '
        Me.Dtp_fecha.Location = New System.Drawing.Point(75, 70)
        Me.Dtp_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.Dtp_fecha.Name = "Dtp_fecha"
        Me.Dtp_fecha.Size = New System.Drawing.Size(265, 26)
        Me.Dtp_fecha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'TxtIdclli
        '
        Me.TxtIdclli.Location = New System.Drawing.Point(107, 36)
        Me.TxtIdclli.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdclli.Name = "TxtIdclli"
        Me.TxtIdclli.Size = New System.Drawing.Size(233, 26)
        Me.TxtIdclli.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnDevolucion)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 188)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(216, 460)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Chk_Eliminar)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Txt_ID_Venta)
        Me.GroupBox5.Controls.Add(Me.BtnIngresar)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 23)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(185, 241)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Transacción"
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.Location = New System.Drawing.Point(36, 137)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(100, 23)
        Me.Chk_Eliminar.TabIndex = 12
        Me.Chk_Eliminar.Text = "Devolver"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID Venta"
        '
        'Txt_ID_Venta
        '
        Me.Txt_ID_Venta.Location = New System.Drawing.Point(21, 208)
        Me.Txt_ID_Venta.Name = "Txt_ID_Venta"
        Me.Txt_ID_Venta.Size = New System.Drawing.Size(140, 26)
        Me.Txt_ID_Venta.TabIndex = 4
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(10, 27)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(164, 63)
        Me.BtnIngresar.TabIndex = 3
        Me.BtnIngresar.Text = "Ingresar Venta"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnRegresar)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 342)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(184, 106)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(8, 23)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(164, 63)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnDevolucion
        '
        Me.BtnDevolucion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDevolucion.Location = New System.Drawing.Point(19, 272)
        Me.BtnDevolucion.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDevolucion.Name = "BtnDevolucion"
        Me.BtnDevolucion.Size = New System.Drawing.Size(164, 63)
        Me.BtnDevolucion.TabIndex = 2
        Me.BtnDevolucion.Text = "Devolución"
        Me.BtnDevolucion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Aquamarine
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1241, 53)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Gestion de Ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Rd_contado)
        Me.GroupBox6.Controls.Add(Me.Rd_credito)
        Me.GroupBox6.Location = New System.Drawing.Point(389, 68)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(267, 133)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo de Venta"
        '
        'Rd_contado
        '
        Me.Rd_contado.AutoSize = True
        Me.Rd_contado.Location = New System.Drawing.Point(28, 76)
        Me.Rd_contado.Margin = New System.Windows.Forms.Padding(4)
        Me.Rd_contado.Name = "Rd_contado"
        Me.Rd_contado.Size = New System.Drawing.Size(82, 21)
        Me.Rd_contado.TabIndex = 1
        Me.Rd_contado.TabStop = True
        Me.Rd_contado.Text = "Contado"
        Me.Rd_contado.UseVisualStyleBackColor = True
        '
        'Rd_credito
        '
        Me.Rd_credito.AutoSize = True
        Me.Rd_credito.Location = New System.Drawing.Point(28, 37)
        Me.Rd_credito.Margin = New System.Windows.Forms.Padding(4)
        Me.Rd_credito.Name = "Rd_credito"
        Me.Rd_credito.Size = New System.Drawing.Size(74, 21)
        Me.Rd_credito.TabIndex = 0
        Me.Rd_credito.TabStop = True
        Me.Rd_credito.Text = "Credito"
        Me.Rd_credito.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(664, 68)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(267, 133)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Descuento"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Rd_tercera_no)
        Me.GroupBox8.Controls.Add(Me.Rd_tercera_si)
        Me.GroupBox8.Location = New System.Drawing.Point(20, 31)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(215, 90)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Tercera Edad"
        '
        'Rd_tercera_no
        '
        Me.Rd_tercera_no.AutoSize = True
        Me.Rd_tercera_no.Location = New System.Drawing.Point(92, 37)
        Me.Rd_tercera_no.Margin = New System.Windows.Forms.Padding(4)
        Me.Rd_tercera_no.Name = "Rd_tercera_no"
        Me.Rd_tercera_no.Size = New System.Drawing.Size(50, 21)
        Me.Rd_tercera_no.TabIndex = 1
        Me.Rd_tercera_no.TabStop = True
        Me.Rd_tercera_no.Text = "NO"
        Me.Rd_tercera_no.UseVisualStyleBackColor = True
        '
        'Rd_tercera_si
        '
        Me.Rd_tercera_si.AutoSize = True
        Me.Rd_tercera_si.Location = New System.Drawing.Point(21, 37)
        Me.Rd_tercera_si.Margin = New System.Windows.Forms.Padding(4)
        Me.Rd_tercera_si.Name = "Rd_tercera_si"
        Me.Rd_tercera_si.Size = New System.Drawing.Size(41, 21)
        Me.Rd_tercera_si.TabIndex = 0
        Me.Rd_tercera_si.TabStop = True
        Me.Rd_tercera_si.Text = "SI"
        Me.Rd_tercera_si.UseVisualStyleBackColor = True
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.Dgv_Listado.Location = New System.Drawing.Point(248, 259)
        Me.Dgv_Listado.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(1009, 389)
        Me.Dgv_Listado.TabIndex = 13
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 125
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 655)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Txtcantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtpreciounidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdclli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnDevolucion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cb_producto As ComboBox
    Friend WithEvents Dtp_fecha As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Rd_contado As RadioButton
    Friend WithEvents Rd_credito As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Rd_tercera_no As RadioButton
    Friend WithEvents Rd_tercera_si As RadioButton
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_ID_Venta As TextBox
    Friend WithEvents Chk_Eliminar As CheckBox
End Class
