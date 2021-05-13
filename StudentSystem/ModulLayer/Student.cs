using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Student : Person
    {
        public int nrOfECs;

        public Student( string name, int age, int pcn, int yearsAtSchool, int nrOfECs) : base( name, age, pcn, yearsAtSchool)
        {
            this.nrOfECs = nrOfECs;
        }
        public Student(int id, string name, int age, int pcn, int yearsAtSchool, int nrOfECs) : base(id, name, age, pcn, yearsAtSchool)
        {
            this.nrOfECs = nrOfECs;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, ECs: {this.nrOfECs}";
        }
        public void AddECs(int n)
        {
            this.nrOfECs += n;
        }

    }
}
