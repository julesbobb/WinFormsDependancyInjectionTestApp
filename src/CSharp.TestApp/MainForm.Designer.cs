namespace CSharp.TestApp
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
            this.bnSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnSayHello
            // 
            this.bnSayHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnSayHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnSayHello.Location = new System.Drawing.Point(10, 10);
            this.bnSayHello.Name = "bnSayHello";
            this.bnSayHello.Size = new System.Drawing.Size(330, 94);
            this.bnSayHello.TabIndex = 0;
            this.bnSayHello.Text = "Say Hello";
            this.bnSayHello.UseVisualStyleBackColor = true;
            this.bnSayHello.Click += new System.EventHandler(this.bnSayHello_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 114);
            this.Controls.Add(this.bnSayHello);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bnSayHello;
    }
}