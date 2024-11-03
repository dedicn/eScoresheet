using System.Windows.Forms;

namespace Client.UserControls
{
    partial class AddPoints
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.cmbIgraci = new System.Windows.Forms.ComboBox();
            this.btnJedan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDva = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite tim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izaberite igraca:";
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(313, 145);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(177, 24);
            this.cmbTimovi.TabIndex = 2;
            this.cmbTimovi.SelectedIndexChanged += new System.EventHandler(this.cmbTimovi_SelectedIndexChanged_1);
            // 
            // cmbIgraci
            // 
            this.cmbIgraci.FormattingEnabled = true;
            this.cmbIgraci.Location = new System.Drawing.Point(313, 222);
            this.cmbIgraci.Name = "cmbIgraci";
            this.cmbIgraci.Size = new System.Drawing.Size(177, 24);
            this.cmbIgraci.TabIndex = 3;
            // 
            // btnJedan
            // 
            this.btnJedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJedan.Location = new System.Drawing.Point(80, 312);
            this.btnJedan.Name = "btnJedan";
            this.btnJedan.Size = new System.Drawing.Size(125, 54);
            this.btnJedan.TabIndex = 4;
            this.btnJedan.Text = "1";
            this.btnJedan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unos rezultata";
            // 
            // btnDva
            // 
            this.btnDva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDva.Location = new System.Drawing.Point(273, 312);
            this.btnDva.Name = "btnDva";
            this.btnDva.Size = new System.Drawing.Size(125, 54);
            this.btnDva.TabIndex = 5;
            this.btnDva.Text = "2";
            this.btnDva.UseVisualStyleBackColor = true;
            // 
            // btnTri
            // 
            this.btnTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTri.Location = new System.Drawing.Point(469, 312);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(125, 54);
            this.btnTri.TabIndex = 6;
            this.btnTri.Text = "3";
            this.btnTri.UseVisualStyleBackColor = true;
            // 
            // AddPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.btnDva);
            this.Controls.Add(this.btnJedan);
            this.Controls.Add(this.cmbIgraci);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPoints";
            this.Size = new System.Drawing.Size(675, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.ComboBox cmbIgraci;
        private System.Windows.Forms.Button btnJedan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDva;
        private System.Windows.Forms.Button btnTri;

        public Button BtnJedan { get => btnJedan; set => btnJedan = value; }
        public Button BtnDva { get => btnDva; set => btnDva= value; }
        public Button BtnTri{ get => btnTri; set => btnTri = value; }
        public ComboBox CmbTim { get => cmbTimovi; set => cmbTimovi = value; }
        public ComboBox CmbIgraqci { get => cmbIgraci; set => cmbIgraci = value; }
    }
}
