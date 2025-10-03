namespace Projet_Driving_Licence
{
    partial class frmRemplacementForDamageLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBLost = new System.Windows.Forms.RadioButton();
            this.RBDamage = new System.Windows.Forms.RadioButton();
            this.linkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linkLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cntr_InternationalLicenseApplication1 = new Projet_Driving_Licence.cntr_InternationalLicenseApplication();
            this.cntrApp_Info_For_Replacement_License1 = new Projet_Driving_Licence.cntrApp_Info_For_Replacement_License();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replacement For Damage License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBLost);
            this.groupBox1.Controls.Add(this.RBDamage);
            this.groupBox1.Location = new System.Drawing.Point(885, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement for";
            // 
            // RBLost
            // 
            this.RBLost.AutoSize = true;
            this.RBLost.Location = new System.Drawing.Point(10, 48);
            this.RBLost.Name = "RBLost";
            this.RBLost.Size = new System.Drawing.Size(103, 20);
            this.RBLost.TabIndex = 1;
            this.RBLost.Text = "Lost License";
            this.RBLost.UseVisualStyleBackColor = true;
            // 
            // RBDamage
            // 
            this.RBDamage.AutoSize = true;
            this.RBDamage.Checked = true;
            this.RBDamage.Location = new System.Drawing.Point(10, 22);
            this.RBDamage.Name = "RBDamage";
            this.RBDamage.Size = new System.Drawing.Size(131, 20);
            this.RBDamage.TabIndex = 0;
            this.RBDamage.TabStop = true;
            this.RBDamage.Text = "Damage License";
            this.RBDamage.UseVisualStyleBackColor = true;
            // 
            // linkShowLicenseInfo
            // 
            this.linkShowLicenseInfo.AutoSize = true;
            this.linkShowLicenseInfo.Enabled = false;
            this.linkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowLicenseInfo.Location = new System.Drawing.Point(382, 739);
            this.linkShowLicenseInfo.Name = "linkShowLicenseInfo";
            this.linkShowLicenseInfo.Size = new System.Drawing.Size(173, 22);
            this.linkShowLicenseInfo.TabIndex = 20;
            this.linkShowLicenseInfo.TabStop = true;
            this.linkShowLicenseInfo.Text = "Show License Info";
            this.linkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseInfo_LinkClicked);
            // 
            // linkLicenseHistory
            // 
            this.linkLicenseHistory.AutoSize = true;
            this.linkLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLicenseHistory.Location = new System.Drawing.Point(77, 739);
            this.linkLicenseHistory.Name = "linkLicenseHistory";
            this.linkLicenseHistory.Size = new System.Drawing.Size(213, 22);
            this.linkLicenseHistory.TabIndex = 19;
            this.linkLicenseHistory.TabStop = true;
            this.linkLicenseHistory.Text = "Show Licenses History";
            this.linkLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicenseHistory_LinkClicked);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.Location = new System.Drawing.Point(885, 731);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(115, 41);
            this.btnIssueReplacement.TabIndex = 18;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(756, 732);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 41);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cntr_InternationalLicenseApplication1
            // 
            this.cntr_InternationalLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.cntr_InternationalLicenseApplication1.Location = new System.Drawing.Point(1, 53);
            this.cntr_InternationalLicenseApplication1.Name = "cntr_InternationalLicenseApplication1";
            this.cntr_InternationalLicenseApplication1.Size = new System.Drawing.Size(1053, 534);
            this.cntr_InternationalLicenseApplication1.TabIndex = 3;
            // 
            // cntrApp_Info_For_Replacement_License1
            // 
            this.cntrApp_Info_For_Replacement_License1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cntrApp_Info_For_Replacement_License1.Location = new System.Drawing.Point(12, 583);
            this.cntrApp_Info_For_Replacement_License1.Name = "cntrApp_Info_For_Replacement_License1";
            this.cntrApp_Info_For_Replacement_License1.Size = new System.Drawing.Size(993, 142);
            this.cntrApp_Info_For_Replacement_License1.TabIndex = 2;
            // 
            // frmRemplacementForDamageLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 784);
            this.Controls.Add(this.linkShowLicenseInfo);
            this.Controls.Add(this.linkLicenseHistory);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cntr_InternationalLicenseApplication1);
            this.Controls.Add(this.cntrApp_Info_For_Replacement_License1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRemplacementForDamageLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRemplacementForDamageLicense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public cntrApp_Info_For_Replacement_License cntrApp_Info_For_Replacement_License1;
        public cntr_InternationalLicenseApplication cntr_InternationalLicenseApplication1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.LinkLabel linkShowLicenseInfo;
        public System.Windows.Forms.LinkLabel linkLicenseHistory;
        public System.Windows.Forms.Button btnIssueReplacement;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.RadioButton RBLost;
        public System.Windows.Forms.RadioButton RBDamage;
    }
}