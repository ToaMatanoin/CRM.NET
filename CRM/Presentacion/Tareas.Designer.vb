<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tareas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tareas))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Dgvtp = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Chb_eliminarPT = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Btn_EliminarPT = New System.Windows.Forms.Button()
        Me.Btn_NuevoPT = New System.Windows.Forms.Button()
        Me.Btn_ModificarPT = New System.Windows.Forms.Button()
        Me.Btn_ingresarPT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidmark = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_idproy = New System.Windows.Forms.TextBox()
        Me.DTPFechaFinalProyecto = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaInicioProyecto = New System.Windows.Forms.DateTimePicker()
        Me.TxtDescripProyecto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNom_proyec = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dgvtp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Lb_Buscar)
        Me.GroupBox5.Controls.Add(Me.Cmb_Buscar)
        Me.GroupBox5.Controls.Add(Me.Txt_Buscar)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(678, 58)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Buscar.Location = New System.Drawing.Point(11, 22)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(57, 18)
        Me.Lb_Buscar.TabIndex = 10
        Me.Lb_Buscar.Text = "Buscar"
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(73, 18)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(218, 28)
        Me.Cmb_Buscar.TabIndex = 11
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Buscar.Location = New System.Drawing.Point(297, 18)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(351, 28)
        Me.Txt_Buscar.TabIndex = 12
        '
        'Dgvtp
        '
        Me.Dgvtp.AllowUserToAddRows = False
        Me.Dgvtp.AllowUserToDeleteRows = False
        Me.Dgvtp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgvtp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgvtp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgvtp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgvtp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgvtp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgvtp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvtp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvtp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvtp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgvtp.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgvtp.EnableHeadersVisualStyles = False
        Me.Dgvtp.GridColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Dgvtp.Location = New System.Drawing.Point(12, 325)
        Me.Dgvtp.Name = "Dgvtp"
        Me.Dgvtp.ReadOnly = True
        Me.Dgvtp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgvtp.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgvtp.RowHeadersVisible = False
        Me.Dgvtp.RowHeadersWidth = 51
        Me.Dgvtp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvtp.Size = New System.Drawing.Size(654, 324)
        Me.Dgvtp.TabIndex = 45
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 59
        '
        'Chb_eliminarPT
        '
        Me.Chb_eliminarPT.AutoSize = True
        Me.Chb_eliminarPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chb_eliminarPT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_eliminarPT.Location = New System.Drawing.Point(12, 300)
        Me.Chb_eliminarPT.Margin = New System.Windows.Forms.Padding(2)
        Me.Chb_eliminarPT.Name = "Chb_eliminarPT"
        Me.Chb_eliminarPT.Size = New System.Drawing.Size(71, 20)
        Me.Chb_eliminarPT.TabIndex = 44
        Me.Chb_eliminarPT.Text = "Eliminar"
        Me.Chb_eliminarPT.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.Btn_EliminarPT)
        Me.GroupBox6.Controls.Add(Me.Btn_NuevoPT)
        Me.GroupBox6.Controls.Add(Me.Btn_ModificarPT)
        Me.GroupBox6.Controls.Add(Me.Btn_ingresarPT)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(654, 86)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        '
        'Btn_EliminarPT
        '
        Me.Btn_EliminarPT.BackColor = System.Drawing.Color.Silver
        Me.Btn_EliminarPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EliminarPT.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Btn_EliminarPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EliminarPT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EliminarPT.Image = CType(resources.GetObject("Btn_EliminarPT.Image"), System.Drawing.Image)
        Me.Btn_EliminarPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_EliminarPT.Location = New System.Drawing.Point(422, 15)
        Me.Btn_EliminarPT.Name = "Btn_EliminarPT"
        Me.Btn_EliminarPT.Size = New System.Drawing.Size(122, 61)
        Me.Btn_EliminarPT.TabIndex = 1
        Me.Btn_EliminarPT.Text = "Eliminar Tarea"
        Me.Btn_EliminarPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_EliminarPT.UseVisualStyleBackColor = False
        '
        'Btn_NuevoPT
        '
        Me.Btn_NuevoPT.BackColor = System.Drawing.Color.Silver
        Me.Btn_NuevoPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NuevoPT.FlatAppearance.BorderSize = 0
        Me.Btn_NuevoPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Btn_NuevoPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_NuevoPT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NuevoPT.Image = CType(resources.GetObject("Btn_NuevoPT.Image"), System.Drawing.Image)
        Me.Btn_NuevoPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_NuevoPT.Location = New System.Drawing.Point(14, 15)
        Me.Btn_NuevoPT.Name = "Btn_NuevoPT"
        Me.Btn_NuevoPT.Size = New System.Drawing.Size(122, 61)
        Me.Btn_NuevoPT.TabIndex = 2
        Me.Btn_NuevoPT.Text = "Nuevo Tarea"
        Me.Btn_NuevoPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_NuevoPT.UseVisualStyleBackColor = False
        '
        'Btn_ModificarPT
        '
        Me.Btn_ModificarPT.BackColor = System.Drawing.Color.Silver
        Me.Btn_ModificarPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ModificarPT.FlatAppearance.BorderSize = 0
        Me.Btn_ModificarPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Btn_ModificarPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ModificarPT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ModificarPT.Image = CType(resources.GetObject("Btn_ModificarPT.Image"), System.Drawing.Image)
        Me.Btn_ModificarPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ModificarPT.Location = New System.Drawing.Point(270, 15)
        Me.Btn_ModificarPT.Name = "Btn_ModificarPT"
        Me.Btn_ModificarPT.Size = New System.Drawing.Size(146, 61)
        Me.Btn_ModificarPT.TabIndex = 2
        Me.Btn_ModificarPT.Text = "Modificar  Tarea"
        Me.Btn_ModificarPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ModificarPT.UseVisualStyleBackColor = False
        '
        'Btn_ingresarPT
        '
        Me.Btn_ingresarPT.BackColor = System.Drawing.Color.Silver
        Me.Btn_ingresarPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ingresarPT.FlatAppearance.BorderSize = 0
        Me.Btn_ingresarPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Btn_ingresarPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ingresarPT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ingresarPT.Image = CType(resources.GetObject("Btn_ingresarPT.Image"), System.Drawing.Image)
        Me.Btn_ingresarPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ingresarPT.Location = New System.Drawing.Point(142, 15)
        Me.Btn_ingresarPT.Name = "Btn_ingresarPT"
        Me.Btn_ingresarPT.Size = New System.Drawing.Size(122, 61)
        Me.Btn_ingresarPT.TabIndex = 0
        Me.Btn_ingresarPT.Text = "Ingresar Tarea"
        Me.Btn_ingresarPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ingresarPT.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtidmark)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_idproy)
        Me.GroupBox1.Controls.Add(Me.DTPFechaFinalProyecto)
        Me.GroupBox1.Controls.Add(Me.DTPFechaInicioProyecto)
        Me.GroupBox1.Controls.Add(Me.TxtDescripProyecto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtNom_proyec)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 130)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'txtidmark
        '
        Me.txtidmark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidmark.Enabled = False
        Me.txtidmark.Location = New System.Drawing.Point(172, 13)
        Me.txtidmark.Margin = New System.Windows.Forms.Padding(2)
        Me.txtidmark.Name = "txtidmark"
        Me.txtidmark.Size = New System.Drawing.Size(76, 19)
        Me.txtidmark.TabIndex = 15
        Me.txtidmark.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo :"
        '
        'txt_idproy
        '
        Me.txt_idproy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_idproy.Enabled = False
        Me.txt_idproy.Location = New System.Drawing.Point(84, 13)
        Me.txt_idproy.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_idproy.Name = "txt_idproy"
        Me.txt_idproy.Size = New System.Drawing.Size(76, 19)
        Me.txt_idproy.TabIndex = 12
        '
        'DTPFechaFinalProyecto
        '
        Me.DTPFechaFinalProyecto.CustomFormat = "dd-MM-yyyy"
        Me.DTPFechaFinalProyecto.Enabled = False
        Me.DTPFechaFinalProyecto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaFinalProyecto.Location = New System.Drawing.Point(108, 94)
        Me.DTPFechaFinalProyecto.Name = "DTPFechaFinalProyecto"
        Me.DTPFechaFinalProyecto.Size = New System.Drawing.Size(140, 26)
        Me.DTPFechaFinalProyecto.TabIndex = 9
        '
        'DTPFechaInicioProyecto
        '
        Me.DTPFechaInicioProyecto.CustomFormat = "dd-MM-yyyy"
        Me.DTPFechaInicioProyecto.Enabled = False
        Me.DTPFechaInicioProyecto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaInicioProyecto.Location = New System.Drawing.Point(108, 62)
        Me.DTPFechaInicioProyecto.Name = "DTPFechaInicioProyecto"
        Me.DTPFechaInicioProyecto.Size = New System.Drawing.Size(140, 26)
        Me.DTPFechaInicioProyecto.TabIndex = 8
        '
        'TxtDescripProyecto
        '
        Me.TxtDescripProyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescripProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripProyecto.Enabled = False
        Me.TxtDescripProyecto.Location = New System.Drawing.Point(285, 37)
        Me.TxtDescripProyecto.MaxLength = 100
        Me.TxtDescripProyecto.Multiline = True
        Me.TxtDescripProyecto.Name = "TxtDescripProyecto"
        Me.TxtDescripProyecto.Size = New System.Drawing.Size(351, 83)
        Me.TxtDescripProyecto.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(282, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Descripción:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Fecha Final:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha Inicio:"
        '
        'TxtNom_proyec
        '
        Me.TxtNom_proyec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNom_proyec.Enabled = False
        Me.TxtNom_proyec.Location = New System.Drawing.Point(84, 37)
        Me.TxtNom_proyec.MaxLength = 30
        Me.TxtNom_proyec.Name = "TxtNom_proyec"
        Me.TxtNom_proyec.Size = New System.Drawing.Size(164, 19)
        Me.TxtNom_proyec.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Nombre :"
        '
        'Tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(678, 661)
        Me.Controls.Add(Me.Dgvtp)
        Me.Controls.Add(Me.Chb_eliminarPT)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tareas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tareas"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Dgvtp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Dgvtp As DataGridView
    Friend WithEvents Chb_eliminarPT As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Btn_EliminarPT As Button
    Friend WithEvents Btn_NuevoPT As Button
    Friend WithEvents Btn_ModificarPT As Button
    Friend WithEvents Btn_ingresarPT As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_idproy As TextBox
    Friend WithEvents DTPFechaFinalProyecto As DateTimePicker
    Friend WithEvents DTPFechaInicioProyecto As DateTimePicker
    Friend WithEvents TxtDescripProyecto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtNom_proyec As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents txtidmark As TextBox
End Class
