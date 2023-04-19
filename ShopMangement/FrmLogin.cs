using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopMangement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ClsShop objLogin = new ClsShop(cmbType.Text,txtEmail.Text,txtPassword.Text);
            //objLogin.LoginData();
            // MessageBox.Show("Login Successfully..!");



            string Mobile = "";
            String User = "";

            ClsShop obj = new ClsShop(txtEmail.Text, txtPassword.Text);
            SqlDataReader dt;
            dt = obj.LoginData();

            while (dt.Read())
            {
                
                string name = dt["UserName"].ToString();
                string Email = dt["UserEmail"].ToString();
                Mobile = dt["UserMobile"].ToString();
                User =dt["UserId"].ToString();

            }

            if (dt.HasRows == true)
            {
                if (cmbType.SelectedItem.ToString() == "Customer")

                {
                    dt.Close();
                    MessageBox.Show("Login Successfully..!");
                    FrmOrder objorder = new FrmOrder(txtPassword.Text,txtEmail.Text,Mobile,User);
                    objorder.Show();
                }
                else if (cmbType.SelectedItem.ToString() == "Admin")
                {
                    FrmadminLogin objfrml= new FrmadminLogin();
                    objfrml.Show();
                    MessageBox.Show("Login Succesful..!");

                }
                else
                {
                    MessageBox.Show("Invalid Login");
                    txtEmail.Clear();
                    txtPassword.Clear();
                }


            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
