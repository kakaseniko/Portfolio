using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Teacher : Person
    {
        public JobPosition position;
        public double salary;

        public Teacher( string name, int age, int pcn, int yearsAtSchool, double salary) : base( name, age, pcn, yearsAtSchool) 
        {
            this.salary = salary;
            this.position = JobPosition.JUNIOR_TEACHER;
        }
        public Teacher(int id, string name, int age, int pcn, int yearsAtSchool, double salary, JobPosition position) : base(id, name, age, pcn, yearsAtSchool)
        {
            this.salary = salary;
            this.position = position;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Position: {this.position}, Salary: {this.salary}";
        }
        public void MakePromotion()
        {
            if(!(this.position == JobPosition.DIRECTOR))
            {
                this.position++;
            }
        }
        public override void StartAnotherSchoolYear()
        {
            base.StartAnotherSchoolYear();
            if(yearsAtSchool % 3 == 0)
            {
                this.salary *= 1.1;
            }
        }


    }
}
