using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class BillItem : UserControl
    {
        String item;
        String qty;
        String size;
        String price;
        public BillItem(String item,String qty,String size,String price)
        {
            this.item = item;
            this.qty = qty;
            this.size = size;
            this.price = price;
            InitializeComponent();
        }

        private void BillItem_Load(object sender, EventArgs e)
        {
            lblItem.Text = item;
            lblQty.Text = qty;
            lblSize.Text = size;
            lblPrice.Text = price;
        }
    }
}
