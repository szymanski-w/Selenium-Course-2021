using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionQuiz
{
    class Employee
    {
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfHire { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public double MonthlySalary 
        { 
            get
            {
                return MonthlySalary;
            }
            set
            {
                if (MonthlySalary >= 0)
                    MonthlySalary = value;
                else
                    Console.WriteLine("Tak się nie da");
            }
        }

        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Employee(int nr, string firstName, string lastName, string dateOfHire, string jobDescription, string Department, double monthSalary)
        {
            this.Number = nr;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfHire = dateOfHire;
            this.JobDescription = jobDescription;
            this.Department = Department;
            this.MonthlySalary = monthSalary;
        }

        public string getName()
        {
            return $"{FirstName} {LastName}";
        }

        public string getNameToSort()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
