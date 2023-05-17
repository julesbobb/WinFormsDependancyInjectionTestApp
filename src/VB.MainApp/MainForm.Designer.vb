<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        bnOpenForm = New Button()
        bnSayHello = New Button()
        SuspendLayout()
        ' 
        ' bnOpenForm
        ' 
        bnOpenForm.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        bnOpenForm.Location = New Point(232, 13)
        bnOpenForm.Margin = New Padding(3, 4, 3, 4)
        bnOpenForm.Name = "bnOpenForm"
        bnOpenForm.Size = New Size(214, 125)
        bnOpenForm.TabIndex = 3
        bnOpenForm.Text = "Open Referenced Form"
        bnOpenForm.UseVisualStyleBackColor = True
        ' 
        ' bnSayHello
        ' 
        bnSayHello.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        bnSayHello.Location = New Point(12, 13)
        bnSayHello.Margin = New Padding(3, 4, 3, 4)
        bnSayHello.Name = "bnSayHello"
        bnSayHello.Size = New Size(214, 125)
        bnSayHello.TabIndex = 2
        bnSayHello.Text = "Say Hello"
        bnSayHello.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(453, 152)
        Controls.Add(bnOpenForm)
        Controls.Add(bnSayHello)
        Name = "MainForm"
        Padding = New Padding(11, 13, 11, 13)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Private WithEvents bnOpenForm As Button
    Private WithEvents bnSayHello As Button
End Class
