using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class frmDesserts : Form
    {
        String itemCode;
        String size;
        String qty;
        String ePrice;
        String total;
        String orderNo;
        public frmDesserts(String orderNo)
        {
            this.orderNo = orderNo;
            InitializeComponent();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            new Order(itemCode, orderNo).Show();


            //new Order(this).Show();
        }

        private void frmDesserts_Load(object sender, EventArgs e)
        {

        }
    }
}
