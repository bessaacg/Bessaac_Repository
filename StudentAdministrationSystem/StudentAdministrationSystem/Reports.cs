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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        
        private void Reports_Load(object sender, EventArgs e)
        {
            //checkedListBox1.Items.Add(checkedListBox)

        }

        private void cbReceiptSummary_MouseClick(object sender, MouseEventArgs e)
        {
            ReceiptSummaryForm rsf = new ReceiptSummaryForm();
            rsf.ShowDialog();
            cbReceiptSummary.Checked = false;
        }

        private void cbFeeCollection_MouseClick(object sender, MouseEventArgs e)
        {
            FeeCollectionReport fcr = new FeeCollectionReport();
            fcr.ShowDialog();
            cbFeeCollection.Checked = false;
        }

        private void cbStudentTrackingSheet_MouseClick(object sender, MouseEventArgs e)
        {
            TrackingSheetForm tsf = new TrackingSheetForm();
            tsf.ShowDialog();
            cbStudentTrackingSheet.Checked = false;
        }

        private void cbQualificationList_MouseClick(object sender, MouseEventArgs e)
        {
            QualificationListForm qlf = new QualificationListForm();
            qlf.ShowDialog();
            cbQualificationList.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void gbReports_Enter(object sender, EventArgs e)
        {

        }

        private void cbExit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbQualificationList_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbReceiptSummary_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbStudentTrackingSheet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFeeCollection_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
