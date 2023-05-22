Imports Microsoft.Extensions.DependencyInjection
Imports VB.Repository.VB.Repository.Interfaces

Namespace VB.Repository.Services

    Public Class FormFactory
        Implements IFormFactory

        Private ReadOnly _serviceProvider As IServiceProvider

        Public Sub New(ByVal serviceProvider As IServiceProvider)
            _serviceProvider = serviceProvider
        End Sub

        Public Function CreateForm(Of T As Form)() As T Implements IFormFactory.CreateForm
            Return _serviceProvider.GetRequiredService(Of T)
        End Function

    End Class

End Namespace

