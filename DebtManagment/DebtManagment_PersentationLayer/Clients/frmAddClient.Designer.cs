namespace DebtManagment_PersentationLayer.Clients
{
    partial class frmAddClient
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
            this.Panel_AddClient = new System.Windows.Forms.Panel();
            this.gbxPersonOrCompany = new System.Windows.Forms.GroupBox();
            this.rdCompany = new System.Windows.Forms.RadioButton();
            this.rdPerson = new System.Windows.Forms.RadioButton();
            this.lblCommercial_Registration = new System.Windows.Forms.Label();
            this.txt_commecial = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txt_SSN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txt_CustomerPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_CloseAddClientPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SaveClient = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txt_CoustmerEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CoustmerAdress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CoustmerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.elips_P = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Panel_AddClient.SuspendLayout();
            this.gbxPersonOrCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_AddClient
            // 
            this.Panel_AddClient.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_AddClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_AddClient.Controls.Add(this.gbxPersonOrCompany);
            this.Panel_AddClient.Controls.Add(this.lblCommercial_Registration);
            this.Panel_AddClient.Controls.Add(this.txt_commecial);
            this.Panel_AddClient.Controls.Add(this.lblSSN);
            this.Panel_AddClient.Controls.Add(this.txt_SSN);
            this.Panel_AddClient.Controls.Add(this.lblPhone);
            this.Panel_AddClient.Controls.Add(this.txt_CustomerPhone);
            this.Panel_AddClient.Controls.Add(this.button1);
            this.Panel_AddClient.Controls.Add(this.label5);
            this.Panel_AddClient.Controls.Add(this.btn_CloseAddClientPanel);
            this.Panel_AddClient.Controls.Add(this.btn_SaveClient);
            this.Panel_AddClient.Controls.Add(this.lblEmail);
            this.Panel_AddClient.Controls.Add(this.lblAddress);
            this.Panel_AddClient.Controls.Add(this.lblClientName);
            this.Panel_AddClient.Controls.Add(this.txt_CoustmerEmail);
            this.Panel_AddClient.Controls.Add(this.txt_CoustmerAdress);
            this.Panel_AddClient.Controls.Add(this.txt_CoustmerName);
            this.Panel_AddClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_AddClient.Location = new System.Drawing.Point(0, 0);
            this.Panel_AddClient.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_AddClient.Name = "Panel_AddClient";
            this.Panel_AddClient.Size = new System.Drawing.Size(814, 486);
            this.Panel_AddClient.TabIndex = 8;
            this.Panel_AddClient.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_AddClient_Paint);
            // 
            // gbxPersonOrCompany
            // 
            this.gbxPersonOrCompany.Controls.Add(this.rdCompany);
            this.gbxPersonOrCompany.Controls.Add(this.rdPerson);
            this.gbxPersonOrCompany.Location = new System.Drawing.Point(201, 347);
            this.gbxPersonOrCompany.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxPersonOrCompany.Name = "gbxPersonOrCompany";
            this.gbxPersonOrCompany.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbxPersonOrCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxPersonOrCompany.Size = new System.Drawing.Size(457, 55);
            this.gbxPersonOrCompany.TabIndex = 17;
            this.gbxPersonOrCompany.TabStop = false;
            // 
            // rdCompany
            // 
            this.rdCompany.AutoSize = true;
            this.rdCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCompany.Location = new System.Drawing.Point(93, 21);
            this.rdCompany.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdCompany.Name = "rdCompany";
            this.rdCompany.Size = new System.Drawing.Size(64, 28);
            this.rdCompany.TabIndex = 1;
            this.rdCompany.TabStop = true;
            this.rdCompany.Text = "شركة";
            this.rdCompany.UseVisualStyleBackColor = true;
            this.rdCompany.CheckedChanged += new System.EventHandler(this.rdCompany_CheckedChanged);
            // 
            // rdPerson
            // 
            this.rdPerson.AutoSize = true;
            this.rdPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPerson.Location = new System.Drawing.Point(313, 20);
            this.rdPerson.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdPerson.Name = "rdPerson";
            this.rdPerson.Size = new System.Drawing.Size(51, 28);
            this.rdPerson.TabIndex = 0;
            this.rdPerson.TabStop = true;
            this.rdPerson.Text = "فرد";
            this.rdPerson.UseVisualStyleBackColor = true;
            this.rdPerson.CheckedChanged += new System.EventHandler(this.rdPerson_CheckedChanged);
            // 
            // lblCommercial_Registration
            // 
            this.lblCommercial_Registration.AutoSize = true;
            this.lblCommercial_Registration.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommercial_Registration.Location = new System.Drawing.Point(159, 242);
            this.lblCommercial_Registration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommercial_Registration.Name = "lblCommercial_Registration";
            this.lblCommercial_Registration.Size = new System.Drawing.Size(116, 26);
            this.lblCommercial_Registration.TabIndex = 16;
            this.lblCommercial_Registration.Text = "السجل التجاري";
            this.lblCommercial_Registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_commecial
            // 
            this.txt_commecial.BorderRadius = 15;
            this.txt_commecial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_commecial.DefaultText = "";
            this.txt_commecial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_commecial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_commecial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_commecial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_commecial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_commecial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_commecial.ForeColor = System.Drawing.Color.Black;
            this.txt_commecial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_commecial.Location = new System.Drawing.Point(44, 283);
            this.txt_commecial.Margin = new System.Windows.Forms.Padding(7);
            this.txt_commecial.Name = "txt_commecial";
            this.txt_commecial.PasswordChar = '\0';
            this.txt_commecial.PlaceholderText = "";
            this.txt_commecial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_commecial.SelectedText = "";
            this.txt_commecial.Size = new System.Drawing.Size(349, 37);
            this.txt_commecial.TabIndex = 15;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(611, 240);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(50, 26);
            this.lblSSN.TabIndex = 14;
            this.lblSSN.Text = "SSN";
            this.lblSSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SSN
            // 
            this.txt_SSN.BorderRadius = 15;
            this.txt_SSN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SSN.DefaultText = "";
            this.txt_SSN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SSN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SSN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SSN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SSN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SSN.ForeColor = System.Drawing.Color.Black;
            this.txt_SSN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SSN.Location = new System.Drawing.Point(464, 284);
            this.txt_SSN.Margin = new System.Windows.Forms.Padding(7);
            this.txt_SSN.Name = "txt_SSN";
            this.txt_SSN.PasswordChar = '\0';
            this.txt_SSN.PlaceholderText = "";
            this.txt_SSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SSN.SelectedText = "";
            this.txt_SSN.Size = new System.Drawing.Size(329, 37);
            this.txt_SSN.TabIndex = 13;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(168, 135);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(86, 26);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "رقم الهاتف";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_CustomerPhone
            // 
            this.txt_CustomerPhone.BorderRadius = 15;
            this.txt_CustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CustomerPhone.DefaultText = "";
            this.txt_CustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CustomerPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerPhone.ForeColor = System.Drawing.Color.Black;
            this.txt_CustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CustomerPhone.Location = new System.Drawing.Point(44, 181);
            this.txt_CustomerPhone.Margin = new System.Windows.Forms.Padding(7);
            this.txt_CustomerPhone.Name = "txt_CustomerPhone";
            this.txt_CustomerPhone.PasswordChar = '\0';
            this.txt_CustomerPhone.PlaceholderText = "";
            this.txt_CustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CustomerPhone.SelectedText = "";
            this.txt_CustomerPhone.Size = new System.Drawing.Size(349, 37);
            this.txt_CustomerPhone.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = global::DebtManagment_PersentationLayer.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 33);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_close_frmAddClient);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(730, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "اضافه عميل";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CloseAddClientPanel
            // 
            this.btn_CloseAddClientPanel.BorderRadius = 15;
            this.btn_CloseAddClientPanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CloseAddClientPanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CloseAddClientPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CloseAddClientPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CloseAddClientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(132)))));
            this.btn_CloseAddClientPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_CloseAddClientPanel.ForeColor = System.Drawing.Color.White;
            this.btn_CloseAddClientPanel.Location = new System.Drawing.Point(16, 427);
            this.btn_CloseAddClientPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CloseAddClientPanel.Name = "btn_CloseAddClientPanel";
            this.btn_CloseAddClientPanel.Size = new System.Drawing.Size(181, 44);
            this.btn_CloseAddClientPanel.TabIndex = 7;
            this.btn_CloseAddClientPanel.Text = "اغلاق";
            this.btn_CloseAddClientPanel.Click += new System.EventHandler(this.btn_CloseAddClientPanel_Click);
            // 
            // btn_SaveClient
            // 
            this.btn_SaveClient.BorderRadius = 15;
            this.btn_SaveClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SaveClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SaveClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SaveClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SaveClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(132)))));
            this.btn_SaveClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SaveClient.ForeColor = System.Drawing.Color.White;
            this.btn_SaveClient.Location = new System.Drawing.Point(611, 427);
            this.btn_SaveClient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SaveClient.Name = "btn_SaveClient";
            this.btn_SaveClient.Size = new System.Drawing.Size(181, 44);
            this.btn_SaveClient.TabIndex = 6;
            this.btn_SaveClient.Text = "حفظ";
            this.btn_SaveClient.Click += new System.EventHandler(this.btn_SaveClient_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(611, 140);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 26);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "الايميل";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(177, 32);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 26);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "العنوان";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft YaHei", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(611, 32);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(77, 26);
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "اسم عميل";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_CoustmerEmail
            // 
            this.txt_CoustmerEmail.BorderRadius = 15;
            this.txt_CoustmerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CoustmerEmail.DefaultText = "";
            this.txt_CoustmerEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CoustmerEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CoustmerEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CoustmerEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CoustmerEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CoustmerEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoustmerEmail.ForeColor = System.Drawing.Color.Black;
            this.txt_CoustmerEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CoustmerEmail.Location = new System.Drawing.Point(464, 180);
            this.txt_CoustmerEmail.Margin = new System.Windows.Forms.Padding(7);
            this.txt_CoustmerEmail.Name = "txt_CoustmerEmail";
            this.txt_CoustmerEmail.PasswordChar = '\0';
            this.txt_CoustmerEmail.PlaceholderText = "";
            this.txt_CoustmerEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CoustmerEmail.SelectedText = "";
            this.txt_CoustmerEmail.Size = new System.Drawing.Size(329, 37);
            this.txt_CoustmerEmail.TabIndex = 2;
            // 
            // txt_CoustmerAdress
            // 
            this.txt_CoustmerAdress.BorderRadius = 15;
            this.txt_CoustmerAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CoustmerAdress.DefaultText = "";
            this.txt_CoustmerAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CoustmerAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CoustmerAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CoustmerAdress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CoustmerAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CoustmerAdress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoustmerAdress.ForeColor = System.Drawing.Color.Black;
            this.txt_CoustmerAdress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CoustmerAdress.Location = new System.Drawing.Point(44, 66);
            this.txt_CoustmerAdress.Margin = new System.Windows.Forms.Padding(7);
            this.txt_CoustmerAdress.Name = "txt_CoustmerAdress";
            this.txt_CoustmerAdress.PasswordChar = '\0';
            this.txt_CoustmerAdress.PlaceholderText = "";
            this.txt_CoustmerAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CoustmerAdress.SelectedText = "";
            this.txt_CoustmerAdress.Size = new System.Drawing.Size(349, 37);
            this.txt_CoustmerAdress.TabIndex = 1;
            // 
            // txt_CoustmerName
            // 
            this.txt_CoustmerName.BorderRadius = 15;
            this.txt_CoustmerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CoustmerName.DefaultText = "";
            this.txt_CoustmerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CoustmerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CoustmerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CoustmerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CoustmerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CoustmerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoustmerName.ForeColor = System.Drawing.Color.Black;
            this.txt_CoustmerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CoustmerName.Location = new System.Drawing.Point(464, 65);
            this.txt_CoustmerName.Margin = new System.Windows.Forms.Padding(7);
            this.txt_CoustmerName.Name = "txt_CoustmerName";
            this.txt_CoustmerName.PasswordChar = '\0';
            this.txt_CoustmerName.PlaceholderText = "";
            this.txt_CoustmerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CoustmerName.SelectedText = "";
            this.txt_CoustmerName.Size = new System.Drawing.Size(329, 37);
            this.txt_CoustmerName.TabIndex = 0;
            // 
            // elips_P
            // 
            this.elips_P.BorderRadius = 20;
            this.elips_P.TargetControl = this.Panel_AddClient;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.Panel_AddClient;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 486);
            this.Controls.Add(this.Panel_AddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddClient";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.Panel_AddClient.ResumeLayout(false);
            this.Panel_AddClient.PerformLayout();
            this.gbxPersonOrCompany.ResumeLayout(false);
            this.gbxPersonOrCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_AddClient;
        private System.Windows.Forms.GroupBox gbxPersonOrCompany;
        private System.Windows.Forms.RadioButton rdCompany;
        private System.Windows.Forms.RadioButton rdPerson;
        private System.Windows.Forms.Label lblCommercial_Registration;
        private Guna.UI2.WinForms.Guna2TextBox txt_commecial;
        private System.Windows.Forms.Label lblSSN;
        private Guna.UI2.WinForms.Guna2TextBox txt_SSN;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI2.WinForms.Guna2TextBox txt_CustomerPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_CloseAddClientPanel;
        private Guna.UI2.WinForms.Guna2Button btn_SaveClient;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblClientName;
        private Guna.UI2.WinForms.Guna2TextBox txt_CoustmerEmail;
        private Guna.UI2.WinForms.Guna2TextBox txt_CoustmerAdress;
        private Guna.UI2.WinForms.Guna2TextBox txt_CoustmerName;
        private Guna.UI2.WinForms.Guna2Elipse elips_P;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}