
Imports System.Windows.Forms
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
    ''' <param name="forms"></param>
    Public Sub ConfigureServices(forms As List(Of Type))
        Dim services As New ServiceCollection()
        forms?.ForEach(Sub(form)
                           services.AddTransient(form)
                       End Sub)

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

    Public Function CreateForm(Of T As Form)() As T
        If ServiceProvider Is Nothing Then Return Nothing
        Return ServiceProvider.GetService(Of T)()
    End Function

End Module
