namespace StudentAdministrationSystem
{
    partial class Transact
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
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.rbReverse = new System.Windows.Forms.RadioButton();
            this.gbTransact = new System.Windows.Forms.GroupBox();
            this.gbTransact.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transact";
            // 
            // rbPay
            // 
            this.rbPay.AutoSize = true;
            this.rbPay.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPay.Location = new System.Drawing.Point(72, 42);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(55, 25);
            this.rbPay.TabIndex = 1;
            this.rbPay.Text = "Pay";
            this.rbPay.UseVisualStyleBackColor = true;
            this.rbPay.CheckedChanged += new System.EventHandler(this.rbPay_CheckedChanged);
            // 
            // rbReverse
            // 
            this.rbReverse.AutoSize = true;
            this.rbReverse.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReverse.Location = new System.Drawing.Point(72, 111);
            this.rbReverse.Name = "rbReverse";
            this.rbReverse.Size = new System.Drawing.Size(154, 25);
            this.rbReverse.TabIndex = 2;
            this.rbReverse.Text = "Reverse Payment";
            this.rbReverse.UseVisualStyleBackColor = true;
            this.rbReverse.CheckedChanged += new System.EventHandler(this.rbReverse_CheckedChanged);
            // 
            // gbTransact
            // 
            this.gbTransact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbTransact.Controls.Add(this.rbPay);
            this.gbTransact.Controls.Add(this.rbReverse);
            this.gbTransact.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransact.Location = new System.Drawing.Point(239, 111);
            this.gbTransact.Name = "gbTransact";
            this.gbTransact.Size = new System.Drawing.Size(397, 182);
            this.gbTransact.TabIndex = 3;
            this.gbTransact.TabStop = false;
            this.gbTransact.Text = "Transaction";
            // 
            // Transact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 360);
            this.Controls.Add(this.gbTransact);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(-200, 0);
            this.Name = "Transact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transact";
            this.Load += new System.EventHandler(this.Transact_Load);
            this.gbTransact.ResumeLayout(false);
            this.gbTransact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.RadioButton rbReverse;
        private System.Windows.Forms.GroupBox gbTransact;
    }
}