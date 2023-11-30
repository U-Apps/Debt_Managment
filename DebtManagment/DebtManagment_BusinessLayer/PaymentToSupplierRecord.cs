using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DebtManagment_DataAccessLayer;

namespace DebtManagment_BusinessLayer
{
    class PaymentToSupplierRecord
    {
        int recordPaymentID { set; get; }
        int UserId { set; get; }
        int SupplierID { set; get; }
        double PayedAmount { set; get; }
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
            this.recordPaymentID = PaymentsToSupplier.AddNewPaymentToSupplier(UserId, SupplierID, PayedAmount, PaymentDate);
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
        public  DataTable GetAllPaymentsToCertainSupplier(int id)
        {
            return PaymentsToSupplier.GetAllPaymentsToCertainSupplier(id);
        }
        public DataTable GetAllPaymentsToSupplier()
        {
            return PaymentsToSupplier.GetAllPaymentsToSupplier();
        }
        public static double GetTotalPaymentsForCertainClient(int supplierID)
        {
            return PaymentsToSupplier.GetTotalPaymentsToCertainSupplier(supplierID);
        }


    }
}
}
