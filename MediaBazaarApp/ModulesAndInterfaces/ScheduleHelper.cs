using System;
using System.Collections.Generic;
using System.Text;

namespace ModulesAndInterfaces
{
    public class ScheduleHelper
    {
        public int ShiftNum { get; private set; }
        public int EmployeeNum { get; private set; }

        public ScheduleHelper(int shiftNum, int emplNum)
        {
            ShiftNum = shiftNum;
            EmployeeNum = emplNum;
        }
    }
}
