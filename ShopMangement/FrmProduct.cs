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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClsShop objproduct=new ClsShop(Convert.ToInt32(cmbType.SelectedValue.ToString()),txtProduct.Text);
            objproduct.SaveProduct();
            MessageBox.Show("Save Product");


            

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            ClsShop objproduct = new ClsShop();
            DataTable dt=new DataTable();
            dt = objproduct.GetType();

            cmbType.DisplayMember= "TypeName";
            cmbType.ValueMember= "TypeID";

            cmbType.DataSource= dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
          
            txtProduct.Text = null;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
