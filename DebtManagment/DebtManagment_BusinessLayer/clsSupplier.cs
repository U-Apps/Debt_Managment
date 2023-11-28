using DebtManagment_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static DebtManagment_BusinessLayer.clsPerson;

namespace DebtManagment_BusinessLayer
{
    internal class clsSupplier : clsPerson
    {
        public int SupplierId { set; get; } 
        public int Commercial_Registration { get; set; }

        public clsSupplier()

        {
            SupplierId = -1;
            this.Commercial_Registration=0;
            Mode = enMode.AddNew;

        }
        private clsSupplier(int SupplierId,int Commercial_registration, string name, string email, string PhoneNumber, string address) : base(name, email, PhoneNumber, address)
        {
            this.SupplierId = SupplierId;
            this.Commercial_Registration = Commercial_Registration;
            Mode = enMode.Update;



        }
        private bool _Add()
        {
            if (clsSupplierData.AddNewSupplier(FullName,Email,PhoneNumber,Address,Commercial_Registration)!= -1)
            {
                return true;
            }
            else { return false; }
        }
        public static bool Delete(int id)
        {
            return clsSupplierData.DeleteSupplier(id);
        }
        private bool _update()
        {
           return clsSupplierData.UpdateSupplier(this.SupplierId, this.FullName, this.Email, this.PhoneNumber, this.Address, this.Commercial_Registration);
        }
        public static clsSupplier Find(int SupplierId)
        {
            string FullName = "", Email = "", PhoneNumber = "", Address = "";
            int Commercial_Registration = 0;
            if (clsSupplierData.GetSupplierInfoByID(SupplierId, ref FullName, ref Email, ref PhoneNumber, ref Address, ref Commercial_Registration))
            {
                return new clsSupplier(SupplierId,Commercial_Registration, FullName, Email, PhoneNumber, Address);

            }
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
       
        public static DataTable GetAllSupplier()
        {
            return clsSupplierData.GetAllSuppliers();
        }
    }
}
