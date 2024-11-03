using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UpdateMember
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzmeniIgraca = new System.Windows.Forms.Button();
            this.txtBrojDresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSifraIgraca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(485, 36);
            this.label5.TabIndex = 19;
            this.label5.Text = "Izmena osnovnih podataka o igracu";
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(232, 273);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(238, 24);
            this.cmbTimovi.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Izaberite tim:";
            // 
            // btnIzmeniIgraca
            // 
            this.btnIzmeniIgraca.Location = new System.Drawing.Point(197, 346);
            this.btnIzmeniIgraca.Name = "btnIzmeniIgraca";
            this.btnIzmeniIgraca.Size = new System.Drawing.Size(158, 59);
            this.btnIzmeniIgraca.TabIndex = 16;
            this.btnIzmeniIgraca.Text = "Izmeni";
            this.btnIzmeniIgraca.UseVisualStyleBackColor = true;
            // 
            // txtBrojDresa
            // 
            this.txtBrojDresa.Location = new System.Drawing.Point(230, 223);
            this.txtBrojDresa.Name = "txtBrojDresa";
            this.txtBrojDresa.Size = new System.Drawing.Size(240, 22);
            this.txtBrojDresa.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Broj dresa:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(228, 171);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(240, 22);
            this.txtImePrezime.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ime i prezime igraca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Licenca igraca:";
            // 
            // lblSifraIgraca
            // 
            this.lblSifraIgraca.AutoSize = true;
            this.lblSifraIgraca.Location = new System.Drawing.Point(225, 126);
            this.lblSifraIgraca.Name = "lblSifraIgraca";
            this.lblSifraIgraca.Size = new System.Drawing.Size(0, 16);
            this.lblSifraIgraca.TabIndex = 20;
            // 
            // UpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSifraIgraca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzmeniIgraca);
            this.Controls.Add(this.txtBrojDresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMember";
            this.Size = new System.Drawing.Size(587, 443);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzmeniIgraca;
        private System.Windows.Forms.TextBox txtBrojDresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSifraIgraca;

        public Button BtnIzmeniIgraca { get => btnIzmeniIgraca; set => btnIzmeniIgraca = value; }
        public Label LblSifraIgraca { get => lblSifraIgraca; set => lblSifraIgraca = value; }
        public TextBox TxtImePrezime { get => txtImePrezime; set => txtImePrezime = value; }
        public TextBox TxtBrojDresa { get => txtBrojDresa; set => txtBrojDresa = value; }
        public ComboBox CmbTimovi { get => cmbTimovi; set => cmbTimovi = value; }
    }
}
