using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces
{
    [Serializable]
    public class Employee
    {
        //Properties
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public int EmployeeNumber { get; set; }

        public EmployeeEmploymentInformation employmentInfo { get; private set; }
        public EmployeePersonalInfo personalInfo { get; private set; }

        public Employee(string firstName, string lastname, EmployeeEmploymentInformation employmentInfo, EmployeePersonalInfo personalInfo)
        {
            FirstName = firstName;
            LastName = lastname;
            this.employmentInfo = employmentInfo;
            this.personalInfo = personalInfo;
        }
        public Employee(string firstName, string lastname, EmployeeEmploymentInformation employmentInfo, EmployeePersonalInfo personalInfo, int employeeNum)
        {
            FirstName = firstName;
            LastName = lastname;
            this.employmentInfo = employmentInfo;
            this.personalInfo = personalInfo;
            EmployeeNumber = employeeNum;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {EmployeeNumber} - {employmentInfo.EmployeeDepartment}";
        }

        public string ToStringHR()
        {
            return $"{FirstName} {LastName}: {personalInfo.Email} , {personalInfo.PhoneNumber}";
        }
    }
}
