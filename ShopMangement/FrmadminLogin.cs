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
    public partial class FrmadminLogin : Form
    {
        public FrmadminLogin()
        {
            InitializeComponent();
        }

        private void FrmadminLogin_Load(object sender, EventArgs e)
        {
            IsMdiContainer= true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void orderProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderProduct objorpro=new FrmOrderProduct();
            objorpro.Show();

        }

        private void allProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllProduct objfrmor=new FrmAllProduct();
            objfrmor.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmUnorderedProduct objUnpro=new FrmUnorderedProduct();
            objUnpro.Show();
        }

        private void unOrderdCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnOrderedCustomer onjUnCu=new FrmUnOrderedCustomer();
            onjUnCu.Show();
        }
    }
}
