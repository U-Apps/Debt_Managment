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
    public partial class Start_Form : Form
    {
        bool ex;
        public Start_Form()
        {
            InitializeComponent();
        }




        private void effect_timerMethod()
        {
            if(ex)
            {
                Start_p.Height += 10;
                if (Start_p.Height == Start_p.MaximumSize.Height)
                {
                    ex= false;
                    effict_Timer.Stop();
                    btn_Start.Visible= false;
                }

            }
            else
            {
                Start_p.Height -= 10;
                if (Start_p.Height==Start_p.MinimumSize.Height)
                {
                    ex = true; effict_Timer.Stop();
                }
            }
            if (Start_p.Height == Start_p.MaximumSize.Height)
            {
                Admins_p.Show();
            }
        }
        private void effict_Timer_Tick(object sender, EventArgs e)
        {
            effect_timerMethod();
        }

        private void Start_Form_Load(object sender, EventArgs e)
        {
               if (Start_p.Height == Start_p.MinimumSize.Height)
            {
                elips_startP.BorderRadius = 30;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
      
          


        }

        private void Start_p_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_adminLog_Click(object sender, EventArgs e)
        {
            hide_Panel(Admins_p);
            P_add_skip.Visible = true;
        }
       void hide_Panel(Panel p )
        {
            if(p.Visible==true)
            {
                p.Visible=false;
               
            }
        }

        private void btn_AddingUsersOnStart_Click(object sender, EventArgs e)
        {
            hide_Panel(P_add_skip);
            AddingUsersP.Show();
        }

        private void btn_loginAddingUsers_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            notification.Show();
            hide_Panel(AddingUsersP);
            effict_Timer.Start();
            change_txt();

        }

        private void Container_Start_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }
        void change_txt()
        {
            label_we.Visible = false; label_we2.Visible = false; label_we4.Visible = false; label_we3.Text = "شكر علئ استخدامكم للتطبيق";
            label_we3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            effict_Timer.Start();
        }
    }
}
