using System.Windows.Forms;

namespace Client
{
    partial class FrmGame
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
            this.lblDomacin = new System.Windows.Forms.Label();
            this.lblGost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTajmDomaci = new System.Windows.Forms.Button();
            this.btnTajmGosti = new System.Windows.Forms.Button();
            this.dgvDomaci = new System.Windows.Forms.DataGridView();
            this.dgvGosti = new System.Windows.Forms.DataGridView();
            this.btnPoen = new System.Windows.Forms.Button();
            this.btnLicna = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.btnSLedeca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDomPoeni = new System.Windows.Forms.Label();
            this.lblGostiPoeni = new System.Windows.Forms.Label();
            this.lblCetvrtina = new System.Windows.Forms.Label();
            this.lblDomaciBrojTajm = new System.Windows.Forms.Label();
            this.lblDomaciFaulovi = new System.Windows.Forms.Label();
            this.lblGostiLicne = new System.Windows.Forms.Label();
            this.lblGostiBrojTajm = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIzbrisiLicnu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDomacin
            // 
            this.lblDomacin.AutoSize = true;
            this.lblDomacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomacin.Location = new System.Drawing.Point(157, 92);
            this.lblDomacin.Name = "lblDomacin";
            this.lblDomacin.Size = new System.Drawing.Size(72, 18);
            this.lblDomacin.TabIndex = 0;
            this.lblDomacin.Text = "Domacin:";
            // 
            // lblGost
            // 
            this.lblGost.AutoSize = true;
            this.lblGost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGost.Location = new System.Drawing.Point(1056, 92);
            this.lblGost.Name = "lblGost";
            this.lblGost.Size = new System.Drawing.Size(49, 18);
            this.lblGost.TabIndex = 1;
            this.lblGost.Text = "Gost: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj faula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj tajmauta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1212, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj tajmauta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1212, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj faula:";
            // 
            // btnTajmDomaci
            // 
            this.btnTajmDomaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTajmDomaci.Location = new System.Drawing.Point(362, 220);
            this.btnTajmDomaci.Name = "btnTajmDomaci";
            this.btnTajmDomaci.Size = new System.Drawing.Size(57, 26);
            this.btnTajmDomaci.TabIndex = 6;
            this.btnTajmDomaci.Text = "+";
            this.btnTajmDomaci.UseVisualStyleBackColor = true;
            // 
            // btnTajmGosti
            // 
            this.btnTajmGosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTajmGosti.Location = new System.Drawing.Point(1231, 216);
            this.btnTajmGosti.Name = "btnTajmGosti";
            this.btnTajmGosti.Size = new System.Drawing.Size(57, 26);
            this.btnTajmGosti.TabIndex = 7;
            this.btnTajmGosti.Text = "+";
            this.btnTajmGosti.UseVisualStyleBackColor = true;
            // 
            // dgvDomaci
            // 
            this.dgvDomaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomaci.Location = new System.Drawing.Point(42, 285);
            this.dgvDomaci.Name = "dgvDomaci";
            this.dgvDomaci.RowHeadersWidth = 51;
            this.dgvDomaci.RowTemplate.Height = 24;
            this.dgvDomaci.Size = new System.Drawing.Size(526, 385);
            this.dgvDomaci.TabIndex = 8;
            // 
            // dgvGosti
            // 
            this.dgvGosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGosti.Location = new System.Drawing.Point(921, 285);
            this.dgvGosti.Name = "dgvGosti";
            this.dgvGosti.RowHeadersWidth = 51;
            this.dgvGosti.RowTemplate.Height = 24;
            this.dgvGosti.Size = new System.Drawing.Size(504, 385);
            this.dgvGosti.TabIndex = 9;
            // 
            // btnPoen
            // 
            this.btnPoen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoen.Location = new System.Drawing.Point(646, 231);
            this.btnPoen.Name = "btnPoen";
            this.btnPoen.Size = new System.Drawing.Size(179, 67);
            this.btnPoen.TabIndex = 10;
            this.btnPoen.Text = "Unos poena";
            this.btnPoen.UseVisualStyleBackColor = true;
            // 
            // btnLicna
            // 
            this.btnLicna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicna.Location = new System.Drawing.Point(646, 329);
            this.btnLicna.Name = "btnLicna";
            this.btnLicna.Size = new System.Drawing.Size(179, 67);
            this.btnLicna.TabIndex = 11;
            this.btnLicna.Text = "Unos licne greske";
            this.btnLicna.UseVisualStyleBackColor = true;
            // 
            // btnIzmena
            // 
            this.btnIzmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmena.Location = new System.Drawing.Point(646, 421);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(179, 67);
            this.btnIzmena.TabIndex = 12;
            this.btnIzmena.Text = "Ispravi rezultat";
            this.btnIzmena.UseVisualStyleBackColor = true;
            // 
            // btnSLedeca
            // 
            this.btnSLedeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLedeca.Location = new System.Drawing.Point(646, 603);
            this.btnSLedeca.Name = "btnSLedeca";
            this.btnSLedeca.Size = new System.Drawing.Size(179, 67);
            this.btnSLedeca.TabIndex = 13;
            this.btnSLedeca.Text = "Sledeca cetvrtina";
            this.btnSLedeca.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cetvrtina";
            // 
            // lblDomPoeni
            // 
            this.lblDomPoeni.AutoSize = true;
            this.lblDomPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomPoeni.Location = new System.Drawing.Point(180, 129);
            this.lblDomPoeni.Name = "lblDomPoeni";
            this.lblDomPoeni.Size = new System.Drawing.Size(62, 67);
            this.lblDomPoeni.TabIndex = 15;
            this.lblDomPoeni.Text = "0";
            // 
            // lblGostiPoeni
            // 
            this.lblGostiPoeni.AutoSize = true;
            this.lblGostiPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGostiPoeni.Location = new System.Drawing.Point(1081, 129);
            this.lblGostiPoeni.Name = "lblGostiPoeni";
            this.lblGostiPoeni.Size = new System.Drawing.Size(62, 67);
            this.lblGostiPoeni.TabIndex = 16;
            this.lblGostiPoeni.Text = "0";
            // 
            // lblCetvrtina
            // 
            this.lblCetvrtina.AutoSize = true;
            this.lblCetvrtina.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCetvrtina.Location = new System.Drawing.Point(702, 106);
            this.lblCetvrtina.Name = "lblCetvrtina";
            this.lblCetvrtina.Size = new System.Drawing.Size(62, 67);
            this.lblCetvrtina.TabIndex = 17;
            this.lblCetvrtina.Text = "1";
            // 
            // lblDomaciBrojTajm
            // 
            this.lblDomaciBrojTajm.AutoSize = true;
            this.lblDomaciBrojTajm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomaciBrojTajm.Location = new System.Drawing.Point(466, 187);
            this.lblDomaciBrojTajm.Name = "lblDomaciBrojTajm";
            this.lblDomaciBrojTajm.Size = new System.Drawing.Size(18, 20);
            this.lblDomaciBrojTajm.TabIndex = 18;
            this.lblDomaciBrojTajm.Text = "0";
            // 
            // lblDomaciFaulovi
            // 
            this.lblDomaciFaulovi.AutoSize = true;
            this.lblDomaciFaulovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomaciFaulovi.Location = new System.Drawing.Point(466, 126);
            this.lblDomaciFaulovi.Name = "lblDomaciFaulovi";
            this.lblDomaciFaulovi.Size = new System.Drawing.Size(18, 20);
            this.lblDomaciFaulovi.TabIndex = 19;
            this.lblDomaciFaulovi.Text = "0";
            // 
            // lblGostiLicne
            // 
            this.lblGostiLicne.AutoSize = true;
            this.lblGostiLicne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGostiLicne.Location = new System.Drawing.Point(1329, 125);
            this.lblGostiLicne.Name = "lblGostiLicne";
            this.lblGostiLicne.Size = new System.Drawing.Size(18, 20);
            this.lblGostiLicne.TabIndex = 21;
            this.lblGostiLicne.Text = "0";
            // 
            // lblGostiBrojTajm
            // 
            this.lblGostiBrojTajm.AutoSize = true;
            this.lblGostiBrojTajm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGostiBrojTajm.Location = new System.Drawing.Point(1329, 186);
            this.lblGostiBrojTajm.Name = "lblGostiBrojTajm";
            this.lblGostiBrojTajm.Size = new System.Drawing.Size(18, 20);
            this.lblGostiBrojTajm.TabIndex = 20;
            this.lblGostiBrojTajm.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Spisak domacih igraca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1272, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Spisak gostujucih igraca";
            // 
            // btnIzbrisiLicnu
            // 
            this.btnIzbrisiLicnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiLicnu.Location = new System.Drawing.Point(646, 516);
            this.btnIzbrisiLicnu.Name = "btnIzbrisiLicnu";
            this.btnIzbrisiLicnu.Size = new System.Drawing.Size(179, 67);
            this.btnIzbrisiLicnu.TabIndex = 24;
            this.btnIzbrisiLicnu.Text = "Izbrisi licnu gresku";
            this.btnIzbrisiLicnu.UseVisualStyleBackColor = true;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 699);
            this.Controls.Add(this.btnIzbrisiLicnu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblGostiLicne);
            this.Controls.Add(this.lblGostiBrojTajm);
            this.Controls.Add(this.lblDomaciFaulovi);
            this.Controls.Add(this.lblDomaciBrojTajm);
            this.Controls.Add(this.lblCetvrtina);
            this.Controls.Add(this.lblGostiPoeni);
            this.Controls.Add(this.lblDomPoeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSLedeca);
            this.Controls.Add(this.btnIzmena);
            this.Controls.Add(this.btnLicna);
            this.Controls.Add(this.btnPoen);
            this.Controls.Add(this.dgvGosti);
            this.Controls.Add(this.dgvDomaci);
            this.Controls.Add(this.btnTajmGosti);
            this.Controls.Add(this.btnTajmDomaci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGost);
            this.Controls.Add(this.lblDomacin);
            this.Name = "FrmGame";
            this.Text = "FrmGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGame_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDomacin;
        private System.Windows.Forms.Label lblGost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTajmDomaci;
        private System.Windows.Forms.Button btnTajmGosti;
        private System.Windows.Forms.DataGridView dgvDomaci;
        private System.Windows.Forms.DataGridView dgvGosti;
        private System.Windows.Forms.Button btnPoen;
        private System.Windows.Forms.Button btnLicna;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Button btnSLedeca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDomPoeni;
        private System.Windows.Forms.Label lblGostiPoeni;
        private System.Windows.Forms.Label lblCetvrtina;
        private Label lblDomaciBrojTajm;
        private Label lblDomaciFaulovi;
        private Label lblGostiLicne;
        private Label lblGostiBrojTajm;
        private Label label10;
        private Label label11;
        private Button btnIzbrisiLicnu;

        public Button BtnTajmDomaci { get => btnTajmDomaci; set => btnTajmDomaci = value; }
        public Button BtnTajmGosti { get => btnTajmGosti; set => btnTajmGosti = value; }
        public Button BtnPoen { get => btnPoen; set => btnPoen= value; }
        public Button BtnLicna { get => btnLicna; set => btnLicna= value; }
        public Button BtnIzmena { get => btnIzmena; set => btnIzmena= value; }
        public Button BtnSledecaCet { get => btnSLedeca; set => btnSLedeca= value; }
        public Label LblDomacin { get => lblDomacin; set => lblDomacin= value; }
        public Label LblGost { get => lblGost; set => lblGost = value; }
        public Label LblDomPoeni { get => lblDomPoeni; set => lblDomPoeni= value; }
        public Label LblGostiPoeni { get => lblGostiPoeni; set => lblGostiPoeni = value; }
        public Label LblCetvrina { get => lblCetvrtina; set => lblCetvrtina= value; }
        public Label LblDomaciTajmBroj { get => lblDomaciBrojTajm; set => lblDomaciBrojTajm= value; }
        public Label LblDomaciLicne { get => lblDomaciFaulovi; set => lblDomaciFaulovi= value; }
        public Label LblGostiTajmBroj { get => lblGostiBrojTajm; set => lblGostiBrojTajm= value; }
        public Label LblGostiLicne { get => lblGostiLicne; set => lblGostiLicne= value; }
        public DataGridView DgvDomaci { get => dgvDomaci; set => dgvDomaci= value; }
        public DataGridView DgvGosti { get => dgvGosti; set => dgvGosti= value; }
    }
}