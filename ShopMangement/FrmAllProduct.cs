using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMangement
{
    public partial class FrmAllProduct : Form
    {
        public FrmAllProduct()
        {
            InitializeComponent();
        }

        private void FrmAllProduct_Load(object sender, EventArgs e)
        {
            //ClsShop objAll = new ClsShop();
            //DataTable dt = objAll.GetAllProduct();
            //SqlDataReader dr;
            //dt = objAll.GetAllProduct();
            //grdAllProducts.DataSource = dt;
            //grdAllProducts.Show();




            ClsShop objAll = new ClsShop();
            DataTable dt = new DataTable();
            dt = objAll.GetAllProduct();
            grdAllProducts.DataSource = dt;
            grdAllProducts.Show();
        }

        private void grdAllProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string Type = "";

            //ClsShop objAll = new ClsShop();
            //DataTable dt = objAll.GetAllProduct();
            //SqlDataReader dr;
            //dt = objAll.GetAllProduct();

            //{
            //   Type = dt["TypeID"].ToString();
            //}






        }
    }
}
