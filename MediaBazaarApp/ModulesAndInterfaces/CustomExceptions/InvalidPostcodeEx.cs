using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces.CustomExceptions
{
    public class InvalidPostcodeEx:Exception
    {
        public InvalidPostcodeEx(string code) : base($"Entered postcode is in invalid format. Valid format example: 0000AA")
        {

        }
    }
}
