using System;
using System.Data;
using DebtManagment_DataAccessLayer;

namespace DebtManagment_BusinessLayer
{
    public class PaymentToSupplierRecord
    {
        int recordPaymentID { set; get; }
        int UserId { set; get; }
        public int SupplierID { set; get; }
        public double PayedAmount { set; get; }
        DateTime PaymentDate { set; get; }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public PaymentToSupplierRecord()
        {
            this.recordPaymentID = 0;
            this.UserId = 0;
            this.SupplierID = 0;
            this.PayedAmount = 0;
            this.PaymentDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private PaymentToSupplierRecord(int recordID, int userId, int supplierID, double amoutn, DateTime paymentDate)
        {
            this.recordPaymentID = recordID;
            UserId = userId;
            SupplierID = supplierID;
            PayedAmount = amoutn;
            PaymentDate = paymentDate;
            Mode = enMode.Update;
        }
        private bool _Add()
        {
            this.recordPaymentID = PaymentsToSupplier.AddNewPaymentToSupplier(ApplicationContext.CurrentUser.ID, SupplierID, PayedAmount, PaymentDate);
            return this.recordPaymentID != -1;

        }
        public static bool Delete(int id)
        {
            return PaymentsToSupplier.DeletePaymentToSupplier(id);
        }
        private bool _update()
        {

            return PaymentsToSupplier.UpdatePaymentToSupplier(this.recordPaymentID, PayedAmount);
        }

        public static PaymentToSupplierRecord Find(int SupplierPaymentID)
        {
            double PaymentAmount = 0;
            DateTime PaymentDate = DateTime.Now;
            int UserID = 0, SupplierID = 0;
            if (PaymentsToSupplier.GetPaymentToSupplierByID(SupplierPaymentID, ref UserID, ref SupplierID, ref PaymentAmount, ref PaymentDate))
            {
                return new PaymentToSupplierRecord(SupplierPaymentID, UserID, SupplierID, PaymentAmount, PaymentDate);
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
        public static DataTable GetAllPaymentsToCertainSupplier(int id)
        {
            return PaymentsToSupplier.GetAllPaymentsToCertainSupplier(id);
        }
        public static DataTable GetAllPaymentsToSupplier(int id)
        {
            return PaymentsToSupplier.GetAllPaymentsToCertainSupplier(id);
        }
        public static double GetTotalPaymentsForCertainClient(int supplierID)
        {
            return PaymentsToSupplier.GetTotalPaymentsToCertainSupplier(supplierID);
        }
        public static double GetTotalDebtsToSuppliers()
        {
            return PaymentsToSupplier.GetTotalPaymentsToSupplier();
        }


    }
}

