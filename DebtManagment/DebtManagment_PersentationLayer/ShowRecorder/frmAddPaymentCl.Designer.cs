namespace DebtManagment_PersentationLayer.ShowRecorder
{
    partial class frmAddUpdatePayment
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
            this.money_P = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.add_money_toTable = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAmountOfMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.EliSupp = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.money_P.SuspendLayout();
            this.SuspendLayout();
            // 
            // money_P
            // 
            this.money_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(132)))));
            this.money_P.Controls.Add(this.button2);
            this.money_P.Controls.Add(this.btn_close);
            this.money_P.Controls.Add(this.add_money_toTable);
            this.money_P.Controls.Add(this.label10);
            this.money_P.Controls.Add(this.label11);
            this.money_P.Controls.Add(this.txtAmountOfMoney);
            this.money_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.money_P.Location = new System.Drawing.Point(0, 0);
            this.money_P.Margin = new System.Windows.Forms.Padding(2);
            this.money_P.Name = "money_P";
            this.money_P.Size = new System.Drawing.Size(426, 173);
            this.money_P.TabIndex = 8;
            this.money_P.Paint += new System.Windows.Forms.PaintEventHandler(this.money_P_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = global::DebtManagment_PersentationLayer.Properties.Resources.delete;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(-1, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 33);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_close
            // 
            this.btn_close.BorderRadius = 15;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.White;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btn_close.Location = new System.Drawing.Point(141, 116);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(105, 28);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "اغلاق";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // add_money_toTable
            // 
            this.add_money_toTable.BorderRadius = 15;
            this.add_money_toTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_money_toTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_money_toTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_money_toTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_money_toTable.FillColor = System.Drawing.Color.White;
            this.add_money_toTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_money_toTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.add_money_toTable.Location = new System.Drawing.Point(261, 116);
            this.add_money_toTable.Margin = new System.Windows.Forms.Padding(2);
            this.add_money_toTable.Name = "add_money_toTable";
            this.add_money_toTable.Size = new System.Drawing.Size(105, 28);
            this.add_money_toTable.TabIndex = 5;
            this.add_money_toTable.Text = "اضافة";
            this.add_money_toTable.Click += new System.EventHandler(this.add_money_toTable_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(314, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "ادخال الدفعه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(228, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "ادخل المبلغ المراد دفعه ";
            // 
            // txtAmountOfMoney
            // 
            this.txtAmountOfMoney.BorderRadius = 15;
            this.txtAmountOfMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountOfMoney.DefaultText = "";
            this.txtAmountOfMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmountOfMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmountOfMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountOfMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountOfMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountOfMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfMoney.ForeColor = System.Drawing.Color.Black;
            this.txtAmountOfMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountOfMoney.Location = new System.Drawing.Point(55, 55);
            this.txtAmountOfMoney.Margin = new System.Windows.Forms.Padding(7);
            this.txtAmountOfMoney.Multiline = true;
            this.txtAmountOfMoney.Name = "txtAmountOfMoney";
            this.txtAmountOfMoney.PasswordChar = '\0';
            this.txtAmountOfMoney.PlaceholderText = "";
            this.txtAmountOfMoney.SelectedText = "";
            this.txtAmountOfMoney.Size = new System.Drawing.Size(312, 52);
            this.txtAmountOfMoney.TabIndex = 2;
            // 
            // EliSupp
            // 
            this.EliSupp.BorderRadius = 30;
            this.EliSupp.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.money_P;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmAddUpdatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 173);
            this.Controls.Add(this.money_P);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdatePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPayment";
            this.Load += new System.EventHandler(this.frmAddPayment_Load);
            this.money_P.ResumeLayout(false);
            this.money_P.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel money_P;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2Button add_money_toTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtAmountOfMoney;
        private Guna.UI2.WinForms.Guna2Elipse EliSupp;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}