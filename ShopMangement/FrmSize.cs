using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMangement
{
    public partial class FrmSize : Form
    {
        public FrmSize()
        {
            InitializeComponent();
        }

        private void FrmSize_Load(object sender, EventArgs e)
        {
            ClsShop objpro= new ClsShop();
            DataTable dt= new DataTable();
            dt = objpro.GetProduct();
            cmbProductName.ValueMember = "ProductID";
            cmbProductName.DisplayMember = "ProductName";
            cmbProductName.DataSource = dt;

            ClsShop objType= new ClsShop();
            dt= objType.GetType();
            cmbTypeName.ValueMember = "TypeID";
            cmbTypeName.DisplayMember = "TypeName";
            cmbTypeName.DataSource = dt;


           


        }

        private void cmbTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeNameID=Convert.ToInt32(cmbTypeName.SelectedValue.ToString());
            ClsShop objProduct= new ClsShop(TypeNameID);
            DataTable dt= objProduct.GetProduct();
            cmbProductName.ValueMember= "ProductID";
            cmbProductName.DisplayMember= "ProductName";
            cmbProductName.DataSource= dt;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(cmbTypeName.SelectedValue.ToString());
            int productid=Convert.ToInt32(cmbProductName.SelectedValue.ToString());
            int mrp = Convert.ToInt32(txtMRP.Text);
            int realprice= Convert.ToInt32(txtRealPrice.Text);
            
            
           ClsShop objBooking=new ClsShop( Convert.ToInt32(cmbTypeName.SelectedValue.ToString()),Convert.ToInt32(cmbProductName.SelectedValue.ToString()),txtSize.Text,Convert.ToInt32(txtMRP.Text),Convert.ToInt32(txtRealPrice.Text));
            objBooking.BookingData();
            MessageBox.Show("Booking Succesfully...!");

                

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
