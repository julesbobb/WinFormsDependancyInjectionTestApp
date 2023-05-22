
Imports System.Configuration
Imports System.Windows.Forms
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Logging
Imports VB.Forms.Data.VB.Forms.Data
Imports VB.Repository.VB.Repository.Interfaces

Namespace VB.Repository.Services

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

            Dim builder = New ConfigurationBuilder().
            AddJsonFile("appsettings.json", [optional]:=True, reloadOnChange:=True)

            Dim configuration = builder.Build()
            Dim services As New ServiceCollection()

            'find all forms in the solution and add them to the ServiceCollection

            forms?.ForEach(Sub(form)
                               services.AddTransient(form)
                           End Sub)
            services.
            AddSingleton(Of IConfiguration)(configuration).
            AddDbContext(Of DataContext)(Function(options As DbContextOptionsBuilder) options.UseInMemoryDatabase(configuration.GetConnectionString("WinformsDatabase"))).
            AddSingleton(Of IFormFactory, FormFactory)().
            AddScoped(Of IHelloWorkRepository, HelloWorkRepository)().
            AddScoped(Of IUsersRepository, UsersRepository)().
            AddLogging(Function(configure) configure.AddDebug())
            Dim serviceProvider = services.BuildServiceProvider()
            SetServiceProvider(serviceProvider)
        End Sub

    End Module

End Namespace


