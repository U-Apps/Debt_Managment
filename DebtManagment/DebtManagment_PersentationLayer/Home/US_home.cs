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
    public partial class US_home : UserControl
    {
        public US_home()
        {
            InitializeComponent();
        }

        private void US_home_Load(object sender, EventArgs e)
        {
            TheTime.Text = DateTime.Now.ToString();
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
