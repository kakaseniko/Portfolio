using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Interfaces;

namespace DataAccess
{
    public class FileWriter : IFileWriter
    {
        public FileWriter() { }
        public void WriteAllWorkshopsToFile(string filename, List<Workshop> workshops)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Seek(0, SeekOrigin.End);
                sw = new StreamWriter(fs);

                foreach (Workshop w in workshops)
                {
                    if (!w.IsStarted)
                    {

                        if (w is InBuildingWks)
                        {
                            sw.WriteLine($"INBUILDING - TITLE: {w.Title}, DESCRIPTION: {w.Topic}, TEACHER: {w.Teacher.FirstName} {w.Teacher.LastName}, CAPACITY: {w.MaxParticipants}, LOCATION: {((InBuildingWks)w).Address}, ROOM: {((InBuildingWks)w).RoomNum}");
                        }
                        else
                        {
                            sw.WriteLine($"ONLINE - TITLE: {w.Title}, DESCRIPTION: {w.Topic}, TEACHER: {w.Teacher.FirstName} {w.Teacher.LastName}, CAPACITY: {w.MaxParticipants}, URL: {((OnlineWks)w).Link}");
                        }
                    }
                
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { if (sw != null) { sw.Close(); } }
        }

        public void WriteOneWorkshopToFile(string filename, Workshop wks)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Seek(0, SeekOrigin.End);
                sw = new StreamWriter(fs);


                if (wks is InBuildingWks)
                {
                    sw.WriteLine($"INBUILDING - TITLE: {wks.Title}, DESCRIPTION: {wks.Topic}, TEACHER: {wks.Teacher.FirstName} {wks.Teacher.LastName}, CAPACITY: {wks.MaxParticipants}, LOCATION: {((InBuildingWks)wks).Address}, ROOM: {((InBuildingWks)wks).RoomNum}");
                    sw.WriteLine("Participants:");
                }
                else
                {
                    sw.WriteLine($"ONLINE - TITLE: {wks.Title}, DESCRIPTION: {wks.Topic}, TEACHER: {wks.Teacher.FirstName} {wks.Teacher.LastName}, CAPACITY: {wks.MaxParticipants}, URL: {((OnlineWks)wks).Link}");
                    sw.WriteLine("Participants:");
                }
                foreach (Person p in wks.GetParticipants())
                {
                    sw.WriteLine($"NAME: {p.FirstName} {p.LastName} - PCN: {p.PCN}");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { if (sw != null) { sw.Close(); } }
        }
    }
}
