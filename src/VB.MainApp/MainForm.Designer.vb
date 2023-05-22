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
        UserControl11 = New Forms.UserControl1()
        SuspendLayout()
        ' 
        ' bnOpenForm
        ' 
        bnOpenForm.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        bnOpenForm.Location = New Point(264, 16)
        bnOpenForm.Margin = New Padding(3, 4, 3, 4)
        bnOpenForm.Name = "bnOpenForm"
        bnOpenForm.Size = New Size(244, 174)
        bnOpenForm.TabIndex = 3
        bnOpenForm.Text = "Open Referenced Form"
        bnOpenForm.UseVisualStyleBackColor = True
        ' 
        ' UserControl11
        ' 
        UserControl11.Location = New Point(14, 16)
        UserControl11.Name = "UserControl11"
        UserControl11.Size = New Size(244, 174)
        UserControl11.TabIndex = 4
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 206)
        Controls.Add(UserControl11)
        Controls.Add(bnOpenForm)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainForm"
        Padding = New Padding(11, 13, 11, 13)
        StartPosition = FormStartPosition.CenterScreen
        Text = "VB.Net Application"
        ResumeLayout(False)
    End Sub

    Private WithEvents bnOpenForm As Button
    Friend WithEvents UserControl11 As Forms.UserControl1
End Class
