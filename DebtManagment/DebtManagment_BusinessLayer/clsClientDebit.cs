using DebtManagment_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static DebtManagment_BusinessLayer.clsPerson;

namespace DebtManagment_BusinessLayer
{
    internal class clsClientDebit
    {
       public string Meterial { get; set; }
        public int idDebit { get; set; }
        public int UserID { get; set; }
        public int ClientID { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        enum enMode { AddNew=0, Update=1 }
        enMode Mode = enMode.AddNew;

        private clsClientDebit(string Meterial,int idDebit, int userID, int clientID, double payedAmount, DateTime paymentDate, enMode mood)
        {
            this.Meterial= Meterial;
            this.idDebit = idDebit;
            UserID = userID;
            ClientID = clientID;
            Amount = payedAmount;
            PaymentDate = paymentDate;
            this.Mode = enMode.Update;
        }

        public clsClientDebit()
        {
            this.Meterial = "";
            this.idDebit=-1;
            UserID = -1;
            ClientID = -1;
            Amount = 0;
            PaymentDate = DateTime.Today;
            this.Mode = enMode.AddNew;

        }

        private bool _Add()
        {
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
        //public static DataTable getAllrecords()
        //{

        //}
    }
}
