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
    public partial class Reversals : Form
    {
        CollegeDBDataContext dc;
        decimal tp = 0;
        decimal cf = 0;
        int refNum = 0;

        public Reversals()
        {
            InitializeComponent();
        }

        private void btnCloseR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            dc = new CollegeDBDataContext();
            tbAmountR.Enabled = false;
            tbCourseFeeR.Enabled = false;
            tbTotalPaidR.Enabled = false;
            btnConfirmR.Enabled = false;
            tbBalanceR.Enabled = false;
            tbDateR.Enabled = false;
            cbReverseR.AutoCheck = true;
            cbReverseR.Enabled = false;
        }

        private void CalculateTotPaid()//calculate total paid by student
        {
            tp = 0;
            dc = new CollegeDBDataContext();
            foreach (Transaction trans in dc.Transactions)
            {
                if ((trans.Transaction_Name == "Payment") && (trans.Reversal == null) &&
                    tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString())
                    tp = tp + trans.Transaction_Amount; //adding up amounts paid from Transactions table to get total paid by a student
            }

            tp = decimal.Round(tp, 2, MidpointRounding.AwayFromZero); //rounding off to 2 decimal places
            refNum = refNum + 1;
            tbTotalPaidR.Text = tp.ToString();
        }

        private void ShowStudentDetails()
        {
            dc = new CollegeDBDataContext();

            foreach (Student std in dc.Students)
            {
                if (tbStudent_NumberR.Text.Trim() == std.Student_Number.ToString())
                {
                    cf = std.Course_Fee;
                    cf = decimal.Round(cf, 2, MidpointRounding.AwayFromZero); //rounding off to 2 decimal places
                    tbCourseFeeR.Text = cf.ToString();
                    this.CalculateTotPaid();
                    tbTotalPaidR.Text = tp.ToString();
                    break;
                }
            }
        }

        private void Show_Balance_Before_Reversal()
        {
            dc = new CollegeDBDataContext();
            int counter = 0;
            decimal balance = 0;
            bool flag = false;
            foreach (Transaction trans in dc.Transactions)
            {
                if (tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString())
                {
                    balance = trans.Balance;
                    balance = decimal.Round(balance, 2, MidpointRounding.AwayFromZero); //rounding off to 2 decimal places
                }

                if ((tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString()) &&
                    (tbRefNumberR.Text.Trim() == trans.Reference_Number.ToString()) &&
                    (trans.Reversal == true))
                    flag = true;
                counter++;
            }

            if (flag == true)
                tbBalanceR.Clear();
            else
                tbBalanceR.Text = balance.ToString();
        }

        private void Total_Paid_After_Calc()
        {
            dc = new CollegeDBDataContext();
            tp = 0; //reinitialise total paid

            foreach (Transaction trans in dc.Transactions)
            {
                if ((trans.Transaction_Name == "Payment") &&
                    (trans.Reversal == null) &&
                    (tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString()))
                    tp = tp + trans.Transaction_Amount;
            }

            tp = tp - Decimal.Parse(tbAmountR.Text);
            tp = decimal.Round(tp, 2, MidpointRounding.AwayFromZero); //rounding off to 2 decimal places
            tbTotalPaidR.Text = tp.ToString();
        }

        private void Show_Balance_After_Calculation()
        {
            try
            {
                decimal bal = Decimal.Parse(tbCourseFeeR.Text) - Decimal.Parse(tbTotalPaidR.Text);
                bal = decimal.Round(bal, 2, MidpointRounding.AwayFromZero); //rounding off to 2 decimal places
                tbBalanceR.Text = bal.ToString();
            }
            catch(FormatException fexp)
            {
                MessageBox.Show(String.Format("{0}\n{1}", fexp.Message, "Transaction was not found"));
            }
        }

        private void TransactionNotFound() //the method determines where the reference for the transaction exists
        {
            cbReverseR.Enabled = false; /*the user will not be allowed to click the checkbox
            if the reference number is not found*/

            bool reversePass = false;
            string stdNum = " ";
            decimal revAmt = 0;
            string payDate = " ";
            string refNum = " ";
            bool namePass = false;

            foreach (Transaction trans in dc.Transactions)
            {
                if ((tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString()) &&
                    (tbRefNumberR.Text.Trim() == trans.Reference_Number.ToString()) &&
                    (trans.Reversal == true))
                {
                    stdNum = trans.Student_Number.ToString();
                    revAmt = decimal.Round(trans.Transaction_Amount, 2, MidpointRounding.AwayFromZero);
                    payDate = trans.Transaction_Date.ToLongDateString();
                    refNum = trans.Reference_Number.ToString();
                    reversePass = true;
                    cbReverseR.CheckState = CheckState.Unchecked;
                    this.ClearWidgets();
                    break;
                }
            }

            if (reversePass)
            {
                MessageBox.Show(String.Format("Payment cannot be reversed\nReversal of {0:C} for student {1} took place on {2}",
                        revAmt, stdNum, payDate));
            }
            else if(!reversePass || !namePass)
                MessageBox.Show("Transaction for the given student of reference number did not take place");
            //this.ClearWidgets();

        }

        private void ShowTransactionDetails()
        {
            dc = new CollegeDBDataContext();
            lbBalance.Text = "Balance before reversal";

            foreach (Transaction trans in dc.Transactions)
            {
                if ((tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString()) &&
                    (tbRefNumberR.Text.Trim() == trans.Reference_Number.ToString()) &&
                    trans.Reversal == null)
                {
                    tbDateR.Text = trans.Transaction_Date.ToString();
                    tbRefNumberR.Text = trans.Reference_Number.ToString();
                    tbAmountR.Text = decimal.Round(trans.Transaction_Amount, 2, MidpointRounding.AwayFromZero).ToString();
                    tbCourseFeeR.Text = cf.ToString();

                    if (cbReverseR.CheckState == CheckState.Unchecked)
                        this.CalculateTotPaid(); //calculate total if before reversal
                    else
                        this.Total_Paid_After_Calc(); //calculate total if reserval is allowed
                    this.Show_Balance_Before_Reversal();
                    tbAmountR.Text = decimal.Round(trans.Transaction_Amount, 2, MidpointRounding.AwayFromZero).ToString();
                    cbReverseR.Text = String.Format("Click to reverse {0:C} for student {1}", trans.Transaction_Amount,
                        tbStudent_NumberR.Text);
                    cbReverseR.Enabled = true; /*the user will be allowed to reverse the transaction as ref number is found*/
                    break;
                }
                else
                {
                    /*nothing will be shown if the reversal took place before*/
                    tbCourseFeeR.Clear();
                    tbTotalPaidR.Clear();
                    tbBalanceR.Text = " ";
                }
            }
            this.Show_Balance_Before_Reversal();
        }


        private void Reversals_Load(object sender, EventArgs e)
        {
            cbReverseR.Enabled = true;
            this.LoadData();
        }

        private void tbStudent_NumberR_TextChanged(object sender, EventArgs e)
        {
            cbReverseR.Checked = false;
            this.ShowStudentDetails();
        }

        private void tbRefNumberR_TextChanged(object sender, EventArgs e)
        {
            foreach (Transaction trans in dc.Transactions)
            {
                if ((tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString()) &&
                    (tbRefNumberR.Text.Trim() == trans.Reference_Number.ToString()) &&
                    trans.Transaction_Name != "Reversal")
                {
                    this.ShowTransactionDetails();
                    this.Show_Balance_Before_Reversal(); //this method outputs balance before reversal to the textbox
                    cbReverseR.Enabled = true;
                    break;
                }
                else if ((trans.Transaction_Name == "Reversal") &&
                    (trans.Student_Number.ToString() == tbStudent_NumberR.Text.Trim()) &&
                    (trans.Reference_Number.ToString() == tbRefNumberR.Text.Trim()))
                {
                    //tbStudent_NumberR.Clear();
                    //tbRefNumberR.Clear();
                    tbAmountR.Clear();
                    tbDateR.Clear();
                    tbCourseFeeR.Clear();
                    tbTotalPaidR.Clear();
                    tbBalanceR.Clear();

                    MessageBox.Show("Reversal Cannot be duplicated");
                    cbReverseR.CheckState = CheckState.Unchecked;
                    cbReverseR.Enabled = false;

                    break;
                    //cbReverseR.Enabled = false;
                }
                else
                {
                    tbAmountR.Clear();
                    tbDateR.Clear();
                    tbCourseFeeR.Clear();
                    tbTotalPaidR.Clear();
                    tbBalanceR.Clear();
                    cbReverseR.Enabled = false;
                    cbReverseR.Text = "Payment Reversal";
                }
                    
            }
        }

        private int TakeLastRefNum()
        {
            int refNum = 0;
            int counter = 0;
            foreach (Transaction trans in dc.Transactions)
            {
                if (counter == dc.Transactions.Count() - 1)
                {
                    refNum = trans.Reference_Number;
                    break;
                }
                counter++;
            }

            return refNum;
        }

        private void btnConfirmR_Click(object sender, EventArgs e) //writing changes to the Transactions table
        {
            dc = new CollegeDBDataContext();

            int? RefNumber = null;
            string trName = "Reversal";

            dc.ReversePayment(RefNumber, int.Parse(tbStudent_NumberR.Text), DateTime.Today, trName, decimal.Parse(tbTotalPaidR.Text), decimal.Parse(tbBalanceR.Text), decimal.Parse(tbAmountR.Text));

            //writing/commiting to the database
            dc.SubmitChanges();
            btnConfirmR.Enabled = false;
            MessageBox.Show("Changes were updated");
            this.Flag_Transaction_As_Reversed(); //the transaction will be flaged as reversed
            //this.ClearWidgets();
        }

        private void Flag_Transaction_As_Reversed()
        {
            dc = new CollegeDBDataContext();
            Transaction trans = dc.Transactions.SingleOrDefault(E => E.Reference_Number == int.Parse(tbRefNumberR.Text));
            trans.Reversal = true;
            dc.SubmitChanges();
        }

        private void cbReverseR_CheckedChanged(object sender, EventArgs e)
        {
            dc = new CollegeDBDataContext();
            bool pass = false;
            cbReverseR.Enabled = false;

            foreach (Transaction trans in dc.Transactions)
            {
                if (((tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString()) &&
                    (tbRefNumberR.Text.Trim() == trans.Reference_Number.ToString() &&
                    (trans.Reversal == true))) ||
                    ((tbStudent_NumberR.Text.Trim() == trans.Student_Number.ToString()) &&
                    (tbRefNumberR.Text.Trim() == trans.Reference_Number.ToString() &&
                    (trans.Reversal == true))) && (trans.Transaction_Name == "Reversal"))
                {
                    pass = true;
                    break; //a match has been found, therefore break
                }
            }

            if ((tbAmountR.Text.Trim() == " ") || (pass == true)) //reference number not found and the transaction was reversed
            {
                this.TransactionNotFound();
            }
            else if(pass == false)
            {
                dc = new CollegeDBDataContext();
                //translating students table to get courseFee and studentNumber
                var CouseFeeData = dc.Students.Select(t => new
                {
                    Student_Number = t.Student_Number,
                    Course_Fee = t.Course_Fee
                }).ToList();

                foreach (var cfItem in CouseFeeData)
                {
                    if (cfItem.Student_Number.ToString() == tbStudent_NumberR.Text)
                    {
                        cf = cfItem.Course_Fee;
                        break;
                    }
                }

                this.ShowTransactionDetails();
                lbBalance.Text = "Post Reversal Balance";
                if(cbReverseR.Checked == true)
                    this.Show_Balance_After_Calculation(); //new balance after calculation
                btnConfirmR.Enabled = true;
            }
            cbReverseR.Enabled = false;
        }

        private void ClearWidgets()
        {
            foreach (Control ctrl in Controls)
            {
                TextBox tb = ctrl as TextBox;
                DateTimePicker dtp = ctrl as DateTimePicker;
                               
                if (ctrl == tb)
                    tb.Clear();

                //cbReverseR.CheckState = CheckState.Unchecked;
            }

            cbReverseR.Text = "Payment Reversal";
            tbStudent_NumberR.Focus();
            cbReverseR.Enabled = false;
            btnConfirmR.Enabled = false;
        }

        private void btnClearR_Click(object sender, EventArgs e)
        {
            this.ClearWidgets();
        }
    }
}
