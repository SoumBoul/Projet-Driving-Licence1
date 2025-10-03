namespace Projet_Driving_Licence
{
    partial class frmScheduleRetakeTests
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
            this.bntClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cntrRetakeTest2 = new Projet_Driving_Licence.cntrRetakeTest();
            this.cntrScheduleTest1 = new Projet_Driving_Licence.cntrScheduleTest();
            this.cntrRetakeTest1 = new Projet_Driving_Licence.cntrRetakeTest();
            this.SuspendLayout();
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(173, 470);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(113, 46);
            this.bntClose.TabIndex = 16;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSave.Location = new System.Drawing.Point(318, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 46);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cntrRetakeTest2
            // 
            this.cntrRetakeTest2.Enabled = false;
            this.cntrRetakeTest2.Location = new System.Drawing.Point(3, 305);
            this.cntrRetakeTest2.Name = "cntrRetakeTest2";
            this.cntrRetakeTest2.Size = new System.Drawing.Size(648, 138);
            this.cntrRetakeTest2.TabIndex = 19;
            // 
            // cntrScheduleTest1
            // 
            this.cntrScheduleTest1.Location = new System.Drawing.Point(3, 12);
            this.cntrScheduleTest1.Name = "cntrScheduleTest1";
            this.cntrScheduleTest1.Size = new System.Drawing.Size(629, 287);
            this.cntrScheduleTest1.TabIndex = 17;
            // 
            // cntrRetakeTest1
            // 
            this.cntrRetakeTest1.Location = new System.Drawing.Point(12, 295);
            this.cntrRetakeTest1.Name = "cntrRetakeTest1";
            this.cntrRetakeTest1.Size = new System.Drawing.Size(620, 197);
            this.cntrRetakeTest1.TabIndex = 19;
            // 
            // frmScheduleRetakeTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(644, 554);
            this.Controls.Add(this.cntrRetakeTest2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cntrScheduleTest1);
            this.Controls.Add(this.bntClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduleRetakeTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmScheduleRetakeTests";
            this.Load += new System.EventHandler(this.frmScheduleRetakeTests_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bntClose;
        public cntrScheduleTest cntrScheduleTest1;
        public System.Windows.Forms.Button btnSave;
        public cntrRetakeTest cntrRetakeTest1;
        public cntrRetakeTest cntrRetakeTest2;
    }
}