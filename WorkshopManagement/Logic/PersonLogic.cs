using Classes;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PersonLogic : IPersonLogic
    {
        private List<Person> allpeople;

        public PersonLogic()
        {
            allpeople = new List<Person>();
        }
        public void AddPerson(Person p)
        {
            foreach(Person pers in allpeople)
            {
                if(pers.PCN == p.PCN)
                {
                    throw new Exception("This pcn is already in the system.");
                }
            }
            allpeople.Add(p);
        }

        public void EditPerson(Person oldp, Person newp)
        {
            allpeople.Remove(GetPerson(oldp.PCN));
            AddPerson(newp);
        }

        public List<Attendance> GetOnesAttendances(Person p)
        {
            return p.GetAttendances();
        }

        public List<Person> GetPeople()
        {
            return allpeople;
        }

        public Person GetPerson(string pcn)
        {          
            foreach(Person p in allpeople)
            {
                if(p.PCN == pcn)
                {
                    return p;
                }
            }
            throw new Exception($"There was no one found with this({pcn}) pcn.");
        }
    }
}
