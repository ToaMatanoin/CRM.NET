<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCargo = New System.Windows.Forms.ComboBox()
        Me.TxtPasswordEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIDEmp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtEmailEmp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTelEmp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomEmp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chk_Eliminar = New System.Windows.Forms.CheckBox()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.txtCargo)
        Me.GroupBox3.Controls.Add(Me.TxtPasswordEmail)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtDireccion)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtIDEmp)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtEmailEmp)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtTelEmp)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtNomEmp)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(648, 185)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'txtCargo
        '
        Me.txtCargo.AutoCompleteCustomSource.AddRange(New String() {"Administrador", "Caja"})
        Me.txtCargo.Enabled = False
        Me.txtCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtCargo.FormattingEnabled = True
        Me.txtCargo.Items.AddRange(New Object() {"Admin", "Gestión Ventas", "Campañas Marketing", "Gestión Inventario", "Gestión Clientes"})
        Me.txtCargo.Location = New System.Drawing.Point(175, 146)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(213, 28)
        Me.txtCargo.TabIndex = 13
        '
        'TxtPasswordEmail
        '
        Me.TxtPasswordEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPasswordEmail.Enabled = False
        Me.TxtPasswordEmail.Location = New System.Drawing.Point(175, 121)
        Me.TxtPasswordEmail.MaxLength = 45
        Me.TxtPasswordEmail.Name = "TxtPasswordEmail"
        Me.TxtPasswordEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordEmail.Size = New System.Drawing.Size(213, 19)
        Me.TxtPasswordEmail.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Contraseña Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cargo Empleado:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDireccion.Enabled = False
        Me.TxtDireccion.Location = New System.Drawing.Point(414, 42)
        Me.TxtDireccion.MaxLength = 100
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(221, 129)
        Me.TxtDireccion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(411, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección: "
        '
        'TxtIDEmp
        '
        Me.TxtIDEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIDEmp.Enabled = False
        Me.TxtIDEmp.Location = New System.Drawing.Point(300, 21)
        Me.TxtIDEmp.Name = "TxtIDEmp"
        Me.TxtIDEmp.Size = New System.Drawing.Size(88, 19)
        Me.TxtIDEmp.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Codigo: "
        '
        'TxtEmailEmp
        '
        Me.TxtEmailEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmailEmp.Enabled = False
        Me.TxtEmailEmp.Location = New System.Drawing.Point(175, 96)
        Me.TxtEmailEmp.MaxLength = 45
        Me.TxtEmailEmp.Name = "TxtEmailEmp"
        Me.TxtEmailEmp.Size = New System.Drawing.Size(213, 19)
        Me.TxtEmailEmp.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-mail Empleado:"
        '
        'TxtTelEmp
        '
        Me.TxtTelEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelEmp.Enabled = False
        Me.TxtTelEmp.Location = New System.Drawing.Point(175, 71)
        Me.TxtTelEmp.MaxLength = 8
        Me.TxtTelEmp.Name = "TxtTelEmp"
        Me.TxtTelEmp.Size = New System.Drawing.Size(213, 19)
        Me.TxtTelEmp.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono Empleado:"
        '
        'TxtNomEmp
        '
        Me.TxtNomEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNomEmp.Enabled = False
        Me.TxtNomEmp.Location = New System.Drawing.Point(175, 46)
        Me.TxtNomEmp.MaxLength = 45
        Me.TxtNomEmp.Name = "TxtNomEmp"
        Me.TxtNomEmp.Size = New System.Drawing.Size(213, 19)
        Me.TxtNomEmp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre Empleado:"
        '
        'Chk_Eliminar
        '
        Me.Chk_Eliminar.AutoSize = True
        Me.Chk_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chk_Eliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Eliminar.Location = New System.Drawing.Point(10, 362)
        Me.Chk_Eliminar.Name = "Chk_Eliminar"
        Me.Chk_Eliminar.Size = New System.Drawing.Size(81, 22)
        Me.Chk_Eliminar.TabIndex = 21
        Me.Chk_Eliminar.Text = "Eliminar"
        Me.Chk_Eliminar.UseVisualStyleBackColor = True
        '
        'Dgv_Listado
        '
        Me.Dgv_Listado.AllowUserToAddRows = False
        Me.Dgv_Listado.AllowUserToDeleteRows = False
        Me.Dgv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_Listado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_Listado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_Listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgv_Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Listado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Listado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Listado.EnableHeadersVisualStyles = False
        Me.Dgv_Listado.GridColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Dgv_Listado.Location = New System.Drawing.Point(12, 390)
        Me.Dgv_Listado.Name = "Dgv_Listado"
        Me.Dgv_Listado.ReadOnly = True
        Me.Dgv_Listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Listado.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Listado.RowHeadersVisible = False
        Me.Dgv_Listado.RowHeadersWidth = 51
        Me.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Listado.Size = New System.Drawing.Size(647, 259)
        Me.Dgv_Listado.TabIndex = 19
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 65
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Buscar.Location = New System.Drawing.Point(281, 20)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(378, 26)
        Me.Txt_Buscar.TabIndex = 23
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(71, 20)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(204, 26)
        Me.Cmb_Buscar.TabIndex = 22
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Buscar.Location = New System.Drawing.Point(6, 22)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(59, 20)
        Me.Lb_Buscar.TabIndex = 20
        Me.Lb_Buscar.Text = "Buscar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Silver
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(485, 17)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(150, 61)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "Eliminar Empleado"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Silver
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(328, 17)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(151, 61)
        Me.BtnModificar.TabIndex = 16
        Me.BtnModificar.Text = "Modificar Empleado"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Silver
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatAppearance.BorderSize = 0
        Me.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Image = CType(resources.GetObject("BtnIngresar.Image"), System.Drawing.Image)
        Me.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngresar.Location = New System.Drawing.Point(171, 17)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(151, 61)
        Me.BtnIngresar.TabIndex = 13
        Me.BtnIngresar.Text = "Ingresar Empleado"
        Me.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Silver
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(14, 17)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(151, 61)
        Me.BtnNuevo.TabIndex = 26
        Me.BtnNuevo.Text = "Nuevo Empleado"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnNuevo)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.BtnIngresar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 91)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Lb_Buscar)
        Me.GroupBox1.Controls.Add(Me.Cmb_Buscar)
        Me.GroupBox1.Controls.Add(Me.Txt_Buscar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 59)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(678, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Chk_Eliminar)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtIDEmp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtEmailEmp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTelEmp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNomEmp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Chk_Eliminar As CheckBox
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPasswordEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCargo As ComboBox
End Class
