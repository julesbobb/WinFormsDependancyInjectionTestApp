Imports VB.Repository

Public Class Form1

    Private ReadOnly _repository As IHelloWorkRepository

    Public Sub New(repository As IHelloWorkRepository)
        _repository = repository

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub bnSayHello_Click(sender As Object, e As EventArgs) Handles bnSayHello.Click
        MessageBox.Show(_repository.SayHello)
    End Sub

End Class