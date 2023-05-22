
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Configuration

Namespace VB.Forms.Data

    Public Class DataContext
        Inherits DbContext
        Protected ReadOnly Configuration As IConfiguration

        Public Sub New(ByVal configuration As IConfiguration)
            Me.Configuration = configuration
        End Sub

        Protected Overrides Sub OnConfiguring(ByVal options As DbContextOptionsBuilder)
            ' connect to sqlite database
            options.UseInMemoryDatabase(Configuration.GetConnectionString("WinformsDatabase"))
        End Sub

        Public Property Users As DbSet(Of User)

    End Class

End Namespace
