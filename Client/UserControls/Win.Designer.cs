using System.Windows.Forms;

namespace Client.UserControls
{
    partial class Win
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lblPobednik = new System.Windows.Forms.Label();
            this.btnKraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Finalni rezultat:";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultat.Location = new System.Drawing.Point(395, 71);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(148, 29);
            this.lblRezultat.TabIndex = 2;
            this.lblRezultat.Text = "Pobednik je:";
            // 
            // lblPobednik
            // 
            this.lblPobednik.AutoSize = true;
            this.lblPobednik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPobednik.Location = new System.Drawing.Point(215, 229);
            this.lblPobednik.Name = "lblPobednik";
            this.lblPobednik.Size = new System.Drawing.Size(100, 20);
            this.lblPobednik.TabIndex = 3;
            this.lblPobednik.Text = "Pobednik je:";
            // 
            // btnKraj
            // 
            this.btnKraj.Location = new System.Drawing.Point(256, 356);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(159, 63);
            this.btnKraj.TabIndex = 4;
            this.btnKraj.Text = "Kraj";
            this.btnKraj.UseVisualStyleBackColor = true;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.lblPobednik);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.label2);
            this.Name = "Win";
            this.Size = new System.Drawing.Size(678, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Label lblPobednik;
        private System.Windows.Forms.Button btnKraj;

        public Button BtnKraj { get => btnKraj; set => btnKraj = value; }
    }
}
