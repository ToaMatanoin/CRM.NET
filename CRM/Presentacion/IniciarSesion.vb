Public Class IniciarSesion
    Public nuevo As New Conexion
    Public Bandera As New Boolean

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
End Class
