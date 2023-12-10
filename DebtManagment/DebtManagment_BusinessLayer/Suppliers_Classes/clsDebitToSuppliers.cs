using System;

using System.Data;
using DebtManagment_DataAccessLayer;

namespace DebtManagment_BusinessLayer
{
    public class clsDebitToSuppliers
    {
        public int DebitID { get; private set; }
        public int UserID { get; private set; }
        public int SupplierID { get; set; }
        public double Amount { get; set; }
        public string Material { get; set; }
        public DateTime DebitDate { get; set; }
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        private clsDebitToSuppliers(int debitID, int userID, int clientID, double payedAmount, string material, DateTime paymentDate, enMode mood)
        {
            this.DebitID = debitID;
            this.UserID = userID;
            this.SupplierID = clientID;
            this.Amount = payedAmount;
            this.Material = material;
            this.DebitDate = paymentDate;
            this.Mode = enMode.Update;
        }

        public clsDebitToSuppliers()
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
            this.DebitID = clsDebtsToSuppliers_Data.AddNewSupplierDebt(ApplicationContext.CurrentUser.ID, this.SupplierID, this.Amount, this.Material);

            return (this.DebitID != -1);
        }
        public static bool DeleteDebit(int id)
        {
            return clsDebtsToSuppliers_Data.DeleteSupplierDebt(id);
        }
        private bool _updateDebit()
        {
            return clsDebtsToSuppliers_Data.UpdateSupplierDebt(this.DebitID, this.Amount, this.Material);
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

        public static bool delelte(int id)
        {
            return clsDebtsToSuppliers_Data.DeleteSupplierDebt(id);
        }
        private bool _update()
        {
            //problem of UserID************
            return clsDebtsToSuppliers_Data.UpdateSupplierDebt(this.DebitID, this.Amount, this.Material);
        }

        public static clsDebitToSuppliers Find(int DebtToSupplierByID)
        {
            double DebtAmount = 0;
            string Material = "";
            DateTime DebtDate = DateTime.Now;
            int UserID = 0, SupplierID = 0;
            if (clsDebtsToSuppliers_Data.GetDebtToSupplierByID(DebtToSupplierByID, ref DebtAmount, ref DebtDate, ref Material, ref SupplierID, ref UserID))
            {
                return new clsDebitToSuppliers(DebtToSupplierByID, UserID,SupplierID, DebtAmount, Material, DebtDate, enMode.Update);
            }
            else
                return null;
        }

        public static DataTable GetAllDebtsToSuppliers()
        {
            return clsDebitToSuppliers.GetAllDebtsToSuppliers();
        }
        public static DataTable GetAllDebitsForCertainSupplier(int supplierID)
        {
            return clsDebtsToSuppliers_Data.GetAllDebtsToCertainSupplier(supplierID);
        }

        public static double GetTotalDebtsToCertainSupplier(int supplierID)
        {
            return clsDebtsToSuppliers_Data.GetTotalDebtsToCertainSupplier(supplierID);
        }
        public static double GetTotalDebtsToSuppliers()
        {
            return clsDebtsToSuppliers_Data.GetTotalDebtsToSuppliers();
        }
    }
}
