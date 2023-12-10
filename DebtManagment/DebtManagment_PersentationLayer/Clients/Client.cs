using System;
using DebtManagment_BusinessLayer;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer
{
    public partial class AddClient : UserControl
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.AddUpdateClients))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Clients.frmAddClient frmaddClient = new Clients.frmAddClient(-1);
            frmaddClient.ShowDialog();
            DGV_coustomers.DataSource = clsClint.getAllClints();
            
        }

       

        private void viewRecord_Click(object sender, EventArgs e)
        {
            int ClntID = (int)DGV_coustomers.CurrentRow.Cells[0].Value;
            if (ClntID != -1)
            {
                show_recorder_client show_Recorder = new show_recorder_client( ClntID);
                show_Recorder.Show();
               
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.DeleteCliets))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ClntID = GetId();
            if (clsClint.Delete(ClntID))
            {
                new Notification("تم الحذف بنجاح").Show();
                return;
            }
            new Notification("الرجاء تحديد عنصر").Show();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.AddUpdateClients))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ClntID = GetId();
            if (ClntID!=-1)
            {
                clsClint newClient = clsClint.Find(ClntID);

                Clients.frmAddClient addClient = new Clients.frmAddClient(newClient.ID);
                addClient.ShowDialog();
                DGV_coustomers.DataSource = clsClint.getAllClints();
            }
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            DGV_coustomers.DataSource = clsClint.getAllClints();
        }

        private void DGV_coustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_SaveClient_Click(object sender, EventArgs e)
        {
            clsClint clnt=new clsClint();
            clnt.Save();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            DGV_coustomers.DataSource = clsClint.getAllClints();

        }

        private int GetId()
        {
            if (DGV_coustomers.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عملاء ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return (int)DGV_coustomers.CurrentRow.Cells[0].Value;
        }
    }
}
