using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces.CustomExceptions
{
    public class InvalidEmailEx:Exception
    {
        public InvalidEmailEx(string email) : base($"Entered email is invalid.") { }
    }
}
