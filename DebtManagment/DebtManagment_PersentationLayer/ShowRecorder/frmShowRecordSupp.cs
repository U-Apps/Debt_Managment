﻿using DebtManagment_BusinessLayer;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer.ShowRecorder
{
    public partial class frmShowRecordSupp : Form
    {
        int _ID;
        clsSupplier _Supplier;
        public frmShowRecordSupp(int SuppId)
        {
            InitializeComponent();
            _ID = SuppId;
            _Supplier = clsSupplier.Find(_ID);

        }

        private void frmShowRecordSupp_Load(object sender, System.EventArgs e)
        {
            label_Name.Text = _Supplier.FullName;
            txt_TotalDebts.Text = clsDebitToSuppliers.GetTotalDebtsToCertainSupplier(_ID).ToString();
            txtTotalPayments.Text = PaymentToSupplierRecord.GetTotalPaymentsForCertainClient(_ID).ToString();
            txtRemainder.Text = (int.Parse(txt_TotalDebts.Text) - int.Parse(txtTotalPayments.Text)).ToString();
            _updateDebts();
            _updatePayments();
        }

        private void _updateDebts()
        {
            DataGridView_dept.DataSource = clsDebitToSuppliers.GetAllDebitsForCertainSupplier(_ID);
            txt_TotalDebts.Text = clsDebitToSuppliers.GetTotalDebtsToCertainSupplier(_ID).ToString();
            txtRemainder.Text = (int.Parse(txt_TotalDebts.Text) - int.Parse(txtTotalPayments.Text)).ToString();

        }

        private void _updatePayments()
        {
            DataGridView_paying.DataSource = PaymentToSupplierRecord.GetAllPaymentsToCertainSupplier(_ID);
            txtTotalPayments.Text = PaymentToSupplierRecord.GetTotalPaymentsForCertainClient(_ID).ToString();
            txtRemainder.Text = (int.Parse(txt_TotalDebts.Text) - int.Parse(txtTotalPayments.Text)).ToString();

        }

        private void btn_add_dept_Click(object sender, System.EventArgs e)
        {
            ShowRecorder.frmAddUpdateSP frmAddDebt = new ShowRecorder.frmAddUpdateSP(-1, _Supplier.ID);

            frmAddDebt.ShowDialog();

            _updateDebts();

        }

        private void btn_delete_dept_Click(object sender, System.EventArgs e)
        {
            int SuppID = (int)DataGridView_dept.CurrentRow.Cells[0].Value;
            clsDebitToSuppliers.delelte(SuppID);
            _updateDebts();
        }

        private void btn_modify_dept_Click(object sender, System.EventArgs e)
        {
            int SuppDebtID = (int)DataGridView_dept.CurrentRow.Cells[0].Value;
            ShowRecorder.frmAddUpdateSP frmUpdateDebt = new ShowRecorder.frmAddUpdateSP(SuppDebtID, _Supplier.ID);
            frmUpdateDebt.ShowDialog();

            _updateDebts();
        }

        private void btn_delete_paying_Click(object sender, System.EventArgs e)
        {
            int SupplierPaymentID = (int)DataGridView_paying.CurrentRow.Cells[0].Value;
            PaymentToSupplierRecord.Delete(SupplierPaymentID);

            _updatePayments();
        }

        private void btn_modify_paying_Click(object sender, System.EventArgs e)
        {
            int SupplierPaymentID = (int)DataGridView_paying.CurrentRow.Cells[0].Value;
            ShowRecorder.frmAddPaymentSP frmUpdatePayment = new ShowRecorder.frmAddPaymentSP(SupplierPaymentID, _Supplier.ID);
            frmUpdatePayment.ShowDialog();

            _updatePayments();
        }

        private void btn_add_paying_Click(object sender, System.EventArgs e)
        {
            ShowRecorder.frmAddPaymentSP frmAddPayment = new ShowRecorder.frmAddPaymentSP(-1, _Supplier.ID);
            frmAddPayment.ShowDialog();

            _updatePayments();
        }
    }
}