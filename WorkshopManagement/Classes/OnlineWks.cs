using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class OnlineWks: Workshop
    {
        private string link;
        public OnlineWks(string title, string topic, DateTime time, int maxPart, Teacher teacher, string link):base(title, topic, time, maxPart, teacher)
        {
            Link = link;
        }
        public string Link
        {
            get { return this.link; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Please provide a link for the online workshop.");
                }
                this.link = value;
            }
        }
        //public override string ToString()
        //{
        //    return $"ONLINE - Title: {Title} - Date: {Time}";
        //}
    }
}
