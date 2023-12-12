using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DebtManagment_PersentationLayer
{
    public partial class Us_generl : UserControl
    {
        MemoryStream ms;
        public Us_generl()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pic_logo_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_logo.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveSetting();
            MessageBox.Show("تم الحفظ بنجاح", "الاعدادات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetSettings()
        {
            DebtManagment_BusinessLayer.ApplicationContext.CampanyName = Properties.Settings.Default.Campany_Name;
            DebtManagment_BusinessLayer.ApplicationContext.CampanyDes = Properties.Settings.Default.Campany_Des;

            txt_nameOfComany.Text = DebtManagment_BusinessLayer.ApplicationContext.CampanyName;
            txtCampDes.Text = DebtManagment_BusinessLayer.ApplicationContext.CampanyDes;

            try
            {
                byte[] imgbyte = Convert.FromBase64String(Properties.Settings.Default.Logo);
                ms = new MemoryStream(imgbyte);
                pic_logo.Image = Image.FromStream(ms);
                DebtManagment_BusinessLayer.ApplicationContext.CampanyLogo = pic_logo.Image;

            }
            catch (Exception ex)
            {

                //throw;
                //MessageBox.Show(ex.Message);
            }
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Campany_Name = txt_nameOfComany.Text;
            Properties.Settings.Default.Campany_Des = txtCampDes.Text;

            try
            {
                ms = new MemoryStream();
                pic_logo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.Logo = Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {

                // throw;
                MessageBox.Show(ex.Message);

            }
            Properties.Settings.Default.Save();
        }

        private void Us_generl_Load(object sender, EventArgs e)
        {
            SetSettings();
        }
    }
}
