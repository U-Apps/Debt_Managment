namespace DebtManagment_PersentationLayer
{
    partial class Notification
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
            this.color_notification = new System.Windows.Forms.FlowLayoutPanel();
            this.elips_color_note = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elips_notification = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Toast_Start_Timer = new System.Windows.Forms.Timer(this.components);
            this.HideToast_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // color_notification
            // 
            this.color_notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.color_notification.Dock = System.Windows.Forms.DockStyle.Right;
            this.color_notification.Location = new System.Drawing.Point(335, 0);
            this.color_notification.Name = "color_notification";
            this.color_notification.Size = new System.Drawing.Size(29, 97);
            this.color_notification.TabIndex = 1;
            // 
            // elips_color_note
            // 
            this.elips_color_note.BorderRadius = 9;
            this.elips_color_note.TargetControl = this.color_notification;
            // 
            // elips_notification
            // 
            this.elips_notification.BorderRadius = 16;
            this.elips_notification.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "اشعار\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "محتوئ الاشعار";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Toast_Start_Timer
            // 
            this.Toast_Start_Timer.Interval = 10;
            this.Toast_Start_Timer.Tick += new System.EventHandler(this.Toast_Timer_Tick);
            // 
            // HideToast_Timer
            // 
            this.HideToast_Timer.Enabled = true;
            this.HideToast_Timer.Interval = 10;
            this.HideToast_Timer.Tick += new System.EventHandler(this.HideToast_Timer_Tick);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color_notification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Notification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel color_notification;
        private Guna.UI2.WinForms.Guna2Elipse elips_color_note;
        private Guna.UI2.WinForms.Guna2Elipse elips_notification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Toast_Start_Timer;
        private System.Windows.Forms.Timer HideToast_Timer;
    }
}

