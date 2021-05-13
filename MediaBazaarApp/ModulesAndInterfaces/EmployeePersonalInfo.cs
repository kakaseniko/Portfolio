using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ModulesAndInterfaces.CustomExceptions;

namespace ModulesAndInterfaces
{
    [Serializable]
    public class EmployeePersonalInfo
    {
        //Properties
        public DateTime DateOfBirth { get; private set; }
        private string phoneNumber;

        public Address Address { get; private set; }

        private string email;

        private string bsn;

        public string ICEName { get; private set; }

        private string iCEPhone;

        public string Password { get; set; }

        public EmployeePersonalInfo(DateTime dateOfBirth, string phoneNumber, Address address, string email, string bsn, string iceName, string icePhone)
        {
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            BSN = bsn;
            ICEName = iceName;
            ICEPhone = icePhone;
            Password = "password";
        }
        public EmployeePersonalInfo(DateTime dateOfBirth, string phoneNumber, Address address, string email, string bsn, string iceName, string icePhone, string password)
        {
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            BSN = bsn;
            ICEName = iceName;
            ICEPhone = icePhone;
            Password = password;
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (Regex.IsMatch(value, @"\b06\d{8}\b"))
                {
                    this.phoneNumber = value;
                }
                else
                {
                    throw new InvalidPhoneNumEx(value);
                }
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (Regex.IsMatch(value, @"\b\w*@\w*\.[a-z]*\b"))
                {
                    this.email = value;
                }
                else
                {
                    throw new InvalidEmailEx(value);
                }
            }
        }
        public string ICEPhone
        {
            get { return this.iCEPhone; }
            set
            {
                if (Regex.IsMatch(value, @"\b06\d{8}\b"))
                {
                    this.iCEPhone = value;
                }
                else
                {
                    throw new InvalidPhoneNumEx(value);
                }
            }
        }
        public string BSN
        {
            get { return this.bsn; }
            set
            {
                if (Regex.IsMatch(value, @"^\d{9}$"))
                {
                    this.bsn = value;
                }
                else
                {
                    throw new CustomExceptions.InvalidBSNEx(value);
                }
            }
        }

    }
}
