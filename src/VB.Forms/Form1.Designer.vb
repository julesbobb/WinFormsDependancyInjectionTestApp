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
        components = New ComponentModel.Container()
        dataGridView1 = New DataGridView()
        userBindingSource = New BindingSource(components)
        tbUserName = New TextBox()
        bnAddUser = New Button()
        bnRefresh = New Button()
        IdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        NameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(userBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataGridView1
        ' 
        dataGridView1.AutoGenerateColumns = False
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView1.Columns.AddRange(New DataGridViewColumn() {IdDataGridViewTextBoxColumn, NameDataGridViewTextBoxColumn})
        dataGridView1.DataSource = userBindingSource
        dataGridView1.Location = New Point(11, 46)
        dataGridView1.Margin = New Padding(2)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.ReadOnly = True
        dataGridView1.RowHeadersWidth = 62
        dataGridView1.RowTemplate.Height = 33
        dataGridView1.Size = New Size(349, 302)
        dataGridView1.TabIndex = 7
        ' 
        ' userBindingSource
        ' 
        userBindingSource.DataSource = GetType(Data.VB.Forms.Data.User)
        ' 
        ' tbUserName
        ' 
        tbUserName.Location = New Point(12, 15)
        tbUserName.Name = "tbUserName"
        tbUserName.Size = New Size(249, 27)
        tbUserName.TabIndex = 5
        ' 
        ' bnAddUser
        ' 
        bnAddUser.Location = New Point(266, 15)
        bnAddUser.Name = "bnAddUser"
        bnAddUser.Size = New Size(94, 29)
        bnAddUser.TabIndex = 6
        bnAddUser.Text = "Add User"
        bnAddUser.UseVisualStyleBackColor = True
        ' 
        ' bnRefresh
        ' 
        bnRefresh.Location = New Point(266, 353)
        bnRefresh.Name = "bnRefresh"
        bnRefresh.Size = New Size(94, 29)
        bnRefresh.TabIndex = 8
        bnRefresh.Text = "Refresh"
        bnRefresh.UseVisualStyleBackColor = True
        ' 
        ' IdDataGridViewTextBoxColumn
        ' 
        IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        IdDataGridViewTextBoxColumn.HeaderText = "Id"
        IdDataGridViewTextBoxColumn.MinimumWidth = 6
        IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        IdDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' NameDataGridViewTextBoxColumn
        ' 
        NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        NameDataGridViewTextBoxColumn.HeaderText = "Name"
        NameDataGridViewTextBoxColumn.MinimumWidth = 6
        NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        NameDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 388)
        Controls.Add(dataGridView1)
        Controls.Add(tbUserName)
        Controls.Add(bnAddUser)
        Controls.Add(bnRefresh)
        Name = "Form1"
        Padding = New Padding(10)
        StartPosition = FormStartPosition.CenterParent
        Text = "Form1"
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(userBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents userBindingSource As BindingSource
    Private WithEvents tbUserName As TextBox
    Private WithEvents bnAddUser As Button
    Private WithEvents bnRefresh As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
