namespace Projet_Driving_Licence
{
    partial class frmPersonInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.contrPersonInfo1 = new Projet_Driving_Licence.contrPersonInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Projet_Driving_Licence.Properties.Resources.close1;
            this.btnClose.Location = new System.Drawing.Point(792, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 44);
            this.btnClose.TabIndex = 86;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("SimSun-ExtB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Lime;
            this.lblTitre.Location = new System.Drawing.Point(259, 26);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(267, 33);
            this.lblTitre.TabIndex = 87;
            this.lblTitre.Text = "Person Details";
            // 
            // contrPersonInfo1
            // 
            this.contrPersonInfo1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.contrPersonInfo1.ID = 0;
            this.contrPersonInfo1.Location = new System.Drawing.Point(25, 62);
            this.contrPersonInfo1.Name = "contrPersonInfo1";
            this.contrPersonInfo1.Size = new System.Drawing.Size(961, 329);
            this.contrPersonInfo1.TabIndex = 88;
            // 
            // frmPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1030, 453);
            this.Controls.Add(this.contrPersonInfo1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonInfo";
            this.Load += new System.EventHandler(this.frmPersonInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitre;
        public contrPersonInfo contrPersonInfo1;
        // private cntrPersonInfo cntrPersonInfo1;
    }
}