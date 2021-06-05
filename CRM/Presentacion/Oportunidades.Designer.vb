<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Oportunidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Oportunidades))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPosibilidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtIDClientePot = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmailCli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTelCli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Convertir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Chk_Convertir = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(403, 374)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "%"
        '
        'TxtPosibilidad
        '
        Me.TxtPosibilidad.Enabled = False
        Me.TxtPosibilidad.Location = New System.Drawing.Point(285, 369)
        Me.TxtPosibilidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPosibilidad.Name = "TxtPosibilidad"
        Me.TxtPosibilidad.Size = New System.Drawing.Size(108, 30)
        Me.TxtPosibilidad.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 374)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Posibilidad de Exito:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TxtIDClientePot)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtEmailCli)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtTelCli)
        Me.GroupBox3.Controls.Add(Me.TxtPosibilidad)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtNomCli)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(67, 256)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(457, 425)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Persona a Cargo"
        '
        'TxtIDClientePot
        '
        Me.TxtIDClientePot.Enabled = False
        Me.TxtIDClientePot.Location = New System.Drawing.Point(319, 31)
        Me.TxtIDClientePot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtIDClientePot.Name = "TxtIDClientePot"
        Me.TxtIDClientePot.Size = New System.Drawing.Size(119, 30)
        Me.TxtIDClientePot.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "ID Cliente Pot:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(152, 188)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(285, 173)
        Me.TxtDescripcion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Descripción:"
        '
        'TxtEmailCli
        '
        Me.TxtEmailCli.Enabled = False
        Me.TxtEmailCli.Location = New System.Drawing.Point(212, 149)
        Me.TxtEmailCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEmailCli.MaxLength = 30
        Me.TxtEmailCli.Name = "TxtEmailCli"
        Me.TxtEmailCli.Size = New System.Drawing.Size(225, 30)
        Me.TxtEmailCli.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-mail Cliente:"
        '
        'TxtTelCli
        '
        Me.TxtTelCli.Enabled = False
        Me.TxtTelCli.Location = New System.Drawing.Point(212, 110)
        Me.TxtTelCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelCli.Name = "TxtTelCli"
        Me.TxtTelCli.Size = New System.Drawing.Size(225, 30)
        Me.TxtTelCli.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono Cliente:"
        '
        'TxtNomCli
        '
        Me.TxtNomCli.Enabled = False
        Me.TxtNomCli.Location = New System.Drawing.Point(212, 70)
        Me.TxtNomCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNomCli.MaxLength = 40
        Me.TxtNomCli.Name = "TxtNomCli"
        Me.TxtNomCli.Size = New System.Drawing.Size(225, 30)
        Me.TxtNomCli.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnConvertir)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnIngresar)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(893, 106)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'btnConvertir
        '
        Me.btnConvertir.BackColor = System.Drawing.Color.Silver
        Me.btnConvertir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConvertir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(707, 20)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(164, 75)
        Me.btnConvertir.TabIndex = 4
        Me.btnConvertir.Text = "Convertir Cliente"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Silver
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(19, 20)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(164, 75)
        Me.BtnNuevo.TabIndex = 3
        Me.BtnNuevo.Text = "Nuevo Cliente"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Silver
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(363, 20)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(164, 75)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar Cliente"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Silver
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(535, 20)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(164, 75)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar Cliente"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Silver
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(191, 20)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(164, 75)
        Me.BtnIngresar.TabIndex = 0
        Me.BtnIngresar.Text = "Ingresar Cliente"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(305, 39)
        Me.Txt_Buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(248, 31)
        Me.Txt_Buscar.TabIndex = 23
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(100, 39)
        Me.Cmb_Buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(196, 31)
        Me.Cmb_Buscar.TabIndex = 22
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Location = New System.Drawing.Point(16, 44)
        Me.Lb_Buscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(71, 23)
        Me.Lb_Buscar.TabIndex = 21
        Me.Lb_Buscar.Text = "Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnRegresar)
        Me.GroupBox2.Location = New System.Drawing.Point(1565, 114)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(184, 106)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Silver
        Me.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnRegresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(8, 23)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(164, 63)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.Location = New System.Drawing.Point(601, 228)
        Me.Chk_Eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(80, 21)
        Me.Chk_Eliminar.TabIndex = 20
        Me.Chk_Eliminar.Text = "Eliminar"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar, Me.Convertir})
        Me.Dgv_Listado.Location = New System.Drawing.Point(601, 256)
        Me.Dgv_Listado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(1136, 421)
        Me.Dgv_Listado.TabIndex = 21
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 125
        '
        'Convertir
        '
        Me.Convertir.HeaderText = "Convertir"
        Me.Convertir.MinimumWidth = 6
        Me.Convertir.Name = "Convertir"
        Me.Convertir.ReadOnly = True
        Me.Convertir.Width = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1832, 111)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Cmb_Buscar)
        Me.GroupBox4.Controls.Add(Me.Lb_Buscar)
        Me.GroupBox4.Controls.Add(Me.Txt_Buscar)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(968, 114)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(589, 106)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'Chk_Convertir
        '
        Me.Chk_Convertir.AutoSize = True
        Me.Chk_Convertir.Location = New System.Drawing.Point(692, 228)
        Me.Chk_Convertir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chk_Convertir.Name = "Chk_Convertir"
        Me.Chk_Convertir.Size = New System.Drawing.Size(146, 21)
        Me.Chk_Convertir.TabIndex = 26
        Me.Chk_Convertir.Text = "Convertir a Cliente"
        Me.Chk_Convertir.UseVisualStyleBackColor = True
        '
        'Oportunidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1827, 706)
        Me.Controls.Add(Me.Chk_Convertir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Chk_Eliminar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Oportunidades"
        Me.Text = "Oportunidades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPosibilidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmailCli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTelCli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNomCli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents TxtIDClientePot As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Chk_Eliminar As CheckBox
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents Chk_Convertir As CheckBox
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Convertir As DataGridViewCheckBoxColumn
End Class
