Public Class eTareas_Marketing

    Dim ID_Tarea, ID_Marketing As Integer
    Dim Nombre_Tarea, Descripcion, Fecha_Inicial, Fecha_Conclusion As String

    Public Property pID_Tarea
        Get
            Return ID_Tarea
        End Get
        Set(value)
            ID_Tarea = value
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

    Public Property pNombre_Tarea
        Get
            Return Nombre_Tarea
        End Get
        Set(value)
            Nombre_Tarea = value
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




    Public Sub New(ID_Tarea As Integer, ID_Marketing As Integer, Nombre_Tarea As String,
                   Descripcion As String, Fecha_Inicial As String, Fecha_Conclusion As String) 'Constructor Full

        pID_Tarea = ID_Tarea
        pID_Marketing = ID_Marketing
        pNombre_Tarea = Nombre_Tarea
        pDescripcion = Descripcion
        pFecha_Inicial = Fecha_Inicial
        pFecha_Conclusion = Fecha_Conclusion


    End Sub

End Class
