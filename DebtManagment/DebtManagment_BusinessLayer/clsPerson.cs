using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagment_BusinessLayer
{
    public abstract class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string FullName { set; get; }

        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }

        protected clsPerson(enMode mode, int iD, string fullNme, string email, string phoneNumber, string address)
        {
            Mode = mode;
            ID = iD;
            FullName = fullNme;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        protected clsPerson()
        {
            Mode = enMode.AddNew;
            ID = -1;
            FullName = "";
            Email = "";
            PhoneNumber = "";
            Address = "";
        }
    }

}
