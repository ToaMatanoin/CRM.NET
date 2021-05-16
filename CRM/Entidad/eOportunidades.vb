Public Class eOportunidades

    Dim ID_ClientePot, CliPot_Telefono, ID_Usuario, Posibilidad As Integer
    Dim CliPot_Nombre, CliPot_Email, Descrip As String

    Public Property pID_ClientePot
        Get
            Return ID_ClientePot
        End Get
        Set(value)
            ID_ClientePot = value
        End Set
    End Property

    Public Property pCliPot_Telefono
        Get
            Return CliPot_Telefono
        End Get
        Set(value)
            CliPot_Telefono = value
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

    Public Property pPosibilidad
        Get
            Return Posibilidad
        End Get
        Set(value)
            Posibilidad = value
        End Set
    End Property

    Public Property pCliPot_Nombre
        Get
            Return CliPot_Nombre
        End Get
        Set(value)
            CliPot_Nombre = value
        End Set
    End Property

    Public Property pCliPot_Email
        Get
            Return CliPot_Email
        End Get
        Set(value)
            CliPot_Email = value
        End Set
    End Property

    Public Property pDescrip
        Get
            Return Descrip
        End Get
        Set(value)
            Descrip = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(iD_ClientePot As Integer, cliPot_Telefono As Integer, iD_Usuario As Integer, posibilidad As Integer, cliPot_Nombre As String, cliPot_Email As String, descrip As String)
        pID_ClientePot = iD_ClientePot
        pCliPot_Telefono = cliPot_Telefono
        pID_Usuario = iD_Usuario
        pPosibilidad = posibilidad
        pCliPot_Nombre = cliPot_Nombre
        pCliPot_Email = cliPot_Email
        pDescrip = descrip
    End Sub
End Class
