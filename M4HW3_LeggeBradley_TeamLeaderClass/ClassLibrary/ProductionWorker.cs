using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductionWorker : Employee
    {
        public ProductionWorker(string employeeName, int employeeNum, int shiftNum, double payRate)
                                : base (employeeName, employeeNum)
        {
            ShiftNum = shiftNum;
            PayRate = payRate;

        }

        public int ShiftNum { get; set; }
        public double PayRate { get; set; }
    }
}
