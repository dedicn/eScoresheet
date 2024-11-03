namespace Server
{
    partial class FrmServer
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
            this.btnPokreni1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnUgasi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPokreni1
            // 
            this.btnPokreni1.Location = new System.Drawing.Point(242, 85);
            this.btnPokreni1.Name = "btnPokreni1";
            this.btnPokreni1.Size = new System.Drawing.Size(127, 43);
            this.btnPokreni1.TabIndex = 0;
            this.btnPokreni1.Text = "Pokreni server";
            this.btnPokreni1.UseVisualStyleBackColor = true;
            this.btnPokreni1.Click += new System.EventHandler(this.btnPokreni1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staus servera:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(397, 37);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(126, 16);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Server nije pokrenut";
            // 
            // btnUgasi
            // 
            this.btnUgasi.Location = new System.Drawing.Point(400, 85);
            this.btnUgasi.Name = "btnUgasi";
            this.btnUgasi.Size = new System.Drawing.Size(127, 43);
            this.btnUgasi.TabIndex = 6;
            this.btnUgasi.Text = "Zaustavi server";
            this.btnUgasi.UseVisualStyleBackColor = true;
            this.btnUgasi.Click += new System.EventHandler(this.btnUgasi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spisak ulogovanih korisnika:";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(72, 177);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(583, 206);
            this.dgvKorisnici.TabIndex = 5;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 406);
            this.Controls.Add(this.btnUgasi);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPokreni1);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokreni1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnUgasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvKorisnici;
    }
}

