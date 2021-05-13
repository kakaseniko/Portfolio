using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StudentSystem
{
    public abstract class Person : IComparable<Person>
    {
        public int ID { get; set; }
        private string name;
        public int age;
        protected int pcn;
        public int yearsAtSchool;

        public Person(string name, int age, int pcn, int yearsAtSchool)
        {
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
        }
        public Person(int id, string name, int age, int pcn, int yearsAtSchool)
        {
            this.ID = ID;
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
        }

        public int Pcn
        {
            get { return this.pcn; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public override string ToString()
        {
            return $"Name: {this.name}, Age: {this.age}, PCN: {this.pcn}, Years at school: {this.yearsAtSchool}";
        }
        public void CelebrateBirthday()
        {
            this.age++;
        }
        public virtual void StartAnotherSchoolYear()
        {
            this.yearsAtSchool++;
        }

        public int CompareTo(Person other)
        {

            return String.Compare(this.Name, other.Name);

        }
    }
}
