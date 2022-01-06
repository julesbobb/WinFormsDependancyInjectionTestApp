<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.bnSayHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bnSayHello
        '
        Me.bnSayHello.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnSayHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSayHello.Location = New System.Drawing.Point(10, 10)
        Me.bnSayHello.Name = "bnSayHello"
        Me.bnSayHello.Size = New System.Drawing.Size(324, 93)
        Me.bnSayHello.TabIndex = 0
        Me.bnSayHello.Text = "Say Hello"
        Me.bnSayHello.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 113)
        Me.Controls.Add(Me.bnSayHello)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bnSayHello As Button
End Class
