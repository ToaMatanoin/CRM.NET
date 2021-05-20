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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_UsuPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_UsuNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Inicio_Sesion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Txt_UsuPass)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_UsuNom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Inicio_Sesion)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 348)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Txt_UsuPass
        '
        Me.Txt_UsuPass.Location = New System.Drawing.Point(102, 272)
        Me.Txt_UsuPass.Name = "Txt_UsuPass"
        Me.Txt_UsuPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_UsuPass.Size = New System.Drawing.Size(100, 20)
        Me.Txt_UsuPass.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña:"
        '
        'Txt_UsuNom
        '
        Me.Txt_UsuNom.Location = New System.Drawing.Point(102, 246)
        Me.Txt_UsuNom.Name = "Txt_UsuNom"
        Me.Txt_UsuNom.Size = New System.Drawing.Size(100, 20)
        Me.Txt_UsuNom.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Inicio_Sesion
        '
        Me.Inicio_Sesion.Location = New System.Drawing.Point(8, 310)
        Me.Inicio_Sesion.Name = "Inicio_Sesion"
        Me.Inicio_Sesion.Size = New System.Drawing.Size(99, 23)
        Me.Inicio_Sesion.TabIndex = 0
        Me.Inicio_Sesion.Text = "Iniciar Sesion"
        Me.Inicio_Sesion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'IniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 372)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IniciarSesion"
        Me.Text = "Iniciar Sesion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_UsuPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_UsuNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Inicio_Sesion As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
