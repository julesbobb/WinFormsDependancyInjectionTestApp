Imports ReferencedProject
Imports Repository

' This demostrats 2 things:
'   1)  Generating the service using the GetProviderService, this can be used for the initial 
'       form load and for user controls
'   2)  Using the CreateForm. This creates a form where the service is injected into
'       the initialiaser. This can be used for all forms.

Public Class MainForm
    Private ReadOnly _repository As IHelloWorkRepository

    Public Sub New()
        _repository = GetProviderService(Of IHelloWorkRepository)()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub bnSayHello_Click(sender As Object, e As EventArgs) Handles bnSayHello.Click
        MessageBox.Show(_repository.SayHello)
    End Sub

    Private Sub bnOpenForm_Click(sender As Object, e As EventArgs) Handles bnOpenForm.Click
        'Using oFrm = CreateForm(Of TestForm)()
        '    oFrm.ShowDialog()
        'End Using
    End Sub
End Class
