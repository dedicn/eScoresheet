using System.Windows.Forms;

namespace Client.UserControls
{
    partial class Cetvrtina
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
            this.lblCetvrtina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPoeniDomaci = new System.Windows.Forms.Label();
            this.lblPoeniGosti = new System.Windows.Forms.Label();
            this.btnSledecaCet = new System.Windows.Forms.Button();
            this.btnKraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCetvrtina
            // 
            this.lblCetvrtina.AutoSize = true;
            this.lblCetvrtina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCetvrtina.Location = new System.Drawing.Point(356, 67);
            this.lblCetvrtina.Name = "lblCetvrtina";
            this.lblCetvrtina.Size = new System.Drawing.Size(107, 29);
            this.lblCetvrtina.TabIndex = 0;
            this.lblCetvrtina.Text = "Cetvrtina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cetvrtina broj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj poena domaci:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj poena gosti:";
            // 
            // lblPoeniDomaci
            // 
            this.lblPoeniDomaci.AutoSize = true;
            this.lblPoeniDomaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeniDomaci.Location = new System.Drawing.Point(139, 255);
            this.lblPoeniDomaci.Name = "lblPoeniDomaci";
            this.lblPoeniDomaci.Size = new System.Drawing.Size(50, 24);
            this.lblPoeniDomaci.TabIndex = 4;
            this.lblPoeniDomaci.Text = "BRoj";
            // 
            // lblPoeniGosti
            // 
            this.lblPoeniGosti.AutoSize = true;
            this.lblPoeniGosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeniGosti.Location = new System.Drawing.Point(437, 260);
            this.lblPoeniGosti.Name = "lblPoeniGosti";
            this.lblPoeniGosti.Size = new System.Drawing.Size(155, 30);
            this.lblPoeniGosti.TabIndex = 5;
            this.lblPoeniGosti.Text = "Cetvrtina broj:";
            // 
            // btnSledecaCet
            // 
            this.btnSledecaCet.Location = new System.Drawing.Point(400, 345);
            this.btnSledecaCet.Name = "btnSledecaCet";
            this.btnSledecaCet.Size = new System.Drawing.Size(145, 64);
            this.btnSledecaCet.TabIndex = 6;
            this.btnSledecaCet.Text = "Sledeca cetvrtina";
            this.btnSledecaCet.UseVisualStyleBackColor = true;
            // 
            // btnKraj
            // 
            this.btnKraj.Location = new System.Drawing.Point(117, 345);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(145, 64);
            this.btnKraj.TabIndex = 7;
            this.btnKraj.Text = "Zavrsi utakmicu";
            this.btnKraj.UseVisualStyleBackColor = true;
            // 
            // Cetvrtina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.btnSledecaCet);
            this.Controls.Add(this.lblPoeniGosti);
            this.Controls.Add(this.lblPoeniDomaci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCetvrtina);
            this.Name = "Cetvrtina";
            this.Size = new System.Drawing.Size(680, 481);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCetvrtina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPoeniDomaci;
        private System.Windows.Forms.Label lblPoeniGosti;
        private System.Windows.Forms.Button btnSledecaCet;
        private System.Windows.Forms.Button btnKraj;

        public Button BtnSledecaCetvrtina { get => btnSledecaCet; set => btnSledecaCet = value; }
        public Button BtnKraj { get => btnKraj; set => btnKraj = value; }
    }
}
