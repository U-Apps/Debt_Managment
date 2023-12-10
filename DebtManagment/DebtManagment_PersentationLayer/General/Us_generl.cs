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
    public partial class Us_generl : UserControl
    {
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
                pic_logo.Image=Image.FromFile(ofd.FileName);
            }
        }
    }
}
