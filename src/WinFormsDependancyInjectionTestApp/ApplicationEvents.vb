Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.ApplicationServices
Imports Repository

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim forms = GetAllForms()
            ConfigureServices(forms)
        End Sub


        Private Function GetAllForms() As List(Of Type)
            ' Get a list of all the forms in the solution
            Dim forms As New List(Of Type)

            ' Add the forms from the current assembly
            forms.AddRange(GetFormTypes(Assembly.GetExecutingAssembly()))

            ' Add forms from all the referenced assemblies that belong to the solution
            For Each assemblyName In Assembly.GetExecutingAssembly().GetReferencedAssemblies()
                ' Load the referenced assembly
                Dim _assembly = Assembly.Load(assemblyName)
                ' Check if the assembly belongs to the solution
                If IsAssemblyInSolution(_assembly) Then
                    ' Add the forms from the assembly
                    forms.AddRange(GetFormTypes(_assembly))
                End If
            Next
            Return forms
        End Function

        ' Returns true if the assembly belongs to the solution
        Private Function IsAssemblyInSolution(assembly As Assembly) As Boolean
            ' Get the solution directory
            Dim solutionDir = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)
            ' Get the assembly directory
            Dim assemblyDir = Path.GetDirectoryName(assembly.Location)
            ' Check if the assembly directory is a subdirectory of the solution directory
            Return assemblyDir.StartsWith(solutionDir, StringComparison.OrdinalIgnoreCase)
        End Function

        ' Returns a list of all the form types in the assembly
        Private Function GetFormTypes(assembly As Assembly) As List(Of Type)
            Return assembly.GetTypes().Where(Function(t) t.IsClass AndAlso Not t.IsAbstract AndAlso t.IsSubclassOf(GetType(Form))).ToList()
        End Function

    End Class

End Namespace
