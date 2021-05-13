using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Administration
    {
        private List<Person> allPersons;
        private DBManager dbman;


        public Administration()
        {
            dbman = new DBManager();
            LoadDataFromDB();
        }

        public void AddPerson(Person p)
        {
            if(GetPerson(p.Pcn) == null)
            {
                allPersons.Add(p);
                AssignID(p);
            }
            
        }

        public Person GetPerson(int pcn)
        {
            foreach (Person p in allPersons)
            {
                if (p.Pcn == pcn)
                {
                    return p;
                }
            }
            return null;
        }

        public List<Person> GetAllPersons()
        {
            return allPersons;
        }

        public List<Person> SearchPerson(string name)
        {
            List<Person> foundpeople = new List<Person>();
            foreach(Person p in allPersons)
            {
                if(p.Name.Contains(name))
                {
                    foundpeople.Add(p);
                }
            }
            return foundpeople;
        }
        private void AssignID(Person p)
        {
            p.ID = 1000 + allPersons.Count();
        }
        private void LoadDataFromDB()
        {
            allPersons = new List<Person>();
            foreach(Person p in dbman.ReadAll().ToList())
            {
                allPersons.Add(p);
            }
        }
        public void SaveDataToDatabase()
        {
            List<Person> people = dbman.ReadAll().ToList();
            foreach(Person p in allPersons)
            {
                bool found = false;
                foreach(Person p2 in people)
                {
                    if(p.ID == p2.ID)
                    {
                        found = true;
                    }
                }
                if(!found)
                {
                    dbman.Insert(p);
                }
                
            }
        }
    }
}
