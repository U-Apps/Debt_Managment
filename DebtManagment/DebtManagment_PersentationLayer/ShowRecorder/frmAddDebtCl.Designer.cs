namespace DebtManagment_PersentationLayer.ShowRecorder
{
    partial class frmAddUpdateDebt
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
            this.addItems_P = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addTotable_dept = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMateraicl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.addItems_P.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItems_P
            // 
            this.addItems_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(132)))));
            this.addItems_P.Controls.Add(this.button1);
            this.addItems_P.Controls.Add(this.btn_addTotable_dept);
            this.addItems_P.Controls.Add(this.label1);
            this.addItems_P.Controls.Add(this.label2);
            this.addItems_P.Controls.Add(this.txtPrice);
            this.addItems_P.Controls.Add(this.txtMateraicl);
            this.addItems_P.Controls.Add(this.label3);
            this.addItems_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItems_P.Location = new System.Drawing.Point(0, 0);
            this.addItems_P.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItems_P.Name = "addItems_P";
            this.addItems_P.Size = new System.Drawing.Size(378, 356);
            this.addItems_P.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = global::DebtManagment_PersentationLayer.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 39);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addTotable_dept
            // 
            this.btn_addTotable_dept.BorderRadius = 15;
            this.btn_addTotable_dept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addTotable_dept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addTotable_dept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addTotable_dept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addTotable_dept.FillColor = System.Drawing.Color.White;
            this.btn_addTotable_dept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addTotable_dept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btn_addTotable_dept.Location = new System.Drawing.Point(129, 299);
            this.btn_addTotable_dept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addTotable_dept.Name = "btn_addTotable_dept";
            this.btn_addTotable_dept.Size = new System.Drawing.Size(135, 33);
            this.btn_addTotable_dept.TabIndex = 5;
            this.btn_addTotable_dept.Text = "اضافة";
            this.btn_addTotable_dept.Click += new System.EventHandler(this.btn_addTotable_dept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "اضافة دين للعميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "المبلغ";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 15;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(51, 217);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(279, 58);
            this.txtPrice.TabIndex = 2;
            // 
            // txtMateraicl
            // 
            this.txtMateraicl.BorderRadius = 15;
            this.txtMateraicl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMateraicl.DefaultText = "";
            this.txtMateraicl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMateraicl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMateraicl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMateraicl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMateraicl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMateraicl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMateraicl.ForeColor = System.Drawing.Color.Black;
            this.txtMateraicl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMateraicl.Location = new System.Drawing.Point(51, 65);
            this.txtMateraicl.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtMateraicl.Multiline = true;
            this.txtMateraicl.Name = "txtMateraicl";
            this.txtMateraicl.PasswordChar = '\0';
            this.txtMateraicl.PlaceholderText = "";
            this.txtMateraicl.SelectedText = "";
            this.txtMateraicl.Size = new System.Drawing.Size(279, 107);
            this.txtMateraicl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "اسم المواد";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.addItems_P;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmAddUpdateDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 356);
            this.Controls.Add(this.addItems_P);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddUpdateDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddDebt";
            this.Load += new System.EventHandler(this.frmAddUpdateDebt_Load);
            this.addItems_P.ResumeLayout(false);
            this.addItems_P.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addItems_P;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button btn_addTotable_dept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtMateraicl;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}