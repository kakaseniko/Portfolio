using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces.CustomExceptions
{
    public class InvalidBSNEx:Exception
    {
        public InvalidBSNEx(string bsn):base($"Entered BSN is invalid.") { }
    }
}
