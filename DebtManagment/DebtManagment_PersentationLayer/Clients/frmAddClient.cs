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

namespace DebtManagment_PersentationLayer.Clients
{
    public partial class frmAddClient : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode ;

        int _ClientID;
        clsClint _Client;
        public frmAddClient(int ClientID)
        {
            InitializeComponent();

            _ClientID = ClientID;

            if (_ClientID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void btn_SaveClient_Click(object sender, EventArgs e)
        {

            string name = txt_CoustmerName.Text.Trim();
            string PhoneNumber = txt_CustomerPhone.Text.Trim();
            string Email = txt_CoustmerEmail.Text.Trim();
            string Address = txt_CoustmerAdress.Text.Trim();
           string SSN = txt_SSN.Text.Trim();
            string Commercial_Registration = txt_commecial.Text.Trim();
            if (!(clsValidatePatterns.IsMatch(clsValidatePatterns.FullNamPatterne, ref name) &&
                clsValidatePatterns.IsMatch(clsValidatePatterns.PhoneNumberPattern, ref PhoneNumber)  &&
                clsValidatePatterns.IsMatch(clsValidatePatterns.EmailPattern, ref Email) &&
                clsValidatePatterns.IsMatch(clsValidatePatterns.AddressPattern, ref Address)
                ))
            {
                new Notification("أحد الحقول خاطئة").Show();
                return;
            }


            _Client.FullName = txt_CoustmerName.Text;
            _Client.PhoneNumber = txt_CustomerPhone.Text;
            _Client.Email = txt_CoustmerEmail.Text;
            _Client.Address = txt_CoustmerAdress.Text;

            if (rdPerson.Checked)
            {
                if(!clsValidatePatterns.IsMatch(clsValidatePatterns.IdentityNumberPattern, ref SSN))
                {
                    new Notification("SSN خاطئ").Show();
                }
                _Client.Classification = 1;
                _Client.SSN = txt_SSN.Text;
                _Client.Commercial_Registration = "";

            }
            else
            {
                if (!clsValidatePatterns.IsMatch(clsValidatePatterns.IdentityNumberPattern, ref Commercial_Registration))
                {
                    new Notification("Commercial_Registration خاطئ").Show();
                }
                _Client.Classification = 2;
                _Client.Commercial_Registration = txt_commecial.Text;
                _Client.SSN = "";
            }


            if (_Client.Save())
            {
                new Notification("تم الحفظ").Show();
            }
            else
            {
               // new Notification(" خطأء. فشلت العملية").Show();
            }

            this.Close();



        }

        void CheckPersonOrCompany(object s)
        {
            RadioButton radioButton = (RadioButton)s;
            if (radioButton.Checked && radioButton.Name == "rdPerson")
            {
                txt_commecial.Enabled = false;
                txt_SSN.Enabled = true;
            }
            else if (radioButton.Checked && radioButton.Name == "rdCompany")
            {
                txt_SSN.Enabled = false;
                txt_commecial.Enabled = true;

            }


        }

        private void rdPerson_CheckedChanged(object sender, EventArgs e)
        {
            CheckPersonOrCompany(sender);
        }
        private void rdCompany_CheckedChanged(object sender, EventArgs e)
        {
            CheckPersonOrCompany(sender);
        }

        private void btn_close_frmAddClient(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CloseAddClientPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmAddClient_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                label5.Text = "اضافة عميل";
                _Client = new clsClint();
                return;
            }
            label5.Text = "تعديل بيانات عميل";

            _Client = clsClint.Find(_ClientID);

            if (_Client == null)
            {
                new Notification("This form will be closed because No Client with ID = " + _ClientID).Show();
                this.Close();

                return;
            }



            txt_CoustmerName.Text = _Client.FullName;
            txt_CustomerPhone.Text = _Client.PhoneNumber;
            txt_CoustmerEmail.Text = _Client.Email;
            txt_CoustmerAdress.Text = _Client.Address;
            if (_Client.Classification == 1)
            {
                txt_SSN.Text = _Client.SSN;
                rdPerson.PerformClick();
            }
            else
            {
                txt_commecial.Text = _Client.Commercial_Registration;
                rdCompany.PerformClick();

            }
        }

        private void Panel_AddClient_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
