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
    public partial class QualificationListForm : Form
    {
        public QualificationListForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadReportData()
        {
            // TODO: This line of code loads data into the 'DataSet1.QualificationList' table. You can move, or remove it, as needed.
            this.QualificationListTableAdapter.Fill(this.DataSet1.QualificationList, int.Parse(tbYear.Text));

            this.reportViewer1.RefreshReport();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.LoadReportData();
        }
    }
}
