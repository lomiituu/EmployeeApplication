namespace EmployeeApplication
{
    partial class Form1
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.ratePerHour = new System.Windows.Forms.TextBox();
            this.totalHoursWorked = new System.Windows.Forms.TextBox();
            this.computeSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FNameHere = new System.Windows.Forms.Label();
            this.LNameHere = new System.Windows.Forms.Label();
            this.BS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(93, 65);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(240, 26);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(343, 68);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(240, 26);
            this.lastName.TabIndex = 1;
            // 
            // Department
            // 
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(93, 159);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(240, 26);
            this.Department.TabIndex = 2;
            // 
            // jobTitle
            // 
            this.jobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitle.Location = new System.Drawing.Point(343, 160);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(240, 26);
            this.jobTitle.TabIndex = 3;
            this.jobTitle.TextChanged += new System.EventHandler(this.jobTitle_TextChanged);
            // 
            // ratePerHour
            // 
            this.ratePerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratePerHour.Location = new System.Drawing.Point(93, 253);
            this.ratePerHour.Name = "ratePerHour";
            this.ratePerHour.Size = new System.Drawing.Size(240, 26);
            this.ratePerHour.TabIndex = 4;
            // 
            // totalHoursWorked
            // 
            this.totalHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursWorked.Location = new System.Drawing.Point(343, 252);
            this.totalHoursWorked.Name = "totalHoursWorked";
            this.totalHoursWorked.Size = new System.Drawing.Size(240, 26);
            this.totalHoursWorked.TabIndex = 5;
            // 
            // computeSalary
            // 
            this.computeSalary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.computeSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.computeSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeSalary.Location = new System.Drawing.Point(246, 299);
            this.computeSalary.Name = "computeSalary";
            this.computeSalary.Size = new System.Drawing.Size(169, 43);
            this.computeSalary.TabIndex = 6;
            this.computeSalary.Text = "Compute Salary";
            this.computeSalary.UseVisualStyleBackColor = false;
            this.computeSalary.Click += new System.EventHandler(this.computeSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Job Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rate per hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total hours worked";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Basic Salary:";
            // 
            // FNameHere
            // 
            this.FNameHere.AutoSize = true;
            this.FNameHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameHere.Location = new System.Drawing.Point(180, 382);
            this.FNameHere.Name = "FNameHere";
            this.FNameHere.Size = new System.Drawing.Size(88, 13);
            this.FNameHere.TabIndex = 16;
            this.FNameHere.Text = "<first name here>";
            // 
            // LNameHere
            // 
            this.LNameHere.AutoSize = true;
            this.LNameHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameHere.Location = new System.Drawing.Point(180, 415);
            this.LNameHere.Name = "LNameHere";
            this.LNameHere.Size = new System.Drawing.Size(88, 13);
            this.LNameHere.TabIndex = 17;
            this.LNameHere.Text = "<last name here>";
            // 
            // BS
            // 
            this.BS.AutoSize = true;
            this.BS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS.Location = new System.Drawing.Point(180, 450);
            this.BS.Name = "BS";
            this.BS.Size = new System.Drawing.Size(34, 13);
            this.BS.TabIndex = 18;
            this.BS.Text = "00.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.BS);
            this.Controls.Add(this.LNameHere);
            this.Controls.Add(this.FNameHere);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computeSalary);
            this.Controls.Add(this.totalHoursWorked);
            this.Controls.Add(this.ratePerHour);
            this.Controls.Add(this.jobTitle);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox jobTitle;
        private System.Windows.Forms.TextBox ratePerHour;
        private System.Windows.Forms.TextBox totalHoursWorked;
        private System.Windows.Forms.Button computeSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FNameHere;
        private System.Windows.Forms.Label LNameHere;
        private System.Windows.Forms.Label BS;
    }
}

