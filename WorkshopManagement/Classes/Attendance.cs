using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Attendance
    {
        public Workshop Wks { get; private set; }
        public int SeatNumber { get; private set; }
        public string LoginCode { get; private set; }

        public Attendance(Workshop wks, int seatnum)
        {
            Wks = wks;
            SeatNumber = seatnum;
        }
        public Attendance(Workshop wks, string logincode)
        {
            Wks = wks;
            LoginCode = logincode;
        }
        public override string ToString()
        {
            if(LoginCode != null)
            {
                return $"{Wks.Title} - LOGIN_CODE: {LoginCode}";
            }
            return $"{Wks.Title} - SEAT_NUMBER: {SeatNumber}";
        }
    }
}
