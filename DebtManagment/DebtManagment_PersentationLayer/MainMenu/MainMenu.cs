using System;
using System.Windows.Forms;
using Guna;                        // Guna UI frame work, [ U should include the Guna.UI.dll in ur PersentationLayer\References]
using DebtManagment_BusinessLayer; // refernecing the Business layer ....
using System.Drawing;
namespace DebtManagment_PersentationLayer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            MoveForm formover = new MoveForm();
            formover.AttachToPanel(Top_panel, this);
        }
        void moveimage(object sender)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            imgSlide.Location = new Point(btn.Location.X - 16, btn.Location.Y - 19);
            imgSlide.SendToBack();
        }


        void Add_control(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            BodyPanel.Controls.Clear();
            BodyPanel.Controls.Add(control);
            control.BringToFront();
        }
        void ChangePanel(object s)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)s;
            if (btn.Name == "Btn_home")
            {
                US_home uS_Home = new US_home();
                Page_Name.Text = "الرئيسية";

                Add_control(uS_Home);
               
                moveimage(s);
               
            }
            else if (btn.Name == "btn_Suppliers")
            {
                suppliers suppliers = new suppliers();
                Add_control(suppliers);
                Page_Name.Text = "الموردين";
                moveimage(s);
               
            }
            else if (btn.Name == "btn_Customers")
            {
                AddClient customers = new AddClient();
                Add_control(customers);
                Page_Name.Text = "العملاء";
                moveimage(s);
                
            }
            else if (btn.Name == "btn_Users")
            {
                if(!DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.CheckAccessPermission(enUserPermissions.ShowUsersInfo))
                {
                    MessageBox.Show("ليس لديك الصلاحية لهذه العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmUsers users = new frmUsers();
                Add_control(users);
                Page_Name.Text = "المستخدمين";
                moveimage(s);
                
            }
            else if (btn.Name == "btn_anylsis")
            {
                analysis analysis = new analysis();
                Add_control(analysis);
                Page_Name.Text = "التحليل";
                moveimage(s);
            }
            //else if (btn.Name == "btn_about")
            //{
            //    Us_about about = new Us_about();
            //    moveimage(s);
            //    Page_Name.Text = "نبذه";
            //    Add_control(about);

            //}
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            ChangePanel(sender);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Perfect.fPerfect.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            US_home uS_Home = new US_home();
            Add_control(uS_Home);
            lblUsername.Text =DebtManagment_BusinessLayer.ApplicationContext.CurrentUser.UserName;
        }

        private void Notifications_Click(object sender, EventArgs e)
        {
            setting setting=new setting();
            setting.Show();
        }

        private void Btn_home_MouseHover(object sender, EventArgs e)
        {
            chanel_label(sender);
        }

         void chanel_label(object s)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)s;

            if (btn.Name == "Btn_home")
            {
                Page_Name.Text = "الرئيسية";

              
               

            }
            else if (btn.Name == "btn_Suppliers")
            {
               
                Page_Name.Text = "الموردين";
               

            }
            else if (btn.Name == "btn_Customers")
            {
                Page_Name.Text = "العملاء";
              

            }
            else if (btn.Name == "btn_Users")
            {
                
                Page_Name.Text = "المستخدمين";
              

            }
            else if (btn.Name == "btn_anylsis")
            {
                
                Page_Name.Text = "التحليل";
              
            }
            else if (btn.Name == "btn_about")
            {
               
                Page_Name.Text = "نبذه";
                

            }

        }

        private void btnMainMenuClose_Click(object sender, EventArgs e)
        {
            Perfect.fPerfect.Close();
        }

        private void BodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        //private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (guna2ToggleSwitch1.Checked)
        //    {
        //        guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
        //        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        //    }
        //    else
        //    {
        //        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
        //        this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(75)))), ((int)(((byte)(211)))));
        //   }

    }

        //private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        //{
        //    moveimage(sender);
        //}

        //private void guna2Button1_Click_1(object sender, EventArgs e)
        //{
        //    ChangePanel(sender);
        //}

        //private void about1_Load(object sender, EventArgs e)
        //{

        //}


    }
