namespace Projet_Driving_Licence
{
    partial class frmRelease_Detained_License
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
            this.linkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linkLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cntrDetainInfo_For_frmRelease1 = new Projet_Driving_Licence.cntrDetainInfo_For_frmRelease();
            this.cntr_InternationalLicenseApplication1 = new Projet_Driving_Licence.cntr_InternationalLicenseApplication();
            this.SuspendLayout();
            // 
            // linkShowLicenseInfo
            // 
            this.linkShowLicenseInfo.AutoSize = true;
            this.linkShowLicenseInfo.Enabled = false;
            this.linkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowLicenseInfo.Location = new System.Drawing.Point(337, 722);
            this.linkShowLicenseInfo.Name = "linkShowLicenseInfo";
            this.linkShowLicenseInfo.Size = new System.Drawing.Size(146, 18);
            this.linkShowLicenseInfo.TabIndex = 28;
            this.linkShowLicenseInfo.TabStop = true;
            this.linkShowLicenseInfo.Text = "Show License Info";
            this.linkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseInfo_LinkClicked);
            // 
            // linkLicenseHistory
            // 
            this.linkLicenseHistory.AutoSize = true;
            this.linkLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLicenseHistory.Location = new System.Drawing.Point(32, 722);
            this.linkLicenseHistory.Name = "linkLicenseHistory";
            this.linkLicenseHistory.Size = new System.Drawing.Size(181, 18);
            this.linkLicenseHistory.TabIndex = 27;
            this.linkLicenseHistory.TabStop = true;
            this.linkLicenseHistory.Text = "Show Licenses History";
            this.linkLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicenseHistory_LinkClicked);
            // 
            // btnRelease
            // 
            this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRelease.Location = new System.Drawing.Point(846, 718);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(115, 27);
            this.btnRelease.TabIndex = 26;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(737, 722);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 26);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cntrDetainInfo_For_frmRelease1
            // 
            this.cntrDetainInfo_For_frmRelease1.BackColor = System.Drawing.Color.White;
            this.cntrDetainInfo_For_frmRelease1.Location = new System.Drawing.Point(1, 551);
            this.cntrDetainInfo_For_frmRelease1.Name = "cntrDetainInfo_For_frmRelease1";
            this.cntrDetainInfo_For_frmRelease1.Size = new System.Drawing.Size(987, 158);
            this.cntrDetainInfo_For_frmRelease1.TabIndex = 29;
            // 
            // cntr_InternationalLicenseApplication1
            // 
            this.cntr_InternationalLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.cntr_InternationalLicenseApplication1.Location = new System.Drawing.Point(0, 0);
            this.cntr_InternationalLicenseApplication1.Name = "cntr_InternationalLicenseApplication1";
            this.cntr_InternationalLicenseApplication1.Size = new System.Drawing.Size(988, 537);
            this.cntr_InternationalLicenseApplication1.TabIndex = 0;
            this.cntr_InternationalLicenseApplication1.Load += new System.EventHandler(this.cntr_InternationalLicenseApplication1_Load);
            // 
            // frmRelease_Detained_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 757);
            this.Controls.Add(this.cntrDetainInfo_For_frmRelease1);
            this.Controls.Add(this.linkShowLicenseInfo);
            this.Controls.Add(this.linkLicenseHistory);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntr_InternationalLicenseApplication1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelease_Detained_License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelease_Detained_License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.LinkLabel linkShowLicenseInfo;
        public System.Windows.Forms.LinkLabel linkLicenseHistory;
        public System.Windows.Forms.Button btnRelease;
        public System.Windows.Forms.Button btnClose;
        public cntr_InternationalLicenseApplication cntr_InternationalLicenseApplication1;
        public cntrDetainInfo_For_frmRelease cntrDetainInfo_For_frmRelease1;
    }
}