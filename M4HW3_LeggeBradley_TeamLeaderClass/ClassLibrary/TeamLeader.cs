using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TeamLeader : ProductionWorker
    {
        public TeamLeader(string employeeName, int employeeNum, int shiftNum, double payRate, 
                          double monthlyBonus, double minTrainHours, double trainHoursDone )
                          : base(employeeName, employeeNum, shiftNum, payRate)
        {
            MonthlyBonus = monthlyBonus;
            MinTrainHours = minTrainHours;
            TrainHoursDone = trainHoursDone;
        }

        public double MonthlyBonus { get; set; }
        public double MinTrainHours { get; set; }
        public double TrainHoursDone { get; set; }

    }
}
