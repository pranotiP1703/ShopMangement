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
    public partial class FrmType : Form
    {
        public FrmType()
        {
            InitializeComponent();
        }

        private void FrmType_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClsShop objTypename=new ClsShop(txt1Type.Text);
            objTypename.SaveData();
            MessageBox.Show("Save Successfully..!");


            


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1Type.Text = null;

        }
    }
}
