using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPersonLogic
    {
        void AddPerson(Person p);
        void EditPerson(Person oldp, Person newp);
        Person GetPerson(string pcn);
        List<Person> GetPeople();
        List<Attendance> GetOnesAttendances(Person p);

    }
}
