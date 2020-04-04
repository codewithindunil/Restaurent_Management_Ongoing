namespace project2
{
    partial class frmGetTableNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetTableNo));
            this.btnSubit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTable = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // btnSubit
            // 
            this.btnSubit.ActiveBorderThickness = 1;
            this.btnSubit.ActiveCornerRadius = 20;
            this.btnSubit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSubit.ActiveForecolor = System.Drawing.Color.White;
            this.btnSubit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSubit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubit.BackgroundImage")));
            this.btnSubit.ButtonText = "SUBMIT";
            this.btnSubit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSubit.IdleBorderThickness = 1;
            this.btnSubit.IdleCornerRadius = 20;
            this.btnSubit.IdleFillColor = System.Drawing.Color.White;
            this.btnSubit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSubit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSubit.Location = new System.Drawing.Point(99, 122);
            this.btnSubit.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubit.Name = "btnSubit";
            this.btnSubit.Size = new System.Drawing.Size(181, 41);
            this.btnSubit.TabIndex = 0;
            this.btnSubit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubit.Click += new System.EventHandler(this.btnSubit_Click);
            // 
            // txtTable
            // 
            this.txtTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTable.HintForeColor = System.Drawing.Color.Empty;
            this.txtTable.HintText = "";
            this.txtTable.isPassword = false;
            this.txtTable.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTable.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTable.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTable.LineThickness = 3;
            this.txtTable.Location = new System.Drawing.Point(52, 61);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(262, 32);
            this.txtTable.TabIndex = 1;
            this.txtTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmGetTableNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 242);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.btnSubit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGetTableNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGetTableNo";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnSubit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTable;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}