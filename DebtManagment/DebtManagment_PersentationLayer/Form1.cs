using System;
using System.Windows.Forms;
using Guna;                        // Guna UI frame work, [ U should include the Guna.UI.dll in ur PersentationLayer\References]
using DebtManagment_BusinessLayer; // refernecing the Business layer ....

namespace DebtManagment_PersentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveForm formover = new MoveForm();
            formover.AttachToPanel(Top_panel, this);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            }
            else
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
                this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(75)))), ((int)(((byte)(211)))));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebtManagment_BusinessLayer.Class1.test();
        }
    }
}
