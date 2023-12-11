using System;
using System.Data;
using DebtManagment_DataAccessLayer;

using static DebtManagment_BusinessLayer.clsPerson;

namespace DebtManagment_BusinessLayer
{
    public class ClientPaymentstRecord
    {
        int recordPaymentID { set; get; }
        public int UserId { set; get; }
        public int ClientID { set; get; }
        public double PayedAmount { set; get; }
        public DateTime PaymentDate {  set; get; }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public ClientPaymentstRecord()
        {
            this.recordPaymentID = -1;
            UserId = ApplicationContext.CurrentUser.ID;
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
            this.recordPaymentID = clsClientsPayments_Data.AddNewClientPayment(UserId,ClientID,PayedAmount);
            return this.recordPaymentID != -1;

        }
        public static bool Delete(int id)
        {
            return clsClientsPayments_Data.DeleteClientPayment(id);
        }
        private bool _update()
        {
           
            return clsClientsPayments_Data.UpdateClientPayment(this.recordPaymentID,PayedAmount);
        }

        public static ClientPaymentstRecord Find(int ClientPaymentID)
        {
            double PaymentAmount = 0;
            DateTime PaymentDate = DateTime.Now;
            int UserID = 0, ClientID = 0;
            if (clsClientsPayments_Data.GetClientPaymentByID(ClientPaymentID, ref UserID, ref ClientID ,ref PaymentAmount, ref PaymentDate ))
            {
                return new ClientPaymentstRecord(ClientPaymentID, UserID, ClientID, PaymentAmount, PaymentDate);
            }
            else
                return null;
        }
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
        public static DataTable GetAllClientPayments(int ClientID)
        {
            return clsClientsPayments_Data.GetAllClientPayments(ClientID);
        }
        public static double GetTotalPaymentsForCertainClient(int ClientID)
        {
            return clsClientsPayments_Data.GetTotalPaymentsForCertainClient(ClientID);
        }
        public static double GetTotalPaymentsForClients()
        {
            return clsClientsPayments_Data.GetTotalPaymentsForClients();
        }


    }
}
