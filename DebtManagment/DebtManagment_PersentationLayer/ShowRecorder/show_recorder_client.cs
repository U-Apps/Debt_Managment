﻿using System;

using DebtManagment_BusinessLayer;
using System.Windows.Forms;

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
            int ClientDebtID = (int)DataGridView_dept.CurrentRow.Cells[0].Value;
            ShowRecorder.frmAddUpdateDebt frmUpdateDebt = new ShowRecorder.frmAddUpdateDebt(ClientDebtID,_Client.ID);
            frmUpdateDebt.ShowDialog();

            _updateDebts();
        
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            int ClientDebtID = (int)DataGridView_dept.CurrentRow.Cells[0].Value;
            clsClientDebit.delelte(ClientDebtID);
            _updateDebts();

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
            int ClientpaymentID = (int)DataGridView_paying.CurrentRow.Cells[0].Value;
            ClientPaymentstRecord.Delete(ClientpaymentID);

            _updatePayments();
        }

        private void btn_modify_paying_Click(object sender, EventArgs e)
        {
           
            int ClientpaymentID = (int)DataGridView_paying.CurrentRow.Cells[0].Value;
            ShowRecorder.frmAddUpdatePayment frmUpdatePayment = new ShowRecorder.frmAddUpdatePayment(ClientpaymentID, _Client.ID);
            frmUpdatePayment.ShowDialog();

            _updatePayments();
        }
    }
}
