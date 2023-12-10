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
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_usGenerl)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_of_Company
            // 
            this.Name_of_Company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_of_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_of_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name_of_Company.Location = new System.Drawing.Point(0, 539);
            this.Name_of_Company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_of_Company.Name = "Name_of_Company";
            this.Name_of_Company.Size = new System.Drawing.Size(1100, 52);
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
            this.pic_logo_usGenerl.Location = new System.Drawing.Point(280, 151);
            this.pic_logo_usGenerl.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo_usGenerl.Name = "pic_logo_usGenerl";
            this.pic_logo_usGenerl.Size = new System.Drawing.Size(567, 287);
            this.pic_logo_usGenerl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo_usGenerl.TabIndex = 0;
            this.pic_logo_usGenerl.TabStop = false;
            // 
            // US_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Name_of_Company);
            this.Controls.Add(this.pic_logo_usGenerl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "US_home";
            this.Size = new System.Drawing.Size(1104, 756);
            this.Load += new System.EventHandler(this.US_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_usGenerl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo_usGenerl;
        private System.Windows.Forms.Label Name_of_Company;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
