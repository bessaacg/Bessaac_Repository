using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystem
{
    public partial class ReceiptSummaryForm : Form
    {
        public ReceiptSummaryForm()
        {
            InitializeComponent();
        }

        private void PopulateReport()
        {
            // TODO: This line of code loads data into the 'DataSet1.ReceiptSummaryReport' table. You can move, or remove it, as needed.
            this.ReceiptSummaryReportTableAdapter.Fill(this.DataSet1.ReceiptSummaryReport, 
                DateTime.Parse(dtpFrom.Text), DateTime.Parse(dtpTo.Text));

            this.reportViewer1.RefreshReport();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.PopulateReport();
        }

        private void ReceiptSummaryForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
