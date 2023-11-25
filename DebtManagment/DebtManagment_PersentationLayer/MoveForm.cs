using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace DebtManagment_PersentationLayer
{
    internal class MoveForm
    {
        // تخزين موقع النقطة عند النقر 
        private Point panelMouseDownLocation;
        public void AttachToPanel(Panel panel, Form form)
        {
            // Lambda Expression --> (=>)
            panel.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    panelMouseDownLocation = e.Location;
                }
            };

            panel.MouseMove += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    form.Left = e.X + form.Left - panelMouseDownLocation.X;
                    form.Top = e.Y + form.Top - panelMouseDownLocation.Y;
                }
            };
        }
    }
}
