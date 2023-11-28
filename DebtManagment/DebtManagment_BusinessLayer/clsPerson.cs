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

        //public int PersonID { set; get; }
        public string FullName { set; get; }

        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Address { set; get; }

        protected clsPerson(string fullname, string email, string phoneNumber, string address)
        {
            Mode=enMode.Update;
            //PersonID = iD;
            FullName = fullname;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        protected clsPerson()
        {
            
            //PersonID= -1;
            FullName = "";
            Email = "";
            PhoneNumber = null;
            Address = "";
            Mode = enMode.AddNew;
        }
        //public abstract bool add();
        //public static bool delelte(int id)
        //{
        //    if (isExist(id))
        //    {

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public abstract bool update();

        

        //public abstract bool search();

        public abstract bool Save();



    }
}
