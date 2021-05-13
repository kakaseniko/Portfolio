using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IWorkshopCRUDLogic
    {
        void AddWorkshop(Workshop wks);
        void RemoveWorkshop(Workshop wks);
        void EditWorkshop(Workshop oldwks, Workshop newwks);
        Workshop GetWorkshop(int id);
        List<Workshop> GetAllWorkshops();
        void WriteAllWorkshopsToFile(string filename);
        void WriteOneWorkshopToFile(string filename, Workshop wks);

    }
}
