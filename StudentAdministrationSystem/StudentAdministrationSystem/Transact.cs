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
    public partial class Transact : Form
    {
        public Transact()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            this.rbPay.Checked = false;
            this.rbReverse.Checked = false;
                        
            
        }

        private void Transact_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void rbPay_CheckedChanged(object sender, EventArgs e)
        {
            Payments pay = new Payments();
            pay.ShowDialog();
            this.Close();
        }

        private void rbReverse_CheckedChanged(object sender, EventArgs e)
        {
            Reversals rev = new Reversals();
            rev.ShowDialog();
            this.Close();
        }
    }
}
