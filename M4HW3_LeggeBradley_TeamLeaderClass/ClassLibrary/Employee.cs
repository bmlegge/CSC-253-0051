using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee
    {
        public Employee(string employeeName, int employeeNum)
        {
            EmployeeName = employeeName;
            EmployeeNum = employeeNum;
        }

        public string EmployeeName { get; set; }
        public int EmployeeNum { get; set; }
    }
}
