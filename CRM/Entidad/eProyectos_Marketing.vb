
Public Class eProyectos_Marketing

    Dim ID_Proyecto, ID_Marketing As Integer
    Dim Nombre_Proyecto, Descripcion, Fecha_Inicial, Fecha_Conclusion As String

    Public Property pID_Proyecto
        Get
            Return ID_Proyecto
        End Get
        Set(value)
            ID_Proyecto = value
        End Set
    End Property

    Public Property pID_Marketing
        Get
            Return ID_Marketing
        End Get
        Set(value)
            ID_Marketing = value
        End Set
    End Property

    Public Property pNombre_Proyecto
        Get
            Return Nombre_Proyecto
        End Get
        Set(value)
            Nombre_Proyecto = value
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

    Public Property pFecha_Inicial
        Get
            Return Fecha_Inicial
        End Get
        Set(value)
            Fecha_Inicial = value
        End Set
    End Property

    Public Property pFecha_Conclusion
        Get
            Return Fecha_Conclusion
        End Get
        Set(value)
            Fecha_Conclusion = value
        End Set
    End Property

    Public Sub New() 'Constructor Vacio
    End Sub





    Public Sub New(ID_Proyecto As Integer, ID_Marketing As Integer, Nombre_Proyecto As String,
                   Fecha_Inicial As String, Fecha_Conclusion As String, Descripcion As String) 'Constructor Full

        pID_Proyecto = ID_Proyecto
        pID_Marketing = ID_Marketing
        pNombre_Proyecto = Nombre_Proyecto
        pFecha_Inicial = Fecha_Inicial
        pFecha_Conclusion = Fecha_Conclusion
        pDescripcion = Descripcion


    End Sub



End Class
