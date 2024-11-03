using System.Windows.Forms;

namespace Client.UserControls
{
    partial class Members
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifraIgraca = new System.Windows.Forms.TextBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojDresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacuvajIgraca = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licenca igraca:";
            // 
            // txtSifraIgraca
            // 
            this.txtSifraIgraca.Location = new System.Drawing.Point(341, 116);
            this.txtSifraIgraca.Name = "txtSifraIgraca";
            this.txtSifraIgraca.Size = new System.Drawing.Size(240, 22);
            this.txtSifraIgraca.TabIndex = 1;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(341, 184);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(240, 22);
            this.txtImePrezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime i prezime igraca:";
            // 
            // txtBrojDresa
            // 
            this.txtBrojDresa.Location = new System.Drawing.Point(341, 261);
            this.txtBrojDresa.Name = "txtBrojDresa";
            this.txtBrojDresa.Size = new System.Drawing.Size(240, 22);
            this.txtBrojDresa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj dresa:";
            // 
            // btnSacuvajIgraca
            // 
            this.btnSacuvajIgraca.Location = new System.Drawing.Point(341, 388);
            this.btnSacuvajIgraca.Name = "btnSacuvajIgraca";
            this.btnSacuvajIgraca.Size = new System.Drawing.Size(158, 59);
            this.btnSacuvajIgraca.TabIndex = 6;
            this.btnSacuvajIgraca.Text = "Sacuvaj igraca";
            this.btnSacuvajIgraca.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Izaberite tim:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(343, 329);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(238, 24);
            this.cmbTimovi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Osnovni podaci o igracu";
            // 
            // btnKraj
            // 
            this.btnKraj.Location = new System.Drawing.Point(687, 439);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(108, 59);
            this.btnKraj.TabIndex = 10;
            this.btnKraj.Text = "Kraj unosa";
            this.btnKraj.UseVisualStyleBackColor = true;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSacuvajIgraca);
            this.Controls.Add(this.txtBrojDresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifraIgraca);
            this.Controls.Add(this.label1);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(812, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifraIgraca;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojDresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSacuvajIgraca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.Label label5;
        private Button btnKraj;

        public Button BtnSacuvajIgraca { get => btnSacuvajIgraca; set => btnSacuvajIgraca = value; }
        public Button BtnKraj { get => btnKraj; set => btnKraj = value; }
        public TextBox TxtSifraIgraca { get => txtSifraIgraca; set => txtSifraIgraca = value; }
        public TextBox TxtImePrezime { get => txtImePrezime; set => txtImePrezime = value; }
        public TextBox TxtBrojDresa { get => txtBrojDresa; set => txtBrojDresa = value; }
        public ComboBox CmbTimovi { get => cmbTimovi; set => cmbTimovi = value; }
    }
}
