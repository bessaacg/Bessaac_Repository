namespace StudentAdministrationSystem
{
    partial class Reports
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
            this.gbReports = new System.Windows.Forms.GroupBox();
            this.cbExit = new System.Windows.Forms.CheckBox();
            this.cbQualificationList = new System.Windows.Forms.CheckBox();
            this.cbReceiptSummary = new System.Windows.Forms.CheckBox();
            this.cbStudentTrackingSheet = new System.Windows.Forms.CheckBox();
            this.cbFeeCollection = new System.Windows.Forms.CheckBox();
            this.gbReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReports
            // 
            this.gbReports.Controls.Add(this.cbExit);
            this.gbReports.Controls.Add(this.cbQualificationList);
            this.gbReports.Controls.Add(this.cbReceiptSummary);
            this.gbReports.Controls.Add(this.cbStudentTrackingSheet);
            this.gbReports.Controls.Add(this.cbFeeCollection);
            this.gbReports.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReports.Location = new System.Drawing.Point(278, 29);
            this.gbReports.Name = "gbReports";
            this.gbReports.Size = new System.Drawing.Size(829, 509);
            this.gbReports.TabIndex = 0;
            this.gbReports.TabStop = false;
            this.gbReports.Text = "Reports";
            this.gbReports.Enter += new System.EventHandler(this.gbReports_Enter);
            // 
            // cbExit
            // 
            this.cbExit.AutoSize = true;
            this.cbExit.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExit.Location = new System.Drawing.Point(332, 331);
            this.cbExit.Name = "cbExit";
            this.cbExit.Size = new System.Drawing.Size(83, 36);
            this.cbExit.TabIndex = 4;
            this.cbExit.Text = "Exit";
            this.cbExit.UseVisualStyleBackColor = true;
            this.cbExit.CheckedChanged += new System.EventHandler(this.cbExit_CheckedChanged);
            this.cbExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbExit_MouseClick);
            // 
            // cbQualificationList
            // 
            this.cbQualificationList.AutoSize = true;
            this.cbQualificationList.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQualificationList.Location = new System.Drawing.Point(332, 268);
            this.cbQualificationList.Name = "cbQualificationList";
            this.cbQualificationList.Size = new System.Drawing.Size(255, 36);
            this.cbQualificationList.TabIndex = 3;
            this.cbQualificationList.Text = "Qualification List";
            this.cbQualificationList.UseVisualStyleBackColor = true;
            this.cbQualificationList.CheckedChanged += new System.EventHandler(this.cbQualificationList_CheckedChanged);
            this.cbQualificationList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbQualificationList_MouseClick);
            // 
            // cbReceiptSummary
            // 
            this.cbReceiptSummary.AutoSize = true;
            this.cbReceiptSummary.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReceiptSummary.Location = new System.Drawing.Point(332, 207);
            this.cbReceiptSummary.Name = "cbReceiptSummary";
            this.cbReceiptSummary.Size = new System.Drawing.Size(258, 36);
            this.cbReceiptSummary.TabIndex = 2;
            this.cbReceiptSummary.Text = "Receipt Summary";
            this.cbReceiptSummary.UseVisualStyleBackColor = true;
            this.cbReceiptSummary.CheckedChanged += new System.EventHandler(this.cbReceiptSummary_CheckedChanged);
            this.cbReceiptSummary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbReceiptSummary_MouseClick);
            // 
            // cbStudentTrackingSheet
            // 
            this.cbStudentTrackingSheet.AutoSize = true;
            this.cbStudentTrackingSheet.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentTrackingSheet.Location = new System.Drawing.Point(332, 144);
            this.cbStudentTrackingSheet.Name = "cbStudentTrackingSheet";
            this.cbStudentTrackingSheet.Size = new System.Drawing.Size(332, 36);
            this.cbStudentTrackingSheet.TabIndex = 1;
            this.cbStudentTrackingSheet.Text = "Student Tracking Sheet";
            this.cbStudentTrackingSheet.UseVisualStyleBackColor = true;
            this.cbStudentTrackingSheet.CheckedChanged += new System.EventHandler(this.cbStudentTrackingSheet_CheckedChanged);
            this.cbStudentTrackingSheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbStudentTrackingSheet_MouseClick);
            // 
            // cbFeeCollection
            // 
            this.cbFeeCollection.AutoSize = true;
            this.cbFeeCollection.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFeeCollection.Location = new System.Drawing.Point(332, 82);
            this.cbFeeCollection.Name = "cbFeeCollection";
            this.cbFeeCollection.Size = new System.Drawing.Size(213, 36);
            this.cbFeeCollection.TabIndex = 0;
            this.cbFeeCollection.Text = "Fee Collection";
            this.cbFeeCollection.UseVisualStyleBackColor = true;
            this.cbFeeCollection.CheckedChanged += new System.EventHandler(this.cbFeeCollection_CheckedChanged);
            this.cbFeeCollection.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbFeeCollection_MouseClick);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 550);
            this.Controls.Add(this.gbReports);
            this.Name = "Reports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            this.gbReports.ResumeLayout(false);
            this.gbReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReports;
        internal System.Windows.Forms.CheckBox cbStudentTrackingSheet;
        internal System.Windows.Forms.CheckBox cbFeeCollection;
        internal System.Windows.Forms.CheckBox cbReceiptSummary;
        internal System.Windows.Forms.CheckBox cbQualificationList;
        internal System.Windows.Forms.CheckBox cbExit;
    }
}