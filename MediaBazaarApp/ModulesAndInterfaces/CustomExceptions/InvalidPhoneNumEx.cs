using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces.CustomExceptions
{
    public class InvalidPhoneNumEx:Exception
    {
        public InvalidPhoneNumEx(string num) : base($"Entered phone number is not in correct format.(06xxxxxxxx")
        {

        }
    }
}
