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
            bnSayHello = new Button();
            SuspendLayout();
            // 
            // bnSayHello
            // 
            bnSayHello.Dock = DockStyle.Fill;
            bnSayHello.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bnSayHello.Location = new Point(10, 10);
            bnSayHello.Margin = new Padding(3, 4, 3, 4);
            bnSayHello.Name = "bnSayHello";
            bnSayHello.Size = new Size(233, 141);
            bnSayHello.TabIndex = 1;
            bnSayHello.Text = "Say Hello";
            bnSayHello.UseVisualStyleBackColor = true;
            bnSayHello.Click += bnSayHello_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 161);
            Controls.Add(bnSayHello);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bnSayHello;
    }
}