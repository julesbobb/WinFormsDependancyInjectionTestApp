namespace CSharp.Forms
{
    partial class UserControl1
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

        #region Component Designer generated code

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
            bnSayHello.Location = new Point(0, 0);
            bnSayHello.Name = "bnSayHello";
            bnSayHello.Size = new Size(221, 159);
            bnSayHello.TabIndex = 1;
            bnSayHello.Text = "User Control";
            bnSayHello.UseVisualStyleBackColor = true;
            bnSayHello.Click += bnSayHello_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bnSayHello);
            Name = "UserControl1";
            Size = new Size(221, 159);
            ResumeLayout(false);
        }

        #endregion

        internal Button bnSayHello;
    }
}
