using System.Data;
using DebtManagment_DataAccessLayer;


using static DebtManagment_BusinessLayer.clsPerson;

namespace DebtManagment_BusinessLayer
{
    public class clsSupplier : clsPerson
    {
        
        public string Commercial_Registration { get; set; }

        public clsSupplier()

        {

            this.FullName = "";
            this.Email = "";
            this.Address = "";
            this.PhoneNumber = "";

            ID = -1;
            this.Commercial_Registration="";
            Mode = enMode.AddNew;

        }
        private clsSupplier(int SupplierId,string Commercial_registration, string name, string email, string PhoneNumber, string address,enMode mood) : base(mood,SupplierId,name, email, PhoneNumber, address)
        {
            this.ID = SupplierId;
            this.Commercial_Registration = Commercial_Registration;
            Mode = mood;



        }
        private bool _Add()
        {
            this.ID = clsSupplier_Data.AddNewSupplier(FullName, Email, PhoneNumber, Address, Commercial_Registration);
            return this.ID != -1;
        }
        public static bool Delete(int id)
        {
            return clsSupplier_Data.DeleteSupplier(id);
        }
        //private bool _update()
        //{
        //   return clsSupplier_Data.UpdateSupplier(this.ID, this.FullName, this.Email, this.PhoneNumber, this.Address, this.Commercial_Registration);
        //}

        private bool _update()
        {
            return clsSupplier_Data.UpdateSupplier(this.ID, this.FullName, this.Email, this.PhoneNumber, this.Address, this.Commercial_Registration);
        }
        public static clsSupplier Find(int SupplierId)
        {
            string FullName = "", Email = "", PhoneNumber = "", Address = "", Commercial_Registration="";
          
            enMode mode = enMode.Update;
            if (clsSupplier_Data.GetSupplierInfoByID(SupplierId, ref FullName, ref Email, ref PhoneNumber, ref Address, ref Commercial_Registration))
            {
                return new clsSupplier(SupplierId,Commercial_Registration, FullName, Email, PhoneNumber, Address,mode);

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
       
        public static DataTable GetAllSuppliers()
        {
            return clsSupplier_Data.GetAllSuppliers();
        }
    }
}
