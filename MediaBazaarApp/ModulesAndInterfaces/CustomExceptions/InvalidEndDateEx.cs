using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces.CustomExceptions
{
    public class InvalidEndDateEx:Exception
    {
        public InvalidEndDateEx(DateTime date) : base($"End date cannot be sooner than start date.") { }
    }
}
