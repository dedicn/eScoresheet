using System.Windows.Forms;

namespace Client.UserControls
{
    partial class GameUpdate
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
            this.lblGos = new System.Windows.Forms.Label();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblGosti = new System.Windows.Forms.Label();
            this.lblDomaci = new System.Windows.Forms.Label();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzmeniUtakmicu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGos
            // 
            this.lblGos.AutoSize = true;
            this.lblGos.Location = new System.Drawing.Point(475, 79);
            this.lblGos.Name = "lblGos";
            this.lblGos.Size = new System.Drawing.Size(85, 16);
            this.lblGos.TabIndex = 27;
            this.lblGos.Text = "Gostujuci tim:";
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Location = new System.Drawing.Point(17, 79);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(77, 16);
            this.lblDom.TabIndex = 26;
            this.lblDom.Text = "Domaci tim:";
            // 
            // lblGosti
            // 
            this.lblGosti.AutoSize = true;
            this.lblGosti.Location = new System.Drawing.Point(487, 83);
            this.lblGosti.Name = "lblGosti";
            this.lblGosti.Size = new System.Drawing.Size(0, 16);
            this.lblGosti.TabIndex = 25;
            // 
            // lblDomaci
            // 
            this.lblDomaci.AutoSize = true;
            this.lblDomaci.Location = new System.Drawing.Point(17, 83);
            this.lblDomaci.Name = "lblDomaci";
            this.lblDomaci.Size = new System.Drawing.Size(0, 16);
            this.lblDomaci.TabIndex = 24;
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(281, 308);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(247, 24);
            this.cmbKategorije.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Odaberite kategoriju:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(511, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "Izmena osnovnih podataka o utakmici";
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(281, 246);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(247, 22);
            this.txtMesto.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mesto odigravanja:";
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(281, 183);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(247, 22);
            this.txtVreme.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vreme pocetka utakmice:";
            // 
            // btnIzmeniUtakmicu
            // 
            this.btnIzmeniUtakmicu.Location = new System.Drawing.Point(228, 361);
            this.btnIzmeniUtakmicu.Name = "btnIzmeniUtakmicu";
            this.btnIzmeniUtakmicu.Size = new System.Drawing.Size(156, 62);
            this.btnIzmeniUtakmicu.TabIndex = 16;
            this.btnIzmeniUtakmicu.Text = "Izmeni";
            this.btnIzmeniUtakmicu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Unesite sifru utakmice:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(278, 124);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(0, 16);
            this.lblSifra.TabIndex = 28;
            // 
            // GameUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSifra);
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
            this.Controls.Add(this.btnIzmeniUtakmicu);
            this.Controls.Add(this.label1);
            this.Name = "GameUpdate";
            this.Size = new System.Drawing.Size(622, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGos;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label lblGosti;
        private System.Windows.Forms.Label lblDomaci;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzmeniUtakmicu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSifra;

        public Button BtnIzmeniUtakmicu { get => btnIzmeniUtakmicu; set => btnIzmeniUtakmicu = value; }
        public Label LblSifraUtakmice { get => lblSifra; set => lblSifra = value; }
        public TextBox TxtVreme { get => txtVreme; set => txtVreme = value; }
        public TextBox TxtMesto { get => txtMesto; set => txtMesto = value; }
        public ComboBox Cmbkategorija { get => cmbKategorije; set => cmbKategorije = value; }
    }
}
