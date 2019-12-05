using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ShiftSupervisor : Employee
    {
        // Constructor
        public ShiftSupervisor(string employeeName, int employeeNum, double annualSalary, double productionBonus)
               : base(employeeName, employeeNum)
        {
            AnnualSalary = annualSalary;
            ProductionBonus = productionBonus;
        }

        // Properties
        public double AnnualSalary { get; set; }
        public double ProductionBonus { get; set; }
    }
}
