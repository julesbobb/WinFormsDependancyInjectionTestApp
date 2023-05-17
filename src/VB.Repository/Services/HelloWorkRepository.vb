Public Class HelloWorkRepository
    Implements IHelloWorkRepository

    Public ReadOnly Property SayHello As String Implements IHelloWorkRepository.SayHello
        Get
            Return "Hello World"
        End Get
    End Property

End Class
