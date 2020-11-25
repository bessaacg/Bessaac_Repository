using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystem
{
    class MyException : ApplicationException
    {
        public void MyDuplicateUserException()
        {
            MessageBox.Show("The User Exists in the database");
        }

        public void NotAnInteger()
        {
            MessageBox.Show("Input entered is not an number");
        }

        public void CheckInputs()
        {
            MessageBox.Show("Make sure you have filled all inputs\nand are in correct format");
        }

        public void RefInvalid()
        {
            MessageBox.Show("Inavid input on ref number");
        }

        public void WrongCategory()
        {
            MessageBox.Show("Details you enter are in wrong category");
        }

        

    }
}
