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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Comunicacion_Cliente))
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
        Me.BtnEscribir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.BtnCliente)
        Me.GroupBox3.Controls.Add(Me.TxtCliCod)
        Me.GroupBox3.Controls.Add(Me.TxtMensaje)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtAsunto)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtCorreoCli)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(528, 398)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'BtnCliente
        '
        Me.BtnCliente.BackColor = System.Drawing.Color.Silver
        Me.BtnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCliente.Enabled = False
        Me.BtnCliente.FlatAppearance.BorderSize = 0
        Me.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.Location = New System.Drawing.Point(445, 28)
        Me.BtnCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(77, 27)
        Me.BtnCliente.TabIndex = 17
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCliente.UseVisualStyleBackColor = False
        '
        'TxtCliCod
        '
        Me.TxtCliCod.Enabled = False
        Me.TxtCliCod.Location = New System.Drawing.Point(446, 31)
        Me.TxtCliCod.Name = "TxtCliCod"
        Me.TxtCliCod.Size = New System.Drawing.Size(35, 26)
        Me.TxtCliCod.TabIndex = 9
        Me.TxtCliCod.Visible = False
        '
        'TxtMensaje
        '
        Me.TxtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMensaje.Enabled = False
        Me.TxtMensaje.Location = New System.Drawing.Point(14, 119)
        Me.TxtMensaje.MaxLength = 250
        Me.TxtMensaje.Multiline = True
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(498, 260)
        Me.TxtMensaje.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Mensaje"
        '
        'TxtAsunto
        '
        Me.TxtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAsunto.Enabled = False
        Me.TxtAsunto.Location = New System.Drawing.Point(77, 63)
        Me.TxtAsunto.MaxLength = 40
        Me.TxtAsunto.Name = "TxtAsunto"
        Me.TxtAsunto.Size = New System.Drawing.Size(445, 19)
        Me.TxtAsunto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Asunto:"
        '
        'TxtCorreoCli
        '
        Me.TxtCorreoCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCorreoCli.Enabled = False
        Me.TxtCorreoCli.Location = New System.Drawing.Point(136, 31)
        Me.TxtCorreoCli.Name = "TxtCorreoCli"
        Me.TxtCorreoCli.Size = New System.Drawing.Size(304, 19)
        Me.TxtCorreoCli.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BtnEnviar)
        Me.GroupBox1.Controls.Add(Me.BtnEscribir)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 64)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.Silver
        Me.BtnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEnviar.FlatAppearance.BorderSize = 0
        Me.BtnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Image = CType(resources.GetObject("BtnEnviar.Image"), System.Drawing.Image)
        Me.BtnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnviar.Location = New System.Drawing.Point(281, 13)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(200, 40)
        Me.BtnEnviar.TabIndex = 3
        Me.BtnEnviar.Text = "      Enviar Mensaje"
        Me.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEnviar.UseVisualStyleBackColor = False
        Me.BtnEnviar.Visible = False
        '
        'BtnEscribir
        '
        Me.BtnEscribir.BackColor = System.Drawing.Color.Silver
        Me.BtnEscribir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEscribir.FlatAppearance.BorderSize = 0
        Me.BtnEscribir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnEscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEscribir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEscribir.Image = CType(resources.GetObject("BtnEscribir.Image"), System.Drawing.Image)
        Me.BtnEscribir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEscribir.Location = New System.Drawing.Point(32, 13)
        Me.BtnEscribir.Name = "BtnEscribir"
        Me.BtnEscribir.Size = New System.Drawing.Size(200, 40)
        Me.BtnEscribir.TabIndex = 0
        Me.BtnEscribir.Text = "     Escribir Mensaje"
        Me.BtnEscribir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEscribir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(547, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Comunicacion_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 545)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Comunicacion_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comunicacion_Cliente"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtAsunto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCorreoCli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEscribir As Button
    Friend WithEvents TxtMensaje As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents TxtCliCod As TextBox
    Friend WithEvents BtnCliente As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
