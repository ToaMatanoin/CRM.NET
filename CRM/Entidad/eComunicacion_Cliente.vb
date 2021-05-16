Public Class eComunicacion_Cliente
    Dim ID_Cliente, ID_Usuario, ID_Email As Integer
    Dim Email_Asunto, Email_Mensaje, Email_Fecha As String

    Public Property pID_Cliente
        Get
            Return ID_Cliente
        End Get
        Set(value)
            ID_Cliente = value
        End Set
    End Property

    Public Property pID_Usuario
        Get
            Return ID_Usuario
        End Get
        Set(value)
            ID_Usuario = value
        End Set
    End Property

    Public Property pID_Email
        Get
            Return ID_Email
        End Get
        Set(value)
            ID_Email = value
        End Set
    End Property

    Public Property pEmail_Asunto
        Get
            Return Email_Asunto
        End Get
        Set(value)
            Email_Asunto = value
        End Set
    End Property

    Public Property pEmail_Mensaje
        Get
            Return Email_Mensaje
        End Get
        Set(value)
            Email_Mensaje = value
        End Set
    End Property

    Public Property pEmail_Fecha
        Get
            Return Email_Fecha
        End Get
        Set(value)
            Email_Fecha = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(iD_Cliente As Integer, iD_Usuario As Integer, iD_Email As Integer, email_Asunto As String, email_Mensaje As String, email_Fecha As String)
        pID_Cliente = iD_Cliente
        pID_Usuario = iD_Usuario
        pID_Email = iD_Email
        pEmail_Asunto = email_Asunto
        pEmail_Mensaje = email_Mensaje
        pEmail_Fecha = email_Fecha
    End Sub
End Class
