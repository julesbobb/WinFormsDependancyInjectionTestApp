<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        bnSayHello = New Button()
        SuspendLayout()
        ' 
        ' bnSayHello
        ' 
        bnSayHello.Dock = DockStyle.Fill
        bnSayHello.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        bnSayHello.Location = New Point(0, 0)
        bnSayHello.Name = "bnSayHello"
        bnSayHello.Size = New Size(254, 176)
        bnSayHello.TabIndex = 0
        bnSayHello.Text = "User Control"
        bnSayHello.UseVisualStyleBackColor = True
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(bnSayHello)
        Name = "UserControl1"
        Size = New Size(254, 176)
        ResumeLayout(False)
    End Sub

    Friend WithEvents bnSayHello As Button
End Class
