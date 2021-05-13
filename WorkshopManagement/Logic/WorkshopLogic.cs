using Classes;
using DataAccess;
using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class WorkshopLogic : IWorkshopLogic
    {
        
        public event IWorkshopLogic.ParticipantsLimitHandler ParticipantsLimitEvent;

        public WorkshopLogic()
        {           
        }

        public void AddParticipantToWks(Workshop wks, Person p)
        {
            wks.AddParticipant(p);
            if (wks.GetParticipants().Count >= (wks.MaxParticipants * 0.9))
            {
                if (ParticipantsLimitEvent != null)
                {
                    ParticipantsLimitEvent(wks);
                }
            }
            AddAttendance(wks, p);          
        }
        public void RemoveParticipantFromWks(Workshop wks, Person p)
        {
            p.RemoveAttendance(wks);
            wks.RemoveParticipant(p);           
        }

       
        public string GenerateLoginCode(Workshop wks, Person p)
        {
            return $"WKS{wks.ID}P{p.PCN}C{wks.GetParticipants().Count}";
        }

        public int GenerateSeatNumber(Workshop wks)
        {
            return wks.GetParticipants().Count;
        }

        public void StartWks(Workshop wks)
        {
            wks.StartWorkshop();
        }

        private void AddAttendance(Workshop wks, Person p)
        {
            if (wks is OnlineWks)
            {
                p.AddAttendance(new Attendance(wks, GenerateLoginCode(wks, p)));
                return;
            }
            p.AddAttendance(new Attendance(wks, GenerateSeatNumber(wks)));
        }


    }
}
