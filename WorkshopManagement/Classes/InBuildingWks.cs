using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class InBuildingWks: Workshop
    {
        private string address;
        public int RoomNum { get; private set; }
        public InBuildingWks(string title, string topic, DateTime time, int maxPart, Teacher teacher, string address, int roomNum) : base(title, topic, time,  maxPart, teacher)
        {
            Address = address;
            RoomNum = roomNum;
        }
        public string Address
        {
            get { return this.address; }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Please fill in address.");
                }
                this.address = value;
            }
        }
        //public override string ToString()
        //{
        //    return $"INBUILDING - Title: {Title} - Date: {Time}";
        //}


    }
}
