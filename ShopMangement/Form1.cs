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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin objlogin = new FrmLogin();
            objlogin.Show();
            objlogin.MdiParent = this;

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmType objType = new FrmType();
            objType.Show();
            objType.MdiParent=this;


        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduct objProduct = new FrmProduct();
            objProduct.Show();
            objProduct.MdiParent = this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSize objSize = new FrmSize();
            objSize.Show();
            objSize.MdiParent = this;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser objfrmuser= new FrmUser();
            objfrmuser.Show();
            objfrmuser.MdiParent = this;
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    FrmOrder objor = new FrmOrder();
        //    objor.Show();

        //    objor.MdiParent = this;
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
