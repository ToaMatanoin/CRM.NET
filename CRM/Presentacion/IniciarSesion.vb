Public Class IniciarSesion
    Public nuevo As New Conexion
    Public Bandera As New Boolean
    Public IDUSU, IDEMP, ROLUSU, PassEMP, EmailEMP As String


    Private Sub IniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuevo.ConexionDB()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Inicio_Sesion_Click(sender As Object, e As EventArgs) Handles Inicio_Sesion.Click
        Try
            If (Txt_UsuNom.Text.Equals("")) Then
                MsgBox("Ingresa un usuario")
            Else

                If nuevo.Usuario(Txt_UsuNom.Text) = True Then
                    Dim contra As String = nuevo.Contrasenha(Txt_UsuNom.Text)
                    If (Txt_UsuPass.Text.Equals("")) Then
                        MsgBox("Ingresa contrasea")
                    Else
                        If contra.Equals(Txt_UsuPass.Text) Then
                            nuevo.ConexionDB()
                            IDUSU = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "ID_Usuario", "Usuarios")
                            IDEMP = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "ID_Empleado", "Usuarios")
                            ROLUSU = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "Usu_Cargo", "Usuarios")
                            EmailEMP = nuevo.Buscar_info(IDEMP, "ID_Empleado", "Emp_Email", "Empleado")
                            PassEMP = nuevo.Buscar_info(IDEMP, "ID_Empleado", "Emp_Email_Pass", "Empleado")
                            Me.Hide()
                            Txt_UsuNom.Text = ""
                            Txt_UsuPass.Text = ""
                            Inicio.Show()
                        Else
                            MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                        End If
                    End If
                Else
                    MsgBox("El Usuario: " + Txt_UsuNom.Text + " no se encuentra registrado")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Password_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_UsuPass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Try
                    If (Txt_UsuNom.Text.Equals("")) Then
                        MsgBox("Ingresa un usuario")
                    Else

                        If nuevo.Usuario(Txt_UsuNom.Text) = True Then
                            Dim contra As String = nuevo.Contrasenha(Txt_UsuNom.Text)
                            If (Txt_UsuPass.Text.Equals("")) Then
                                MsgBox("Ingresa contrasea")
                            Else
                                If contra.Equals(Txt_UsuPass.Text) Then
                                    nuevo.ConexionDB()
                                    IDUSU = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "ID_Usuario", "Usuarios")
                                    IDEMP = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "ID_Empleado", "Usuarios")
                                    ROLUSU = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "Usu_Cargo", "Usuarios")
                                    Me.Hide()
                                    Txt_UsuNom.Text = ""
                                    Txt_UsuPass.Text = ""
                                    Inicio.Show()
                                Else
                                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                                End If
                            End If
                        Else
                            MsgBox("El Usuario: " + Txt_UsuNom.Text + " no se encuentra registrado")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select
    End Sub

    Private Sub Usuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_UsuNom.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Try
                    If (Txt_UsuNom.Text.Equals("")) Then
                        MsgBox("Ingresa un usuario")
                    Else

                        If nuevo.Usuario(Txt_UsuNom.Text) = True Then
                            Dim contra As String = nuevo.Contrasenha(Txt_UsuNom.Text)
                            If (Txt_UsuPass.Text.Equals("")) Then
                                MsgBox("Ingresa contrasea")
                            Else
                                If contra.Equals(Txt_UsuPass.Text) Then
                                    nuevo.ConexionDB()
                                    IDUSU = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "ID_Usuario", "Usuarios")
                                    IDEMP = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "ID_Empleado", "Usuarios")
                                    ROLUSU = nuevo.Buscar_info(Txt_UsuNom.Text, "Usu_Nombre", "Usu_Cargo", "Usuarios")
                                    Me.Hide()
                                    Txt_UsuNom.Text = ""
                                    Txt_UsuPass.Text = ""
                                    Inicio.Show()
                                Else
                                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                                End If
                            End If
                        Else
                            MsgBox("El Usuario: " + Txt_UsuNom.Text + " no se encuentra registrado")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select
    End Sub

End Class
