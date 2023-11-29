using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DebtManagment_DataAccessLayer; // refernecing the database Layer ,,,,
namespace DebtManagment_BusinessLayer      //[Logic]
{
    public class clsUser:clsPerson
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SSN { get; set; }
        public int Permissions { get; set; }
        public string ImagePath { set; get; }


        public clsUser()
        {
            this.UserName = "";
            this.Password = "";
            this.SSN = "";
            this.Permissions = 0;
            this.ImagePath = "";
        }

        private clsUser(int ID, string FullName,
            string Email, string phoneNumber, string Address,
            string userName,string password,string snn, 
            int permissions, string ImagePath):base(enMode.Update,ID, FullName, Email, phoneNumber,Address)

        {
            this.UserName = userName;
            this.Password = password;
            this.SSN = snn;
            this.Permissions = permissions;
            this.ImagePath = ImagePath;

        }

        private bool _AddNewUser()
        {
            // call DataAccess Layer

            this.ID = clsUser_Data.AddNewUser(this.FullName, this.Email, this.PhoneNumber,this.Address, this.SSN, this.ImagePath, this.UserName, this.Password, this.Permissions);

            return (this.ID != -1);
        }

        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUser_Data.UpdateUser(this.ID, this.FullName, this.Email, this.PhoneNumber, this.Address, this.SSN, this.ImagePath, this.UserName, this.Password, this.Permissions);

        }

        public static clsUser FindUserByUsernameAndPassword(string userName, string password)
        {
            int userID = -1, permissions = 0;
            string name = "", email = "", phone = "", address = "", ssn = "", personalPhoto = "";
            
            if (clsUser_Data.GetUserInfoByUsernameAndPassword(ref userID, ref name, ref email, ref phone,
            ref address, ref ssn, ref personalPhoto, userName, password, ref permissions))

                return new clsUser(userID, name, email, phone, address, userName, password, ssn, permissions, personalPhoto);

            else
                return null;

        }

        public static clsUser FindUserByID(int userID)
        {
            int permissions = 0;
            string name = "", email = "", phone = "", address = "", ssn = "", personalPhoto = "", userName = "", password = "";

            if (clsUser_Data.GetUserInfoByID(userID, ref name, ref email, ref phone,
            ref address, ref ssn, ref personalPhoto,ref userName,ref password, ref permissions))

                return new clsUser(userID, name, email, phone, address, userName, password, ssn, permissions, personalPhoto);

            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUser_Data.GetAllUsers();

        }

        public static bool DeleteUser(int ID)
        {
            return clsUser_Data.DeleteUser(ID);
        }

        public static bool isUserExist(int ID)
        {
            return clsUser_Data.IsUserExist(ID);
        }


        bool CheckAccessPermission(enUserPermissions OperationPermission)
        {
            //if (this.Permissions == (int)enPermissions.All)
            //    return true;

            //if (((int)OperationPermission & this.Permissions) == (int) OperationPermission)
            //    return true;
            //else
            //    return false;
            return OperationPermission.HasFlag((enUserPermissions)Permissions);

        }

        public void AddPermisson(enUserPermissions OperationPermission)
        {
            if (!OperationPermission.HasFlag((enUserPermissions)Permissions))
                this.Permissions += (int)OperationPermission;
        }

        public void RemovePermisson(enUserPermissions OperationPermission)
        {
            if (OperationPermission.HasFlag((enUserPermissions)Permissions))
                this.Permissions -= (int)OperationPermission;
        }
    }
}
