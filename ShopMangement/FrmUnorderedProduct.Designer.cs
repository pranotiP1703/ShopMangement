﻿namespace ShopMangement
{
    partial class FrmUnorderedProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.grdUnOrderdProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnOrderdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UnOrdered Product Information";
            // 
            // grdUnOrderdProduct
            // 
            this.grdUnOrderdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnOrderdProduct.Location = new System.Drawing.Point(12, 75);
            this.grdUnOrderdProduct.Name = "grdUnOrderdProduct";
            this.grdUnOrderdProduct.Size = new System.Drawing.Size(755, 327);
            this.grdUnOrderdProduct.TabIndex = 1;
            // 
            // FrmUnorderedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdUnOrderdProduct);
            this.Controls.Add(this.label1);
            this.Name = "FrmUnorderedProduct";
            this.Text = "FrmUnorderedProduct";
            this.Load += new System.EventHandler(this.FrmUnorderedProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnOrderdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdUnOrderdProduct;
    }
}