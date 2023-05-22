namespace CSharp.MainApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bnOpenForm = new Button();
            userControl11 = new Forms.UserControl1();
            SuspendLayout();
            // 
            // bnOpenForm
            // 
            bnOpenForm.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bnOpenForm.Location = new Point(264, 16);
            bnOpenForm.Margin = new Padding(3, 4, 3, 4);
            bnOpenForm.Name = "bnOpenForm";
            bnOpenForm.Size = new Size(244, 174);
            bnOpenForm.TabIndex = 1;
            bnOpenForm.Text = "Open Referenced Form";
            bnOpenForm.UseVisualStyleBackColor = true;
            bnOpenForm.Click += bnOpenForm_Click;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(14, 16);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(244, 174);
            userControl11.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 206);
            Controls.Add(userControl11);
            Controls.Add(bnOpenForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Padding = new Padding(11, 13, 11, 13);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C# Application";
            ResumeLayout(false);
        }

        #endregion
        private Button bnOpenForm;
        private Forms.UserControl1 userControl11;
    }
}