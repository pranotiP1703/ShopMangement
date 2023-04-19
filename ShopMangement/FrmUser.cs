using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ShopMangement
{
    public partial class FrmUser : Form
    {
        string Gender;
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            
            ClsShop objRegister= new ClsShop(cmbType.Text,txtName.Text,txtEmail.Text,Gender,cmbState.Text ,txtMobile.Text, txtPassword.Text);
            objRegister.RegisterData();

            MessageBox.Show("Registration SuccessFully....");



        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";

        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbType.SelectedItem= null;
            txtName.Text= null;
            txtEmail.Clear();
            rdbFemale.Checked= false;
            rdbMale.Checked= false;
            cmbState.SelectedItem= null;
            txtMobile.Text= null;
            txtPassword.Clear();


        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(txtEmail.Text,pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtEmail, "please provide valid email address");
                return;
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
            }




            //string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*[-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            //if (Regex.IsMatch(txtPassword.Text, pattern))
            //{
            //    errorProvider2.Clear();
            //}
            //else
            //{
            //    errorProvider2.SetError(this.txtPassword, "please enter special character, numbers");
            //    return;
            //}
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*[-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            //if (Regex.IsMatch(txtPassword.Text, pattern))
            //{
            //    errorProvider2.Clear();
            //}
            //else
            //{
            //    errorProvider2.SetError(this.txtPassword, "please enter special character, numbers");
            //    return;
            //}
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{10}$");
            if (r.IsMatch(txtMobile.Text))
            {
                //string[] row1 = new string[] { txtMobile.Text };
                //txtMobile.Show();
               
            }
            else
            {
                MessageBox.Show("Invalid Mobile Number");
            }
        }
    }
}
