using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleParking
{
    public class BicycleParking
    {
        // Instance variables
        private double pricePerHour;
        private double surchargeElectricPerHour;
        private List<Bicycle> allParkedBicycles;
        
        // Properties        
        
        // Constructor
        public BicycleParking(double pricePerHour, double surchargeElectricPerHour)
        {
            this.pricePerHour = pricePerHour;
            this.surchargeElectricPerHour = surchargeElectricPerHour;
            allParkedBicycles = new List<Bicycle>();

        }

        // Methods    
        private Bicycle GetBicycle(string ticketNumber)
        {
            foreach (Bicycle b in allParkedBicycles)
            {
                if (b.GetTicketNr() == ticketNumber)
                {
                    return b;
                }
            }
            return null;

        }
        public string ParkBicycle(BicycleType type)
        {
            Bicycle bicycle = new Bicycle(type);
            allParkedBicycles.Add(bicycle);

            return bicycle.GetTicketNr();
        }
        public double RetrieveBicycle(string ticketNumber, int hoursInParking, string zipcode)
        {
            double price;

            if (this.GetBicycle(ticketNumber) == null)
            {
                return -1;
            }
            else
            {
                Bicycle b = this.GetBicycle(ticketNumber);
                if (b.IsInParking)
                {
                    b.HoursInParking = hoursInParking;
                    b.OwnerZipcode = zipcode;
                    b.IsInParking = false;

                    switch(b.Type)
                    {
                        case BicycleType.NORMAL:
                            {
                                price = b.HoursInParking * this.pricePerHour;
                                return price;
                            }
                        case BicycleType.ELECTRIC:
                            {
                                price = (b.HoursInParking * this.pricePerHour) + this.surchargeElectricPerHour;
                                return price;
                            }
                        case BicycleType.FOLDING:
                            {
                                price = b.HoursInParking * (this.pricePerHour / 2);
                                return price;
                            }
                        case BicycleType.TANDEM:
                            {
                                price = b.HoursInParking * (this.pricePerHour * 2);
                                return price;
                            }
                        default:
                            {
                                return -1;
                            }
                    }
                }
                else
                {
                    return -1;
                }
            }

        }
        public Bicycle[] GetAllRetrievedBicyclesByZipcode(string partialZipcode)
        {
            /*Bicycle[] bs = new Bicycle[allParkedBicycles.Count];

            for(int i = 0; i < allParkedBicycles.Count; i++)
            {
                if(allParkedBicycles[i].OwnerZipcode == null)
                {
                    return null;
                }
                else if (allParkedBicycles[i].OwnerZipcode.Contains(partialZipcode))
                {
                    bs[i] = allParkedBicycles[i];
                }
            }
            return bs;*/

            List<Bicycle> bs = new List<Bicycle>();
            foreach(Bicycle b in allParkedBicycles)
            {
                if(b.OwnerZipcode == null)
                {
                    return null;
                }
                else if(b.OwnerZipcode.Contains(partialZipcode))
                {
                    bs.Add(b);
                }
            }
            return bs.ToArray();
        }

        public List<string> GetAllBNr()
        {
            List<string> allBNr = new List<string>();
            foreach(Bicycle b in allParkedBicycles)
            {
                allBNr.Add(b.GetTicketNr());
            }
            return allBNr;
        }

    }
}
