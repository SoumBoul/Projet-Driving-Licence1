namespace Projet_Driving_Licence
{
    partial class frm_Renew_License_Application
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
            this.btnRenew = new System.Windows.Forms.Button();
            this.linkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linkLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cntrRenewLicenseApplication1 = new Projet_Driving_Licence.cntrRenewLicenseApplication();
            this.cntr_InternationalLicenseApplication1 = new Projet_Driving_Licence.cntr_InternationalLicenseApplication();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(812, 879);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(909, 879);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(75, 23);
            this.btnRenew.TabIndex = 3;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // linkShowLicenseInfo
            // 
            this.linkShowLicenseInfo.AutoSize = true;
            this.linkShowLicenseInfo.Enabled = false;
            this.linkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowLicenseInfo.Location = new System.Drawing.Point(348, 885);
            this.linkShowLicenseInfo.Name = "linkShowLicenseInfo";
            this.linkShowLicenseInfo.Size = new System.Drawing.Size(173, 22);
            this.linkShowLicenseInfo.TabIndex = 16;
            this.linkShowLicenseInfo.TabStop = true;
            this.linkShowLicenseInfo.Text = "Show License Info";
            this.linkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseInfo_LinkClicked);
            // 
            // linkLicenseHistory
            // 
            this.linkLicenseHistory.AutoSize = true;
            this.linkLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLicenseHistory.Location = new System.Drawing.Point(61, 885);
            this.linkLicenseHistory.Name = "linkLicenseHistory";
            this.linkLicenseHistory.Size = new System.Drawing.Size(213, 22);
            this.linkLicenseHistory.TabIndex = 15;
            this.linkLicenseHistory.TabStop = true;
            this.linkLicenseHistory.Text = "Show Licenses History";
            this.linkLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(275, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "Renew License Application";
            // 
            // cntrRenewLicenseApplication1
            // 
            this.cntrRenewLicenseApplication1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cntrRenewLicenseApplication1.Location = new System.Drawing.Point(12, 592);
            this.cntrRenewLicenseApplication1.Name = "cntrRenewLicenseApplication1";
            this.cntrRenewLicenseApplication1.Size = new System.Drawing.Size(997, 281);
            this.cntrRenewLicenseApplication1.TabIndex = 1;
            // 
            // cntr_InternationalLicenseApplication1
            // 
            this.cntr_InternationalLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.cntr_InternationalLicenseApplication1.Location = new System.Drawing.Point(12, 48);
            this.cntr_InternationalLicenseApplication1.Name = "cntr_InternationalLicenseApplication1";
            this.cntr_InternationalLicenseApplication1.Size = new System.Drawing.Size(1027, 538);
            this.cntr_InternationalLicenseApplication1.TabIndex = 0;
            this.cntr_InternationalLicenseApplication1.Load += new System.EventHandler(this.cntr_InternationalLicenseApplication1_Load);
            // 
            // frm_Renew_License_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 914);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkShowLicenseInfo);
            this.Controls.Add(this.linkLicenseHistory);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntrRenewLicenseApplication1);
            this.Controls.Add(this.cntr_InternationalLicenseApplication1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Renew_License_Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Renew_License_Application";
            this.Load += new System.EventHandler(this.frm_Renew_License_Application_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.LinkLabel linkShowLicenseInfo;
        private System.Windows.Forms.Label label1;
        public cntr_InternationalLicenseApplication cntr_InternationalLicenseApplication1;
        public cntrRenewLicenseApplication cntrRenewLicenseApplication1;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnRenew;
        public System.Windows.Forms.LinkLabel linkLicenseHistory;
    }
}