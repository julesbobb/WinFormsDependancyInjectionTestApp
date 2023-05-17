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
            bnSayHello = new Button();
            bnOpenForm = new Button();
            SuspendLayout();
            // 
            // bnSayHello
            // 
            bnSayHello.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bnSayHello.Location = new Point(11, 13);
            bnSayHello.Margin = new Padding(3, 4, 3, 4);
            bnSayHello.Name = "bnSayHello";
            bnSayHello.Size = new Size(214, 125);
            bnSayHello.TabIndex = 0;
            bnSayHello.Text = "Say Hello";
            bnSayHello.UseVisualStyleBackColor = true;
            bnSayHello.Click += bnSayHello_Click;
            // 
            // bnOpenForm
            // 
            bnOpenForm.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bnOpenForm.Location = new Point(231, 13);
            bnOpenForm.Margin = new Padding(3, 4, 3, 4);
            bnOpenForm.Name = "bnOpenForm";
            bnOpenForm.Size = new Size(214, 125);
            bnOpenForm.TabIndex = 1;
            bnOpenForm.Text = "Open Referenced Form";
            bnOpenForm.UseVisualStyleBackColor = true;
            bnOpenForm.Click += bnOpenForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 152);
            Controls.Add(bnOpenForm);
            Controls.Add(bnSayHello);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Padding = new Padding(11, 13, 11, 13);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bnSayHello;
        private Button bnOpenForm;
    }
}