<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargarDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargarDatos))
        Me.Lb_Buscar = New System.Windows.Forms.Label()
        Me.Cmb_Buscar = New System.Windows.Forms.ComboBox()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Dgv_Listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.TxtEmailCli = New System.Windows.Forms.TextBox()
        Me.TxtCargoEmp = New System.Windows.Forms.TextBox()
        Me.TxtNomEmpl = New System.Windows.Forms.TextBox()
        Me.TxtIDEmp = New System.Windows.Forms.TextBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lb_Buscar
        '
        Me.Lb_Buscar.AutoSize = True
        Me.Lb_Buscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Buscar.Location = New System.Drawing.Point(10, 25)
        Me.Lb_Buscar.Name = "Lb_Buscar"
        Me.Lb_Buscar.Size = New System.Drawing.Size(57, 18)
        Me.Lb_Buscar.TabIndex = 19
        Me.Lb_Buscar.Text = "Buscar"
        '
        'Cmb_Buscar
        '
        Me.Cmb_Buscar.FormattingEnabled = True
        Me.Cmb_Buscar.Location = New System.Drawing.Point(73, 25)
        Me.Cmb_Buscar.Name = "Cmb_Buscar"
        Me.Cmb_Buscar.Size = New System.Drawing.Size(148, 21)
        Me.Cmb_Buscar.TabIndex = 20
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Buscar.Location = New System.Drawing.Point(227, 25)
        Me.Txt_Buscar.Multiline = True
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(287, 22)
        Me.Txt_Buscar.TabIndex = 21
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
        Me.Dgv_Listado.Location = New System.Drawing.Point(10, 58)
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
        Me.Dgv_Listado.Size = New System.Drawing.Size(924, 431)
        Me.Dgv_Listado.TabIndex = 18
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Width = 65
        '
        'BtnCargar
        '
        Me.BtnCargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCargar.FlatAppearance.BorderSize = 0
        Me.BtnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.Image = CType(resources.GetObject("BtnCargar.Image"), System.Drawing.Image)
        Me.BtnCargar.Location = New System.Drawing.Point(742, 12)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(131, 40)
        Me.BtnCargar.TabIndex = 22
        Me.BtnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCargar.UseVisualStyleBackColor = False
        '
        'TxtEmailCli
        '
        Me.TxtEmailCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmailCli.Location = New System.Drawing.Point(329, 239)
        Me.TxtEmailCli.Multiline = True
        Me.TxtEmailCli.Name = "TxtEmailCli"
        Me.TxtEmailCli.Size = New System.Drawing.Size(287, 22)
        Me.TxtEmailCli.TabIndex = 23
        Me.TxtEmailCli.Visible = False
        '
        'TxtCargoEmp
        '
        Me.TxtCargoEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCargoEmp.Enabled = False
        Me.TxtCargoEmp.Location = New System.Drawing.Point(606, 160)
        Me.TxtCargoEmp.Name = "TxtCargoEmp"
        Me.TxtCargoEmp.Size = New System.Drawing.Size(161, 13)
        Me.TxtCargoEmp.TabIndex = 25
        Me.TxtCargoEmp.Visible = False
        '
        'TxtNomEmpl
        '
        Me.TxtNomEmpl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNomEmpl.Enabled = False
        Me.TxtNomEmpl.Location = New System.Drawing.Point(606, 135)
        Me.TxtNomEmpl.Name = "TxtNomEmpl"
        Me.TxtNomEmpl.Size = New System.Drawing.Size(161, 13)
        Me.TxtNomEmpl.TabIndex = 24
        Me.TxtNomEmpl.Visible = False
        '
        'TxtIDEmp
        '
        Me.TxtIDEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIDEmp.Enabled = False
        Me.TxtIDEmp.Location = New System.Drawing.Point(440, 120)
        Me.TxtIDEmp.Name = "TxtIDEmp"
        Me.TxtIDEmp.Size = New System.Drawing.Size(88, 13)
        Me.TxtIDEmp.TabIndex = 26
        Me.TxtIDEmp.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(879, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(53, 40)
        Me.BtnCerrar.TabIndex = 27
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'CargarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.TxtIDEmp)
        Me.Controls.Add(Me.TxtCargoEmp)
        Me.Controls.Add(Me.TxtNomEmpl)
        Me.Controls.Add(Me.TxtEmailCli)
        Me.Controls.Add(Me.BtnCargar)
        Me.Controls.Add(Me.Lb_Buscar)
        Me.Controls.Add(Me.Cmb_Buscar)
        Me.Controls.Add(Me.Txt_Buscar)
        Me.Controls.Add(Me.Dgv_Listado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CargarDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CargarDatos"
        CType(Me.Dgv_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_Buscar As Label
    Friend WithEvents Cmb_Buscar As ComboBox
    Friend WithEvents Txt_Buscar As TextBox
    Friend WithEvents Dgv_Listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents BtnCargar As Button
    Friend WithEvents TxtEmailCli As TextBox
    Friend WithEvents TxtCargoEmp As TextBox
    Friend WithEvents TxtNomEmpl As TextBox
    Friend WithEvents TxtIDEmp As TextBox
    Friend WithEvents BtnCerrar As Button
End Class
