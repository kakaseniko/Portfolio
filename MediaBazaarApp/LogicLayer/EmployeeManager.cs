using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ModulesAndInterfaces;

namespace LogicLayer
{
    [Serializable]
    public class EmployeeManager
    {
        List<Employee> employees;
        EmployeeDBManager dbman = new EmployeeDBManager();

        public EmployeeManager()
        {
            employees = new List<Employee>();
        }

        public bool AddEmployee(Employee empl)
        {
            foreach (Employee e in employees)
            {
                if (e.EmployeeNumber == empl.EmployeeNumber)
                {
                    return false;
                }
            }
            employees.Add(empl);
            dbman.InsertToDB(empl);
            return true;
        }

        public bool RemoveEmployee(int emplNum)
        {
            foreach (Employee e in employees)
            {
                if (e.EmployeeNumber == emplNum)
                {
                    employees.Remove(e);
                    return true;
                }
            }
            return false;
        }
        public bool EditEmployee(Employee oldEmpl, Employee newEmpl)
        {
            newEmpl.EmployeeNumber = oldEmpl.EmployeeNumber;

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeNumber == newEmpl.EmployeeNumber)
                {
                    employees[i] = newEmpl;
                    dbman.UpdateDB(newEmpl);
                    return true;
                }
            }

            return false;

        }
        public Employee GetEmployee(int num)
        {
            foreach (Employee e in employees)
            {
                if (e.EmployeeNumber == num)
                {
                    return e;
                }
            }
            return null;
        }

        public Employee[] GetEmployees()
        {
            return this.employees.ToArray();
        }
        public bool AddNewContractToEmployee(Employee e, EmployeeContract c)
        {
            if (GetEmployee(e.EmployeeNumber) != null)
            {
                e.employmentInfo.AddNewContract(c);
                dbman.InsertNewContractToDB(c);
                return true;
            }
            return false;
        }
        public void EditEmployeePassword(Employee empl, string password)
        {

            empl.personalInfo.Password = password;
            dbman.UpdateDB(empl);

        }
        public Employee[] SearchEmployeeByName(string name)
        {
            List<Employee> found = new List<Employee>();
            foreach (Employee e in employees)
            {
                if (e.FirstName.Contains(name) || e.LastName.Contains(name))
                {
                    found.Add(e);
                }
            }
            return found.ToArray();
        }
        public Employee SearchEmployeeByNumber(int num)
        {
            foreach (Employee e in employees)
            {
                if (e.EmployeeNumber == num)
                {
                    return e;
                }
            }
            return null;
        }
        public Employee[] SearchEmployeeByDepartment(EmployeeDepartment dep)
        {
            List<Employee> found = new List<Employee>();
            foreach (Employee e in employees)
            {
                if (e.employmentInfo.EmployeeDepartment == dep)
                {
                    found.Add(e);
                }
            }
            return found.ToArray();
        }
        public void ReadEmployeesFromDB()
        {
            employees = dbman.ReadFromDB();
        }
        

    }
}
