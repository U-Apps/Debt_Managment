using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtManagment_BusinessLayer;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer.Suppliers
{
    public partial class frmAddSupplier : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _SupplierID;
        clsSupplier _Supplier;

        public frmAddSupplier(int SupID)
        {
            InitializeComponent();
            _SupplierID = SupID;

            if (_SupplierID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
            
        }

       
        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_SuppliersName.Text.Trim();
            string PhoneNumber = txt_SuppliersPhone.Text.Trim();
            string Email = txt_SuppliersEmail.Text.Trim();
            string Address = txt_SuppliersAdress.Text.Trim();
            string Commercial_Registration = txt_SuppliersCommecial.Text.Trim();



            //if (!(clsValidatePatterns.IsMatch(clsValidatePatterns.FullNamPatterne, ref name) &&
            //    clsValidatePatterns.IsMatch(clsValidatePatterns.PhoneNumberPattern, ref PhoneNumber) &&
            //    clsValidatePatterns.IsMatch(clsValidatePatterns.EmailPattern, ref Email) &&
            //    clsValidatePatterns.IsMatch(clsValidatePatterns.AddressPattern, ref Address) &&
            //    clsValidatePatterns.IsMatch(clsValidatePatterns.IdentityNumberPattern, ref Commercial_Registration)
            //    ))
            //{
            //    new Notification("أحد الحقول خاطئة").Show();
            //    return;
            //}

            //string ErrorMsg ="";
            //if(!clsValidatePatterns.IsMatch(clsValidatePatterns.FullNamPatterne,ref name))
            //{
            //    ErrorMsg = $"{lblSupplierName.Text} is Incorrect formate!";
            //    new Notification(ErrorMsg).Show();
            //    return;
            //}
            //if (!clsValidatePatterns.IsMatch(clsValidatePatterns.PhoneNumberPattern, ref PhoneNumber))
            //{
            //    ErrorMsg = $"{lblPhone.Text} is Incorrect formate";
            //    new Notification(ErrorMsg).Show();
            //    return;
            //}
            //if (!clsValidatePatterns.IsMatch(clsValidatePatterns.AddressPattern, ref Address))
            //{
            //    ErrorMsg = $"{lblAddress.Text} is Incorrect formate!";
            //    new Notification(ErrorMsg).Show();
            //    return;
            //}
            //if (!clsValidatePatterns.IsMatch(clsValidatePatterns.EmailPattern, ref Email))
            //{
            //    ErrorMsg = $"{lblEmail.Text} is Incorrect formate!";
            //    new Notification(ErrorMsg).Show();
            //    return;
            //}
            //if (!clsValidatePatterns.IsMatch(clsValidatePatterns.IdentityNumberPattern, ref Commercial_Registration))
            //{
            //    ErrorMsg = $"{lblCommercial.Text} is Incorrect formate!";
            //    new Notification(ErrorMsg).Show();
            //    return;
            //}

            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.FullNamPatterne, ref name))
            {
                //ErrorMsg = $"{lblSupplierName.Text} is Incorrect formate!";
                txt_SuppliersName.BorderColor = Color.Red;
                txt_SuppliersName.Clear();
                txt_SuppliersName.PlaceholderText = "خطا في الادخال";


                //new Notification(ErrorMsg).Show();
                return;
            }
            else txt_SuppliersName.BorderColor = Color.White;
            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.PhoneNumberPattern, ref PhoneNumber))
            {
                //ErrorMsg = $"{lblPhone.Text} is Incorrect formate";
                txt_SuppliersPhone.BorderColor = Color.Red;
                txt_SuppliersPhone.Clear();
                txt_SuppliersPhone.PlaceholderText = "خطا في الادخال";


                return;
            }
            else txt_SuppliersPhone.BorderColor = Color.White;

            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.AddressPattern, ref Address))
            {
                //ErrorMsg = $"{lblAddress.Text} is Incorrect formate!";
                txt_SuppliersAdress.BorderColor = Color.Red;
                txt_SuppliersAdress.Clear();
                txt_SuppliersAdress.PlaceholderText = "خطا في الادخال";

                //new Notification(ErrorMsg).Show();
                return;
            }
            txt_SuppliersAdress.BorderColor = Color.White;
            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.EmailPattern, ref Email))
            {
                //ErrorMsg = $"{lblEmail.Text} is Incorrect formate!";
                txt_SuppliersEmail.BorderColor = Color.Red;
                txt_SuppliersEmail.Clear();
                txt_SuppliersEmail.PlaceholderText = "خطا في الادخال";
                //new Notification(ErrorMsg).Show();
                return;
            }
            else txt_SuppliersEmail.BorderColor = Color.White;
            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.IdentityNumberPattern, ref Commercial_Registration))
            {
                //ErrorMsg = $"{lblCommercial.Text} is Incorrect formate!";
                txt_SuppliersCommecial.BorderColor = Color.Red;
                txt_SuppliersCommecial.Clear();
                txt_SuppliersCommecial.PlaceholderText = "خطا في الادخال";
                //new Notification(ErrorMsg).Show();
                return;
            }
            else txt_SuppliersCommecial.BorderColor = Color.White;




            _Supplier.FullName = name;
            _Supplier.PhoneNumber =PhoneNumber;
            _Supplier.Email = Email;
            _Supplier.Address = Address;
            _Supplier.Commercial_Registration = Commercial_Registration;

           


            if (_Supplier.Save())
            {
                new Notification("تم الحفظ").Show();
            }
            else
            {
                // new Notification(" خطأء. فشلت العملية").Show();
            }

            this.Close();



        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                //label5.Text = "اضافة مورد";
                _Supplier = new clsSupplier();
                return;
            }
            //label5.Text = "تعديل بيانات مورد";

            _Supplier = clsSupplier.Find(_SupplierID);

            if (_Supplier == null)
            {
                new Notification("This form will be closed because No Supplier with ID = " + _SupplierID).Show();
                this.Close();

                return;
            }



            txt_SuppliersName.Text =   _Supplier.FullName;
            txt_SuppliersPhone.Text =  _Supplier.PhoneNumber;
            txt_SuppliersEmail.Text =  _Supplier.Email;
            txt_SuppliersAdress.Text = _Supplier.Address;
            txt_SuppliersCommecial.Text = _Supplier.Commercial_Registration;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
