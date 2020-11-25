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
    public partial class FormRegistration1 : Form
    {
        CollegeDBDataContext dc;
        public FormRegistration1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dc = new CollegeDBDataContext();
            dataGridView1.DataSource = dc.Students;
            this.dataGridView1.ReadOnly = true;
        }

        private void FormRegistration1_Load(object sender, EventArgs e)
        {
            this.LoadData();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormRegistration2 fr2 = new FormRegistration2();
            fr2.ShowDialog(); //calling the dialog to register student details
            this.LoadData(); //showing data on the gridview that has been saved from the form
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete selected record?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Eno = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    //delete foreign key table
                    foreach (Transaction trans in dc.Transactions)
                    {
                        if (Eno == trans.Student_Number)
                            dc.Transactions.DeleteOnSubmit(trans);
                    }

                    //delete primary key table
                    Student std = dc.Students.SingleOrDefault(E => E.Student_Number == Eno);
                    dc.Students.DeleteOnSubmit(std);
                    dc.SubmitChanges();
                    this.LoadData();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormRegistration2 rf2 = new FormRegistration2();
                rf2.tbStudentNumber.ReadOnly = true; //employee number cannot be edited
                rf2.btnClear.Enabled = false; //clear button is disabled
                rf2.btnSave.Text = "Update"; //the save button is renamed to 'update'
                rf2.tbStudentNumber.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                rf2.tbFirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                rf2.tbMiddlename.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                rf2.tbSurname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                rf2.dtpDOB.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                rf2.comboBoxGender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                rf2.dtpRegDate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                rf2.comboBoxCourse.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                rf2.tbCourseFee.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                rf2.ShowDialog();
                this.LoadData();
            }
            else
                MessageBox.Show("Please select a record for updation.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
