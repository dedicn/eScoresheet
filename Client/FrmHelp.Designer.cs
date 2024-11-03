namespace Client
{
    partial class FrmHelp
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
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlHelp
            // 
            this.pnlHelp.Location = new System.Drawing.Point(-2, -1);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(668, 439);
            this.pnlHelp.TabIndex = 0;
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 438);
            this.Controls.Add(this.pnlHelp);
            this.Name = "FrmHelp";
            this.Text = "FrmHelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHelp;
    }
}