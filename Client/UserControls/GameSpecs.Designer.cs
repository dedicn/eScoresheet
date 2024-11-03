using System.Windows.Forms;

namespace Client.UserControls
{
    partial class GameSpecs
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
            this.btnSacuvajUtakmicu = new System.Windows.Forms.Button();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.lblDomaci = new System.Windows.Forms.Label();
            this.lblGosti = new System.Windows.Forms.Label();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblGos = new System.Windows.Forms.Label();
            this.txtSifraUtakmice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite sifru utakmice:";
            // 
            // btnSacuvajUtakmicu
            // 
            this.btnSacuvajUtakmicu.Location = new System.Drawing.Point(389, 441);
            this.btnSacuvajUtakmicu.Name = "btnSacuvajUtakmicu";
            this.btnSacuvajUtakmicu.Size = new System.Drawing.Size(156, 62);
            this.btnSacuvajUtakmicu.TabIndex = 2;
            this.btnSacuvajUtakmicu.Text = "Sacuvaj";
            this.btnSacuvajUtakmicu.UseVisualStyleBackColor = true;
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(441, 246);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(247, 22);
            this.txtVreme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vreme pocetka utakmice:";
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(441, 309);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(247, 22);
            this.txtMesto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesto odigravanja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unos osnovnih podataka o utakmici";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Odaberite kategoriju:";
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(441, 371);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(247, 24);
            this.cmbKategorije.TabIndex = 9;
            // 
            // lblDomaci
            // 
            this.lblDomaci.AutoSize = true;
            this.lblDomaci.Location = new System.Drawing.Point(178, 125);
            this.lblDomaci.Name = "lblDomaci";
            this.lblDomaci.Size = new System.Drawing.Size(0, 16);
            this.lblDomaci.TabIndex = 10;
            // 
            // lblGosti
            // 
            this.lblGosti.AutoSize = true;
            this.lblGosti.Location = new System.Drawing.Point(648, 125);
            this.lblGosti.Name = "lblGosti";
            this.lblGosti.Size = new System.Drawing.Size(0, 16);
            this.lblGosti.TabIndex = 11;
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Location = new System.Drawing.Point(178, 121);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(77, 16);
            this.lblDom.TabIndex = 12;
            this.lblDom.Text = "Domaci tim:";
            // 
            // lblGos
            // 
            this.lblGos.AutoSize = true;
            this.lblGos.Location = new System.Drawing.Point(636, 121);
            this.lblGos.Name = "lblGos";
            this.lblGos.Size = new System.Drawing.Size(85, 16);
            this.lblGos.TabIndex = 13;
            this.lblGos.Text = "Gostujuci tim:";
            // 
            // txtSifraUtakmice
            // 
            this.txtSifraUtakmice.Location = new System.Drawing.Point(441, 184);
            this.txtSifraUtakmice.Name = "txtSifraUtakmice";
            this.txtSifraUtakmice.Size = new System.Drawing.Size(247, 22);
            this.txtSifraUtakmice.TabIndex = 1;
            // 
            // GameSpecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGos);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.lblGosti);
            this.Controls.Add(this.lblDomaci);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSacuvajUtakmicu);
            this.Controls.Add(this.txtSifraUtakmice);
            this.Controls.Add(this.label1);
            this.Name = "GameSpecs";
            this.Size = new System.Drawing.Size(931, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvajUtakmicu;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Label lblDomaci;
        private System.Windows.Forms.Label lblGosti;
        private Label lblDom;
        private Label lblGos;
        private TextBox txtSifraUtakmice;

        public Button BtnSacuvajUtakmicu { get => btnSacuvajUtakmicu; set => btnSacuvajUtakmicu = value; }
        public TextBox TxtSifraUtakmice { get => txtSifraUtakmice; set => txtSifraUtakmice = value; }
        public TextBox TxtVreme { get => txtVreme; set => txtVreme = value; }
        public TextBox TxtMesto { get => txtMesto; set => txtMesto = value; }
        public ComboBox Cmbkategorija { get => cmbKategorije; set => cmbKategorije = value; }
    }
}
