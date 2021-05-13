using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class EnrollmentRequest
    {
        public Workshop Wks { get; private set; }
        public Person Person { get; private set; }
        public string status;

        public EnrollmentRequest(Workshop wks, Person p)
        {
            Wks = wks;
            Person = p;
            Status = "Pending";
        }
        public string Status
        {
            get { return this.status; }
            set
            {
                this.status = value;
            }
        }
        public override string ToString()
        {
            return $"Workshop: {Wks.Title} - {Wks.Time}, Requester: {Person.FirstName} {Person.LastName}, Status: {Status}";
        }
    }
}
