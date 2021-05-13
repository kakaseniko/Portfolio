using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFileWriter
    {
        void WriteAllWorkshopsToFile(string filename, List<Workshop> workshops);
        void WriteOneWorkshopToFile(string filename, Workshop wks);

    }
}
