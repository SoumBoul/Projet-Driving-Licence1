namespace Projet_Driving_Licence
{
    partial class frm_Local_Driving_License_App
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
            this.components = new System.ComponentModel.Container();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLocalDriving = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelledApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirsTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPlus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalDriving)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(310, 253);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(163, 22);
            this.txtFilterBy.TabIndex = 19;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblRecord.Location = new System.Drawing.Point(101, 664);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(53, 20);
            this.lblRecord.TabIndex = 18;
            this.lblRecord.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 664);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Record: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(647, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Local Driving License Applications";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "LocalNationalID",
            "License Name",
            "NationalNo",
            "Full Name",
            "Application Date",
            "Passed Test",
            "Status",
            ""});
            this.cbFilter.Location = new System.Drawing.Point(103, 253);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(201, 24);
            this.cbFilter.TabIndex = 12;
            this.cbFilter.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "FilterBy";
            // 
            // dgLocalDriving
            // 
            this.dgLocalDriving.AllowUserToAddRows = false;
            this.dgLocalDriving.AllowUserToDeleteRows = false;
            this.dgLocalDriving.AllowUserToOrderColumns = true;
            this.dgLocalDriving.BackgroundColor = System.Drawing.Color.White;
            this.dgLocalDriving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocalDriving.ContextMenuStrip = this.contextMenuStrip2;
            this.dgLocalDriving.Location = new System.Drawing.Point(18, 293);
            this.dgLocalDriving.Name = "dgLocalDriving";
            this.dgLocalDriving.ReadOnly = true;
            this.dgLocalDriving.RowHeadersWidth = 51;
            this.dgLocalDriving.RowTemplate.Height = 24;
            this.dgLocalDriving.Size = new System.Drawing.Size(1452, 332);
            this.dgLocalDriving.TabIndex = 10;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolStripMenuItem2,
            this.delToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cancelledApplicationToolStripMenuItem,
            this.toolStripMenuItem4,
            this.scheduToolStripMenuItem,
            this.toolStripMenuItem5,
            this.issueDrivingLicenseFirsTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem6,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(288, 276);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            this.contextMenuStrip2.Opened += new System.EventHandler(this.contextMenuStrip2_Opened);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.List_32;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(284, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.editToolStripMenuItem.Text = "Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(284, 6);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.Delete_32_2;
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.delToolStripMenuItem.Text = "Delete Application";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(284, 6);
            // 
            // cancelledApplicationToolStripMenuItem
            // 
            this.cancelledApplicationToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.Delete_32;
            this.cancelledApplicationToolStripMenuItem.Name = "cancelledApplicationToolStripMenuItem";
            this.cancelledApplicationToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.cancelledApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelledApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelledApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(284, 6);
            // 
            // scheduToolStripMenuItem
            // 
            this.scheduToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.schduleStreetTestToolStripMenuItem});
            this.scheduToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.Schedule_Test_32;
            this.scheduToolStripMenuItem.Name = "scheduToolStripMenuItem";
            this.scheduToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.scheduToolStripMenuItem.Text = "schedule Tests";
            this.scheduToolStripMenuItem.DropDownOpening += new System.EventHandler(this.scheduToolStripMenuItem_DropDownOpening);
            this.scheduToolStripMenuItem.Click += new System.EventHandler(this.scheduToolStripMenuItem_Click);
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.CheckOnClick = true;
            this.scheduleVisionTestToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.Vision_512;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.scheduleVisionTestToolStripMenuItem.Tag = "1";
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.CheckOnClick = true;
            this.scheduleWrittenTestToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.Edit;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.scheduleWrittenTestToolStripMenuItem.Tag = "2";
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // schduleStreetTestToolStripMenuItem
            // 
            this.schduleStreetTestToolStripMenuItem.CheckOnClick = true;
            this.schduleStreetTestToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.Drivers;
            this.schduleStreetTestToolStripMenuItem.Name = "schduleStreetTestToolStripMenuItem";
            this.schduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.schduleStreetTestToolStripMenuItem.Tag = "3";
            this.schduleStreetTestToolStripMenuItem.Text = "Schdule Street Test";
            this.schduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.schduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(284, 6);
            // 
            // issueDrivingLicenseFirsTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirsTimeToolStripMenuItem.Enabled = false;
            this.issueDrivingLicenseFirsTimeToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrivingLicenseFirsTimeToolStripMenuItem.Name = "issueDrivingLicenseFirsTimeToolStripMenuItem";
            this.issueDrivingLicenseFirsTimeToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.issueDrivingLicenseFirsTimeToolStripMenuItem.Text = "Issue Driving License (FirsTime)";
            this.issueDrivingLicenseFirsTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirsTimeToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.License_Type_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(284, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::Projet_Driving_Licence.Properties.Resources.PersonDetails_32;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Projet_Driving_Licence.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1393, 631);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 57);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projet_Driving_Licence.Properties.Resources.Application_Types_512;
            this.pictureBox2.Location = new System.Drawing.Point(676, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnPlus
            // 
            this.btnPlus.Image = global::Projet_Driving_Licence.Properties.Resources.New_Application_64;
            this.btnPlus.Location = new System.Drawing.Point(1379, 209);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(77, 78);
            this.btnPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlus.TabIndex = 13;
            this.btnPlus.TabStop = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // frm_Local_Driving_License_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1482, 698);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLocalDriving);
            this.Name = "frm_Local_Driving_License_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Local_Driving_License_Applications";
            this.Load += new System.EventHandler(this.frm_Local_Driving_License_Applications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalDriving)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnPlus;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgLocalDriving;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.ToolStripMenuItem scheduToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem schduleStreetTestToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cancelledApplicationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirsTimeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}