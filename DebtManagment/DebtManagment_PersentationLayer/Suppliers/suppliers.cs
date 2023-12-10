using System;
using DebtManagment_BusinessLayer;
using System.Windows.Forms;
using System.Drawing;

namespace DebtManagment_PersentationLayer
{
    public partial class suppliers : UserControl
    {
        public suppliers()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            
        }

        private void viewRecord_Click(object sender, EventArgs e)
        {
            int SupID = (int)DGV_suppliers.CurrentRow.Cells[0].Value;
            if (SupID!=null)
            {
                ShowRecorder.frmShowRecordSupp show_RecorderSupp = new ShowRecorder.frmShowRecordSupp(SupID);
                show_RecorderSupp.Show();
            }
            

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.AddUpdateSuppliser))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Suppliers.frmAddSupplier frmaddSupplier = new Suppliers.frmAddSupplier(-1);
            frmaddSupplier.ShowDialog();
            _Update();
        }


        void _Update()
        {
            DGV_suppliers.DataSource = clsSupplier.GetAllSuppliers();

        }
        private void btn_close_Click_1(object sender, EventArgs e)
        {
            ;
        }


        public void Number_validition(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
                {
                e.Handled = true;

            }
           
        }


        public void change_color_validtion(object sender)
        {

            Guna.UI2.WinForms.Guna2TextBox txt = (Guna.UI2.WinForms.Guna2TextBox)sender;

            if (txt.MaxLength != 10){
                txt.ForeColor = Color.Red;
                txt.ShadowDecoration.Color = Color.Red;

            }
            else
            {
                txt.ForeColor= Color.Black;
          
            }
        }




        private void txt_SuppliersPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Number_validition(sender, e);
        }


        private void txt_SuppliersName_Validated(object sender, EventArgs e)
        {

        }

        private void txt_SuppliersPhone_Leave(object sender, EventArgs e)
        {
            change_color_validtion(sender);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _Update();
        }

        private void suppliers_Load(object sender, EventArgs e)
        {
            _Update();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.DeleteSuppliser))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int SupID = (int)DGV_suppliers.CurrentRow.Cells[0].Value;
            if (clsSupplier.Delete(SupID))
            {

                new Notification("تم الحذف ينجاح");
                return;
            }
            new Notification("الرجاء تحديد عنصر");
            _Update();  

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.AddUpdateSuppliser))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int SuppID = (int)DGV_suppliers.CurrentRow.Cells[0].Value;
            clsSupplier newSupplierID = clsSupplier.Find(SuppID);

            Suppliers.frmAddSupplier frmaddSupplier = new Suppliers.frmAddSupplier(newSupplierID.ID);
            frmaddSupplier.ShowDialog();
            _Update();
        }
    }
}
