using System;
using DebtManagment_BusinessLayer;
using System.Windows.Forms;

namespace DebtManagment_PersentationLayer
{
    public partial class AddClient : UserControl
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Panel_AddClient.Visible = true;
        }

        private void btn_CloseAddClientPanel_Click(object sender, EventArgs e)
        {
            Panel_AddClient.Visible=false;
        }

        private void viewRecord_Click(object sender, EventArgs e)
        {
            int ClntID = (int)DGV_coustomers.CurrentRow.Cells[0].Value;
            if (ClntID != null)
            {
                show_recorder show_Recorder = new show_recorder(show_recorder.enType.Client, ClntID);
                show_Recorder.Show();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Panel_AddClient.Visible = false;
        }

        private void txt_CoustmerName_TextChanged(object sender, EventArgs e)
        {

        }
        void CheckPersonOrCompany(object s)
        {
         RadioButton radioButton = (RadioButton)s;
            if (radioButton.Checked && radioButton.Name == "rdPerson")
            {
                txt_commecial.Enabled = false;
                txt_SSN.Enabled = true;
            }
            else if (radioButton.Checked && radioButton.Name == "rdCompany")
            {
                txt_SSN.Enabled = false;
                txt_commecial.Enabled = true;

            }

            
        }

        private void Radio_individal_CheckedChanged(object sender, EventArgs e)
        {
            CheckPersonOrCompany(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_AddClient.Visible = false;
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            clsClint newClient = new clsClint();
            newClient.FullName = txt_CoustmerName.ToString();
            newClient.PhoneNumber = txt_CoustmerEmail.ToString();
            newClient.Email = txt_CoustmerEmail.ToString();
            newClient.Address = txt_CoustmerAdress.ToString();

            if (rdPerson.Checked)
            {
                newClient.Classification = 1;
                newClient.SSN = txt_SSN.ToString();
                newClient.Commercial_Registration = "";

            }
            else
            {
                newClient.Classification = 2;
                newClient.Commercial_Registration = txt_commecial.ToString();
                newClient.SSN = "";
            }


            newClient.Save();
        }


        private void Panel_AddClient_Paint(object sender, PaintEventArgs e)
        {
            rdPerson.PerformClick();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            DGV_coustomers.DataSource = clsClint.getAllClints();
        }

        private void DGV_coustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_SaveClient_Click(object sender, EventArgs e)
        {
            clsClint clnt=new clsClint();
            clnt.Save();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            DGV_coustomers.DataSource = clsClint.getAllClints();

        }
    }
}
