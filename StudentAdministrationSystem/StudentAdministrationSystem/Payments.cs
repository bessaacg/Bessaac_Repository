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
    public partial class Payments : Form
    {
        CollegeDBDataContext dc;
        string trName = " "; //initialising transaction name

        public Payments()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dc = new CollegeDBDataContext();
            tbAmountP.Enabled = false;
            tbCourseP.Enabled = false;
            tbCourseFeeP.Enabled = false;
            tbFirstnameP.Enabled = false;
            tbMiddlenameP.Enabled = false;
            tbSurnameP.Enabled = false;
            tbTotalPaidP.Enabled = false;
            dtpRegDateP.Enabled = false;
            tbRefNumberP.ReadOnly = true;
            btnConfirmP.Enabled = false;
            tbBalanceP.ReadOnly = true;
            tbDateP.Enabled = false;
            cbPayP.Enabled = false;
            this.ClearWidgets();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowStudentTransDetails()
        {
            foreach (Student std in dc.Students)
            {
                if (tbStdNumberP.Text.Trim() == std.Student_Number.ToString())
                {
                    tbFirstnameP.Text = std.Firstname;
                    tbMiddlenameP.Text = std.Middlename;
                    tbSurnameP.Text = std.Surname;
                    tbCourseP.Text = std.Course;
                    tbCourseFeeP.Text = std.Course_Fee.ToString();
                    tbDateP.Text = DateTime.Now.ToLongDateString();
                    dtpRegDateP.Text = std.Registration_Date.ToLongDateString();
                    break;
                }

            }
        }

        private void FocusDate()
        {
            tbDateP.Focus();
        }

        private void ClearWidgets()
        {
            foreach (Control ctrl in Controls)
            {
                TextBox tb = ctrl as TextBox;
                if (ctrl == tb)
                    tb.Clear();
            }

            cbPayP.CheckState = CheckState.Unchecked;
            cbPayP.Enabled = false; //the can not click the combobox after the clearing
            tbStdNumberP.Focus();
            btnConfirmP.Enabled = false;
        }


        private void tbStdNumberP_TextChanged_1(object sender, EventArgs e)
        {
            dc = new CollegeDBDataContext();

            tbAmountP.Enabled = false; //the student not found yet and the textEditor for the amount is not enabled
            tbAmountP.Text = "0.00";

            foreach (Student std in dc.Students)
            {
                if (tbStdNumberP.Text.Trim() == std.Student_Number.ToString())
                {
                    tbAmountP.Enabled = true; //the amount textEditor is enabled for the user to input figures
                    tbAmountP.Focus();
                    this.ShowStudentTransDetails();
                }
            }

        }

        private void btnConfirmP_Click_1(object sender, EventArgs e)
        {
            try
            {
                dc = new CollegeDBDataContext();

                int? RefNumber = null;
                dc.Payment_Insert(RefNumber, int.Parse(tbStdNumberP.Text), DateTime.Parse(tbDateP.Text), trName, decimal.Parse(tbTotalPaidP.Text), decimal.Parse(tbBalanceP.Text), decimal.Parse(tbAmountP.Text));

                //writing/commiting to the database
                dc.SubmitChanges();
                btnConfirmP.Enabled = false;
                MessageBox.Show("Changes were updated");
                this.ClearWidgets();
            }
            catch (FormatException fexp)
            {
                MessageBox.Show(String.Format("{0}\n{1}", fexp.Message, "Fill up all relevant areas"));
            }
        }

        private void cbPayP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPayP.CheckState.ToString() == "Checked")
                btnConfirmP.Enabled = true;
            else
                btnConfirmP.Enabled = false;

            try
            {
                dc = new CollegeDBDataContext();

                //translating students table to get courseFee and studentNumber
                var CouseFeeData = dc.Students.Select(t => new
                {
                    Student_Number = t.Student_Number,
                    Course_Fee = t.Course_Fee
                }).ToList();

                decimal tp = 0;
                decimal cf = 0;
                decimal bal = 0;
                int refNum = 0;
                btnConfirmP.Text = "Pay";
                
                foreach (var cfItem in CouseFeeData)
                {
                    if (cfItem.Student_Number.ToString() == tbStdNumberP.Text)
                    {
                        cf = cfItem.Course_Fee;
                        break;
                    }
                }

                foreach (Transaction trans in dc.Transactions)
                {
                    if (tbStdNumberP.Text == trans.Student_Number.ToString())
                    {
                        tp = trans.Total_Paid; //adding up amounts paid from Transactions table to get total paid by a student
                        refNum = trans.Reference_Number; //get the reference number
                    }
                }

                tp = tp + Decimal.Parse(tbAmountP.Text); //adding the value input by user to his/her total paid from the Transactions table
                bal = cf - tp; //calculating balance

                tbTotalPaidP.Text = tp.ToString(); //outputing total paid to the textbox
                tbBalanceP.Text = bal.ToString(); //outputing the balance to the textbox
                trName = cbPayP.Text; //assigning the the clicked radio button name to trName(transaction name)
                tbRefNumberP.Text = (refNum + 1).ToString(); //assigning and incrementing reference number
            }
            catch (FormatException fexp)
            {
                MessageBox.Show(String.Format("{0}\n{1}", fexp.Message, "Put valid input on Amount"));
            }
        }

        private void btnClearP_Click(object sender, EventArgs e)
        {
            this.ClearWidgets();
        }

        private void tbAmountP_TextChanged(object sender, EventArgs e)
        {
            if (tbAmountP.Text.Trim() == "0.00")
                cbPayP.Enabled = false;
            else
                cbPayP.Enabled = true;
        }
    }
}
