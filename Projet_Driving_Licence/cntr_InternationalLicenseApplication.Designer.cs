namespace Projet_Driving_Licence
{
    partial class cntr_InternationalLicenseApplication
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblExp_Date = new System.Windows.Forms.Label();
            this.lblLocal_L_ID = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblFees2 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cntrDriverLiceseInfo11 = new Projet_Driving_Licence.cntrDriverLiceseInfo1();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(81, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Projet_Driving_Licence.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(592, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 51);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(231, 40);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(338, 28);
            this.txtLicenseID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(116, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "LicenseID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblExp_Date);
            this.groupBox2.Controls.Add(this.lblLocal_L_ID);
            this.groupBox2.Controls.Add(this.lblLicenseID);
            this.groupBox2.Controls.Add(this.lblFees2);
            this.groupBox2.Controls.Add(this.lblIssueDate);
            this.groupBox2.Controls.Add(this.lblAppDate);
            this.groupBox2.Controls.Add(this.lblApplicationID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblApplicationDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.lblExpirationDate);
            this.groupBox2.Controls.Add(this.lblLocalLicenseID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 544);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 151);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(557, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 18);
            this.label18.TabIndex = 15;
            this.label18.Text = "Created By";
            // 
            // lblExp_Date
            // 
            this.lblExp_Date.AutoSize = true;
            this.lblExp_Date.Location = new System.Drawing.Point(557, 76);
            this.lblExp_Date.Name = "lblExp_Date";
            this.lblExp_Date.Size = new System.Drawing.Size(123, 18);
            this.lblExp_Date.TabIndex = 14;
            this.lblExp_Date.Text = "Expiration Date";
            // 
            // lblLocal_L_ID
            // 
            this.lblLocal_L_ID.AutoSize = true;
            this.lblLocal_L_ID.Location = new System.Drawing.Point(557, 52);
            this.lblLocal_L_ID.Name = "lblLocal_L_ID";
            this.lblLocal_L_ID.Size = new System.Drawing.Size(128, 18);
            this.lblLocal_L_ID.TabIndex = 13;
            this.lblLocal_L_ID.Text = "Local LicenseID";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.ForeColor = System.Drawing.Color.Crimson;
            this.lblLicenseID.Location = new System.Drawing.Point(718, 30);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(44, 18);
            this.lblLicenseID.TabIndex = 12;
            this.lblLicenseID.Text = "????";
            // 
            // lblFees2
            // 
            this.lblFees2.AutoSize = true;
            this.lblFees2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFees2.Location = new System.Drawing.Point(314, 103);
            this.lblFees2.Name = "lblFees2";
            this.lblFees2.Size = new System.Drawing.Size(44, 18);
            this.lblFees2.TabIndex = 11;
            this.lblFees2.Text = "????";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIssueDate.Location = new System.Drawing.Point(314, 76);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(44, 18);
            this.lblIssueDate.TabIndex = 10;
            this.lblIssueDate.Text = "????";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.ForeColor = System.Drawing.Color.Black;
            this.lblAppDate.Location = new System.Drawing.Point(90, 52);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(125, 18);
            this.lblAppDate.TabIndex = 9;
            this.lblAppDate.Text = "ApplicationDate";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.ForeColor = System.Drawing.Color.Crimson;
            this.lblApplicationID.Location = new System.Drawing.Point(314, 30);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(44, 18);
            this.lblApplicationID.TabIndex = 8;
            this.lblApplicationID.Text = "????";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(557, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "L_L_LicenseID";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblApplicationDate.Location = new System.Drawing.Point(314, 52);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(44, 18);
            this.lblApplicationDate.TabIndex = 6;
            this.lblApplicationDate.Text = "????";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(90, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Issue Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(90, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fees";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCreatedBy.Location = new System.Drawing.Point(718, 103);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(44, 18);
            this.lblCreatedBy.TabIndex = 3;
            this.lblCreatedBy.Text = "????";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExpirationDate.Location = new System.Drawing.Point(718, 76);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(44, 18);
            this.lblExpirationDate.TabIndex = 2;
            this.lblExpirationDate.Text = "????";
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLocalLicenseID.Location = new System.Drawing.Point(718, 52);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(35, 18);
            this.lblLocalLicenseID.TabIndex = 1;
            this.lblLocalLicenseID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(90, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "L_LApplicationID";
            // 
            // cntrDriverLiceseInfo11
            // 
            this.cntrDriverLiceseInfo11.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cntrDriverLiceseInfo11.Location = new System.Drawing.Point(7, 123);
            this.cntrDriverLiceseInfo11.Name = "cntrDriverLiceseInfo11";
            this.cntrDriverLiceseInfo11.Size = new System.Drawing.Size(996, 415);
            this.cntrDriverLiceseInfo11.TabIndex = 10;
            // 
            // cntr_InternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cntrDriverLiceseInfo11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "cntr_InternationalLicenseApplication";
            this.Size = new System.Drawing.Size(1027, 709);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtLicenseID;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lblExp_Date;
        public System.Windows.Forms.Label lblLocal_L_ID;
        public System.Windows.Forms.Label lblLicenseID;
        public System.Windows.Forms.Label lblFees2;
        public System.Windows.Forms.Label lblIssueDate;
        public System.Windows.Forms.Label lblAppDate;
        public System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox2;
      
        public System.Windows.Forms.Label lblApplicationDate;
        public System.Windows.Forms.Label lblCreatedBy;
        public System.Windows.Forms.Label lblExpirationDate;
        public System.Windows.Forms.Label lblLocalLicenseID;
        public cntrDriverLiceseInfo1 cntrDriverLiceseInfo11;
    }
}
