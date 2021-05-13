using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Workshop
    {
        protected int id;
        protected string title;
        protected string topic;
        public DateTime Time { get; private set; }
        public int MaxParticipants { get; private set; }
        public bool IsStarted { get; private set;}
        protected List<Person> participants;
        public Teacher Teacher { get; private set; }

        public Workshop(string title, string topic, DateTime time, int maxPart, Teacher teacher)
        {
            participants = new List<Person>();           
            Title = title;
            Topic = topic;
            Time = time;
            MaxParticipants = maxPart;
            Teacher = teacher;
            IsStarted = false;
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Title
        {
            get { return this.title; }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Please fill in title.");
                }
                this.title = value;
            }
        }
        public string Topic
        {
            get { return this.topic; }
            private set 
            { 
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Please fill in topic.");
                }
                this.topic = value;
            }
        }
        
        public void AddParticipant(Person p)
        {
            if (participants.Count < MaxParticipants)
            {
                foreach (Person pers in participants)
                {
                    if (pers.PCN == p.PCN)
                    {
                        throw new Exception("Selected person is already participating in this workshop.");
                    }
                }
                participants.Add(p);
                return;
            }
            throw new Exception("Workshop is already full.");
        }
        public void RemoveParticipant(Person p)
        {
            foreach(Person pers in this.participants.ToList())
            {
                if(pers.PCN == p.PCN)
                {
                    participants.Remove(p);
                    return;
                }
            }
            throw new Exception("Selected person has not been enrolled to this workshop.");
        }
        public List<Person> GetParticipants()
        {
            if(this.participants.Count == 0)
            {
                return null;
            }
            return this.participants;
        }

        public void StartWorkshop()
        {
            IsStarted = true;
        }
        public override string ToString()
        {
            return $"Title: {Title} - Date: {Time}";
        }
    }
}
