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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void GeneralSettingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void hidePanel(UserControl user)

        {
               user.Dock= DockStyle.Fill;
               boddy.Controls.Clear();
               boddy.Controls.Add(user);
               //user.BringToFront();
        }
        private void pic_generl_p_Click(object sender, EventArgs e)
        {
            Us_generl us_Generl = new Us_generl();
            hidePanel(us_Generl);

        }

        private void pic_DB_P_Click(object sender, EventArgs e)
        {
            US_DB us_DB = new US_DB();
            hidePanel(us_DB);
        }

        private void Curenncy_P_Click(object sender, EventArgs e)
        {
          
            Us_currency us_Currency = new Us_currency();
            hidePanel(us_Currency);
        }

        private void notifaction_P_Click(object sender, EventArgs e)
        {
           Us_notifaction us_Notifaction = new Us_notifaction();
           hidePanel(us_Notifaction);

        }

        private void btnSettingClose_Cleck(object sender, EventArgs e)
        {
            Close();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            Us_generl us_Generl_p = new Us_generl();
            hidePanel(us_Generl_p);
        }

        //private void guna2Button6_Click(object sender, EventArgs e)
        //{
        //    hidePanel(generl_p, currency_P, setting_DB_P, notification_P);
        //}

        //private void guna2Button7_Click(object sender, EventArgs e)
        //{
        //    hidePanel(currency_P,generl_p,setting_DB_P, notification_P);
        //}

        //private void guna2Button8_Click(object sender, EventArgs e)
        //{
        //    hidePanel(setting_DB_P, currency_P, generl_p,notification_P);

        //}

        //private void guna2Button9_Click(object sender, EventArgs e)
        //{
        //    hidePanel(notification_P,currency_P, notification_P,generl_p);
        //}
    }
}
