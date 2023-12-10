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
    public partial class frmAddUpdatePayment : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PaymentID;
        int _ClientID;

        ClientPaymentstRecord _ClientPayment;
        public frmAddUpdatePayment(int PaymentID, int ClientID)
        {
            InitializeComponent();

            this._PaymentID = PaymentID;
            this._ClientID = ClientID;
            if (_PaymentID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

      

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                label10.Text = "اضافة تسديد للعميل";
                _ClientPayment = new ClientPaymentstRecord();
                return;
            }

            label10.Text = "نعديل التسديد ";
            _ClientPayment = ClientPaymentstRecord.Find(_PaymentID);
            txtAmountOfMoney.Text = _ClientPayment.PayedAmount.ToString();

            if (_ClientPayment == null)
            {
                new Notification("This form will be closed because No Client payment with ID = " + _PaymentID).Show();
                this.Close();

                return;
            }
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
                _ClientPayment.PayedAmount = amount;
            }
            else
            {
                new Notification("قيمة السعر غير صحيحة").Show();
                return;
            }

            //_ClientPayment.PayedAmount = double.Parse( txtAmountOfMoney.Text);
            _ClientPayment.ClientID = _ClientID;

            if (_ClientPayment.Save())
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void money_P_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
