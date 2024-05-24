﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {

        private string first_name;
        private string last_name;
        private string department;
        private string job_tile;
        private double basic_salary;
       
        public string FirstName
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }

        public string LastName
        {
            get
            {
                return last_name;
            } set
            {
                last_name = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return job_tile;
            } set
            {
                job_tile = value;
            }
        }

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.first_name = FName;
            this.last_name = LName;
            this.department = dept;
            this.job_tile = job;
        }

        public double BasicSalary
        {
            get
            {
                return basic_salary;
            } set
            {
                basic_salary = value;
            }
        }
        

        public double getSalary()
        {
            return basic_salary;
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
        }
    }
}
