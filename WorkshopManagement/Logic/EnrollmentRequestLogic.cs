using Classes;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EnrollmentRequestLogic : IEnrollmentRequest
    {
        public event IEnrollmentRequest.EnrollmentRequestHandler EnrollmentRequestEvent;
        public event IEnrollmentRequest.EnrollmentRequestStatusHandler EnrollmentRequestStatusChangeEvent;
        List<EnrollmentRequest> ers;

        public EnrollmentRequestLogic()
        {
            ers = new List<EnrollmentRequest>();
        }

        public void AddER(EnrollmentRequest er)
        {
            foreach(EnrollmentRequest e in ers)
            {
                if(e.Wks.ID == er.Wks.ID && e.Person.PCN == er.Person.PCN)
                {
                    throw new Exception("You already requested to enroll to this workshop.");
                }
            }
            ers.Add(er);
            if(EnrollmentRequestEvent != null)
            {
                EnrollmentRequestEvent(er);
            }
        }

        public List<EnrollmentRequest> GetAllER()
        {
            return ers;
        }

        public void SetERStatus(EnrollmentRequest er, string status)
        {
            er.Status = status;
            if(EnrollmentRequestStatusChangeEvent != null)
            {
                EnrollmentRequestStatusChangeEvent(er);
            }
        }
    }
}
