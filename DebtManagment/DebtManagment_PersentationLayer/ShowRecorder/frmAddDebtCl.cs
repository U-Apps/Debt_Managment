using System;
using DebtManagment_BusinessLayer;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer.ShowRecorder
{
    public partial class frmAddUpdateDebt : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _DebtID;
        int _ClientID;

        clsClientDebit _ClientDebt; 
        public frmAddUpdateDebt(int DebtID, int ClientID)
        {
            InitializeComponent();

            this._DebtID = DebtID;
            this._ClientID = ClientID;
            if (_DebtID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void btn_addTotable_dept_Click(object sender, System.EventArgs e)
        {
            
            if (txtMateraicl.Text == "" || txtPrice.Text == "")
            {
                new Notification("يرجى تعبئة جميع الحقول").Show();
                return;
            }
            if (double.TryParse(txtPrice.Text , out double amount))
            {
                _ClientDebt.DebtAmount=amount;
            }
            else
            {
                new Notification("قيمة السعر غير صحيحة").Show();
                return;
            }
                _ClientDebt.Material = txtMateraicl.Text;
            //_ClientDebt.DebtAmount = double.Parse(txtPrice.Text.ToString());
            _ClientDebt.DebtDate = _ClientDebt.DebtDate;
            _ClientDebt.ClientID = this._ClientID;

            if (_ClientDebt.Save())
            {
                MessageBox.Show("debt added succesfully");
            }
            else
            {
                MessageBox.Show("faild to add debt");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateDebt_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                label1.Text = "اضافة دين للعميل";
                _ClientDebt = new clsClientDebit();
                return;
            }

            label1.Text = "نعديل دين للعميل";

            _ClientDebt = clsClientDebit.Find(_DebtID);

            if (_ClientDebt == null)
            {
                new Notification("This form will be closed because No Client Debt with ID = " + _DebtID).Show();
                this.Close();

                return;
            }

            txtMateraicl.Text = _ClientDebt.Material.ToString();
            txtPrice.Text = _ClientDebt.DebtAmount.ToString();





        }
    }
}
