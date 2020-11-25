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
    public partial class Menu : Form
    {
        FormRegistration1 fr1;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fr1 = new FormRegistration1();
            fr1.btnDelete.Enabled = false; //only insert button is allowed to register
            fr1.btnUpdate.Enabled = false; //only insert button is allowed to register
            fr1.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fr1 = new FormRegistration1();
            fr1.btnInsert.Enabled = false; //only update button is allowed to register
            fr1.ShowDialog();
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            Transact tr = new Transact();
            tr.WindowState = FormWindowState.Normal;
            tr.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports rpts = new Reports();
            rpts.ShowDialog();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryForm qf = new QueryForm();
            qf.ShowDialog();
        }
    }
}


