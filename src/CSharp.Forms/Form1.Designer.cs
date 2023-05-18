namespace CSharp.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bnAddUser = new Button();
            tbUserName = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            bnRefresh = new Button();
            userControl11 = new UserControl1();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bnAddUser
            // 
            bnAddUser.Location = new Point(266, 11);
            bnAddUser.Name = "bnAddUser";
            bnAddUser.Size = new Size(94, 29);
            bnAddUser.TabIndex = 2;
            bnAddUser.Text = "Add User";
            bnAddUser.UseVisualStyleBackColor = true;
            bnAddUser.Click += bnAddUser_Click;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(12, 11);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(249, 27);
            tbUserName.TabIndex = 1;
            tbUserName.KeyDown += tbUserName_KeyDown;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(12, 42);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(349, 302);
            dataGridView1.TabIndex = 3;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Data.Models.User);
            // 
            // bnRefresh
            // 
            bnRefresh.Location = new Point(266, 349);
            bnRefresh.Name = "bnRefresh";
            bnRefresh.Size = new Size(94, 29);
            bnRefresh.TabIndex = 4;
            bnRefresh.Text = "Refresh";
            bnRefresh.UseVisualStyleBackColor = true;
            bnRefresh.Click += bnRefresh_Click;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(385, 42);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(335, 206);
            userControl11.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 383);
            Controls.Add(userControl11);
            Controls.Add(bnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(tbUserName);
            Controls.Add(bnAddUser);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bnAddUser;
        private TextBox tbUserName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private Button bnRefresh;
        private UserControl1 userControl11;
    }
}