using System;
using System.Data;
using DebtManagment_DataAccessLayer; // refernecing the database Layer ,,,,
namespace DebtManagment_BusinessLayer      //[Logic]
{
    public class clsUser : clsPerson
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SSN { get; set; }
        public int Permissions { get; set; }
        public byte[] ImgaeData { set; get; }


        public clsUser()
        {
            this.FullName = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.Address = "";
            this.UserName = "";
            this.Password = "";
            this.SSN = "";
            this.Permissions = 0;
            this.ImgaeData = new byte[] {};
        }

        private clsUser(int ID, string FullName,
            string Email, string phoneNumber, string Address,
            string userName,string password,string snn, 
            int permissions, byte[] ImageData):base(enMode.Update,ID, FullName, Email, phoneNumber,Address)

        {
            this.UserName = userName;
            this.Password = password;
            this.SSN = snn;
            this.Permissions = permissions;
            this.ImgaeData = ImageData;

        }

        private bool _AddNewUser()
        {
            // call DataAccess Layer

            this.ID = clsUser_Data.AddNewUser(this.FullName, this.Email, this.PhoneNumber,this.Address, this.SSN, this.ImgaeData, this.UserName, this.Password, this.Permissions);

            return (this.ID != -1);
        }

        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUser_Data.UpdateUser(this.ID, this.FullName, this.Email, this.PhoneNumber, this.Address, this.SSN, this.ImgaeData, this.Password, this.Permissions);

        }

        public static clsUser FindUserByUsernameAndPassword(string userName, string password)
        {
            int userID = -1, permissions = 0;
            string name = "", email = "", phone = "", address = "", ssn = "";
            byte [] personalPhoto = new byte[] {};
            
            if (clsUser_Data.GetUserInfoByUsernameAndPassword(ref userID, ref name, ref email, ref phone,
            ref address, ref ssn, ref personalPhoto, userName, password, ref permissions))

                return new clsUser(userID, name, email, phone, address, userName, password, ssn, permissions, personalPhoto);

            else
                return null;

        }

        public static clsUser FindUserByID(int userID)
        {
            int permissions = 0;
            string name = "", email = "", phone = "", address = "", ssn = "", userName = "", password = "";
            byte[] personalPhoto = new byte[] { };

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


        public  bool CheckAccessPermission(enUserPermissions OperationPermission)
        {
            //if (this.Permissions == (int)enPermissions.All)
            //    return true;

            //if (((int)OperationPermission & this.Permissions) == (int) OperationPermission)
            //    return true;
            //else
            //    return false;
            //return OperationPermission.HasFlag((enUserPermissions)Permissions);
            return ((enUserPermissions)Permissions).HasFlag(OperationPermission);

        }

        public void AddPermisson(enUserPermissions OperationPermission)
        {
            if (!((enUserPermissions)Permissions).HasFlag(OperationPermission))
                this.Permissions += (int)OperationPermission;
        }

        public void RemovePermisson(enUserPermissions OperationPermission)
        {
            if (OperationPermission.HasFlag((enUserPermissions)Permissions))
                this.Permissions -= (int)OperationPermission;
        }
    }
}
