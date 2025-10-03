namespace Projet_Driving_Licence
{
    partial class frmScheduleTest
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
            this.lblTestID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cntrScheduleTest2 = new Projet_Driving_Licence.cntrScheduleTest();
            this.cntrScheduleTest1 = new Projet_Driving_Licence.cntrScheduleTest();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(53, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test ID";
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.BackColor = System.Drawing.Color.White;
            this.lblTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblTestID.Location = new System.Drawing.Point(227, 407);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(52, 18);
            this.lblTestID.TabIndex = 2;
            this.lblTestID.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_Driving_Licence.Properties.Resources.Vision_5122;
            this.pictureBox1.Location = new System.Drawing.Point(266, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Test ID";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(158, 502);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(492, 106);
            this.txtNotes.TabIndex = 6;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPass.ForeColor = System.Drawing.Color.LawnGreen;
            this.rbPass.Location = new System.Drawing.Point(213, 457);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(75, 26);
            this.rbPass.TabIndex = 7;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = false;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rbFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFail.ForeColor = System.Drawing.Color.LawnGreen;
            this.rbFail.Location = new System.Drawing.Point(315, 457);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(64, 26);
            this.rbFail.TabIndex = 8;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbFail.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Brown;
            this.btnSave.Location = new System.Drawing.Point(315, 632);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Brown;
            this.btnClose.Location = new System.Drawing.Point(464, 632);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cntrScheduleTest2
            // 
            this.cntrScheduleTest2.Location = new System.Drawing.Point(26, 91);
            this.cntrScheduleTest2.Name = "cntrScheduleTest2";
            this.cntrScheduleTest2.Size = new System.Drawing.Size(650, 286);
            this.cntrScheduleTest2.TabIndex = 11;
            // 
            // cntrScheduleTest1
            // 
            this.cntrScheduleTest1.Location = new System.Drawing.Point(24, 22);
            this.cntrScheduleTest1.Name = "cntrScheduleTest1";
            this.cntrScheduleTest1.Size = new System.Drawing.Size(652, 390);
            this.cntrScheduleTest1.TabIndex = 0;
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(688, 706);
            this.Controls.Add(this.cntrScheduleTest2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.label1);
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmScheduleTest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton rbPass;
        public System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.Button btnClose;
        public cntrScheduleTest cntrScheduleTest1;
        public System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.Button btnSave;
        public cntrScheduleTest cntrScheduleTest2;
        public System.Windows.Forms.Label lblTestID;
    }
}