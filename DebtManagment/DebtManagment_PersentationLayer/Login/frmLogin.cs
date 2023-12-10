using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DebtManagment_BusinessLayer;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer
{
    public partial class Perfect : Form
    {
        public Perfect()
        {
            InitializeComponent();
            fPerfect = this;
        }
        public static Perfect fPerfect { get; set; }

        bool _Login(string Username,string Password)
        {
            clsUser tempUser = clsUser.FindUserByUsernameAndPassword(Username, Password); 
            if (tempUser!=null)
            {
                DebtManagment_BusinessLayer.ApplicationContext.CurrentUser = tempUser;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_adminUserName.Text == "" || txt_AdminPassword.Text == "")
            {
                lblwrng.Text = "أحد حقول الدخول فارغة ... يرجى تعبئتها";
                lblwrng.Visible = true;
                return;
            }

            if (_Login(txt_adminUserName.Text, txt_AdminPassword.Text))
            {
                MainMenu frmMain = new MainMenu();
                ResetInputs();
                frmMain.Show();
                Notification frmNotify = new Notification("done");
                frmNotify.Show();
                this.Hide();
                DebtManagment_BusinessLayer.ApplicationContext.CurrentUser = clsUser.FindUserByUsernameAndPassword(txt_adminUserName.Text, txt_AdminPassword.Text);
            }
            else
            {
                lblwrng.Text = "اسم المستخدم او كلمة المرور خاطئة";
                lblwrng.Visible = true;
                ResetInputs();
                return;
            }
           
        }

        private void ResetInputs()
        {
            txt_adminUserName.Clear();
            txt_AdminPassword.Clear();
            txt_adminUserName.Focus();
            lblwrng.Text = "";

        }

        private void chk_remmoberPassword_CheckedChanged(object sender, EventArgs e)
        {
           if(chk_remmoberPassword.Checked)
            {
                txt_AdminPassword.PasswordChar = (char)0;

            }
           else
            {
                txt_AdminPassword.PasswordChar ='*';
            }
        }

        private void left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
