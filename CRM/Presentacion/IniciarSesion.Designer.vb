<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IniciarSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniciarSesion))
        Me.Txt_UsuPass = New System.Windows.Forms.TextBox()
        Me.Txt_UsuNom = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Inicio_Sesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_UsuPass
        '
        Me.Txt_UsuPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_UsuPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_UsuPass.ForeColor = System.Drawing.Color.DarkGray
        Me.Txt_UsuPass.Location = New System.Drawing.Point(301, 158)
        Me.Txt_UsuPass.Name = "Txt_UsuPass"
        Me.Txt_UsuPass.Size = New System.Drawing.Size(439, 19)
        Me.Txt_UsuPass.TabIndex = 2
        Me.Txt_UsuPass.Text = "CONTRASEÑA"
        '
        'Txt_UsuNom
        '
        Me.Txt_UsuNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_UsuNom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_UsuNom.ForeColor = System.Drawing.Color.DarkGray
        Me.Txt_UsuNom.Location = New System.Drawing.Point(301, 96)
        Me.Txt_UsuNom.Name = "Txt_UsuNom"
        Me.Txt_UsuNom.Size = New System.Drawing.Size(439, 19)
        Me.Txt_UsuNom.TabIndex = 1
        Me.Txt_UsuNom.Text = "USUARIO"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(540, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Inicio_Sesion
        '
        Me.Inicio_Sesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Inicio_Sesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inicio_Sesion.FlatAppearance.BorderSize = 0
        Me.Inicio_Sesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Inicio_Sesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Inicio_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inicio_Sesion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio_Sesion.ForeColor = System.Drawing.Color.Black
        Me.Inicio_Sesion.Location = New System.Drawing.Point(301, 238)
        Me.Inicio_Sesion.Name = "Inicio_Sesion"
        Me.Inicio_Sesion.Size = New System.Drawing.Size(200, 40)
        Me.Inicio_Sesion.TabIndex = 3
        Me.Inicio_Sesion.Text = "Iniciar Sesion"
        Me.Inicio_Sesion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 330)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 190)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(464, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(298, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(442, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------------------------------------"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(298, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(442, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------------------------------------"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(780, 330)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txt_UsuPass)
        Me.Controls.Add(Me.Txt_UsuNom)
        Me.Controls.Add(Me.Inicio_Sesion)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_UsuPass As TextBox
    Friend WithEvents Txt_UsuNom As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Inicio_Sesion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
