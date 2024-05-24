using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void computeSalary_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(firstName.Text, lastName.Text, Department.Text, jobTitle.Text);
            double hour = Convert.ToDouble(ratePerHour.Text);
            int totalHour = Convert.ToInt32(totalHoursWorked.Text);
            partTimeEmployee.computeSalary(totalHour, hour);

            FNameHere.Text = firstName.Text;
            LNameHere.Text = lastName.Text;
            BS.Text = Convert.ToString(partTimeEmployee.getSalary());

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void jobTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
