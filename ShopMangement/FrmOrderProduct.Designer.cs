namespace ShopMangement
{
    partial class FrmOrderProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdOrderProducts = new System.Windows.Forms.DataGridView();
            this.Discount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.lblSearchbyProduct = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.txtSearchByProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrderProducts
            // 
            this.grdOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Discount,
            this.Column1});
            this.grdOrderProducts.Location = new System.Drawing.Point(12, 36);
            this.grdOrderProducts.Name = "grdOrderProducts";
            this.grdOrderProducts.Size = new System.Drawing.Size(776, 382);
            this.grdOrderProducts.TabIndex = 0;
            this.grdOrderProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderProducts_CellClick);
            this.grdOrderProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderProducts_CellContentClick);
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Offer";
            this.Discount.Name = "Discount";
            this.Discount.Text = "Discount";
            this.Discount.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Products Information";
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByName.Location = new System.Drawing.Point(131, 451);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(140, 20);
            this.lblSearchByName.TabIndex = 2;
            this.lblSearchByName.Text = "Search by Name";
            // 
            // lblSearchbyProduct
            // 
            this.lblSearchbyProduct.AutoSize = true;
            this.lblSearchbyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyProduct.Location = new System.Drawing.Point(131, 485);
            this.lblSearchbyProduct.Name = "lblSearchbyProduct";
            this.lblSearchbyProduct.Size = new System.Drawing.Size(158, 20);
            this.lblSearchbyProduct.TabIndex = 3;
            this.lblSearchbyProduct.Text = "Search By Product";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(299, 448);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchByName.TabIndex = 4;
            // 
            // txtSearchByProduct
            // 
            this.txtSearchByProduct.Location = new System.Drawing.Point(299, 485);
            this.txtSearchByProduct.Name = "txtSearchByProduct";
            this.txtSearchByProduct.Size = new System.Drawing.Size(100, 20);
            this.txtSearchByProduct.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(458, 464);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 41);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(627, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 41);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Check";
            this.Column1.Name = "Column1";
            // 
            // FrmOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchByProduct);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.lblSearchbyProduct);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdOrderProducts);
            this.Name = "FrmOrderProduct";
            this.Text = "FrmOrderProduct";
            this.Load += new System.EventHandler(this.FrmOrderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrderProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Label lblSearchbyProduct;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.TextBox txtSearchByProduct;
        private System.Windows.Forms.DataGridViewButtonColumn Discount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btnDelete;
    }
}