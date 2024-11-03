using System.Windows.Forms;

namespace Client.UserControls
{
    partial class Team
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifraTima = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra tima:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(332, 221);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(164, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv tima:";
            // 
            // lblSifraTima
            // 
            this.lblSifraTima.AutoSize = true;
            this.lblSifraTima.Location = new System.Drawing.Point(329, 159);
            this.lblSifraTima.Name = "lblSifraTima";
            this.lblSifraTima.Size = new System.Drawing.Size(0, 20);
            this.lblSifraTima.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Izmena tima";
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(291, 315);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(135, 57);
            this.btnSacuvajIzmene.TabIndex = 6;
            this.btnSacuvajIzmene.Text = "Izmeni";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSifraTima);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Team";
            this.Size = new System.Drawing.Size(701, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifraTima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacuvajIzmene;

        public Button BtnSacuvajIzmene { get => btnSacuvajIzmene; set => btnSacuvajIzmene = value; }
        public TextBox TxtNazivTima { get => txtNaziv; set => txtNaziv= value; }
        public Label TxtSifra { get => lblSifraTima; set => lblSifraTima = value; }
    }
}
