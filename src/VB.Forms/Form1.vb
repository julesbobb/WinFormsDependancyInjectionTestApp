Imports VB.Repository
Imports VB.Repository.VB.Repository.Interfaces
Imports Microsoft.Extensions.Logging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports VB.Forms.Data.VB.Forms.Data

Public Class Form1

    Private ReadOnly _userRepository As IUsersRepository
    Private ReadOnly _logger As ILogger

    Public Sub New(userRepository As IUsersRepository, logger As ILogger(Of Form1))
        _userRepository = userRepository
        _logger = logger

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Async Sub bnAddUser_Click(sender As Object, e As EventArgs) Handles bnAddUser.Click
        Await AddUser()
    End Sub

    Private Async Function AddUser() As Task
        Dim userName = tbUserName.Text
        If userName.Length > 0 Then
            If Await _userRepository.UserExists(userName) Then
                _logger.LogError($"User {userName} already exists")
                MessageBox.Show($"User {userName} already exists")
            Else
                Await _userRepository.Add(New User(userName))
                userBindingSource.DataSource = Await _userRepository.GetAll()
                _logger.LogInformation($"Added user {userName}")
                tbUserName.Clear()
                tbUserName.Focus()
            End If
        End If
    End Function

    Private Async Sub bnRefresh_Click(sender As Object, e As EventArgs) Handles bnRefresh.Click
        userBindingSource.DataSource = Await _userRepository.GetAll()
    End Sub

    Private Async Sub tbUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Await AddUser()
        End If
    End Sub

    Private Async Sub dataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dataGridView1.UserDeletingRow
        If e.Row?.DataBoundItem IsNot Nothing Then
            Dim item As User = CType(e.Row.DataBoundItem, User)
            Await _userRepository.Delete(item)
            _logger.LogWarning($"Deleted user {item.Name}")
        End If
    End Sub

End Class