﻿namespace ShopMangement
{
    partial class FrmadminLogin
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unOrderdCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductToolStripMenuItem,
            this.orderProductToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.unOrderdCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allProductToolStripMenuItem
            // 
            this.allProductToolStripMenuItem.Name = "allProductToolStripMenuItem";
            this.allProductToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.allProductToolStripMenuItem.Text = "All Product";
            this.allProductToolStripMenuItem.Click += new System.EventHandler(this.allProductToolStripMenuItem_Click);
            // 
            // orderProductToolStripMenuItem
            // 
            this.orderProductToolStripMenuItem.Name = "orderProductToolStripMenuItem";
            this.orderProductToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.orderProductToolStripMenuItem.Text = "Order Product";
            this.orderProductToolStripMenuItem.Click += new System.EventHandler(this.orderProductToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.logOutToolStripMenuItem.Text = "UnOrdered Product";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // unOrderdCustomerToolStripMenuItem
            // 
            this.unOrderdCustomerToolStripMenuItem.Name = "unOrderdCustomerToolStripMenuItem";
            this.unOrderdCustomerToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.unOrderdCustomerToolStripMenuItem.Text = "UnOrderd Customer";
            this.unOrderdCustomerToolStripMenuItem.Click += new System.EventHandler(this.unOrderdCustomerToolStripMenuItem_Click);
            // 
            // FrmadminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmadminLogin";
            this.Text = "FrmadminLogin";
            this.Load += new System.EventHandler(this.FrmadminLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unOrderdCustomerToolStripMenuItem;
    }
}