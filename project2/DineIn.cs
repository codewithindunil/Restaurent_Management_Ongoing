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
    public partial class DineIn : Form
    {
        public String orderNo;
        String tbleNo;
        
        public DineIn(String tbNo)
        {
            InitializeComponent();
            this.tbleNo = tbNo;
            Console.WriteLine("tble np "+tbleNo);
        }
        public DineIn()
        {
            

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Dessert menu = new Dessert(orderNo, tbleNo);

            panel2.Controls.Clear();
            //menu.TopLevel = false; ;
            panel2.Controls.Add(menu);
            menu.Show();
            //Console.WriteLine(tbleNo);
            //new frmKitchen().addItem("", "", "");
        }

        private void DineIn_Load(object sender, EventArgs e)
        {
            //getTableNo();
            String x = new OrderDb().searchNextOrderNo();
            int max = int.Parse(x) + 1;
            this.orderNo = max.ToString();
            Console.WriteLine(orderNo);
            
            
        }

        private void getTableNo()
        {
            new frmGetTableNo().Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Food2 item = new Food2(orderNo, tbleNo);
            panel2.Controls.Clear();
            item.Top = 20;
            item.Left = 20;
            panel2.Controls.Add(item);
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Buns item = new Buns(orderNo, tbleNo);
            panel2.Controls.Clear();
            item.Top = 20;
            item.Left = 20;
            panel2.Controls.Add(item);
            
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Sweets item = new Sweets(orderNo, tbleNo);
            panel2.Controls.Clear();
            item.Top = 20;
            item.Left = 20;
            panel2.Controls.Add(item);
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Drinks item = new Drinks(orderNo, tbleNo);
            panel2.Controls.Clear();
            item.Top = 20;
            item.Left = 20;
            panel2.Controls.Add(item);
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new frmBill(orderNo).Show();
        }
    }
}
