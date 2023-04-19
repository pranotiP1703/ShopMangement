using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMangement
{
    public partial class FrmOffer : Form
    {
        public int MRP { get; set; }
        public int OrderiD{get; set; }
        public FrmOffer()
        {
           
            InitializeComponent();
           // lblMRP.Text= MRP.ToString();
        }
        
        public FrmOffer(string Nm,string Em,string Pd,int MRP2 ,int OrderID)
        {
            InitializeComponent();
            lblCustomerName.Text = Nm;
            Email1.Text = Em;
            Product1.Text = Pd;
            MRP1.Text=MRP2.ToString();
            OrderID1.Text=OrderID.ToString();
            OrderiD= OrderID;
            
            
          // MRP1 = MRP1.ToString();
           // MRP1. = MRP1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUPdatedMRP_Click(object sender, EventArgs e)
        {
          
            int productID= Convert.ToInt32(txtCalculatedMRP.Text);
            int Orderid=Convert.ToInt32(OrderID1.Text);
          //  int Orderid=Convert.ToInt32(txtCalculatedMRP.Text);
       
            ClsShop objshop =new ClsShop(productID,Orderid);
            objshop.UpdatedDiscount();
            MessageBox.Show("Updated");

        }

        private void btnCalculatedMRP_Click(object sender, EventArgs e)
        {


           

  


                        int Discount = ((Convert.ToInt32(MRP1.Text) * Convert.ToInt32(txtDiscount.Text) / 100));
                        txtCalculatedMRP.Text = (Convert.ToInt32(MRP1.Text) - Discount).ToString();
                }
     

        private void FrmOffer_Load(object sender, EventArgs e)
        {
            
        }

        private void MRP1_Click(object sender, EventArgs e)
        {

        }

        private void txtCalculatedMRP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
