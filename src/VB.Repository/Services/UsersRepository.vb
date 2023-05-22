
Imports Microsoft.EntityFrameworkCore
Imports VB.Forms.Data.VB.Forms.Data
Imports VB.Repository.VB.Repository.Interfaces

Namespace VB.Repository.Services

    Public Class UsersRepository
        Implements IUsersRepository

        Private ReadOnly _dataContext As DataContext

        Public Sub New(dataContext As DataContext)
            _dataContext = dataContext
        End Sub

        Public Async Function GetAll() As Task(Of IEnumerable(Of User)) Implements IUsersRepository.GetAll
            Return Await _dataContext.Users.ToListAsync()
        End Function

        Public Async Function [Get](username As String) As Task(Of User) Implements IUsersRepository.Get
            Return Await _dataContext.Users.Where(Function(x) x.Name = username).FirstOrDefaultAsync()
        End Function

        Public Async Function Update(user As User) As Task Implements IUsersRepository.Update
            Dim _user = Await _dataContext.Users.FindAsync(user.Id)
            If _user IsNot Nothing Then
                _user.Name = user.Name
                Await _dataContext.SaveChangesAsync()
            End If
        End Function

        Public Async Function Delete(user As User) As Task Implements IUsersRepository.Delete
            Dim _user = Await _dataContext.Users.FindAsync(user.Id)
            If _user IsNot Nothing Then
                _dataContext.Remove(_user)
                Await _dataContext.SaveChangesAsync()
            End If
        End Function

        Public Async Function Add(user As User) As Task Implements IUsersRepository.Add
            _dataContext.Add(user)
            Await _dataContext.SaveChangesAsync()
        End Function

        Public Async Function UserExists(username As String) As Task(Of Boolean) Implements IUsersRepository.UserExists
            Return Await _dataContext.Users.Where(Function(x) x.Name = username).AnyAsync
        End Function
    End Class

End Namespace

