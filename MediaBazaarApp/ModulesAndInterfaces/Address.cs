using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ModulesAndInterfaces.CustomExceptions;

namespace ModulesAndInterfaces
{
    [Serializable]
    public class Address
    {
        public string StreetName { get; private set; }
        public int StreetNum { get; private set; }
        public string StreetNumAddition { get; private set; }
        private string postcode;
        public string City { get; set; }

        public Address(string streetName, int streetNum, string streetNumAddition, string postcode, string city)
        {
            StreetName = streetName;
            StreetNum = streetNum;
            StreetNumAddition = streetNumAddition;
            Postcode = postcode;
            City = city;
        }
        public string Postcode
        {
            get { return this.postcode; }
            set
            {
                if (Regex.IsMatch(value, @"^\d{4}[A-Z]{2}$"))
                {
                    this.postcode = value;
                }
                else
                {
                    throw new InvalidPostcodeEx(value);
                }
            }

        }
    }
}

