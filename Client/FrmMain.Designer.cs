using System.Windows.Forms;

namespace Client
{
    partial class FrmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtGost = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveTeams = new System.Windows.Forms.Button();
            this.txtDomacin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtGost);
            this.pnlMain.Controls.Add(this.btnLogout);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.btnSaveTeams);
            this.pnlMain.Controls.Add(this.txtDomacin);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(932, 540);
            this.pnlMain.TabIndex = 0;
            // 
            // txtGost
            // 
            this.txtGost.Location = new System.Drawing.Point(600, 251);
            this.txtGost.Name = "txtGost";
            this.txtGost.Size = new System.Drawing.Size(220, 22);
            this.txtGost.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(777, 482);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Izloguj se";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ime gostujeceg tima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime domaceg tima:";
            // 
            // btnSaveTeams
            // 
            this.btnSaveTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTeams.Location = new System.Drawing.Point(368, 375);
            this.btnSaveTeams.Name = "btnSaveTeams";
            this.btnSaveTeams.Size = new System.Drawing.Size(169, 83);
            this.btnSaveTeams.TabIndex = 3;
            this.btnSaveTeams.Text = "Sacuvaj timove";
            this.btnSaveTeams.UseVisualStyleBackColor = true;
            // 
            // txtDomacin
            // 
            this.txtDomacin.Location = new System.Drawing.Point(136, 251);
            this.txtDomacin.Name = "txtDomacin";
            this.txtDomacin.Size = new System.Drawing.Size(220, 22);
            this.txtDomacin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodosli u eZapisnik";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 534);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveTeams;
        private System.Windows.Forms.TextBox txtDomacin;
        private System.Windows.Forms.TextBox txtGost;

        public Button BtnLogout { get => btnLogout; set => btnLogout = value; }
        public Button btnSaveTemas { get => btnSaveTeams; set => btnSaveTeams = value; }
        public TextBox Domaci { get => txtDomacin; set => txtDomacin = value; }
        public TextBox Gost { get => txtGost; set => txtGost = value; }
       
    }
}