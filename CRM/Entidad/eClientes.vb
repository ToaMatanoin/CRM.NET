Public Class eClientes

    Dim ID_Cliente, Cli_Telefono, Cli_TelEmpresa As Integer
    Dim Cli_Nombre, Cli_Email, Cli_NombreEmpresa,
        Cli_EmailEmpresa, RTN As String

    Public Property pID_Cliente
        Get
            Return ID_Cliente
        End Get
        Set(value)
            ID_Cliente = value
        End Set
    End Property

    Public Property pCli_Nombre
        Get
            Return Cli_Nombre
        End Get
        Set(value)
            Cli_Nombre = value
        End Set
    End Property

    Public Property pCli_Telefono
        Get
            Return Cli_Telefono
        End Get
        Set(value)
            Cli_Telefono = value
        End Set
    End Property

    Public Property pCli_Email
        Get
            Return Cli_Email
        End Get
        Set(value)
            Cli_Email = value
        End Set
    End Property

    Public Property pCli_NombreEmpresa
        Get
            Return Cli_NombreEmpresa
        End Get
        Set(value)
            Cli_NombreEmpresa = value
        End Set
    End Property

    Public Property pCli_TelEmpresa
        Get
            Return Cli_TelEmpresa
        End Get
        Set(value)
            Cli_TelEmpresa = value
        End Set
    End Property

    Public Property pCli_EmailEmpresa
        Get
            Return Cli_EmailEmpresa
        End Get
        Set(value)
            Cli_EmailEmpresa = value
        End Set
    End Property

    Public Property pRTN
        Get
            Return RTN
        End Get
        Set(value)
            RTN = value
        End Set
    End Property

    Public Sub New() 'Constructor Vacio
    End Sub

    Public Sub New(ID_Cliente As Integer, Cli_Nombre As String,
                   Cli_Email As String, Cli_NombreEmpresa As String,
                   Cli_EmailEmpresa As String, RTN As String, Cli_Telefono As Integer,
                   Cli_TelEmpresa As Integer) 'Constructor Full

        pID_Cliente = ID_Cliente
        pCli_Nombre = Cli_Nombre
        pCli_Email = Cli_Email
        pCli_NombreEmpresa = Cli_NombreEmpresa
        pCli_EmailEmpresa = Cli_EmailEmpresa
        pRTN = RTN
        pCli_Telefono = Cli_Telefono
        pCli_TelEmpresa = Cli_TelEmpresa
    End Sub
End Class
