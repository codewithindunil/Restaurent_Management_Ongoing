namespace project2
{
    partial class BillItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(27, 19);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(26, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "item";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(240, 19);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 13);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "item";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(292, 19);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(26, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "item";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(423, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(26, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "item";
            // 
            // BillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblItem);
            this.Name = "BillItem";
            this.Size = new System.Drawing.Size(500, 50);
            this.Load += new System.EventHandler(this.BillItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
    }
}
