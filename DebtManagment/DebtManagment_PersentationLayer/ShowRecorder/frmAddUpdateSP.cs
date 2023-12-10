using DebtManagment_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer.ShowRecorder
{
    public partial class frmAddUpdateSP : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _DebtID;
        int _SuppID;

        clsDebitToSuppliers _DebtToSupplier;
        public frmAddUpdateSP(int DebtID,int SuppID)
        {
            InitializeComponent();
            this._DebtID = DebtID;
            this._SuppID = SuppID;
            if (_DebtID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void btn_addTotable_dept_Click(object sender, EventArgs e)
        {
            if (txtMateraicl.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول");
                return;
            }
            if (double.TryParse(txtPrice.Text, out double amount))
            {
                _DebtToSupplier.Amount = amount;
            }
            else
            {
                new Notification("قيمة السعر غير صحيحة").Show();
                return;
            }
            _DebtToSupplier.Material = txtMateraicl.Text;
            //_DebtToSupplier.Amount = double.Parse(txtPrice.Text.ToString());
            _DebtToSupplier.DebitDate = _DebtToSupplier.DebitDate;
            _DebtToSupplier.SupplierID = this._SuppID;

            if (_DebtToSupplier.Save())
            {
                MessageBox.Show("debt added succesfully");
            }
            else
            {
                MessageBox.Show("faild to add debt");

            }
            Close();

        }

        private void frmAddUpdateSP_Load(object sender, EventArgs e)
        {

            if (_Mode == enMode.AddNew)
            {
                label1.Text = "اضافة دين من المورد";
                _DebtToSupplier = new clsDebitToSuppliers();
                return;
            }

            label1.Text = "نعديل دين من المورد";

            _DebtToSupplier = clsDebitToSuppliers.Find(_DebtID);

            if (_DebtToSupplier == null)
            {
                new Notification("This form will be closed because No Client Debt with ID = " + _DebtID).Show();
                this.Close();

                return;
            }

            txtMateraicl.Text = _DebtToSupplier.Material.ToString();
            txtPrice.Text = _DebtToSupplier.Amount.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
