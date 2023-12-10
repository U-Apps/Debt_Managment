using DebtManagment_PersentationLayer.AboutUs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer
{
    public partial class Us_about : UserControl
    {
        //[DIIImport("user32")]
        //static extern bool Animatewindow(IntPtr hWnd,int time,AnimateWindowFlags flags);
        //enum AnimateWindoFlags : uint
        //{
        //    AW_HOR_POSITIVE=0x00000001,
        //    AW_HOR_NEGATIVE= 0x00000002,
        //    AW_VER_POSITIVE= 0x00000004,
        //    AW_VER_NEGATIVE= 0x00000008,
        //    AW_CENTER=0X00000010,
        //    AW_HIDE=0X00010000,
        //    AW_ACTIVATE=0X00020000,
        //    AW_SLIDE=0X00040000,
        //    AW_BLEND=0X00080000
        //};
        public Us_about()
        {
            InitializeComponent();
     
        }


        private void addControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            body_slide.Controls.Clear();
            body_slide.Controls.Add(control);
            control.BringToFront();
        }


        void choose (object s)
        {
             PictureBox pic =  (PictureBox)s;
            if (pic.Name=="pcYa")
            {
                YAMANI yAMANI = new YAMANI();
                addControl(yAMANI);
            }
            else if(pic.Name=="pcFar")
            {
                FAROOQ fAROOQ = new FAROOQ();
                addControl(fAROOQ);
            }
            else if (pic.Name=="pcSa")
            {
                SALAH sALAH = new SALAH();
                addControl(sALAH);
            }
            else if (pic.Name=="pcMO")
            {
                MOHAMMED mOHAMMED = new MOHAMMED();
                addControl(mOHAMMED);
            }
            else if (pic.Name=="pcFas")
            {
                FASIL fASIL = new FASIL();
                addControl(fASIL);
            }
            else if ( pic.Name=="pcAH")
            {
                AHMED aHMED = new AHMED();
                addControl(aHMED);
            }
            else if ((pic.Name == "pcYo"))
            {

                YOSEF yOSEF = new YOSEF();
                addControl(yOSEF);
            }
           
        }

        private void FA_Click(object sender, EventArgs e)
        {
            choose(sender);
        }

      


        //void Hover(Panel p )
        //{
        //    pic.Visible = false;

        //    Thread.Sleep(100);
        //    p.Width = 200;

        //}

        //void leave(Panel p)
        //{
        //    pic.Visible=true;
        //    //pic.Dock = DockStyle.Fill;
        //    Thread.Sleep(100);
        //    p.Width = 94;
        //}

        //private void Abo_Night_MouseHover(object sender, EventArgs e)
        //{

        //}

        //private void Abo_Night_MouseLeave(object sender, EventArgs e)
        //{

        //}

        //private void Fisal_MouseHover(object sender, EventArgs e)
        //{


        //}

        //private void Abo_Night_MouseHover_1(object sender, EventArgs e)
        //{
        //    Hover((Panel)sender);
        //}

        //private void Abo_Night_MouseLeave_1(object sender, EventArgs e)
        //{
        //    leave((Panel)sender);
        //}

        //private void Fisal_MouseHover_1(object sender, EventArgs e)
        //{
        //    ((Panel)sender).Dock = DockStyle.Left;
        //    ((Panel)sender).Width = 234;
        //}

        //private void Fisal_MouseLeave(object sender, EventArgs e)
        //{
        //    ((Panel)sender).Dock = DockStyle.Right;
        //    ((Panel)sender).Width = 130;
        //}

        //private void Abo_Night_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void pic2_Click(object sender, EventArgs e)
        //{

        //}
    }

    internal class AnimateWindowFlags
    {
    }
}
