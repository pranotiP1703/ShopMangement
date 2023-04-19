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


    public partial class FrmOrderProduct : Form
    {
        public FrmOrderProduct()
        {
            InitializeComponent();
        }

        private void FrmOrderProduct_Load(object sender, EventArgs e)
        {
            ClsShop objop = new ClsShop();
            DataTable dt = new DataTable();
            dt = objop.GetOrderProduct();
            grdOrderProducts.DataSource = dt;
            grdOrderProducts.Show();
        }

        private void grdOrderProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdOrderProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdOrderProducts.Columns[e.ColumnIndex].HeaderText == "Offer")
            {
                string UserName = this.grdOrderProducts.CurrentRow.Cells[3].Value.ToString();
                string Email = grdOrderProducts.CurrentRow.Cells[4].Value.ToString();
                string ProductName = grdOrderProducts.CurrentRow.Cells[5].Value.ToString();
                int MRP1 = Convert.ToInt32(grdOrderProducts.CurrentRow.Cells[8].Value.ToString());
                int OrderID = Convert.ToInt32(grdOrderProducts.CurrentRow.Cells[2].Value.ToString());

                FrmOffer objoff = new FrmOffer(UserName, Email, ProductName, MRP1, OrderID);
                objoff.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            (grdOrderProducts.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName like '%" + txtSearchByProduct.Text + "%'");
            (grdOrderProducts.DataSource as DataTable).DefaultView.RowFilter = string.Format("UserName like '%" + txtSearchByName.Text + "%'");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdOrderProducts.Rows.Count; i++)
            {
                if (grdOrderProducts.Rows[i].Cells[1].Value != null)
                {
                    bool a = (bool)grdOrderProducts.Rows[i].Cells[1].Value;
                   if (a == true)
                    {
                        int OrderID = Convert.ToInt32(grdOrderProducts.Rows[i].Cells[2].Value.ToString());
                        ClsShop frm = new ClsShop(OrderID);
                        frm.Delete();
                        MessageBox.Show("Successfully Deleted");
                      

                    }
                    else
                    {
                        int OrderID = Convert.ToInt32(grdOrderProducts.Rows[i].Cells[2].Value.ToString());
                        ClsShop frm = new ClsShop(OrderID);
                        frm.Delete();
                    }
                }

            }

        }
    }
}

