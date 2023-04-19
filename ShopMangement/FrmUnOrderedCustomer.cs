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
    public partial class FrmUnOrderedCustomer : Form
    {
        public FrmUnOrderedCustomer()
        {
            InitializeComponent();
        }

        private void FrmUnOrderedCustomer_Load(object sender, EventArgs e)
        {
            ClsShop objoc = new ClsShop();
            DataTable dt = new DataTable();
            dt = objoc.UnOrderedCustomer();
            grdUnorderedcustomer.DataSource = dt;
           grdUnorderedcustomer.Show();
        }
    }
}
