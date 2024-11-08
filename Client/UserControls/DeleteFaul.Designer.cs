﻿using System.Windows.Forms;

namespace Client.UserControls
{
    partial class DeleteFaul
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
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPoeni = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoeni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(257, 375);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(141, 56);
            this.btnIzbrisi.TabIndex = 15;
            this.btnIzbrisi.Text = "Izbrisi faul";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Izbrisite faul";
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(175, 95);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(177, 24);
            this.cmbTimovi.TabIndex = 12;
            this.cmbTimovi.SelectedIndexChanged += new System.EventHandler(this.cmbTimovi_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Izaberite tim:";
            // 
            // dgvPoeni
            // 
            this.dgvPoeni.AllowUserToAddRows = false;
            this.dgvPoeni.AllowUserToDeleteRows = false;
            this.dgvPoeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoeni.Location = new System.Drawing.Point(47, 140);
            this.dgvPoeni.MultiSelect = false;
            this.dgvPoeni.Name = "dgvPoeni";
            this.dgvPoeni.ReadOnly = true;
            this.dgvPoeni.RowHeadersWidth = 51;
            this.dgvPoeni.RowTemplate.Height = 24;
            this.dgvPoeni.Size = new System.Drawing.Size(565, 206);
            this.dgvPoeni.TabIndex = 23;
            // 
            // DeleteFaul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPoeni);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.label1);
            this.Name = "DeleteFaul";
            this.Size = new System.Drawing.Size(673, 454);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.Label label1;
        private DataGridView dgvPoeni;

        public Button BtnIzbrisiFaul { get => btnIzbrisi; set => btnIzbrisi = value; }
        public ComboBox CmbTim { get => cmbTimovi; set => cmbTimovi = value; }
        public DataGridView DgvPoeni { get => dgvPoeni; set => dgvPoeni = value; }
    }
}
