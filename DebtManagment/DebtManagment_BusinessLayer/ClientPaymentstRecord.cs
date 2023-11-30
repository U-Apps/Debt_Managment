using DebtManagment_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DebtManagment_BusinessLayer.clsPerson;

namespace DebtManagment_BusinessLayer
{
    internal class ClientPaymentstRecord
    {
        int recordPaymentID { set; get; }
        int UserId {  set; get; }
        int ClientID { set; get; }
        double PayedAmount { set; get; }
        DateTime PaymentDate {  set; get; }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public ClientPaymentstRecord()
        {
            this.recordPaymentID = 0;
            this.UserId = 0;
            this.ClientID = 0;
            this.PayedAmount = 0;
            this.PaymentDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private ClientPaymentstRecord(int recordID, int userId, int clientID, double amoutn, DateTime paymentDate)
        {
            this.recordPaymentID = recordID;
            UserId = userId;
            ClientID = clientID;
            PayedAmount = amoutn;
            PaymentDate = paymentDate;
            Mode= enMode.Update;
        }
        private bool _Add()
        {
            //problem of UserID************
            this.recordPaymentID = clsClientsPayments_Data.AddNewClientPayment(UserId,ClientID,PayedAmount,PaymentDate);
            return this.recordPaymentID != -1;

        }
        public static bool Delete(int id)
        {
            return clsClientsPayments_Data.DeleteClientPayment(id);
        }
        private bool _update()
        {
           
            return clsClientsPayments_Data.UpdateClientPayment(this.recordPaymentID,UserId,ClientID,PayedAmount,PaymentDate);
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
                    return _update();



            }
            return false;


        }
        public static DataTable GetAllClientsPayments()
        {
            return clsClientsPayments_Data.GetAllClientsPayments();
        }

        public static double GetTotalPaymentsForCertainClient(int ClientID)
        {
            return clsClientsPayments_Data.GetTotalPaymentsForCertainClient(ClientID);
        }
  

    }
}
