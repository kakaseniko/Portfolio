using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ModulesAndInterfaces;

namespace LogicLayer
{
    [Serializable]
    public class ShiftsManager
    {
        private List<Shift> shifts;

        ScheduleDBManager shiftmanager = new ScheduleDBManager();

        public ShiftsManager()
        {
            shifts = new List<Shift>();
            
        }



        public bool AddShift(Shift shift)
        {

            foreach (Shift s in shifts)
            {
                if (s.ShiftType == shift.ShiftType && s.Employee == shift.Employee && s.WeeklyDay == shift.WeeklyDay)
                {
                    return false; 
                }

            }
            
            shifts.Add(shift);
            shiftmanager.InsertToDB(shift);

            return true;
        }

       
        public bool RemoveShift(Shift shift)
        {
            foreach (Shift s in shifts)
            {
                if (s.ShiftType == shift.ShiftType)
                {
                    shifts.Remove(shift);
                    return true; 
                }

            }

            return false; 
        }

        public Shift GetShift(Days day)
        {
            foreach (Shift s in shifts)
            {
                if (s.WeeklyDay == day)
                {
                    return s;
                }
            }

            return null;
        }

        public List<Shift> GetShifts()
        {
            return shifts;
        }

        public List<Shift> GetSpecificShifts(Days day, ShiftType ShiftType)
        {
            List<Shift> SpesShifts = new List<Shift>();
            foreach (Shift s in shifts)
            {
                if (s.WeeklyDay == day && s.ShiftType == ShiftType)
                {
                    SpesShifts.Add(s);
                }

            }
            return SpesShifts;

        }

        public void ClearShifts() 
        {
            shifts.Clear();
        }



        public override string ToString()
        {
            return base.ToString();
        }

        public List<Employee> GetEmployeesFromDep(EmployeeDepartment department)
        {
            List<Employee> employees = shiftmanager.ReadEmployeeFromDepartmentFromDB(department);
            return employees;
        }
        public void ReadShiftsFromDB()
        {
            shifts = shiftmanager.ReadFromDB();
        }

    }
}
