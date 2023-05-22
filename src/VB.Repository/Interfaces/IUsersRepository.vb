
Imports VB.Forms.Data.VB.Forms.Data

Namespace VB.Repository.Interfaces

    Public Interface IUsersRepository

        Function GetAll() As Task(Of IEnumerable(Of User))
        Function [Get](ByVal username As String) As Task(Of User)
        Function Update(ByVal user As User) As Task
        Function Delete(ByVal user As User) As Task
        Function Add(ByVal user As User) As Task
        Function UserExists(ByVal username As String) As Task(Of Boolean)

    End Interface


End Namespace


