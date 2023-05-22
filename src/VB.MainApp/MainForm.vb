Imports VB.Forms
Imports VB.Repository
Imports VB.Repository.VB.Repository.Interfaces
Imports VB.Repository.VB.Repository.Services

' This demostrats 2 things:
'   1)  Generating the service using the GetService, this can be used for the initial 
'       form load and for user controls
'   2)  Using the CreateForm. This creates a form where the service is injected into
'       the initialiaser. This can be used for all forms.
'   3) Automatically retrieving all forms within a solution and configuring them for DI

Public Class MainForm

    Private ReadOnly _formFactory As IFormFactory

    Public Sub New()
        _formFactory = ServiceLocator.GetService(Of IFormFactory)()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub bnOpenForm_Click(sender As Object, e As EventArgs) Handles bnOpenForm.Click
        Using oFrm = _formFactory.CreateForm(Of Form1)()
            oFrm.ShowDialog()
        End Using
    End Sub

End Class
