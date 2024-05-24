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
            

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
