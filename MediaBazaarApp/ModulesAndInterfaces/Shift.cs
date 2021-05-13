using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces
{
    [Serializable]
    public class Shift
    {
        public int ShiftNumber { get; set; }


        private List<Employee> employees;


        //Properties
        public EmployeeDepartment EmployeeDepartment { get; private set; }

        public Employee Employee { get; private set; }


        public ShiftType ShiftType { get; private set; }


        public Days WeeklyDay { get; private set; }

        public DateTime DateTime { get; set; }


        //Constructor
        

        public Shift(EmployeeDepartment employeeDepartment, Employee employee, DateTime datetime, ShiftType shiftType) // this is for getting day as an input string (one week) 
        {
            EmployeeDepartment = employeeDepartment;
            this.DateTime = datetime;
            ShiftType = shiftType;
            employees = new List<Employee>();
            employees.Add(employee);

        }
        public Shift(EmployeeDepartment employeeDepartment, DateTime datetime, ShiftType shiftType, int shiftnum) // this is for reading shifts from the DB 
        {
            EmployeeDepartment = employeeDepartment;
            this.DateTime = datetime;
            ShiftType = shiftType;
            ShiftNumber = shiftnum;
        }

        public void AssignShiftNumber(int num)
        {
            this.ShiftNumber = num;
        }


        public bool AddEmployee(Employee employee)
        {
            if (employees != null)
            {
                foreach (Employee e in employees)
                {
                    if (e.EmployeeNumber != employee.EmployeeNumber)
                    {
                        employees.Add(employee);
                        return true;
                    }
                }
            }
            else
            {
                employees = new List<Employee>();
                employees.Add(employee);
                return true;
            }

            return false;
        }

        public bool RemoveEmployee(Employee employee)
        {
            foreach (Employee e in employees)
            {
                if (e == employee)
                {
                    employees.Remove(employee);
                    return true;
                }
            }

            return false;
        }

        public Employee GetEmployee(int employeeNumber)
        {
            foreach (Employee e in employees)
            {
                if (e.EmployeeNumber == employeeNumber)
                {
                    return e;
                }
            }

            return null;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public override string ToString()
        {
            return $"{Employee.FirstName},  {EmployeeDepartment}";
        }
    }
}
