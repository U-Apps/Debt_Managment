using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebtManagment_BusinessLayer; // refernecing the Business layer ....

namespace DebtManagment_PersentationLayer
{
    public partial class Notification : Form
    {  int TosatX, TosatY ,y=100;
        
        public Notification()
        {
            InitializeComponent();
        }

        private void Toast_Timer_Tick(object sender, EventArgs e)
        {
            TosatX -= 10;
            this.Location = new Point(TosatX, TosatY);
            if (TosatY <= 770) // deponded about ur screen  u can set that to choose the right place 
            {
                Toast_Start_Timer.Stop(); HideToast_Timer.Start();
            }
        }

        private void HideToast_Timer_Tick(object sender, EventArgs e)
        {
            y--;
            if (y < 0)
            {
                TosatY += 1;
                this.Location = new Point(TosatX, TosatY += 10);
                if (TosatY >= 800)
                {
                    HideToast_Timer.Stop() ; y = 100; this.Close();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            position();
        }


        void position()  // this method to determine the position 
        {
            int screen_height=Screen.PrimaryScreen.WorkingArea.Height;
            int screen_width=Screen.PrimaryScreen.WorkingArea.Width;
            TosatX = screen_width - this.Width;
            TosatY= screen_height - this.Height;
            this.Location=new Point(TosatX, TosatY);

        }
    }
}
