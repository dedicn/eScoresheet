namespace Client
{
    partial class FrmChange
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msUtakmica = new System.Windows.Forms.ToolStripMenuItem();
            this.msIgrqaci = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimovi = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlChange = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.msKrajUnosa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUtakmica,
            this.msIgrqaci,
            this.msTimovi,
            this.msKrajUnosa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msUtakmica
            // 
            this.msUtakmica.Name = "msUtakmica";
            this.msUtakmica.Size = new System.Drawing.Size(85, 24);
            this.msUtakmica.Text = "Utakmica";
            // 
            // msIgrqaci
            // 
            this.msIgrqaci.Name = "msIgrqaci";
            this.msIgrqaci.Size = new System.Drawing.Size(60, 24);
            this.msIgrqaci.Text = "Igraci";
            // 
            // msTimovi
            // 
            this.msTimovi.Name = "msTimovi";
            this.msTimovi.Size = new System.Drawing.Size(68, 24);
            this.msTimovi.Text = "Timovi";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlChange
            // 
            this.pnlChange.Controls.Add(this.label1);
            this.pnlChange.Location = new System.Drawing.Point(0, 31);
            this.pnlChange.Name = "pnlChange";
            this.pnlChange.Size = new System.Drawing.Size(934, 510);
            this.pnlChange.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodosli na stranicu za izmenu podataka!";
            // 
            // msKrajUnosa
            // 
            this.msKrajUnosa.Name = "msKrajUnosa";
            this.msKrajUnosa.Size = new System.Drawing.Size(92, 24);
            this.msKrajUnosa.Text = "Kraj unosa";
            // 
            // FrmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 539);
            this.Controls.Add(this.pnlChange);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmChange";
            this.Text = "FrmChange";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChange_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlChange.ResumeLayout(false);
            this.pnlChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msUtakmica;
        private System.Windows.Forms.ToolStripMenuItem msIgrqaci;
        private System.Windows.Forms.ToolStripMenuItem msTimovi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem msKrajUnosa;
    }
}