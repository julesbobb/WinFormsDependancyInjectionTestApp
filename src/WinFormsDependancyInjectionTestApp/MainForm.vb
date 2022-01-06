Imports Repository

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

End Class
