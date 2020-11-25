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
    public partial class PinBox : Form
    {
        CollegeDBDataContext dc;
        string adm = " ";
        internal int counter = 0;
        public PinBox()
        {
            InitializeComponent();
        }

        private void PinBox_Load(object sender, EventArgs e)
        {
            dc = new CollegeDBDataContext();

            new Point(-600, 600);

        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (Admin admin in dc.Admins)
            {
                adm = admin.Pin;
            }

            if (tbPin.Text == adm)
            {
                counter = 1;
                this.Close(); //closes the administrator form
            }
        }
    }
}
