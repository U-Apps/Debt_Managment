using System;
using System.IO;
using DebtManagment_BusinessLayer;
using System.Windows.Forms;
using System.Drawing;

namespace DebtManagment_PersentationLayer.Users
{
    public partial class frmAddUpdateUser : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        byte[] _imageData = new byte[] {};

        int _UserID;
        clsUser _User;

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            this._UserID = UserID;

            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }


        private void _Load()
        {
            if (_Mode == enMode.AddNew)
            {
                _User = new clsUser();
                return;
            }

            _User = clsUser.FindUserByID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                this.Close();

                return;
            }

            txtUserFullName.Text = _User.FullName;
            txtPhoneNumber.Text = _User.PhoneNumber;
            txtUserEmail.Text = _User.Email;
            txtUserAddress.Text = _User.Address;
            txtSSN.Text = _User.SSN;
            txtUsername.Text = _User.UserName;
            txtUserPassword.Text = _User.Password;
            if (_User.ImgaeData.Length != 0)
            {
                using (MemoryStream ms = new MemoryStream(_User.ImgaeData))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox1.Image = image;
                }
            }
            else
            {
               // _imageData= _User.ImgaeData;
                pictureBox1.Image =  null;
            }

            if (_User.CheckAccessPermission(enUserPermissions.All))
            {
                foreach (CheckBox item in groupBox1.Controls)
                {
                    item.Checked = true;
                    item.Enabled = false;
                }
                chkFullAccess.Enabled = true;
            }
            else
            {
                foreach (CheckBox item in groupBox1.Controls)
                {
                    if (_User.CheckAccessPermission((enUserPermissions)int.Parse(item.Tag.ToString())))
                    {
                        item.Checked = true;
                    }

                }
            }

        }

        private void AddPerimssions()
        {
            if (chkFullAccess.Checked)
            {
                _User.AddPermisson(enUserPermissions.All);
                return;
            }
            foreach (CheckBox item in groupBox1.Controls)
            {
                
               // MessageBox.Show(int.Parse(item.Tag.ToString()).ToString());
                if (item.Checked)
                {
                    _User.AddPermisson((enUserPermissions)(int.Parse(item.Tag.ToString())));
                }
                else
                {
                    _User.RemovePermisson((enUserPermissions)(int.Parse(item.Tag.ToString())));
                }

            }
        }
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string name = txtUserFullName.Text.Trim();
            string PhoneNumber = txtPhoneNumber.Text.Trim();
            string Email = txtUserEmail.Text.Trim();
            string SSN = txtSSN.Text.Trim();
            string Address = txtUserAddress.Text.Trim();

            //if (!(clsValidatePatterns.IsMatch(clsValidatePatterns.FullNamPatterne, ref name) &&
            //    clsValidatePatterns.IsMatch(clsValidatePatterns.PhoneNumberPattern, ref PhoneNumber) &&
            //    clsValidatePatterns.IsMatch(clsValidatePatterns.EmailPattern, ref Email) &&
            //    clsValidatePatterns.IsMatch(clsValidatePatterns.AddressPattern, ref Address) &&
            //    clsValidatePatterns.IsMatch(clsValidatePatterns.IdentityNumberPattern, ref SSN)
            //    ))
            //{
            //    new Notification("أحد الحقول خاطئة").Show();
            //    return;
            //}



            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.FullNamPatterne, ref name))
            {

                txtUserFullName.BorderColor = Color.Red;
                txtUserFullName.Clear();
                txtUserFullName.PlaceholderText = "خطا في الادخال";


                return;
            }
            else txtUserFullName.BorderColor = Color.White;

            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.PhoneNumberPattern, ref PhoneNumber))
            {

                txtPhoneNumber.BorderColor = Color.Red;
                txtPhoneNumber.Clear();
                txtPhoneNumber.PlaceholderText = "خطا في الادخال";


                return;
            }
            else txtPhoneNumber.BorderColor = Color.White;

            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.EmailPattern, ref Email))
            {

                txtUserEmail.BorderColor = Color.Red;
                txtUserEmail.Clear();
                txtUserEmail.PlaceholderText = "خطا في الادخال";


                return;
            }
            else txtUserEmail.BorderColor = Color.White;



            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.AddressPattern, ref Address))
            {

                txtUserAddress.BorderColor = Color.Red;
                txtUserAddress.Clear();
                txtUserAddress.PlaceholderText = "خطا في الادخال";


                return;
            }


            if (!clsValidatePatterns.IsMatch(clsValidatePatterns.IdentityNumberPattern, ref SSN))
            {

                txtSSN.BorderColor = Color.Red;
                txtSSN.Clear();
                txtSSN.PlaceholderText = "خطا في الادخال";


                return;
            }
            else txtSSN.BorderColor = Color.White;




            _User.FullName = name;
            _User.PhoneNumber = PhoneNumber;
            _User.Email = Email;
            _User.Address = Address;
            _User.SSN = SSN;
            _User.UserName = txtUsername.Text;
            _User.Password = txtUserPassword.Text;

            _User.ImgaeData = _imageData;
            AddPerimssions();

            if (_User.Save())
                MessageBox.Show("User Added Succedfully");
            else
                MessageBox.Show("Error Occur");
        }

        private void adding_P_Paint(object sender, PaintEventArgs e)
        {
            _Load();
        }



        private void chkFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullAccess.Checked)
            {
                foreach (CheckBox item in groupBox1.Controls)
                {
                    item.Checked = true;
                    item.Enabled = false;
                }
                chkFullAccess.Enabled = true;
            }
            else
            {
                foreach (CheckBox item in groupBox1.Controls)
                {
                    item.Checked = false;
                    item.Enabled = true;
                }

            }
        }

        private void btnCloseAddUserPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkAddUsers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);
                if (selectedFilePath == null)
                {
                    return;
                }
                _imageData = File.ReadAllBytes(selectedFilePath);
                pictureBox1.Load(selectedFilePath);
                // ...
            }
        }
    }
}