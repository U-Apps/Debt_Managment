using DebtManagment_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer
{
    public partial class analysis : UserControl
    {
        public analysis()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void analysis_Load(object sender, EventArgs e)
        {
            double deptsC = clsClientDebit.GetTotalDebtsForClients();
            double paymentC = ClientPaymentstRecord.GetTotalPaymentsForClients();
            double deptC = (paymentC > deptsC) ? 0 : deptsC - paymentC;
            leb_RYCust.Text = deptC.ToString();

            double deptsS = clsDebitToSuppliers.GetTotalDebtsToSuppliers();
            double paymentS = PaymentToSupplierRecord.GetTotalDebtsToSuppliers();
            double deptS = (paymentS > deptsS) ? 0 : deptsS - paymentS;
            leb_RYSupp.Text = deptS.ToString();

        }
    }
}
