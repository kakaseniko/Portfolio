using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEnrollmentRequest
    {
        void AddER(EnrollmentRequest er);
        List<EnrollmentRequest> GetAllER();
        void SetERStatus(EnrollmentRequest er, string status);
        delegate void EnrollmentRequestHandler(EnrollmentRequest er);
        event EnrollmentRequestHandler EnrollmentRequestEvent;
        delegate void EnrollmentRequestStatusHandler(EnrollmentRequest er);
        event EnrollmentRequestStatusHandler EnrollmentRequestStatusChangeEvent;
    }
}
