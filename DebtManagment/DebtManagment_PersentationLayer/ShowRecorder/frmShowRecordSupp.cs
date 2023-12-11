using DebtManagment_BusinessLayer;
using System.Windows.Forms;
using System.Drawing;

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
            int SuppID = GetDebtId();
            if (SuppID != -1)
            {
                clsDebitToSuppliers.delelte(SuppID);
                _updateDebts();
            }
           
        }

        private void btn_modify_dept_Click(object sender, System.EventArgs e)
        {
            int SuppDebtID = GetDebtId();
            if (SuppDebtID != -1)
            {
                ShowRecorder.frmAddUpdateSP frmUpdateDebt = new ShowRecorder.frmAddUpdateSP(SuppDebtID, _Supplier.ID);
                frmUpdateDebt.ShowDialog();

                _updateDebts();
            }
          
        }

        private void btn_delete_paying_Click(object sender, System.EventArgs e)
        {
            int SupplierPaymentID = GetPayId();
            if (SupplierPaymentID != -1)
            {
                PaymentToSupplierRecord.Delete(SupplierPaymentID);

                _updatePayments();
            }
          
        }

        private void btn_modify_paying_Click(object sender, System.EventArgs e)
        {
            int SupplierPaymentID = GetPayId();
            if (SupplierPaymentID != -1)
            {
                ShowRecorder.frmAddPaymentSP frmUpdatePayment = new ShowRecorder.frmAddPaymentSP(SupplierPaymentID, _Supplier.ID);
                frmUpdatePayment.ShowDialog();

                _updatePayments();
            }
        }
           

        private void btn_add_paying_Click(object sender, System.EventArgs e)
        {
            ShowRecorder.frmAddPaymentSP frmAddPayment = new ShowRecorder.frmAddPaymentSP(-1, _Supplier.ID);
            frmAddPayment.ShowDialog();

            _updatePayments();
        }

        private int GetDebtId()
        {
            if (DataGridView_dept.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد ديون ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return (int)DataGridView_dept.CurrentRow.Cells[0].Value;
        }

        private int GetPayId()
        {
            if (DataGridView_paying.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد تسديدات ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return (int)DataGridView_paying.CurrentRow.Cells[0].Value;
        }

        private void btn_praint_paying_Click(object sender, System.EventArgs e)
        {
            if (printDialog1_pay.ShowDialog() == DialogResult.OK){
                printDocument1_pay.Print();

            }
        }

        private void printDocument1_pay_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bt =new Bitmap(this.DataGridView_paying.Width,this.DataGridView_paying.Height);
            DataGridView_paying.DrawToBitmap(bt, new Rectangle(0, 0, this.DataGridView_paying.Width, this.DataGridView_paying.Height));
            e.Graphics.DrawImage(bt, 0, 0);
        }

        private void btn_print_dept_Click(object sender, System.EventArgs e)
        {
            if (printDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bt =new Bitmap(this.DataGridView_dept.Width,this.DataGridView_dept.Height);
            DataGridView_dept.DrawToBitmap(bt , new Rectangle(0,0,this.DataGridView_dept.Width,this.DataGridView_dept.Height)); 
            e.Graphics.DrawImage(bt,0,0);
        }
    }
}
