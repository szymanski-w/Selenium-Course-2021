using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReference
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public Employee(int id)
        {
            this.EmployeeID = id;
        }

        public Employee(string name, int id, string title)
        {
            this.Name = name;
            this.EmployeeID = id;
            this.JobTitle = title;
        }

        public string JobLocation()
        {
            if (JobTitle == "Manager")
                return "Boston";
            else if (JobTitle == "Staff")
                return "Pcim Dolny";
            return "New York";
        }

        public override string ToString()
        {
            return EmployeeID + " " + Name + " Job title: " + JobTitle; 
        }
    }
}
