
Imports Microsoft.Extensions.DependencyInjection
Imports Repository

''' <summary>
''' A module containing the <see cref="ServiceCollection"/> used for dependency injection, throughout the application
''' </summary>
Public Module ServiceConfiguration

    Private Property ServiceProvider As IServiceProvider

    ''' <summary>
    ''' Adds the scoped services into the <see cref="ServiceCollection"/>
    ''' </summary>
    Public Sub ConfigureServices()
        Dim services As New ServiceCollection()
        services.AddScoped(Of IHelloWorkRepository, HelloWorkRepository)

        ServiceProvider = services.BuildServiceProvider()

    End Sub

    ''' <summary>
    ''' Returns a new instance of the scoped service associated with type <typeparamref name="T"/>
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <returns></returns>
    Public Function GetProviderService(Of T As Class)() As T
        Return ServiceProvider.GetService(GetType(T))
    End Function

End Module
