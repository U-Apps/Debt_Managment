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

namespace DebtManagment_PersentationLayer.ShowRecorder
{
   
    public partial class frmAddPaymentSP : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PaymentID;
        int _SuppID;

        PaymentToSupplierRecord _SupplierPayment;
        public frmAddPaymentSP(int PaymentID,int SuppID)
        {
            InitializeComponent();

            this._PaymentID = PaymentID;
            this._SuppID = SuppID;
            if (_PaymentID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void frmAddPaymentSP_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                label10.Text = "اضافة تسديد للمورد";
                _SupplierPayment = new PaymentToSupplierRecord();
                return;
            }

            label10.Text = "نعديل التسديد ";

            _SupplierPayment = PaymentToSupplierRecord.Find(_PaymentID);
            txtAmountOfMoney.Text = _SupplierPayment.PayedAmount.ToString();

            if (_SupplierPayment == null)
            {
                new Notification("This form will be closed because No Supplier payment with ID = " + _PaymentID).Show();
                this.Close();

                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_money_toTable_Click(object sender, EventArgs e)
        {
            if (txtAmountOfMoney.Text == "")
            {
                MessageBox.Show("please fill all fields");
                return;
            }
            if (double.TryParse(txtAmountOfMoney.Text, out double amount))
            {
                _SupplierPayment.PayedAmount = amount;
            }
            else
            {
                new Notification("قيمة السعر غير صحيحة").Show();
                return;
            }

            //_SupplierPayment.PayedAmount = double.Parse(txtAmountOfMoney.Text);
            _SupplierPayment.SupplierID = _SuppID;

            if (_SupplierPayment.Save())
            {
                MessageBox.Show("changes saved succusfully");
            }
            else
            {
                MessageBox.Show("Error Occur");
            }

            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
