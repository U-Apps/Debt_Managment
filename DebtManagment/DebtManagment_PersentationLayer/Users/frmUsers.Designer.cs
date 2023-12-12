namespace DebtManagment_PersentationLayer
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.edit = new Guna.UI2.WinForms.Guna2Button();
            this.print = new Guna.UI2.WinForms.Guna2Button();
            this.update = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_Users = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elips_adding_p = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 41);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 41);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Add);
            this.panel3.Controls.Add(this.delete);
            this.panel3.Controls.Add(this.edit);
            this.panel3.Controls.Add(this.print);
            this.panel3.Controls.Add(this.update);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 80);
            this.panel3.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.FillColor = System.Drawing.Color.Transparent;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Image = global::DebtManagment_PersentationLayer.Properties.Resources.add_button2;
            this.Add.ImageSize = new System.Drawing.Size(30, 30);
            this.Add.Location = new System.Drawing.Point(712, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(200, 80);
            this.Add.TabIndex = 6;
            this.Add.Text = "إضافة";
            this.Add.Tile = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete.FillColor = System.Drawing.Color.Transparent;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Image = global::DebtManagment_PersentationLayer.Properties.Resources.user1;
            this.delete.ImageSize = new System.Drawing.Size(30, 30);
            this.delete.Location = new System.Drawing.Point(517, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(195, 80);
            this.delete.TabIndex = 5;
            this.delete.Text = "حذف";
            this.delete.Tile = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit.FillColor = System.Drawing.Color.Transparent;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edit.ForeColor = System.Drawing.Color.Black;
            this.edit.Image = global::DebtManagment_PersentationLayer.Properties.Resources.edit_info1;
            this.edit.ImageSize = new System.Drawing.Size(30, 30);
            this.edit.Location = new System.Drawing.Point(329, 0);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(188, 80);
            this.edit.TabIndex = 4;
            this.edit.Text = "تعديل";
            this.edit.Tile = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // print
            // 
            this.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.print.Dock = System.Windows.Forms.DockStyle.Left;
            this.print.FillColor = System.Drawing.Color.Transparent;
            this.print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.print.ForeColor = System.Drawing.Color.Black;
            this.print.Image = global::DebtManagment_PersentationLayer.Properties.Resources.printer1;
            this.print.ImageSize = new System.Drawing.Size(30, 30);
            this.print.Location = new System.Drawing.Point(171, 0);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(158, 80);
            this.print.TabIndex = 3;
            this.print.Text = "طباعة";
            this.print.Tile = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // update
            // 
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update.Dock = System.Windows.Forms.DockStyle.Left;
            this.update.FillColor = System.Drawing.Color.Transparent;
            this.update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Image = global::DebtManagment_PersentationLayer.Properties.Resources.loop1;
            this.update.ImageSize = new System.Drawing.Size(30, 30);
            this.update.Location = new System.Drawing.Point(22, 0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(149, 80);
            this.update.TabIndex = 2;
            this.update.Text = "تحديث";
            this.update.Tile = true;
            this.update.Click += new System.EventHandler(this.Refrsh_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(22, 80);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(912, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 80);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV_Users);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 493);
            this.panel2.TabIndex = 5;
            // 
            // DGV_Users
            // 
            this.DGV_Users.AllowUserToAddRows = false;
            this.DGV_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGV_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Users.ColumnHeadersHeight = 20;
            this.DGV_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Users.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Users.Location = new System.Drawing.Point(15, 0);
            this.DGV_Users.Name = "DGV_Users";
            this.DGV_Users.ReadOnly = true;
            this.DGV_Users.RowHeadersVisible = false;
            this.DGV_Users.RowHeadersWidth = 82;
            this.DGV_Users.RowTemplate.Height = 25;
            this.DGV_Users.Size = new System.Drawing.Size(916, 493);
            this.DGV_Users.TabIndex = 3;
            this.DGV_Users.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Users.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_Users.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV_Users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_Users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV_Users.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Users.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Users.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGV_Users.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Users.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Users.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Users.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_Users.ThemeStyle.HeaderStyle.Height = 20;
            this.DGV_Users.ThemeStyle.ReadOnly = true;
            this.DGV_Users.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Users.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Users.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Users.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Users.ThemeStyle.RowsStyle.Height = 25;
            this.DGV_Users.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Users.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 493);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(931, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 493);
            this.panel6.TabIndex = 0;
            // 
            // elips_adding_p
            // 
            this.elips_adding_p.BorderRadius = 30;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(946, 614);
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button Add;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button edit;
        private Guna.UI2.WinForms.Guna2Button print;
        private Guna.UI2.WinForms.Guna2Button update;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse elips_adding_p;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2DataGridView DGV_Users;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
