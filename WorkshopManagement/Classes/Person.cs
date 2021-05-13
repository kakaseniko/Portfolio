using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected string pcn;
        protected List<Attendance> attendances;

        public Person(string fname, string lname, string pcn)
        {
            attendances = new List<Attendance>();
            FirstName = fname;
            LastName = lname;
            PCN = pcn;
        }
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Please fill in first name.");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Please fill in last name.");
                }
                this.lastName = value;
            }
        }
        public string PCN
        {
            get { return this.pcn; }
            private set
            {
                if(Regex.IsMatch(value, @"^\d{6}$"))
                {
                    this.pcn = value;
                    return;
                }
                throw new Exception("PCN has to be 6 digits.");
            }
        }
        public void AddAttendance(Attendance a)
        {
            foreach(Attendance atten in attendances)
            {
                if(atten.Wks.ID == a.Wks.ID)
                {
                    throw new Exception("Selected person is already participating in this workshop.");
                }
            }
            attendances.Add(a);
        }
        public void RemoveAttendance(Workshop wks)
        {
            foreach(Attendance a in this.attendances.ToList())
            {
                if(a.Wks.ID == wks.ID)
                {
                    attendances.Remove(a);
                    return;
                }
            }
            throw new Exception("Workshop haven't been found in this persons attandances.");
        }
        public List<Attendance> GetAttendances()
        {
            if (attendances.Count != 0)
            {
                return this.attendances;
            }
            return null;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} - PCN: {PCN}";
        }
    }
}
