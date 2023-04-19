using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMangement
{
    public partial class FrmOrder : Form
    {
        public int UserId { get; set; }

        public FrmOrder()
        {
            InitializeComponent();
        }
        public FrmOrder(String Nm,String em,String Phone,String Ui)
        {
            InitializeComponent();
            OName.Text = Nm;
            orE.Text = em;
            lblPhone1.Text = Phone;
            lblUID.Text = Ui;
            UserId = Convert.ToInt32(Ui);
            }

            private void FrmOrder_Load(object sender, EventArgs e)
        {
                  

          
            ClsShop objType = new ClsShop();  
            DataTable dt = new DataTable();
            dt = objType.GetType();
            cmbType.ValueMember = "TypeID";
            cmbType.DisplayMember = "TypeName";
            cmbType.DataSource = dt;

           // listView1.Columns.Add("ProductType", 100, HorizontalAlignment.Center);
           // listView1.Columns.Add("ProductName", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("SizeID", 100, HorizontalAlignment.Center);
            Hide();
           
            //listView1.Columns.Add("Size", 100, HorizontalAlignment.Center);
            //listView1.Columns.Add("MRP", 100, HorizontalAlignment.Center);


            ClsShop objor = new ClsShop();
            dt = objor.GetSize();
            grdSize.DataSource = dt;
            grdSize.Show();


        }

        private void grdSize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbType.SelectedValue);
            ClsShop objpro = new ClsShop(TypeID);
            DataTable dt = objpro.GetProduct();
            cmbProduct.ValueMember = "ProductId";
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.DataSource = dt;
        }


        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            int TypeID = Convert.ToInt32(cmbProduct.SelectedValue.ToString());
            ClsShop objpr = new ClsShop(TypeID);
            DataTable dt = new DataTable();
            dt = objpr.GetSize();
            grdSize.DataSource = dt;
            grdSize.Show();




        }

        private void grdSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // int SizeID = Convert.ToInt32(grdSize.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

            //if (e.RowIndex >= 0)
            //{
            //int SizeID = Convert.ToInt32(grdSize.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //}


            int SizeID = Convert.ToInt32(grdSize.Rows[grdSize.CurrentRow.Index].Cells[1].Value.ToString());
           // int SizeID = Convert.ToInt32(grdSize.SelectedCells[1].Value.ToString());
            ClsShop objgr = new ClsShop(SizeID);        //display mrp 

            SqlDataReader dr;
            dr = objgr.GetMRP();
            while (dr.Read())
            {

                txt1MRP.Text = dr["MRP"].ToString();
            }
            dr.Close();

        }
        private void grdSize_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void txtMRP_TextChanged(object sender, EventArgs e)
        {


           

        }

        private void txt1MRP_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdSize_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Add(String Type, String ProductName, String Size,string SizeId, String MRP)
        {
          
            if (MRP!= null)
            {
                ListViewItem lst = new ListViewItem(Type);
                lst.SubItems.Add(ProductName);

                lst.SubItems.Add(Size);
                lst.SubItems.Add(MRP);
                lst.SubItems.Add(SizeId);
                listView1.Items.Add(lst);
                //listView1.Columns[4].Width = 0;
               

            }
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            ////string[] row = { cmbType.Text, cmbProduct.Text, grdSize.CurrentRow.Cells[1].Value.ToString(),txt1MRP.Text };
            ////var Listitem = new ListViewItems(row);
            ////listView1.Items.Add(Listitem)
            {
                if (grdSize.SelectedRows.Count > 0)
                {
                    String Type = cmbType.Text;
                    String ProductName = cmbProduct.Text;
                    String Size = grdSize.SelectedRows[0].Cells[0].Value.ToString();
                   string SizeID = grdSize.SelectedRows[0].Cells[1].Value.ToString();
                    String MRP = txt1MRP.Text;



                    Add(Type, ProductName, Size,SizeID, MRP) ;     //add to Cart 
                }
                else
                {
                    MessageBox.Show("Please Select all Fields..");

                }
            }

           
        }
            private void btnRemoveFromCart_Click(object sender, EventArgs e)
            {
                 //listView1.SelectedItems.Clear();
                if(listView1.SelectedItems.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text != null)
                {
                    sum += int.Parse(listView1.Items[i].SubItems[3].Text);
                    // sum++;

                }
                //txtTotal.Text = sum.ToString();
                else
                {
                    sum -= int.Parse(listView1.Items[i].SubItems[3].Text);
                }
                txtTotal.Text = sum.ToString();
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbType.SelectedItem = null;
            cmbProduct.SelectedItem = null;
           // grdSize= null;
           
            txt1MRP.Text = null;
        }

        private void btnOrderConfirmed_Click(object sender, EventArgs e)
        {
            for(int i=0; i < listView1.Items.Count;i++)
            {
                DateTime time = DateTime.Now;
                string OrderStatus = "Confirmed";
                string OrderDate = Convert.ToString(time);
               int SizeId = Convert.ToInt32(listView1.Items[i].SubItems[4].Text);
                ClsShop objorc = new ClsShop(UserId, SizeId,OrderStatus,OrderDate);
                objorc.OrderConfirm();
            }
            MessageBox.Show("OrderConfirmed....!");
        }
      
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    } 



