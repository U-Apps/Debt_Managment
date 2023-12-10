namespace DebtManagment_PersentationLayer
{
    partial class AddClient
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
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.edit = new Guna.UI2.WinForms.Guna2Button();
            this.print = new Guna.UI2.WinForms.Guna2Button();
            this.update = new Guna.UI2.WinForms.Guna2Button();
            this.viewRecord = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.elips_P = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DGV_coustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_coustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 50);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1104, 50);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.add);
            this.panel3.Controls.Add(this.delete);
            this.panel3.Controls.Add(this.edit);
            this.panel3.Controls.Add(this.print);
            this.panel3.Controls.Add(this.update);
            this.panel3.Controls.Add(this.viewRecord);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 658);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 98);
            this.panel3.TabIndex = 4;
            // 
            // add
            // 
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.FillColor = System.Drawing.Color.Transparent;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Image = global::DebtManagment_PersentationLayer.Properties.Resources.add_button2;
            this.add.ImageSize = new System.Drawing.Size(30, 30);
            this.add.Location = new System.Drawing.Point(892, 0);
            this.add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(172, 98);
            this.add.TabIndex = 6;
            this.add.Text = "إضافة";
            this.add.Tile = true;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.delete.Location = new System.Drawing.Point(726, 0);
            this.delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(166, 98);
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
            this.edit.Location = new System.Drawing.Point(572, 0);
            this.edit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(154, 98);
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
            this.print.Location = new System.Drawing.Point(406, 0);
            this.print.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(166, 98);
            this.print.TabIndex = 3;
            this.print.Text = "طباعة";
            this.print.Tile = true;
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
            this.update.Location = new System.Drawing.Point(259, 0);
            this.update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(147, 98);
            this.update.TabIndex = 2;
            this.update.Text = "تحديث";
            this.update.Tile = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // viewRecord
            // 
            this.viewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viewRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewRecord.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewRecord.FillColor = System.Drawing.Color.Transparent;
            this.viewRecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewRecord.ForeColor = System.Drawing.Color.Black;
            this.viewRecord.Image = global::DebtManagment_PersentationLayer.Properties.Resources.criminal_record1;
            this.viewRecord.ImageSize = new System.Drawing.Size(30, 30);
            this.viewRecord.Location = new System.Drawing.Point(40, 0);
            this.viewRecord.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viewRecord.Name = "viewRecord";
            this.viewRecord.Size = new System.Drawing.Size(219, 98);
            this.viewRecord.TabIndex = 1;
            this.viewRecord.Text = "عرض سجل";
            this.viewRecord.Tile = true;
            this.viewRecord.Click += new System.EventHandler(this.viewRecord_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 98);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1064, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 98);
            this.panel4.TabIndex = 0;
            // 
            // elips_P
            // 
            this.elips_P.BorderRadius = 20;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1086, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 608);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(18, 608);
            this.panel6.TabIndex = 6;
            // 
            // DGV_coustomers
            // 
            this.DGV_coustomers.AllowUserToAddRows = false;
            this.DGV_coustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGV_coustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_coustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_coustomers.ColumnHeadersHeight = 30;
            this.DGV_coustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_coustomers.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_coustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_coustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_coustomers.Location = new System.Drawing.Point(18, 50);
            this.DGV_coustomers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DGV_coustomers.Name = "DGV_coustomers";
            this.DGV_coustomers.ReadOnly = true;
            this.DGV_coustomers.RowHeadersVisible = false;
            this.DGV_coustomers.RowHeadersWidth = 82;
            this.DGV_coustomers.RowTemplate.Height = 35;
            this.DGV_coustomers.Size = new System.Drawing.Size(1068, 608);
            this.DGV_coustomers.TabIndex = 7;
            this.DGV_coustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_coustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_coustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV_coustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_coustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV_coustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_coustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_coustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGV_coustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_coustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_coustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_coustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_coustomers.ThemeStyle.HeaderStyle.Height = 30;
            this.DGV_coustomers.ThemeStyle.ReadOnly = true;
            this.DGV_coustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_coustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_coustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_coustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_coustomers.ThemeStyle.RowsStyle.Height = 35;
            this.DGV_coustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_coustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV_coustomers);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddClient";
            this.Size = new System.Drawing.Size(1104, 756);
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_coustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button edit;
        private Guna.UI2.WinForms.Guna2Button print;
        private Guna.UI2.WinForms.Guna2Button update;
        private Guna.UI2.WinForms.Guna2Button viewRecord;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Elipse elips_P;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2DataGridView DGV_coustomers;
    }
}
