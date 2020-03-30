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
    public partial class Order : Form
    {
        private String itemCode;
        public String size ;
        public String qty ;
        public String ePrice ;
        public String total ;
        String orderNo;
        public Order(String itemCode, String orderNo)
        {
           
            InitializeComponent();
            this.itemCode = itemCode;
            this.orderNo = orderNo;
           
        }
       

        private void Order_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            qty = txtQty.Text;
            size = txtSize.SelectedItem.ToString();
            Console.WriteLine(size);
            ePrice=new OrderDb().searchItem(itemCode, size);
            total = (int.Parse(qty) * int.Parse(ePrice)).ToString();
            new OrderDb().saveOrder(orderNo,itemCode, size, qty, ePrice, total);
            //Console.WriteLine(ePrice);
        }
    }
}
