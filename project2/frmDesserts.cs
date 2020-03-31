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
        //String size;
        //String qty;
        //String ePrice;
        //String total;
        String orderNo="";
        String tbleNo = "";
        public frmDesserts(String orderNo,String tbleNo)
        {
            InitializeComponent();
            this.orderNo = orderNo;
            this.tbleNo = tbleNo;

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();


            //new Order(this).Show();
        }

        private void frmDesserts_Load(object sender, EventArgs e)
        {

        }
    }
}
