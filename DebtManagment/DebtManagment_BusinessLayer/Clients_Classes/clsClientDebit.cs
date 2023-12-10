using System;
using System.Data;
using DebtManagment_DataAccessLayer;

using static DebtManagment_BusinessLayer.clsPerson;

namespace DebtManagment_BusinessLayer
{
    public class clsClientDebit
    {
        public int DebtID { get; private set; }
        public string Material { get; set; }
        // public int UserID { get; private set; }
        public int UserID = DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.ID;
        public int ClientID { get; set; }
        public double DebtAmount { get; set; }
        public DateTime DebtDate { get; set; }
        enum enMode { AddNew=0, Update=1 }
        enMode Mode = enMode.AddNew;

        private clsClientDebit(string Meterial,int idDebit, int userID, int clientID, double DebtAmount, DateTime DebtDate, enMode mood)
        {
            this.Material = Meterial;
            this.DebtID = idDebit;
            UserID = userID;
            ClientID = clientID;
            this.DebtAmount = DebtAmount;
            this.DebtDate = DebtDate;
            this.Mode = enMode.Update;
        }

        public clsClientDebit()
        {
            this.Material = "";
            this.DebtID = -1;
            UserID = -1;
            ClientID = -1;
            DebtAmount = 0;
            DebtDate = DateTime.Now;
            this.Mode = enMode.AddNew;

        }

        private bool _Add()
        {
            //problem of UserID************
            this.DebtID = clsClientsDebts_Data.AddNewClientDebt(ApplicationContext.CurrentUser.ID, ClientID, DebtAmount, Material);
            return this.DebtID != -1;
           
        }
        public static bool delelte(int id)
        {
            return clsClientsDebts_Data.DeleteClientDebt(id);
        }
        private bool _update()
        {
            //problem of UserID************
            return clsClientsDebts_Data.UpdateClientDebt(this.DebtID,  this.DebtAmount, this.Material);
        }

        public static clsClientDebit Find(int ClientDebtID)
        {
            double DebtAmount = 0;
            string Material = "";
            DateTime DebtDate = DateTime.Now;
            int UserID =0, ClientID =0;
            if (clsClientsDebts_Data.GetClientDebtByID(ClientDebtID,ref DebtAmount,ref DebtDate,ref Material,ref ClientID,ref UserID))
            {
                return new clsClientDebit(Material, ClientDebtID, UserID, ClientID, DebtAmount, DebtDate, enMode.Update);
            }
            else
                return null;
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
        public DataTable GetAllClientsDebts()
        {
            return clsClientsDebts_Data.GetAllClientsDebts();
        }

        public static DataTable GetAllDebtsForCertainClient(int ClientID)
        {
            return clsClientsDebts_Data.GetAllDebtsForCertainClient(ClientID);
        }
        public static double GetTotalDebtsForCertainClient(int ClientID)
        {
            return clsClientsDebts_Data.GetTotalDebtsForCertainClient(ClientID);
        }
        public static double GetTotalDebtsForClients()
        {
            return clsClientsDebts_Data.GetTotalDebtsForClients();
        }

    }
}
