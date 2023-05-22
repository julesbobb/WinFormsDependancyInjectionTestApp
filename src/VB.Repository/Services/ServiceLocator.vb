Namespace VB.Repository.Services

    Public Module ServiceLocator

        Public ServiceProvider As IServiceProvider

        Public Sub SetServiceProvider(ByVal _serviceProvider As IServiceProvider)
            ServiceProvider = _serviceProvider
        End Sub

        Public Function GetService(Of T As Class)() As T
            If ServiceProvider Is Nothing Then
                Throw New InvalidOperationException("Service provider is not set.")
            End If

            Return ServiceProvider.GetService(GetType(T))
        End Function

    End Module

End Namespace