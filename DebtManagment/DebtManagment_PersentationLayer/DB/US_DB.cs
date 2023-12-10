using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtManagment_BusinessLayer; 
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer
{
    public partial class US_DB : UserControl
    {
        public US_DB()
        {
            InitializeComponent();
        }

        private void btnSaveDBSt_Click(object sender, EventArgs e)
        {
            DebtManagment_BusinessLayer.ApplicationContext.SetDBSettings(txt_ServerName.Text, txt_UserName_db.Text, txt_passwordDb.Text);
            Notification ntMsg = new Notification("تم حفظ التغيرات بنجاح");
            ntMsg.Show();

        }

        private void setting_DB_P_Paint(object sender, PaintEventArgs e)
        {
           string[] sttsDB= DebtManagment_BusinessLayer.ApplicationContext.GetDBSettings();
            txt_ServerName.Text=sttsDB[0];
            txt_UserName_db.Text=sttsDB[1];
            txt_passwordDb.Text=sttsDB[2];
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (DebtManagment_BusinessLayer.ApplicationContext.TakeBackup())
            {
                new Notification("تم حفظ السخة بنجاح").Show();

            }
            else
                new Notification("فشلت العملية ولا يمكن حفظ النسخة").Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (DebtManagment_BusinessLayer.ApplicationContext.Restore())
            {
                new Notification("تم استعادة النسخة بنجاح").Show();

            }
            else
                new Notification("فشلت العملية ولا يمكن استعادة النسخة").Show();
        }
    }
}
