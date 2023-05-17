<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        bnSayHello.Location = New Point(10, 10)
        bnSayHello.Margin = New Padding(3, 4, 3, 4)
        bnSayHello.Name = "bnSayHello"
        bnSayHello.Size = New Size(233, 141)
        bnSayHello.TabIndex = 2
        bnSayHello.Text = "Say Hello"
        bnSayHello.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(253, 161)
        Controls.Add(bnSayHello)
        Name = "Form1"
        Padding = New Padding(10)
        StartPosition = FormStartPosition.CenterParent
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Private WithEvents bnSayHello As Button
End Class
