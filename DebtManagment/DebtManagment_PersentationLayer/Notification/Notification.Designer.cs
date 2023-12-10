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
            this.note_title = new System.Windows.Forms.Label();
            this.Toast_Start_Timer = new System.Windows.Forms.Timer(this.components);
            this.HideToast_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // color_notification
            // 
            this.color_notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.color_notification.Dock = System.Windows.Forms.DockStyle.Right;
            this.color_notification.Location = new System.Drawing.Point(306, 0);
            this.color_notification.Margin = new System.Windows.Forms.Padding(2);
            this.color_notification.Name = "color_notification";
            this.color_notification.Size = new System.Drawing.Size(20, 87);
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
            // note_title
            // 
            this.note_title.AutoSize = true;
            this.note_title.Font = new System.Drawing.Font("Segoe UI", 12.125F, System.Drawing.FontStyle.Bold);
            this.note_title.Location = new System.Drawing.Point(123, 28);
            this.note_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.note_title.Name = "note_title";
            this.note_title.Size = new System.Drawing.Size(62, 30);
            this.note_title.TabIndex = 2;
            this.note_title.Text = "اشعار\r\n";
            this.note_title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 87);
            this.Controls.Add(this.note_title);
            this.Controls.Add(this.color_notification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Notification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel color_notification;
        private Guna.UI2.WinForms.Guna2Elipse elips_color_note;
        private Guna.UI2.WinForms.Guna2Elipse elips_notification;
        private System.Windows.Forms.Label note_title;
        private System.Windows.Forms.Timer Toast_Start_Timer;
        private System.Windows.Forms.Timer HideToast_Timer;
    }
}

