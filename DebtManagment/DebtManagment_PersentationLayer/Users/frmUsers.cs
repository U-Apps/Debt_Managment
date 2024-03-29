﻿using System;
using DebtManagment_BusinessLayer;
using System.Windows.Forms;
using System.Drawing;
namespace DebtManagment_PersentationLayer
{
    public partial class frmUsers : UserControl
    {
     
        public frmUsers()
        {
            InitializeComponent();
        }



        private void Add_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.AddUpdateUsers))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Users.frmAddUpdateUser frmAddUpdateUser = new Users.frmAddUpdateUser(-1);
            frmAddUpdateUser.ShowDialog();

            _UpdateDGV();
        }

  
        private void edit_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.AddUpdateUsers))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int UserID = GetId();
            if (UserID !=-1)
            {
                Users.frmAddUpdateUser frmAddUpdateUser = new Users.frmAddUpdateUser(UserID);
                frmAddUpdateUser.ShowDialog();

                _UpdateDGV();
            }
           

        }

        private void _UpdateDGV()
        {
            DGV_Users.DataSource = clsUser.GetAllUsers();

        }

        private void Refrsh_Click(object sender, EventArgs e)
        {
            _UpdateDGV();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.DeleteUsers))
            {
                MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int UserID = GetId();
            if (clsUser.DeleteUser(UserID))
            {
                new Notification("تم الحذف بنجاح").Show();
                return;
            }
            new Notification(" الرجاء تحديد عنصر ").Show();

            _UpdateDGV();

        }

        private void DGV_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _UpdateDGV();    
        }

        private int GetId()
        {
            if (DGV_Users.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد عملاء ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return (int)DGV_Users.CurrentRow.Cells[0].Value;
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bt =new Bitmap(this.DGV_Users.Width, this.DGV_Users.Height);
            DGV_Users.DrawToBitmap(bt,new Rectangle(0,0,this.DGV_Users.Width,this.DGV_Users.Height));
            e.Graphics.DrawImage(bt, 0, 0);
        }
    }
}