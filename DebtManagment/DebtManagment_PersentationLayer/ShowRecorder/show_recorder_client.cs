using System;

using DebtManagment_BusinessLayer;
using System.Windows.Forms;
using System.Drawing;

namespace DebtManagment_PersentationLayer
{
    public partial class show_recorder_client : Form
    {

        int _ID;
        clsClint _Client;
        public show_recorder_client(int ID)
        {
            InitializeComponent();

            //MoveForm mf = new MoveForm();
            //mf.AttachToPanel(pnControl,this);

            _ID = ID;
            _Client = clsClint.Find(_ID);
        }

        private void show_recorder_Load(object sender, EventArgs e)
        {
            label_Name.Text = _Client.FullName;
            txt_TotalDebts.Text = clsClientDebit.GetTotalDebtsForCertainClient(_ID).ToString();
            txtTotalPayments.Text = ClientPaymentstRecord.GetTotalPaymentsForCertainClient(_ID).ToString();
            txtRemainder.Text = (int.Parse(txt_TotalDebts.Text) - int.Parse(txtTotalPayments.Text)).ToString();
            _updateDebts();
            _updatePayments();
            
        }


        private void _updateDebts()
        {
            DataGridView_dept.DataSource = clsClientDebit.GetAllDebtsForCertainClient(_ID);
            txt_TotalDebts.Text = clsClientDebit.GetTotalDebtsForCertainClient(_ID).ToString();
            txtRemainder.Text = (int.Parse(txt_TotalDebts.Text) - int.Parse(txtTotalPayments.Text)).ToString();

        }

        private void _updatePayments()
        {
            DataGridView_paying.DataSource = ClientPaymentstRecord.GetAllClientPayments(_ID);
            txtTotalPayments.Text = ClientPaymentstRecord.GetTotalPaymentsForCertainClient(_ID).ToString();
            txtRemainder.Text = (int.Parse(txt_TotalDebts.Text) - int.Parse(txtTotalPayments.Text)).ToString();

        }

        private void btn_add_dept_Click(object sender, EventArgs e)
        {
            ShowRecorder.frmAddUpdateDebt frmAddDebt  = new ShowRecorder.frmAddUpdateDebt(-1,_Client.ID);

            frmAddDebt.ShowDialog();

            _updateDebts();

        }
        //------------------------------------------------------
        // 

        private void btn_modify_dept_Click(object sender, EventArgs e)
        {
            int ClientDebtID = GetDebtId();
            if (ClientDebtID != -1)
            {
                ShowRecorder.frmAddUpdateDebt frmUpdateDebt = new ShowRecorder.frmAddUpdateDebt(ClientDebtID, _Client.ID);
                frmUpdateDebt.ShowDialog();

                _updateDebts();
            }
          
        
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            int ClientDebtID = GetDebtId();
            if (ClientDebtID != 1)
            {
                clsClientDebit.delelte(ClientDebtID);
                _updateDebts();
            }
           

        }

        //------------------------------------------------

        private void btn_add_paying_Click(object sender, EventArgs e)
        {
            ShowRecorder.frmAddUpdatePayment frmAddPayment = new ShowRecorder.frmAddUpdatePayment(-1, _Client.ID) ;
            frmAddPayment.ShowDialog();

            _updatePayments();
        }

        private void btn_delete_paying_Click(object sender, EventArgs e)
        {
            int ClientpaymentID = GetPayId();
            if (ClientpaymentID != 1)
            {
                ClientPaymentstRecord.Delete(ClientpaymentID);

                _updatePayments();
            }
           
        }

        private void btn_modify_paying_Click(object sender, EventArgs e)
        {
           
            int ClientpaymentID = GetPayId();
            if (ClientpaymentID != 1)
            {
                ShowRecorder.frmAddUpdatePayment frmUpdatePayment = new ShowRecorder.frmAddUpdatePayment(ClientpaymentID, _Client.ID);
                frmUpdatePayment.ShowDialog();

                _updatePayments();
            }
          
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

        private void btn_praint_paying_Click(object sender, EventArgs e)
        {
            if (printDialog1_pay.ShowDialog() == DialogResult.OK)
            {
                printDocument1_pay.Print();
            }
        }

        private void printDocument1_pay_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bt=new Bitmap(this.DataGridView_paying.Width,this.DataGridView_paying.Height);
            DataGridView_paying.DrawToBitmap(bt,new Rectangle(0,0,this.DataGridView_paying.Width,this.DataGridView_paying.Height)); 
            e.Graphics.DrawImage(bt,0,0);   
        }

        private void btn_print_dept_Click(object sender, EventArgs e)
        {
            if (printDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bt =new Bitmap(this.DataGridView_dept.Width,this.DataGridView_dept.Height);
            DataGridView_dept.DrawToBitmap(bt,new Rectangle(0,0, this.DataGridView_dept.Width,this.DataGridView_dept.Height));
            e.Graphics.DrawImage(bt,0,0);   
        }
    }
}
