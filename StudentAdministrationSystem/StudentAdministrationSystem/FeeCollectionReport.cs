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
    public partial class FeeCollectionReport : Form
    {
        public FeeCollectionReport()
        {
            InitializeComponent();
        }

        private void FeeCollectionReport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.FeeCollection' table. You can move, or remove it, as needed.
            this.FeeCollectionTableAdapter.Fill(this.DataSet1.FeeCollection, tbYear.Text);

            this.reportViewer1.RefreshReport();

        }

        private void tbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
