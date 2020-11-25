using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentAdministrationSystem
{
    public partial class QueryForm : Form
    {
        CollegeDBDataContext dc;
        bool flag = false;

        public QueryForm()
        {
            InitializeComponent();

            cbQuery.Items.Add("Student Number");
            cbQuery.Items.Add("Firstname");
            cbQuery.Items.Add("Middlename");
            cbQuery.Items.Add("Surname");
            cbQuery.Items.Add("Gender");
            cbQuery.Items.Add("Course");
            cbQuery.Items.Add("Year Registered");

            dc = new CollegeDBDataContext();
            this.Load += QueryForm1_Load;
            dataGridView1.ReadOnly = true;


        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dc.QueryAllStudents();

        }

        private void QueryForm1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 130; //Student Number column size
            dataGridView1.Columns[2].Width = 105; //Middlename column size
            dataGridView1.Columns[4].Width = 65; //Gender column size
            dataGridView1.Columns[5].Width = 395; //course column size
            flag = true;
            this.PaintDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbQuery.SelectedIndex = -1;
            tbDetails.Clear();
            dataGridView1.Rows.Clear();
        }

        private void tbDetails_TextChanged(object sender, EventArgs e)
        {
            string msg = "Only numeric characters are allowed for Student Number";

            if (flag == true)
            {
                if ((cbQuery.Text == "Student Number") && (tbDetails.Text.Length > 0))
                {
                    try
                    {
                        dataGridView1.DataSource = dc.QueryByStudentNumber(tbDetails.Text);
                        this.PaintDataGridView();
                    }
                    catch (FormatException exp)
                    {
                        MessageBox.Show(string.Format("{0}\n{1}", exp.Message, msg));
                    }
                }
                else if (cbQuery.Text == "Firstname")
                {
                    dataGridView1.DataSource = dc.QueryByFirstname(tbDetails.Text);
                    this.PaintDataGridView();
                }
                else if (cbQuery.Text == "Middlename")
                {
                    dataGridView1.DataSource = dc.QueryByMiddlename(tbDetails.Text);
                    this.PaintDataGridView();
                }
                else if (cbQuery.Text == "Surname")
                {
                    dataGridView1.DataSource = dc.QueryBySurname(tbDetails.Text);
                    this.PaintDataGridView();
                }
                else if (cbQuery.Text == "Gender")
                {
                    dataGridView1.DataSource = dc.QueryByGender(tbDetails.Text);
                    this.PaintDataGridView();
                }

                else if (cbQuery.Text == "Course")
                {
                    dataGridView1.DataSource = dc.QueryByCourse(tbDetails.Text);
                    this.PaintDataGridView();
                }
                else if (cbQuery.Text == "Year Registered")
                {
                    dataGridView1.DataSource = dc.QueryByYear(tbDetails.Text);
                    this.PaintDataGridView();
                }
                else
                {
                    dataGridView1.DataSource = dc.QueryAllStudents();
                    this.PaintDataGridView();
                }
            }
        }

        private void PaintDataGridView()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (((Convert.ToString(row.Cells[5].Value) == "IT Technical Support (NQF4) - PC Engineering") ||
                    (Convert.ToString(row.Cells[5].Value) == "IT Technical Support (NQF4) - Datacom & Networks") ||
                    (Convert.ToString(row.Cells[5].Value) == "IT Systems Development (NQF5)") ||
                    (Convert.ToString(row.Cells[5].Value) == "BA (NQF4) - Human Resources Management") ||
                    (Convert.ToString(row.Cells[5].Value) == "BA (NQF4) - Project Management") ||
                    (Convert.ToString(row.Cells[5].Value) == "BA (NQF4) - Secretarial Support")) &&
                    (DateTime.Today - DateTime.Parse(Convert.ToString(row.Cells[6].Value))).TotalDays <= 365)
                {
                    if ((DateTime.Today.Month == 2) && (Convert.ToDouble(row.Cells[8].Value) >= 3330.00) ||
                        ((DateTime.Today.Month == 3) && (Convert.ToDouble(row.Cells[8].Value) >= 4875.56)) ||
                        ((DateTime.Today.Month == 4) && (Convert.ToDouble(row.Cells[8].Value) >= 6421.12)) ||
                        ((DateTime.Today.Month == 5) && (Convert.ToDouble(row.Cells[8].Value) >= 7966.68)) ||
                        ((DateTime.Today.Month == 6) && (Convert.ToDouble(row.Cells[8].Value) >= 9512.24)) ||
                        ((DateTime.Today.Month == 7) && (Convert.ToDouble(row.Cells[8].Value) >= 11057.80)) ||
                        ((DateTime.Today.Month == 8) && (Convert.ToDouble(row.Cells[8].Value) >= 12603.36)) ||
                        ((DateTime.Today.Month == 9) && (Convert.ToDouble(row.Cells[8].Value) >= 14148.92)) ||
                        ((DateTime.Today.Month == 10) && (Convert.ToDouble(row.Cells[8].Value) >= 15694.68)) ||
                        ((DateTime.Today.Month == 11) && (Convert.ToDouble(row.Cells[8].Value) >= 17240.00)))
                    {
                        row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else if ((DateTime.Today.Month == 2) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 3330.00) ||
                        ((DateTime.Today.Month == 3) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 4875.56)) ||
                        ((DateTime.Today.Month == 4) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 6421.12)) ||
                        ((DateTime.Today.Month == 5) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 7966.68)) ||
                        ((DateTime.Today.Month == 6) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 9512.24)) ||
                        ((DateTime.Today.Month == 7) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 11057.80)) ||
                        ((DateTime.Today.Month == 8) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 12603.36)) ||
                        ((DateTime.Today.Month == 9) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 14148.92)) ||
                        ((DateTime.Today.Month == 10) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 15694.68)) ||
                        ((DateTime.Today.Month == 11) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 17240.00)))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }

                if ((Convert.ToString(row.Cells[5].Value) == "IT Skills Combo (A+, N+, MCSE)") &&
                    (DateTime.Today - DateTime.Parse(Convert.ToString(row.Cells[6].Value))).TotalDays <= 365)
                {
                    if ((DateTime.Today.Month == 2) && (Convert.ToDouble(row.Cells[8].Value) >= 3330.00) ||
                        ((DateTime.Today.Month == 3) && (Convert.ToDouble(row.Cells[8].Value) >= 5431.11)) ||
                        ((DateTime.Today.Month == 4) && (Convert.ToDouble(row.Cells[8].Value) >= 7532.22)) ||
                        ((DateTime.Today.Month == 5) && (Convert.ToDouble(row.Cells[8].Value) >= 9633.33)) ||
                        ((DateTime.Today.Month == 6) && (Convert.ToDouble(row.Cells[8].Value) >= 11734.44)) ||
                        ((DateTime.Today.Month == 7) && (Convert.ToDouble(row.Cells[8].Value) >= 13835.55)) ||
                        ((DateTime.Today.Month == 8) && (Convert.ToDouble(row.Cells[8].Value) >= 15936.66)) ||
                        ((DateTime.Today.Month == 9) && (Convert.ToDouble(row.Cells[8].Value) >= 18037.77)) ||
                        ((DateTime.Today.Month == 10) && (Convert.ToDouble(row.Cells[8].Value) >= 20138.88)) ||
                        ((DateTime.Today.Month == 11) && (Convert.ToDouble(row.Cells[8].Value) >= 22240.00)))
                    {
                        row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    else if ((DateTime.Today.Month == 2) && (Convert.ToDouble(row.Cells[8].Value) <= 3330.00) ||
                        ((DateTime.Today.Month == 3) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 5431.11)) ||
                        ((DateTime.Today.Month == 4) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 7532.22)) ||
                        ((DateTime.Today.Month == 5) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 9633.33)) ||
                        ((DateTime.Today.Month == 6) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 11734.44)) ||
                        ((DateTime.Today.Month == 7) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 13835.55)) ||
                        ((DateTime.Today.Month == 8) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 15936.66)) ||
                        ((DateTime.Today.Month == 9) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 18037.77)) ||
                        ((DateTime.Today.Month == 10) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 20138.88)) ||
                        ((DateTime.Today.Month == 11) && (Convert.ToDouble(row.Cells[8].Value) <= 0.65 * 22240.00)))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }

                if ((Convert.ToString(row.Cells[5].Value) == "A+") ||
                    (Convert.ToString(row.Cells[5].Value) == "N+") ||
                    (Convert.ToString(row.Cells[5].Value) == "MCSE") ||
                    (Convert.ToString(row.Cells[5].Value) == "End User Computing"))
                {
                    if ((DateTime.Parse(Convert.ToString(row.Cells[6].Value)).AddDays(0) == DateTime.Today) &&
                        (Convert.ToDouble(row.Cells[8].Value) >= 1850.00) ||
                        (DateTime.Parse(Convert.ToString(row.Cells[6].Value)).AddDays(30) >= DateTime.Today) &&
                        (Convert.ToDouble(row.Cells[8].Value) >= 2980.00) ||
                        (DateTime.Parse(Convert.ToString(row.Cells[6].Value)).AddDays(60) >= DateTime.Today) &&
                        (Convert.ToDouble(row.Cells[8].Value) >= 4110.00) ||
                        (DateTime.Parse(Convert.ToString(row.Cells[6].Value)).AddDays(90) >= DateTime.Today) &&
                        (Convert.ToDouble(row.Cells[8].Value) >= 5240.00))
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                    else if ((DateTime.Parse(Convert.ToString(row.Cells[6].Value)).AddDays(0) == DateTime.Today) &&
                        (Convert.ToDouble(row.Cells[8].Value) < 0.5 * 1850.00) ||
                        (DateTime.Parse(Convert.ToString(row.Cells[6].Value)).AddDays(30) >= DateTime.Today) &&
                        (Convert.ToDouble(row.Cells[8].Value) >= 2980.00) ||
                        (DateTime.Parse(Convert.ToString(row.Cells[6].Value)).AddDays(60) >= DateTime.Today) &&
                        (Convert.ToDouble(row.Cells[8].Value) < 0.5 * 4110.00) ||
                        (DateTime.Parse(Convert.ToString(row.Cells[6].Value)).AddDays(90) >= DateTime.Today) &&
                        (Convert.ToDouble(row.Cells[8].Value) < 0.5 * 5240.00))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }
    }
}

