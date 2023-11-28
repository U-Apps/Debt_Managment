using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtManagment_DataAccessLayer; // refernecing the database Layer ,,,,
namespace DebtManagment_BusinessLayer      //[Logic]
{
    public class clsUser:clsPerson
    {
        // this is flag
        [Flags]
        enum enPermissions
        {
            SuppliersManagemnt = 0b_0000_0001,
            ClientsManagemnt   = 0b_0000_0010,
            UsersManagemnt     = 0b_0000_0100,
            All = SuppliersManagemnt | ClientsManagemnt | UsersManagemnt

        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SNN { get; set; }
        public int Permissions { get; set; }
        public string ImagePath { set; get; }


        public clsUser()
        {
            this.UserName = "";
            this.Password = "";
            this.SNN = "";
            this.Permissions = 0;
            this.ImagePath = "";
        }

        private clsUser(int ID, string FullName,
            string Email, List<string> phoneNumbers, string Address,
            int CountryID,string userName,string password,string snn, 
            int permissions, string ImagePath):base(enMode.Update,ID, FullName, Email, phoneNumbers,Address)

        {
            this.UserName = userName;
            this.Password = password;
            this.SNN = snn;
            this.Permissions = permissions;
            this.ImagePath = ImagePath;

        }

        private bool _AddNewUser()
        {
            // call DataAccess Layer

            this.ID = clsUserData.AddNewUser(this.FullName, this.Email, this.PhoneNumbers, this.SNN, this.ImagePath, this.UserName, this.Password,this.Password, this.Permissions);

            return (this.ID != -1);
        }

        //private bool _UpdateUser()
        //{
        //    //call DataAccess Layer 

        //    //return clsUserData.UpdateUser();

        //}

        //public static clsUser Find(int ID)
        //{

        //    string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
        //    DateTime DateOfBirth = DateTime.Now;
        //    int CountryID = -1;

        //    if (clsContactDataAccess.GetContactInfoByID(ID, ref FirstName, ref LastName,
        //                  ref Email, ref Phone, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath))

        //        return new clsUser(ID, FirstName, LastName,
        //                   Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
        //    else
        //        return null;
        //}

        //public bool Save()
        //{


        //    switch (Mode)
        //    {
        //        case enMode.AddNew:
        //            if (_AddNewUser())
        //            {

        //                Mode = enMode.Update;
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //        case enMode.Update:

        //            return _UpdateUser();

        //    }




        //    return false;
        //}

        //public static DataTable GetAllContacts()
        //{
        //    return clsContactDataAccess.GetAllContacts();

        //}

        //public static bool DeleteContact(int ID)
        //{
        //    return clsContactDataAccess.DeleteContact(ID);
        //}

        //public static bool isContactExist(int ID)
        //{
        //    return clsContactDataAccess.IsContactExist(ID);
        //}


        bool CheckAccessPermission(enPermissions OperationPermission)
        {
            //if (this.Permissions == (int)enPermissions.All)
            //    return true;

            //if (((int)OperationPermission & this.Permissions) == (int) OperationPermission)
            //    return true;
            //else
            //    return false;
            return OperationPermission.HasFlag((enPermissions)Permissions);

        }
    }
}
