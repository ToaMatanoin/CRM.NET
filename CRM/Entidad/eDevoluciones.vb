Public Class eDevoluciones

    Dim ID_Devolu, ID_Factura As Integer
    Dim Descripcion, Fecha_Devolu As String

    Public Property pID_Devolu
        Get
            Return ID_Devolu
        End Get
        Set(value)
            ID_Devolu = value
        End Set
    End Property

    Public Property pID_Factura
        Get
            Return ID_Factura
        End Get
        Set(value)
            ID_Factura = value
        End Set
    End Property

        Public Property pDescripcion
        Get
            Return Descripcion
        End Get
        Set(value)
            Descripcion = value
        End Set
    End Property


    Public Property pFecha_Devolu
        Get
            Return Fecha_Devolu
        End Get
        Set(value)
            Fecha_Devolu = value
        End Set
    End Property

    Public Sub New() 'Constructor Vacio
    End Sub



    Public Sub New(ID_Devolu As Integer, ID_Factura As Integer,
                   Descripcion As String, Fecha_Devolu As String) 'Constructor Full

        pID_Devolu = ID_Devolu
        pID_Factura = ID_Factura
        pDescripcion = Descripcion
        pFecha_Devolu = Fecha_Devolu
       


    End Sub

End Class
