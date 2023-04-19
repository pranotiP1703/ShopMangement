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
    public partial class FrmUnorderedProduct : Form
    {
        public FrmUnorderedProduct()
        {
            InitializeComponent();
        }

        private void FrmUnorderedProduct_Load(object sender, EventArgs e)
        {
            ClsShop objop = new ClsShop();
            DataTable dt = new DataTable();
            dt = objop.UnOrderedProduct();
            grdUnOrderdProduct.DataSource = dt;
            grdUnOrderdProduct.Show();
        }
    }
}
