using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BicycleParking
{
    public class Bicycle
    {
        // Instance variables
        private static int ticketSeeder = 10000;
        private int hoursInParking;
        private string ownerZipcode;
        private string ticketNumber;

        // Properties
        public BicycleType Type { get; private set; }
        public bool IsInParking
        {
            get; set;
        }
        public int HoursInParking
        {
            get { return this.hoursInParking; }
            set
            {
                if(value >= 1)
                {
                    this.hoursInParking = value;
                }
                else
                {
                    this.hoursInParking = 1;
                }
            }
        }
        public string OwnerZipcode
        {
            get { return this.ownerZipcode; }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    this.ownerZipcode = "Unknown";
                }
                else
                {
                    this.ownerZipcode = value;
                }
            }
        }


        // Constructor

        public Bicycle(BicycleType type)
        {
            this.Type = type;
            this.IsInParking = true;

            string t = this.Type.ToString();
            this.ticketNumber = $"{t.Substring(0, 3)}{Bicycle.ticketSeeder}"; 
            
            Bicycle.ticketSeeder++;

        }
        
        // Uncomment this method when you are done with assignment  2a
        public string GetInfo()
        {
            string s = this.ticketNumber + ": " + this.Type.ToString() + " bicycle";
            if (!this.IsInParking)
            {
                s += " - hours parked " + this.hoursInParking;
                s += " & owner zipcode "+ this.ownerZipcode;
            }
            return s;
        }

        public string GetTicketNr()
        {
            return this.ticketNumber;
        }
    }
}
