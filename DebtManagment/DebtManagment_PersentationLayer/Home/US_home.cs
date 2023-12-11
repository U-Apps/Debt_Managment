using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DebtManagment_PersentationLayer
{
    public partial class US_home : UserControl
    {
        public US_home()
        {
            InitializeComponent();
        }
        private void SetInfo()
        {
            byte[] imgbyte = Convert.FromBase64String(Properties.Settings.Default.Logo);
            MemoryStream ms = new MemoryStream(imgbyte);

            DebtManagment_BusinessLayer.ApplicationContext.CampanyName = Properties.Settings.Default.Campany_Name;
            DebtManagment_BusinessLayer.ApplicationContext.CampanyDes = Properties.Settings.Default.Campany_Des;
            DebtManagment_BusinessLayer.ApplicationContext.CampanyLogo = Image.FromStream(ms);

        }
        private void US_home_Load(object sender, EventArgs e)
        {
            SetInfo();
            TheTime.Text = DateTime.Now.ToString();
            pic_Logo.Image = DebtManagment_BusinessLayer.ApplicationContext.CampanyLogo;
            Name_of_Company.Text = DebtManagment_BusinessLayer.ApplicationContext.CampanyName;

        }

        private void users1_Load(object sender, EventArgs e)
        {
            
        }

        private void suppliers1_Load(object sender, EventArgs e)
        {

        }

        private void users2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
