using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagment_BusinessLayer
{
    class clsDebitToSuppliers
    {
        public int DebitID { get; set; }
        public int UserID { get; set; }
        public int SupplierID { get; set; }
        public double Amount { get; set; }
        public string Material { get; set; }
        public DateTime DebtDate { get; set; }
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        private clsDebitToSuppliers(int debitID, int userID, int clientID, double payedAmount, string material, DateTime paymentDate, enMode mood)
        {
            this.DebitID = debitID;
            this.UserID = userID;
            this.SupplierID = clientID;
            this.Amount = payedAmount;
            this.Material = material;
            this.DebtDate = paymentDate;
            this.Mode = enMode.Update;
        }

        public clsDebitToSuppliers()
        {
            this.DebitID = -1;
            UserID = -1;
            SupplierID = -1;
            Amount = 0;
            this.Material = "";
            DebtDate = DateTime.Today;
            this.Mode = enMode.AddNew;

        }

        private bool _Add()
        {
            return true;
            //if (clsClientData.AddNewClient(FullName, Email, PhoneNumber, Address, SSN,
            //   Commercial_Registration, Classification, RemainderAmount) != -1)
            //{
            //    return true;
            //}
            //else { return false; }
        }
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
        private bool _update()
        {
            return true;
            //return clsContactDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone,
            //   this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
        }

        //public bool search()
        //{

        //}
        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    break;

                    //return/* _UpdateContact()*/;



            }
            return false;


        }
        //public static DataTable getAllRecords()
        //{

        //}
    }
}
