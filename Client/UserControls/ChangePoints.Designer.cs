using System.Windows.Forms;

namespace Client.UserControls
{
    partial class ChangePoints
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
            this.dgvPoeni = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJedan = new System.Windows.Forms.Button();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDva = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoeni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoeni
            // 
            this.dgvPoeni.AllowUserToAddRows = false;
            this.dgvPoeni.AllowUserToDeleteRows = false;
            this.dgvPoeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoeni.Location = new System.Drawing.Point(58, 209);
            this.dgvPoeni.MultiSelect = false;
            this.dgvPoeni.Name = "dgvPoeni";
            this.dgvPoeni.ReadOnly = true;
            this.dgvPoeni.RowHeadersWidth = 51;
            this.dgvPoeni.RowTemplate.Height = 24;
            this.dgvPoeni.Size = new System.Drawing.Size(565, 190);
            this.dgvPoeni.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ispravka rezultata";
            // 
            // btnJedan
            // 
            this.btnJedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJedan.Location = new System.Drawing.Point(76, 148);
            this.btnJedan.Name = "btnJedan";
            this.btnJedan.Size = new System.Drawing.Size(138, 41);
            this.btnJedan.TabIndex = 20;
            this.btnJedan.Text = "1";
            this.btnJedan.UseVisualStyleBackColor = true;
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(446, 56);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(177, 24);
            this.cmbTimovi.TabIndex = 18;
            this.cmbTimovi.SelectedIndexChanged += new System.EventHandler(this.cmbTimovi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Izaberite tim:";
            // 
            // btnDva
            // 
            this.btnDva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDva.Location = new System.Drawing.Point(271, 148);
            this.btnDva.Name = "btnDva";
            this.btnDva.Size = new System.Drawing.Size(138, 41);
            this.btnDva.TabIndex = 23;
            this.btnDva.Text = "2";
            this.btnDva.UseVisualStyleBackColor = true;
            // 
            // btnTri
            // 
            this.btnTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTri.Location = new System.Drawing.Point(468, 148);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(138, 41);
            this.btnTri.TabIndex = 24;
            this.btnTri.Text = "3";
            this.btnTri.UseVisualStyleBackColor = true;
            // 
            // ChangePoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.btnDva);
            this.Controls.Add(this.dgvPoeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnJedan);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.label1);
            this.Name = "ChangePoints";
            this.Size = new System.Drawing.Size(679, 474);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPoeni;
        private Label label3;
        private Button btnJedan;
        private ComboBox cmbTimovi;
        private Label label1;
        private Button btnDva;
        private Button btnTri;

        public Button BtnJedan { get => btnJedan; set => btnJedan = value; }
        public Button BtnDva { get => btnDva; set => btnDva = value; }
        public Button BtnTri { get => btnTri; set => btnTri = value; }
        public ComboBox CmbTim { get => cmbTimovi; set => cmbTimovi = value; }
        public DataGridView DgvPoeni { get => dgvPoeni; set => dgvPoeni = value; }

    }
}
