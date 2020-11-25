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
    public partial class TrackingSheetForm : Form
    {
        public TrackingSheetForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.StudentTrackingSheetReport' table. You can move, or remove it, as needed.
            this.StudentTrackingSheetReportTableAdapter.Fill(this.DataSet1.StudentTrackingSheetReport, tbStdNumber.Text);
            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //close the form
        }
    }
}
