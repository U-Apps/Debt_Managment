using DebtManagment_DataAccessLayer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DebtManagment_BusinessLayer.clsPerson;

namespace DebtManagment_BusinessLayer
{
    public class clsClint : clsPerson
    {
        public int ClientId { get; set; }
        public int Classification { get; set; }
        public double RemainderAmount { get; set; }
        public string SSN { get; set; }
        public string Commercial_Registration { get; set; }
        public clsClint()

        {
            ClientId = -1;
            this.SSN = "";
            this.Commercial_Registration = "";
            Classification = -1;
            RemainderAmount = 0;
            Mode = enMode.AddNew;
        }
        private clsClint(int clientId , string name, string email, string PhoneNumber, string address, int classification, double remainderAmount, string Commercial_Registration, string SSN) : base(name, email, PhoneNumber, address)
        {
            this.ClientId = clientId;
            Classification = classification;
            RemainderAmount = remainderAmount;
            this.Commercial_Registration = Commercial_Registration;
            this.SSN = SSN;
            this.Mode = enMode.Update;
        }
        private bool _Add()
        {
           if(clsClient_Data.AddNewClient(FullName, Email, PhoneNumber , Address, SSN,
              Commercial_Registration, Classification, RemainderAmount) != -1)
            {
                return true;
            }
           else { return false; }
        }

        public static bool Delete(int ClientId)
        {
           return clsClient_Data.DeleteClient(ClientId);
        }

        private bool _update()
        {
            return clsClient_Data.UpdateClient(this.ClientId, this.FullName, this.Email, this.PhoneNumber, this.Address, this.SSN, this.Commercial_Registration, this.Classification, this.RemainderAmount);
        }
        public static clsClint Find(int clientId)
        {
            string FullName="" , Email = "", PhoneNumber = "", Address = "", SSN = "", Commercial_Registration ="";
            int Classification = 0;
            double remainderAmount = 0;

            if (clsClient_Data.GetClientInfoByID(clientId, ref FullName,ref Email, ref PhoneNumber, ref Address,ref SSN,ref Commercial_Registration,ref Classification,ref remainderAmount))

                return new clsClint(clientId,FullName, Email, PhoneNumber, Address, Classification,remainderAmount,Commercial_Registration,SSN);
            else
                return null;
        }


        //public bool search()
        //{

        //}


        public override bool Save()
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
        public static DataTable getAllClint()
        {
            return clsClient_Data.GetAllClients();
        }
    }
} 
