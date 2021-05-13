using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulesAndInterfaces.CustomExceptions;

namespace ModulesAndInterfaces
{
    [Serializable]
    public class EmployeeContract
    {
        public double FTE { get; private set; }
        public double Salary { get; private set; }
        public DateTime StartDate { get; private set; }
        private DateTime endDate;
        public string EndReason { get; set; }
        public bool IsActive { get; set; }
        public int EmplNum { get; set; }

        public string ContractNum { get; set; }

        

        public EmployeeContract(double fte, double salary, DateTime startDate, DateTime endDate, string endReason, bool isActive, int emplNum, string contractNum)
        {

            FTE = fte;
            Salary = salary;
            StartDate = startDate;
            EndDate = endDate;
            EndReason = endReason;
            IsActive = isActive;
            EmplNum = emplNum;
            ContractNum = contractNum;
        }
        public EmployeeContract(double fte, double salary, DateTime startDate, int emplNum, string contractNum)
        {
            FTE = fte;
            Salary = salary;
            StartDate = startDate;
            IsActive = true;
            EmplNum = emplNum;
            ContractNum = contractNum;
        }
        public DateTime EndDate
        {
            get { return this.endDate; }
            set
            {
                if (StartDate > value)
                {
                    throw new InvalidEndDateEx(value);
                }
                else
                {
                    this.endDate = value;
                }
            }
        }
        public override string ToString()
        {
            if (IsActive)
            {
                return $"Status: active - FTE: {this.FTE} - Salary: {this.Salary} - Start date: {this.StartDate.ToShortDateString()}";
            }
            return $"Status: ended - FTE: {this.FTE} - Salary: {this.Salary} - Start date: {this.StartDate.ToShortDateString()} - End date: {this.EndDate.ToShortDateString()} - End reason: {this.EndReason}";
        }


    }
}
