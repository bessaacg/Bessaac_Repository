namespace StudentAdministrationSystem
{
    partial class Payments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbStdNumberP = new System.Windows.Forms.TextBox();
            this.gbTransactP = new System.Windows.Forms.GroupBox();
            this.cbPayP = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmountP = new System.Windows.Forms.TextBox();
            this.btnConfirmP = new System.Windows.Forms.Button();
            this.btnCloseP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRefNumberP = new System.Windows.Forms.TextBox();
            this.btnClearP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFirstnameP = new System.Windows.Forms.TextBox();
            this.tbMiddlenameP = new System.Windows.Forms.TextBox();
            this.tbSurnameP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCourseP = new System.Windows.Forms.TextBox();
            this.tbCourseFeeP = new System.Windows.Forms.TextBox();
            this.dtpRegDateP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTotalPaidP = new System.Windows.Forms.TextBox();
            this.tbBalanceP = new System.Windows.Forms.TextBox();
            this.tbDateP = new System.Windows.Forms.TextBox();
            this.gbTransactP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Number";
            // 
            // tbStdNumberP
            // 
            this.tbStdNumberP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStdNumberP.Location = new System.Drawing.Point(367, 78);
            this.tbStdNumberP.Name = "tbStdNumberP";
            this.tbStdNumberP.Size = new System.Drawing.Size(148, 27);
            this.tbStdNumberP.TabIndex = 1;
            this.tbStdNumberP.TextChanged += new System.EventHandler(this.tbStdNumberP_TextChanged_1);
            // 
            // gbTransactP
            // 
            this.gbTransactP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbTransactP.Controls.Add(this.cbPayP);
            this.gbTransactP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransactP.Location = new System.Drawing.Point(188, 234);
            this.gbTransactP.Name = "gbTransactP";
            this.gbTransactP.Size = new System.Drawing.Size(944, 134);
            this.gbTransactP.TabIndex = 3;
            this.gbTransactP.TabStop = false;
            this.gbTransactP.Text = "Transactions";
            // 
            // cbPayP
            // 
            this.cbPayP.AutoSize = true;
            this.cbPayP.Enabled = false;
            this.cbPayP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayP.Location = new System.Drawing.Point(21, 58);
            this.cbPayP.Name = "cbPayP";
            this.cbPayP.Size = new System.Drawing.Size(93, 25);
            this.cbPayP.TabIndex = 5;
            this.cbPayP.Text = "Payment";
            this.cbPayP.UseVisualStyleBackColor = true;
            this.cbPayP.CheckedChanged += new System.EventHandler(this.cbPayP_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Amount";
            // 
            // tbAmountP
            // 
            this.tbAmountP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmountP.Location = new System.Drawing.Point(682, 77);
            this.tbAmountP.Name = "tbAmountP";
            this.tbAmountP.Size = new System.Drawing.Size(148, 27);
            this.tbAmountP.TabIndex = 2;
            this.tbAmountP.TextChanged += new System.EventHandler(this.tbAmountP_TextChanged);
            // 
            // btnConfirmP
            // 
            this.btnConfirmP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmP.Location = new System.Drawing.Point(461, 458);
            this.btnConfirmP.Name = "btnConfirmP";
            this.btnConfirmP.Size = new System.Drawing.Size(82, 34);
            this.btnConfirmP.TabIndex = 6;
            this.btnConfirmP.Text = "Confirm";
            this.btnConfirmP.UseVisualStyleBackColor = true;
            this.btnConfirmP.Click += new System.EventHandler(this.btnConfirmP_Click_1);
            // 
            // btnCloseP
            // 
            this.btnCloseP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseP.Location = new System.Drawing.Point(817, 458);
            this.btnCloseP.Name = "btnCloseP";
            this.btnCloseP.Size = new System.Drawing.Size(75, 34);
            this.btnCloseP.TabIndex = 8;
            this.btnCloseP.Text = "Close";
            this.btnCloseP.UseVisualStyleBackColor = true;
            this.btnCloseP.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Transaction Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(869, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date C/D At Bank";
            // 
            // tbRefNumberP
            // 
            this.tbRefNumberP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRefNumberP.Location = new System.Drawing.Point(352, 188);
            this.tbRefNumberP.Name = "tbRefNumberP";
            this.tbRefNumberP.Size = new System.Drawing.Size(163, 27);
            this.tbRefNumberP.TabIndex = 11;
            // 
            // btnClearP
            // 
            this.btnClearP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearP.Location = new System.Drawing.Point(645, 458);
            this.btnClearP.Name = "btnClearP";
            this.btnClearP.Size = new System.Drawing.Size(75, 34);
            this.btnClearP.TabIndex = 7;
            this.btnClearP.Text = "Clear";
            this.btnClearP.UseVisualStyleBackColor = true;
            this.btnClearP.Click += new System.EventHandler(this.btnClearP_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Firstname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Middlename";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(869, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Surname";
            // 
            // tbFirstnameP
            // 
            this.tbFirstnameP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstnameP.Location = new System.Drawing.Point(267, 110);
            this.tbFirstnameP.Name = "tbFirstnameP";
            this.tbFirstnameP.Size = new System.Drawing.Size(248, 27);
            this.tbFirstnameP.TabIndex = 18;
            // 
            // tbMiddlenameP
            // 
            this.tbMiddlenameP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddlenameP.Location = new System.Drawing.Point(662, 110);
            this.tbMiddlenameP.Name = "tbMiddlenameP";
            this.tbMiddlenameP.Size = new System.Drawing.Size(168, 27);
            this.tbMiddlenameP.TabIndex = 19;
            // 
            // tbSurnameP
            // 
            this.tbSurnameP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurnameP.Location = new System.Drawing.Point(947, 111);
            this.tbSurnameP.Name = "tbSurnameP";
            this.tbSurnameP.Size = new System.Drawing.Size(185, 27);
            this.tbSurnameP.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Course";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(563, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Course Fee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(869, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "Date Registered";
            // 
            // tbCourseP
            // 
            this.tbCourseP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourseP.Location = new System.Drawing.Point(248, 146);
            this.tbCourseP.Name = "tbCourseP";
            this.tbCourseP.Size = new System.Drawing.Size(267, 27);
            this.tbCourseP.TabIndex = 24;
            // 
            // tbCourseFeeP
            // 
            this.tbCourseFeeP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourseFeeP.Location = new System.Drawing.Point(657, 146);
            this.tbCourseFeeP.Name = "tbCourseFeeP";
            this.tbCourseFeeP.Size = new System.Drawing.Size(173, 27);
            this.tbCourseFeeP.TabIndex = 25;
            // 
            // dtpRegDateP
            // 
            this.dtpRegDateP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegDateP.Location = new System.Drawing.Point(997, 149);
            this.dtpRegDateP.Name = "dtpRegDateP";
            this.dtpRegDateP.Size = new System.Drawing.Size(135, 27);
            this.dtpRegDateP.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(563, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total Paid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(869, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "Balance";
            // 
            // tbTotalPaidP
            // 
            this.tbTotalPaidP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPaidP.Location = new System.Drawing.Point(657, 188);
            this.tbTotalPaidP.Name = "tbTotalPaidP";
            this.tbTotalPaidP.Size = new System.Drawing.Size(173, 27);
            this.tbTotalPaidP.TabIndex = 29;
            // 
            // tbBalanceP
            // 
            this.tbBalanceP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalanceP.Location = new System.Drawing.Point(940, 185);
            this.tbBalanceP.Name = "tbBalanceP";
            this.tbBalanceP.Size = new System.Drawing.Size(192, 27);
            this.tbBalanceP.TabIndex = 30;
            // 
            // tbDateP
            // 
            this.tbDateP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateP.Location = new System.Drawing.Point(1006, 78);
            this.tbDateP.Name = "tbDateP";
            this.tbDateP.Size = new System.Drawing.Size(126, 27);
            this.tbDateP.TabIndex = 6;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 531);
            this.Controls.Add(this.tbDateP);
            this.Controls.Add(this.tbBalanceP);
            this.Controls.Add(this.tbTotalPaidP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpRegDateP);
            this.Controls.Add(this.tbCourseFeeP);
            this.Controls.Add(this.tbCourseP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbSurnameP);
            this.Controls.Add(this.tbMiddlenameP);
            this.Controls.Add(this.tbFirstnameP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClearP);
            this.Controls.Add(this.tbRefNumberP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCloseP);
            this.Controls.Add(this.btnConfirmP);
            this.Controls.Add(this.tbAmountP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbTransactP);
            this.Controls.Add(this.tbStdNumberP);
            this.Controls.Add(this.label1);
            this.Name = "Payments";
            this.Text = "Transactions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.gbTransactP.ResumeLayout(false);
            this.gbTransactP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox tbStdNumberP;
        internal System.Windows.Forms.GroupBox gbTransactP;
        internal System.Windows.Forms.TextBox tbAmountP;
        internal System.Windows.Forms.Button btnConfirmP;
        internal System.Windows.Forms.Button btnCloseP;
        internal System.Windows.Forms.TextBox tbRefNumberP;
        internal System.Windows.Forms.Button btnClearP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox tbFirstnameP;
        internal System.Windows.Forms.TextBox tbMiddlenameP;
        internal System.Windows.Forms.TextBox tbSurnameP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox tbCourseP;
        internal System.Windows.Forms.TextBox tbCourseFeeP;
        internal System.Windows.Forms.TextBox dtpRegDateP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox tbTotalPaidP;
        internal System.Windows.Forms.TextBox tbBalanceP;
        private System.Windows.Forms.CheckBox cbPayP;
        private System.Windows.Forms.TextBox tbDateP;
    }
}