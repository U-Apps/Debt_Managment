namespace DebtManagment_PersentationLayer
{
    partial class Start_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            this.Start_p = new System.Windows.Forms.Panel();
            this.elips_startP = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.effict_Timer = new System.Windows.Forms.Timer(this.components);
            this.Container_Start = new System.Windows.Forms.Panel();
            this.Admins_p = new System.Windows.Forms.Panel();
            this.elips_adminP = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txt_AdminName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_PasswordAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_adminLog = new Guna.UI2.WinForms.Guna2Button();
            this.P_add_skip = new System.Windows.Forms.Panel();
            this.btn_SkipStartForm = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AddingUsersOnStart = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.elips_add_skipP = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AddingUsersP = new System.Windows.Forms.Panel();
            this.btn_loginAddingUsers = new Guna.UI2.WinForms.Guna2Button();
            this.txt_PasswordUserAdding = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_FullNameUserAdding = new Guna.UI2.WinForms.Guna2TextBox();
            this.elips_addingUser = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elips_pic_addingUserP = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pic_addingUserP = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_UserNameAdding = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_conformAddingUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.design_cir1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.design_cir2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_we4 = new System.Windows.Forms.Label();
            this.label_we3 = new System.Windows.Forms.Label();
            this.label_we2 = new System.Windows.Forms.Label();
            this.label_we = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.PictureBox();
            this.Start_p.SuspendLayout();
            this.Container_Start.SuspendLayout();
            this.Admins_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.P_add_skip.SuspendLayout();
            this.AddingUsersP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addingUserP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_p
            // 
            this.Start_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(75)))), ((int)(((byte)(211)))));
            this.Start_p.Controls.Add(this.btn_Start);
            this.Start_p.Controls.Add(this.AddingUsersP);
            this.Start_p.Controls.Add(this.P_add_skip);
            this.Start_p.Controls.Add(this.Admins_p);
            this.guna2Transition1.SetDecoration(this.Start_p, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Start_p.Dock = System.Windows.Forms.DockStyle.Top;
            this.Start_p.Location = new System.Drawing.Point(0, 0);
            this.Start_p.MaximumSize = new System.Drawing.Size(1079, 709);
            this.Start_p.MinimumSize = new System.Drawing.Size(1079, 115);
            this.Start_p.Name = "Start_p";
            this.Start_p.Size = new System.Drawing.Size(1079, 115);
            this.Start_p.TabIndex = 0;
            this.Start_p.Paint += new System.Windows.Forms.PaintEventHandler(this.Start_p_Paint);
            // 
            // elips_startP
            // 
            this.elips_startP.BorderRadius = 99;
            this.elips_startP.TargetControl = this.Start_p;
            // 
            // effict_Timer
            // 
            this.effict_Timer.Interval = 5;
            this.effict_Timer.Tick += new System.EventHandler(this.effict_Timer_Tick);
            // 
            // Container_Start
            // 
            this.Container_Start.BackColor = System.Drawing.Color.White;
            this.Container_Start.Controls.Add(this.panel1);
            this.Container_Start.Controls.Add(this.Start_p);
            this.guna2Transition1.SetDecoration(this.Container_Start, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Container_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_Start.Location = new System.Drawing.Point(0, 0);
            this.Container_Start.Name = "Container_Start";
            this.Container_Start.Size = new System.Drawing.Size(1079, 775);
            this.Container_Start.TabIndex = 1;
            this.Container_Start.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_Start_Paint);
            // 
            // Admins_p
            // 
            this.Admins_p.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Admins_p.Controls.Add(this.btn_adminLog);
            this.Admins_p.Controls.Add(this.txt_PasswordAdmin);
            this.Admins_p.Controls.Add(this.guna2CirclePictureBox1);
            this.Admins_p.Controls.Add(this.txt_AdminName);
            this.guna2Transition1.SetDecoration(this.Admins_p, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Admins_p.Location = new System.Drawing.Point(365, 216);
            this.Admins_p.Name = "Admins_p";
            this.Admins_p.Size = new System.Drawing.Size(434, 400);
            this.Admins_p.TabIndex = 1;
            this.Admins_p.Visible = false;
            // 
            // elips_adminP
            // 
            this.elips_adminP.BorderRadius = 60;
            this.elips_adminP.TargetControl = this.Admins_p;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(149, 21);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(129, 98);
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // txt_AdminName
            // 
            this.txt_AdminName.BorderRadius = 15;
            this.txt_AdminName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_AdminName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_AdminName.DefaultText = "";
            this.txt_AdminName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AdminName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AdminName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AdminName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AdminName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AdminName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_AdminName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AdminName.Location = new System.Drawing.Point(45, 153);
            this.txt_AdminName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_AdminName.Name = "txt_AdminName";
            this.txt_AdminName.PasswordChar = '\0';
            this.txt_AdminName.PlaceholderText = "ادخل اسم المستخدم";
            this.txt_AdminName.SelectedText = "";
            this.txt_AdminName.Size = new System.Drawing.Size(358, 53);
            this.txt_AdminName.TabIndex = 1;
            this.txt_AdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_PasswordAdmin
            // 
            this.txt_PasswordAdmin.BorderRadius = 15;
            this.txt_PasswordAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_PasswordAdmin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_PasswordAdmin.DefaultText = "";
            this.txt_PasswordAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PasswordAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PasswordAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PasswordAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PasswordAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PasswordAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PasswordAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PasswordAdmin.Location = new System.Drawing.Point(45, 237);
            this.txt_PasswordAdmin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_PasswordAdmin.Name = "txt_PasswordAdmin";
            this.txt_PasswordAdmin.PasswordChar = '*';
            this.txt_PasswordAdmin.PlaceholderText = "ادخل كلمة السر";
            this.txt_PasswordAdmin.SelectedText = "";
            this.txt_PasswordAdmin.Size = new System.Drawing.Size(358, 53);
            this.txt_PasswordAdmin.TabIndex = 2;
            this.txt_PasswordAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_adminLog
            // 
            this.btn_adminLog.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.btn_adminLog, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_adminLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_adminLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_adminLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_adminLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_adminLog.FillColor = System.Drawing.Color.CadetBlue;
            this.btn_adminLog.Font = new System.Drawing.Font("Times New Roman", 10.125F);
            this.btn_adminLog.ForeColor = System.Drawing.Color.White;
            this.btn_adminLog.Location = new System.Drawing.Point(134, 329);
            this.btn_adminLog.Name = "btn_adminLog";
            this.btn_adminLog.Size = new System.Drawing.Size(180, 45);
            this.btn_adminLog.TabIndex = 3;
            this.btn_adminLog.Text = "تسجيل";
            this.btn_adminLog.Click += new System.EventHandler(this.btn_adminLog_Click);
            // 
            // P_add_skip
            // 
            this.P_add_skip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_add_skip.Controls.Add(this.label1);
            this.P_add_skip.Controls.Add(this.btn_AddingUsersOnStart);
            this.P_add_skip.Controls.Add(this.btn_SkipStartForm);
            this.guna2Transition1.SetDecoration(this.P_add_skip, Guna.UI2.AnimatorNS.DecorationType.None);
            this.P_add_skip.Location = new System.Drawing.Point(338, 317);
            this.P_add_skip.Name = "P_add_skip";
            this.P_add_skip.Size = new System.Drawing.Size(472, 198);
            this.P_add_skip.TabIndex = 4;
            this.P_add_skip.Visible = false;
            // 
            // btn_SkipStartForm
            // 
            this.btn_SkipStartForm.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.btn_SkipStartForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_SkipStartForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SkipStartForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SkipStartForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SkipStartForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SkipStartForm.FillColor = System.Drawing.Color.CadetBlue;
            this.btn_SkipStartForm.Font = new System.Drawing.Font("Times New Roman", 10.125F);
            this.btn_SkipStartForm.ForeColor = System.Drawing.Color.White;
            this.btn_SkipStartForm.Location = new System.Drawing.Point(238, 132);
            this.btn_SkipStartForm.Name = "btn_SkipStartForm";
            this.btn_SkipStartForm.Size = new System.Drawing.Size(180, 45);
            this.btn_SkipStartForm.TabIndex = 3;
            this.btn_SkipStartForm.Text = "تخطي";
            // 
            // btn_AddingUsersOnStart
            // 
            this.btn_AddingUsersOnStart.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.btn_AddingUsersOnStart, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_AddingUsersOnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddingUsersOnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddingUsersOnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddingUsersOnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddingUsersOnStart.FillColor = System.Drawing.Color.CadetBlue;
            this.btn_AddingUsersOnStart.Font = new System.Drawing.Font("Times New Roman", 10.125F);
            this.btn_AddingUsersOnStart.ForeColor = System.Drawing.Color.White;
            this.btn_AddingUsersOnStart.Location = new System.Drawing.Point(9, 132);
            this.btn_AddingUsersOnStart.Name = "btn_AddingUsersOnStart";
            this.btn_AddingUsersOnStart.Size = new System.Drawing.Size(180, 45);
            this.btn_AddingUsersOnStart.TabIndex = 4;
            this.btn_AddingUsersOnStart.Text = "اضافه";
            this.btn_AddingUsersOnStart.Click += new System.EventHandler(this.btn_AddingUsersOnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(67, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "هل تريد ان تضيف مستخدم جديد";
            // 
            // elips_add_skipP
            // 
            this.elips_add_skipP.BorderRadius = 50;
            this.elips_add_skipP.TargetControl = this.P_add_skip;
            // 
            // AddingUsersP
            // 
            this.AddingUsersP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddingUsersP.Controls.Add(this.txt_conformAddingUserPassword);
            this.AddingUsersP.Controls.Add(this.txt_UserNameAdding);
            this.AddingUsersP.Controls.Add(this.pic_addingUserP);
            this.AddingUsersP.Controls.Add(this.btn_loginAddingUsers);
            this.AddingUsersP.Controls.Add(this.txt_PasswordUserAdding);
            this.AddingUsersP.Controls.Add(this.txt_FullNameUserAdding);
            this.guna2Transition1.SetDecoration(this.AddingUsersP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AddingUsersP.Location = new System.Drawing.Point(327, 189);
            this.AddingUsersP.Name = "AddingUsersP";
            this.AddingUsersP.Size = new System.Drawing.Size(512, 452);
            this.AddingUsersP.TabIndex = 4;
            this.AddingUsersP.Visible = false;
            // 
            // btn_loginAddingUsers
            // 
            this.btn_loginAddingUsers.BorderRadius = 15;
            this.guna2Transition1.SetDecoration(this.btn_loginAddingUsers, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_loginAddingUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_loginAddingUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_loginAddingUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_loginAddingUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_loginAddingUsers.FillColor = System.Drawing.Color.CadetBlue;
            this.btn_loginAddingUsers.Font = new System.Drawing.Font("Times New Roman", 10.125F);
            this.btn_loginAddingUsers.ForeColor = System.Drawing.Color.White;
            this.btn_loginAddingUsers.Location = new System.Drawing.Point(172, 383);
            this.btn_loginAddingUsers.Name = "btn_loginAddingUsers";
            this.btn_loginAddingUsers.Size = new System.Drawing.Size(180, 45);
            this.btn_loginAddingUsers.TabIndex = 3;
            this.btn_loginAddingUsers.Text = "تسجيل";
            this.btn_loginAddingUsers.Click += new System.EventHandler(this.btn_loginAddingUsers_Click);
            // 
            // txt_PasswordUserAdding
            // 
            this.txt_PasswordUserAdding.BorderRadius = 15;
            this.txt_PasswordUserAdding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_PasswordUserAdding, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_PasswordUserAdding.DefaultText = "";
            this.txt_PasswordUserAdding.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PasswordUserAdding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PasswordUserAdding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PasswordUserAdding.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PasswordUserAdding.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PasswordUserAdding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PasswordUserAdding.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PasswordUserAdding.Location = new System.Drawing.Point(45, 230);
            this.txt_PasswordUserAdding.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_PasswordUserAdding.Name = "txt_PasswordUserAdding";
            this.txt_PasswordUserAdding.PasswordChar = '*';
            this.txt_PasswordUserAdding.PlaceholderText = "ادخل كلمة السر";
            this.txt_PasswordUserAdding.SelectedText = "";
            this.txt_PasswordUserAdding.Size = new System.Drawing.Size(429, 53);
            this.txt_PasswordUserAdding.TabIndex = 2;
            this.txt_PasswordUserAdding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_FullNameUserAdding
            // 
            this.txt_FullNameUserAdding.BorderRadius = 15;
            this.txt_FullNameUserAdding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_FullNameUserAdding, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_FullNameUserAdding.DefaultText = "";
            this.txt_FullNameUserAdding.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_FullNameUserAdding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_FullNameUserAdding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FullNameUserAdding.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FullNameUserAdding.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FullNameUserAdding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_FullNameUserAdding.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FullNameUserAdding.Location = new System.Drawing.Point(45, 153);
            this.txt_FullNameUserAdding.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_FullNameUserAdding.Name = "txt_FullNameUserAdding";
            this.txt_FullNameUserAdding.PasswordChar = '\0';
            this.txt_FullNameUserAdding.PlaceholderText = "ادخل الاسم الرباعي";
            this.txt_FullNameUserAdding.SelectedText = "";
            this.txt_FullNameUserAdding.Size = new System.Drawing.Size(422, 53);
            this.txt_FullNameUserAdding.TabIndex = 1;
            this.txt_FullNameUserAdding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // elips_addingUser
            // 
            this.elips_addingUser.BorderRadius = 70;
            this.elips_addingUser.TargetControl = this.AddingUsersP;
            // 
            // elips_pic_addingUserP
            // 
            this.elips_pic_addingUserP.BorderRadius = 60;
            this.elips_pic_addingUserP.TargetControl = this.pic_addingUserP;
            // 
            // pic_addingUserP
            // 
            this.guna2Transition1.SetDecoration(this.pic_addingUserP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pic_addingUserP.ImageRotate = 0F;
            this.pic_addingUserP.Location = new System.Drawing.Point(30, 41);
            this.pic_addingUserP.Name = "pic_addingUserP";
            this.pic_addingUserP.Size = new System.Drawing.Size(134, 79);
            this.pic_addingUserP.TabIndex = 4;
            this.pic_addingUserP.TabStop = false;
            // 
            // txt_UserNameAdding
            // 
            this.txt_UserNameAdding.BorderRadius = 15;
            this.txt_UserNameAdding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_UserNameAdding, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_UserNameAdding.DefaultText = "";
            this.txt_UserNameAdding.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_UserNameAdding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_UserNameAdding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserNameAdding.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserNameAdding.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserNameAdding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_UserNameAdding.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserNameAdding.Location = new System.Drawing.Point(202, 60);
            this.txt_UserNameAdding.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_UserNameAdding.Name = "txt_UserNameAdding";
            this.txt_UserNameAdding.PasswordChar = '\0';
            this.txt_UserNameAdding.PlaceholderText = "ادخل اسم المستخدم";
            this.txt_UserNameAdding.SelectedText = "";
            this.txt_UserNameAdding.Size = new System.Drawing.Size(265, 53);
            this.txt_UserNameAdding.TabIndex = 5;
            this.txt_UserNameAdding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_conformAddingUserPassword
            // 
            this.txt_conformAddingUserPassword.BorderRadius = 15;
            this.txt_conformAddingUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_conformAddingUserPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_conformAddingUserPassword.DefaultText = "";
            this.txt_conformAddingUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_conformAddingUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_conformAddingUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_conformAddingUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_conformAddingUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_conformAddingUserPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_conformAddingUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_conformAddingUserPassword.Location = new System.Drawing.Point(38, 308);
            this.txt_conformAddingUserPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_conformAddingUserPassword.Name = "txt_conformAddingUserPassword";
            this.txt_conformAddingUserPassword.PasswordChar = '*';
            this.txt_conformAddingUserPassword.PlaceholderText = "تاكيد كلمة السر";
            this.txt_conformAddingUserPassword.SelectedText = "";
            this.txt_conformAddingUserPassword.Size = new System.Drawing.Size(429, 53);
            this.txt_conformAddingUserPassword.TabIndex = 6;
            this.txt_conformAddingUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation4;
            // 
            // design_cir1
            // 
            this.guna2Transition1.SetDecoration(this.design_cir1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.design_cir1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.design_cir1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.design_cir1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.design_cir1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.design_cir1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(75)))), ((int)(((byte)(211)))));
            this.design_cir1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.design_cir1.ForeColor = System.Drawing.Color.White;
            this.design_cir1.Location = new System.Drawing.Point(1008, 560);
            this.design_cir1.Name = "design_cir1";
            this.design_cir1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.design_cir1.Size = new System.Drawing.Size(176, 220);
            this.design_cir1.TabIndex = 4;
            // 
            // design_cir2
            // 
            this.guna2Transition1.SetDecoration(this.design_cir2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.design_cir2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.design_cir2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.design_cir2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.design_cir2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.design_cir2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(75)))), ((int)(((byte)(211)))));
            this.design_cir2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.design_cir2.ForeColor = System.Drawing.Color.White;
            this.design_cir2.Location = new System.Drawing.Point(-104, 570);
            this.design_cir2.Name = "design_cir2";
            this.design_cir2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.design_cir2.Size = new System.Drawing.Size(185, 245);
            this.design_cir2.TabIndex = 5;
            this.design_cir2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label_we4);
            this.panel1.Controls.Add(this.label_we3);
            this.panel1.Controls.Add(this.design_cir1);
            this.panel1.Controls.Add(this.design_cir2);
            this.panel1.Controls.Add(this.label_we2);
            this.panel1.Controls.Add(this.label_we);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 660);
            this.panel1.TabIndex = 8;
            // 
            // label_we4
            // 
            this.label_we4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label_we4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_we4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_we4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_we4.Location = new System.Drawing.Point(228, 440);
            this.label_we4.Name = "label_we4";
            this.label_we4.Size = new System.Drawing.Size(652, 124);
            this.label_we4.TabIndex = 7;
            this.label_we4.Text = "احصل علئ نظرة شاملة علئ الديون \r\n والمستحقة والمدفوعة في مكان واحد";
            this.label_we4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_we3
            // 
            this.label_we3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label_we3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_we3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_we3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_we3.Location = new System.Drawing.Point(155, 317);
            this.label_we3.Name = "label_we3";
            this.label_we3.Size = new System.Drawing.Size(798, 124);
            this.label_we3.TabIndex = 6;
            this.label_we3.Text = "ساعدك في تنظيم وتتبع ديونك بسهوله وفعالية \r\n  ";
            // 
            // label_we2
            // 
            this.label_we2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label_we2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_we2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_we2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_we2.Location = new System.Drawing.Point(316, 223);
            this.label_we2.Name = "label_we2";
            this.label_we2.Size = new System.Drawing.Size(477, 62);
            this.label_we2.TabIndex = 5;
            this.label_we2.Text = "بك في تطبيق ادارة الديون ";
            // 
            // label_we
            // 
            this.label_we.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label_we, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_we.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_we.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_we.Location = new System.Drawing.Point(490, 96);
            this.label_we.Name = "label_we";
            this.label_we.Size = new System.Drawing.Size(128, 62);
            this.label_we.TabIndex = 4;
            this.label_we.Text = "مرحبا";
            // 
            // btn_Start
            // 
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btn_Start, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Start.Location = new System.Drawing.Point(466, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(147, 81);
            this.btn_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Start.TabIndex = 5;
            this.btn_Start.TabStop = false;
            this.btn_Start.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 775);
            this.Controls.Add(this.Container_Start);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start_Form";
            this.Text = "Start_Form";
            this.Load += new System.EventHandler(this.Start_Form_Load);
            this.Start_p.ResumeLayout(false);
            this.Container_Start.ResumeLayout(false);
            this.Admins_p.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.P_add_skip.ResumeLayout(false);
            this.P_add_skip.PerformLayout();
            this.AddingUsersP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_addingUserP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Start_p;
        private Guna.UI2.WinForms.Guna2Elipse elips_startP;
        private System.Windows.Forms.Timer effict_Timer;
        private System.Windows.Forms.Panel Container_Start;
        private System.Windows.Forms.Panel Admins_p;
        private Guna.UI2.WinForms.Guna2Button btn_adminLog;
        private Guna.UI2.WinForms.Guna2TextBox txt_PasswordAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txt_AdminName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse elips_adminP;
        private System.Windows.Forms.Panel P_add_skip;
        private Guna.UI2.WinForms.Guna2Button btn_SkipStartForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_AddingUsersOnStart;
        private Guna.UI2.WinForms.Guna2Elipse elips_add_skipP;
        private System.Windows.Forms.Panel AddingUsersP;
        private Guna.UI2.WinForms.Guna2Button btn_loginAddingUsers;
        private Guna.UI2.WinForms.Guna2TextBox txt_PasswordUserAdding;
        private Guna.UI2.WinForms.Guna2TextBox txt_FullNameUserAdding;
        private Guna.UI2.WinForms.Guna2Elipse elips_addingUser;
        private Guna.UI2.WinForms.Guna2Elipse elips_pic_addingUserP;
        private Guna.UI2.WinForms.Guna2TextBox txt_conformAddingUserPassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_UserNameAdding;
        private Guna.UI2.WinForms.Guna2PictureBox pic_addingUserP;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2CircleButton design_cir2;
        private Guna.UI2.WinForms.Guna2CircleButton design_cir1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_we4;
        private System.Windows.Forms.Label label_we3;
        private System.Windows.Forms.Label label_we2;
        private System.Windows.Forms.Label label_we;
        private System.Windows.Forms.PictureBox btn_Start;
    }
}