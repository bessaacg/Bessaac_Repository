namespace StudentAdministrationSystem
{
    partial class FeeCollectionReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FeeCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new StudentAdministrationSystem.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.FeeCollectionTableAdapter = new StudentAdministrationSystem.DataSet1TableAdapters.FeeCollectionTableAdapter();
            this.tbClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeeCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // FeeCollectionBindingSource
            // 
            this.FeeCollectionBindingSource.DataMember = "FeeCollection";
            this.FeeCollectionBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year";
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.Location = new System.Drawing.Point(534, 6);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(112, 22);
            this.tbYear.TabIndex = 3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FeeCollectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentAdministrationSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(122, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1146, 604);
            this.reportViewer1.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "tbUpdate";
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(749, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FeeCollectionTableAdapter
            // 
            this.FeeCollectionTableAdapter.ClearBeforeFill = true;
            // 
            // tbClose
            // 
            this.tbClose.AccessibleName = "tbClose";
            this.tbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClose.Location = new System.Drawing.Point(913, 6);
            this.tbClose.Name = "tbClose";
            this.tbClose.Size = new System.Drawing.Size(75, 23);
            this.tbClose.TabIndex = 11;
            this.tbClose.Text = "Close";
            this.tbClose.UseVisualStyleBackColor = true;
            this.tbClose.Click += new System.EventHandler(this.tbClose_Click);
            // 
            // FeeCollectionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 597);
            this.Controls.Add(this.tbClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label1);
            this.Name = "FeeCollectionReport";
            this.Text = "FeeCollectionReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FeeCollectionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeeCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYear;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FeeCollectionBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.FeeCollectionTableAdapter FeeCollectionTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button tbClose;
    }
}