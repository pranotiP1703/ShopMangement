namespace ShopMangement
{
    partial class FrmUnOrderedCustomer
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
            this.grdUnorderedcustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnorderedcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UnOrdered customer Information";
            // 
            // grdUnorderedcustomer
            // 
            this.grdUnorderedcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnorderedcustomer.Location = new System.Drawing.Point(50, 88);
            this.grdUnorderedcustomer.Name = "grdUnorderedcustomer";
            this.grdUnorderedcustomer.Size = new System.Drawing.Size(648, 292);
            this.grdUnorderedcustomer.TabIndex = 1;
            // 
            // FrmUnOrderedCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdUnorderedcustomer);
            this.Controls.Add(this.label1);
            this.Name = "FrmUnOrderedCustomer";
            this.Text = "FrmUnOrderedCustomer";
            this.Load += new System.EventHandler(this.FrmUnOrderedCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnorderedcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdUnorderedcustomer;
    }
}