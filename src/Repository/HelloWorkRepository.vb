
Public Interface IHelloWorkRepository
    Function SayHello() As String
End Interface

Public Class HelloWorkRepository
    Implements IHelloWorkRepository

    Public Function SayHello() As String Implements IHelloWorkRepository.SayHello
        Return "Hello World"
    End Function

End Class
