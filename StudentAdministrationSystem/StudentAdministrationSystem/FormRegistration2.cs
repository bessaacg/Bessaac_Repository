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
    public partial class FormRegistration2 : Form
    {
        CollegeDBDataContext dc;

        public FormRegistration2()
        {
            InitializeComponent();
        }

        private void LoadComboBoxGender()
        {
            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
            comboBoxGender.Items.Add("Unknown");
        }

        private void LoadComboBoxCourse()
        {
            comboBoxCourse.Items.Add("IT Technical Support (NQF4) - PC Engineering");
            comboBoxCourse.Items.Add("IT Technical Support (NQF4) - Datacom & Networks");
            comboBoxCourse.Items.Add("IT Systems Development (NQF5)");
            comboBoxCourse.Items.Add("IT Skills Combo (A+, N+, MCSE)");
            comboBoxCourse.Items.Add("A+");
            comboBoxCourse.Items.Add("N+");
            comboBoxCourse.Items.Add("MSCE");
            comboBoxCourse.Items.Add("IT Skills Combo (A+, N+, MCSE)");
            comboBoxCourse.Items.Add("End User Computing");
            comboBoxCourse.Items.Add("BA (NQF4) - Human Resources Management");
            comboBoxCourse.Items.Add("BA (NQF4) - Project Management");
            comboBoxCourse.Items.Add("BA (NQF4) - Office Management");
            comboBoxCourse.Items.Add("BA (NQF4) - Secretarial Support");
            comboBoxCourse.Items.Add("Other Short Course");
        }

        private void ClearInput() //remove any input on the input form
        {
            foreach (Control ctrl in Controls)
            {
                TextBox tb = ctrl as TextBox;
                ComboBox cb = ctrl as ComboBox;
                DateTimePicker dtp = ctrl as DateTimePicker;
                if (ctrl == tb)
                    tb.Clear();
                if (ctrl == cb)
                    cb.SelectedIndex = -1;
                if (ctrl == dtp)
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                }
            }
        }

        private void FormRegistration2_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxGender();
            this.LoadComboBoxCourse();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            dc = new CollegeDBDataContext();
            try
            {
                if (tbStudentNumber.ReadOnly == false)
                {
                    dc = new CollegeDBDataContext();
                    Student std = new Student();
                    std.Student_Number = int.Parse(tbStudentNumber.Text);
                    std.Firstname = tbFirstname.Text;
                    std.Middlename = tbMiddlename.Text;
                    std.Surname = tbSurname.Text;
                    std.Date_Of_Birth = DateTime.Parse(dtpDOB.Text);
                    std.Gender = comboBoxGender.Text;
                    std.Registration_Date = DateTime.Parse(dtpRegDate.Text);
                    std.Course = comboBoxCourse.Text;
                    std.Course_Fee = decimal.Parse(tbCourseFee.Text);

                    //writing/commiting to the database
                    dc.Students.InsertOnSubmit(std);
                    dc.SubmitChanges();
                }
                else
                {
                    Student std = dc.Students.SingleOrDefault(E => E.Student_Number == int.Parse(tbStudentNumber.Text));
                    std.Student_Number = int.Parse(tbStudentNumber.Text);
                    std.Firstname = tbFirstname.Text;
                    std.Middlename = tbMiddlename.Text;
                    std.Surname = tbSurname.Text;
                    std.Date_Of_Birth = DateTime.Parse(dtpDOB.Text);
                    std.Gender = comboBoxGender.Text;
                    std.Registration_Date = DateTime.Parse(dtpRegDate.Text);
                    std.Course = comboBoxCourse.Text;
                    std.Course_Fee = decimal.Parse(tbCourseFee.Text);


                    //updating balances in the transaction table if course fee is changed
                    foreach (Transaction trans in dc.Transactions)
                    {
                        if (tbStudentNumber.Text.Trim() == trans.Student_Number.ToString())
                            trans.Balance = std.Course_Fee - trans.Total_Paid;
                    }

                    dc.SubmitChanges();
                    MessageBox.Show("Record Updated in the table.");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        //close form for recording/updating details
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clearing the form widgets
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearInput();
            this.btnSave.Enabled = true;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.Format = DateTimePickerFormat.Short;
        }

        private void dtpRegDate_ValueChanged(object sender, EventArgs e)
        {
            dtpRegDate.Format = DateTimePickerFormat.Short;
        }

    }
}
