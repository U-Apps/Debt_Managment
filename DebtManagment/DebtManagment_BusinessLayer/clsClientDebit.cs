using DebtManagment_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static DebtManagment_BusinessLayer.clsPerson;

namespace DebtManagment_BusinessLayer
{
    internal class clsClientDebit
    {
       public string Material { get; set; }
        public int DebtID { get; set; }
        public int UserID { get; set; }
        public int ClientID { get; set; }
        public double DebtAmount { get; set; }
        public DateTime DebtDate { get; set; }
        enum enMode { AddNew=0, Update=1 }
        enMode Mode = enMode.AddNew;

        private clsClientDebit(string Meterial,int idDebit, int userID, int clientID, double payedAmount, DateTime paymentDate, enMode mood)
        {
            this.Material = Meterial;
            this.DebtID = idDebit;
            UserID = userID;
            ClientID = clientID;
            DebtAmount = payedAmount;
            DebtDate = paymentDate;
            this.Mode = enMode.Update;
        }

        public clsClientDebit()
        {
            this.Material = "";
            this.DebtID = -1;
            UserID = -1;
            ClientID = -1;
            DebtAmount = 0;
            DebtDate = DateTime.Today;
            this.Mode = enMode.AddNew;

        }

        private bool _Add()
        {
            if (clsClientsDebts_Data.AddNewClientDebt(UserID, ClientID, DebtAmount, Material , DebtDate ) != -1)
            {
                return true;
            }
            else { return false; }
        }
        public static bool delelte(int id)
        {
            return clsClientsDebts_Data.DeleteClientDebt(id);
        }
        private bool _update()
        {
            return clsClientsDebts_Data.UpdateClientDebt(this.DebtID, this.UserID, this.ClientID, this.DebtAmount, this.Material,this.DebtDate);
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

        public static DataTable GetAllDebtsForClient(int ClientID)
        {
            return clsClientsDebts_Data.GetAllDebtsForCertainClient(ClientID);
        }
        public static double GetTotalDebtsForClient(int ClientID)
        {
            return clsClientsDebts_Data.GetTotalDebtsForCertainClient(ClientID);
        }
        
    }
}
