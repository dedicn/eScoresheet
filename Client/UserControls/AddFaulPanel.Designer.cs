using System.Windows.Forms;

namespace Client.UserControls
{
    partial class AddFaulPanel
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
            this.cmbIgraci = new System.Windows.Forms.ComboBox();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnesiFaul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbIgraci
            // 
            this.cmbIgraci.FormattingEnabled = true;
            this.cmbIgraci.Location = new System.Drawing.Point(310, 246);
            this.cmbIgraci.Name = "cmbIgraci";
            this.cmbIgraci.Size = new System.Drawing.Size(177, 24);
            this.cmbIgraci.TabIndex = 7;
            this.cmbIgraci.SelectedIndexChanged += new System.EventHandler(this.cmbIgraci_SelectedIndexChanged);
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(310, 169);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(177, 24);
            this.cmbTimovi.TabIndex = 6;
            this.cmbTimovi.SelectedIndexChanged += new System.EventHandler(this.cmbTimovi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izaberite igraca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izaberite tim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unesite faul";
            // 
            // btnUnesiFaul
            // 
            this.btnUnesiFaul.Location = new System.Drawing.Point(269, 329);
            this.btnUnesiFaul.Name = "btnUnesiFaul";
            this.btnUnesiFaul.Size = new System.Drawing.Size(141, 56);
            this.btnUnesiFaul.TabIndex = 9;
            this.btnUnesiFaul.Text = "Unesi faul";
            this.btnUnesiFaul.UseVisualStyleBackColor = true;
            // 
            // AddFaulPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUnesiFaul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIgraci);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFaulPanel";
            this.Size = new System.Drawing.Size(666, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIgraci;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnesiFaul;

        public Button BtnUnesiFaul { get => btnUnesiFaul; set => btnUnesiFaul= value; }
        public ComboBox CmbTim { get => cmbTimovi; set => cmbTimovi = value; }
        public ComboBox CmbIgraqci { get => cmbIgraci; set => cmbIgraci= value; }
    }
}
