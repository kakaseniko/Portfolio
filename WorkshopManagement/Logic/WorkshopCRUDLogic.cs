using Classes;
using DataAccess;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class WorkshopCRUDLogic:IWorkshopCRUDLogic
    {
        private List<Workshop> workshops;
        private IFileWriter filewriter;

        public WorkshopCRUDLogic()
        {
            workshops = new List<Workshop>();
            filewriter = new FileWriter();
        }
        public void AddWorkshop(Workshop wks)
        {
            foreach (Workshop w in workshops)
            {
                if (w.Title == wks.Title)
                {
                    throw new Exception("A workshop already exists with the same title. Please choose a new title.");
                }
            }
            workshops.Add(wks);
            wks.ID = workshops.Count;
        }

        public void EditWorkshop(Workshop oldwks, Workshop newwks)
        {
            RemoveWorkshop(oldwks);
            AddWorkshop(newwks);
        }
        public List<Workshop> GetAllWorkshops()
        {
            return workshops;
        }

        public Workshop GetWorkshop(int id)
        {
            foreach (Workshop w in workshops)
            {
                if (w.ID == id)
                {
                    return w;
                }
            }
            throw new Exception($"No workshop was found with this id({id}).");
        }

        public void RemoveWorkshop(Workshop wks)
        {
            if(wks.GetParticipants() != null)
            {
                foreach (Person p in wks.GetParticipants())
                {
                    p.RemoveAttendance(wks);
                }
            }          
            workshops.Remove(GetWorkshop(wks.ID));

        }
        public void WriteAllWorkshopsToFile(string filename)
        {
            filewriter.WriteAllWorkshopsToFile(filename, workshops);
        }

        public void WriteOneWorkshopToFile(string filename, Workshop wks)
        {
            filewriter.WriteOneWorkshopToFile(filename, wks);
        }
    }
}
