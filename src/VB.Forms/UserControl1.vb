Imports VB.Repository.VB.Repository.Interfaces
Imports VB.Repository.VB.Repository.Services

Public Class UserControl1

    Private ReadOnly _repository As IHelloWorkRepository

    Public Sub New()
        If ServiceProvider IsNot Nothing Then
            _repository = ServiceLocator.GetService(Of IHelloWorkRepository)()
        End If
        InitializeComponent()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bnSayHello.Click
        MessageBox.Show(_repository.SayHello)
    End Sub

End Class
