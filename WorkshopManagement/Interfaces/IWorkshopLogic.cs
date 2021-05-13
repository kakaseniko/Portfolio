using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IWorkshopLogic
    {
        void AddParticipantToWks(Workshop wks, Person p);
        void RemoveParticipantFromWks(Workshop wks, Person p);
        void StartWks(Workshop wks);
        int GenerateSeatNumber(Workshop wks);
        string GenerateLoginCode(Workshop wks, Person p);
        delegate void ParticipantsLimitHandler(Workshop wks);
        event ParticipantsLimitHandler ParticipantsLimitEvent;

    }
}
