using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace StudentAdministrationSystem
{
    public partial class FormLogin : Form
    {
        CollegeDBDataContext dc;
        Menu m;
        PinBox pb;
        int counter = 0; //if counter is 0, the btnCreate will clear the textBoxes so that the user creates his/her account
        internal string username;
        internal string password;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void HideConfirmation()
        {
            label4.Hide();
            tbConfirmPassword.Hide();

        }

        private void ShowConfirmation()
        {
            label4.Show();
            tbConfirmPassword.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.HideConfirmation();
            dc = new CollegeDBDataContext();
            tbUsername.Focus();
        }

        private void ClearData() //clear login textboxes
        {
            foreach (Control ctrl in Controls)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Clear();
            }
            tbUsername.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            this.ShowConfirmation();

            if (counter == 0)
            {
                this.ClearData();
                this.ShowConfirmation();
            }

            else if ((string.IsNullOrEmpty(tbUsername.Text) || (string.IsNullOrEmpty(tbPassword.Text) ||
                    (string.IsNullOrEmpty(tbConfirmPassword.Text)))))
                MessageBox.Show("Missing Username and/or Password");
            else if (tbPassword.Text != tbConfirmPassword.Text)
                MessageBox.Show("Passwords supplied do not match");
            else
            {
                try
                {
                    foreach (User us in dc.Users)
                    {
                        if (us.Username.ToUpper() == tbUsername.Text.ToUpper())
                        {
                            throw new MyException();
                        }
                    }

                    username = tbUsername.Text;
                    password = tbPassword.Text;
                    pb = new PinBox();
                    pb.ShowDialog();

                    if (pb.counter == 1)
                    {
                        m = new Menu();
                        User usr = new User();

                        usr.Username = tbUsername.Text;
                        usr.Password = tbPassword.Text;

                        dc.Users.InsertOnSubmit(usr);
                        dc.SubmitChanges(); //user login details are commited to the database
                        this.Hide(); //hide the login screen after for security reasons

                        m.ShowDialog();
                    }
                    else
                        MessageBox.Show("Access Denied");
                }
                catch (MyException exp)
                {
                    exp.MyDuplicateUserException();
                }
            }

            this.ClearData();
            counter += 1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.HideConfirmation();

            try
            {
                int count = 0; //this counter determines whether the end of the database is reached
                               //if so it means there is no match between the the login inputs and the user details in the database 
                foreach (User usr in dc.Users)
                {
                    if ((usr.Username == tbUsername.Text) && (usr.Password == tbPassword.Text))
                    {
                        this.Hide();
                        m = new Menu();
                        m.ShowDialog();
                        this.Close();
                    }
                    else if (count == dc.Users.Count() - 1)
                        MessageBox.Show("There is no match for Username and/or Password\nincorrect Username and/or Password");

                    tbUsername.Focus();
                    count += 1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
