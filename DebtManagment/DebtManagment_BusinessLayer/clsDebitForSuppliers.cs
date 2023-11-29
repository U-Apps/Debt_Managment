using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DebtManagment_DataAccessLayer;

namespace DebtManagment_BusinessLayer
{
    class clsDebitForSuppliers
    {
        public int DebitID { get; private set; }
        public int UserID { get; private set; }
        public int SupplierID { get; set; }
        public double Amount { get; set; }
        public string Material { get; set; }
        public DateTime DebitDate { get; set; }
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        private clsDebitForSuppliers(int debitID, int userID, int clientID, double payedAmount, string material, DateTime paymentDate, enMode mood)
        {
            this.DebitID = debitID;
            this.UserID = userID;
            this.SupplierID = clientID;
            this.Amount = payedAmount;
            this.Material = material;
            this.DebitDate = paymentDate;
            this.Mode = enMode.Update;
        }

        public clsDebitForSuppliers()
        {
            this.DebitID = -1;
            UserID = -1;
            SupplierID = -1;
            Amount = 0;
            this.Material = "";
            DebitDate = DateTime.Today;
            this.Mode = enMode.AddNew;

        }

        private bool _AddNewDebit()
        {
            this.DebitID = clsDebtsToSuppliers.AddNewSupplierDebt(ApplicationContext.CurrentUser.ID, this.SupplierID, this.Amount, this.Material, this.DebitDate);

            return (this.DebitID != -1);
        }
        public static bool DeleteDebit(int id)
        {
            return clsDebtsToSuppliers.DeleteSupplierDebt(id);
        }
        private bool _updateDebit()
        {
            return clsDebtsToSuppliers.UpdateSupplierDebt(this.DebitID, this.UserID, this.SupplierID, this.Amount, this.Material, this.DebitDate);
        }

        //public bool search()
        //{

        //}
        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDebit())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _updateDebit();

            }
            return false;


        }
        public static DataTable GetAllDebitsForCertainSupplier(int supplierID)
        {
            return clsDebtsToSuppliers.GetAllDebtsToCertainSupplier(supplierID);
        }

        public static double GetTotalDebtsToCertainSupplier(int supplierID)
        {
            return clsDebtsToSuppliers.GetTotalDebtsToCertainSupplier(supplierID);
        }
    }
}
