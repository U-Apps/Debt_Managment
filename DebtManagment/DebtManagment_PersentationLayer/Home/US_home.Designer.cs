namespace DebtManagment_PersentationLayer
{
    partial class US_home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Name_of_Company = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pic_logo_usGenerl = new System.Windows.Forms.PictureBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.TheTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_usGenerl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_of_Company
            // 
            this.Name_of_Company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_of_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_of_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name_of_Company.Location = new System.Drawing.Point(9, 402);
            this.Name_of_Company.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Name_of_Company.Name = "Name_of_Company";
            this.Name_of_Company.Size = new System.Drawing.Size(937, 117);
            this.Name_of_Company.TabIndex = 1;
            this.Name_of_Company.Text = "اسم الشعار";
            this.Name_of_Company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 13;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pic_logo_usGenerl
            // 
            this.pic_logo_usGenerl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo_usGenerl.Image = global::DebtManagment_PersentationLayer.Properties.Resources.edit_info;
            this.pic_logo_usGenerl.Location = new System.Drawing.Point(2247, 1278);
            this.pic_logo_usGenerl.Margin = new System.Windows.Forms.Padding(9);
            this.pic_logo_usGenerl.Name = "pic_logo_usGenerl";
            this.pic_logo_usGenerl.Size = new System.Drawing.Size(0, 0);
            this.pic_logo_usGenerl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo_usGenerl.TabIndex = 0;
            this.pic_logo_usGenerl.TabStop = false;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Logo.Image = global::DebtManagment_PersentationLayer.Properties.Resources.edit_info;
            this.pic_Logo.Location = new System.Drawing.Point(29, 136);
            this.pic_Logo.Margin = new System.Windows.Forms.Padding(9);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(917, 234);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 2;
            this.pic_Logo.TabStop = false;
            // 
            // TheTime
            // 
            this.TheTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TheTime.Location = new System.Drawing.Point(9, 497);
            this.TheTime.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.TheTime.Name = "TheTime";
            this.TheTime.Size = new System.Drawing.Size(937, 117);
            this.TheTime.TabIndex = 3;
            this.TheTime.Text = "اسم الشعار";
            this.TheTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // US_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 64F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TheTime);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.Name_of_Company);
            this.Controls.Add(this.pic_logo_usGenerl);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "US_home";
            this.Size = new System.Drawing.Size(946, 614);
            this.Load += new System.EventHandler(this.US_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_usGenerl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo_usGenerl;
        private System.Windows.Forms.Label Name_of_Company;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label TheTime;
        private System.Windows.Forms.Timer timer1;
    }
}
