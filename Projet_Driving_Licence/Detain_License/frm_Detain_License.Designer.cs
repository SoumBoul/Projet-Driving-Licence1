namespace Projet_Driving_Licence
{
    partial class frm_Detain_License
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
            this.linkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linkLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cntr_Detain_License1 = new Projet_Driving_Licence.cntr_Detain_License();
            this.cntr_InternationalLicenseApplication1 = new Projet_Driving_Licence.cntr_InternationalLicenseApplication();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain License";
            // 
            // linkShowLicenseInfo
            // 
            this.linkShowLicenseInfo.AutoSize = true;
            this.linkShowLicenseInfo.Enabled = false;
            this.linkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowLicenseInfo.Location = new System.Drawing.Point(335, 703);
            this.linkShowLicenseInfo.Name = "linkShowLicenseInfo";
            this.linkShowLicenseInfo.Size = new System.Drawing.Size(146, 18);
            this.linkShowLicenseInfo.TabIndex = 24;
            this.linkShowLicenseInfo.TabStop = true;
            this.linkShowLicenseInfo.Text = "Show License Info";
            this.linkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseInfo_LinkClicked);
            // 
            // linkLicenseHistory
            // 
            this.linkLicenseHistory.AutoSize = true;
            this.linkLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLicenseHistory.Location = new System.Drawing.Point(30, 703);
            this.linkLicenseHistory.Name = "linkLicenseHistory";
            this.linkLicenseHistory.Size = new System.Drawing.Size(181, 18);
            this.linkLicenseHistory.TabIndex = 23;
            this.linkLicenseHistory.TabStop = true;
            this.linkLicenseHistory.Text = "Show Licenses History";
            this.linkLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicenseHistory_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetain.Location = new System.Drawing.Point(844, 699);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(115, 27);
            this.btnDetain.TabIndex = 22;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(709, 696);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 26);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cntr_Detain_License1
            // 
            this.cntr_Detain_License1.BackColor = System.Drawing.Color.White;
            this.cntr_Detain_License1.Location = new System.Drawing.Point(44, 581);
            this.cntr_Detain_License1.Name = "cntr_Detain_License1";
            this.cntr_Detain_License1.Size = new System.Drawing.Size(887, 109);
            this.cntr_Detain_License1.TabIndex = 25;
            // 
            // cntr_InternationalLicenseApplication1
            // 
            this.cntr_InternationalLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.cntr_InternationalLicenseApplication1.Location = new System.Drawing.Point(-8, 47);
            this.cntr_InternationalLicenseApplication1.Name = "cntr_InternationalLicenseApplication1";
            this.cntr_InternationalLicenseApplication1.Size = new System.Drawing.Size(1012, 528);
            this.cntr_InternationalLicenseApplication1.TabIndex = 1;
            // 
            // frm_Detain_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.cntr_Detain_License1);
            this.Controls.Add(this.linkShowLicenseInfo);
            this.Controls.Add(this.linkLicenseHistory);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntr_InternationalLicenseApplication1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Detain_License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Detain_License";
            this.Load += new System.EventHandler(this.frm_Detain_License_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel linkShowLicenseInfo;
        public System.Windows.Forms.LinkLabel linkLicenseHistory;
        public System.Windows.Forms.Button btnDetain;
        public System.Windows.Forms.Button btnClose;
        public cntr_InternationalLicenseApplication cntr_InternationalLicenseApplication1;
        public cntr_Detain_License cntr_Detain_License1;
    }
}