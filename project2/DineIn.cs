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
            panel2.Controls.Clear();
            frmDesserts menu = new frmDesserts(orderNo,tbleNo);
            menu.TopLevel = false; ;
            panel2.Controls.Add(menu);
            menu.Show();
            Console.WriteLine(tbleNo);
            new frmKitchen().addItem("", "", "");
        }

        private void DineIn_Load(object sender, EventArgs e)
        {
            String x = new OrderDb().searchNextOrderNo();
            int max = int.Parse(x) + 1;
            this.orderNo = max.ToString();
            Console.WriteLine(orderNo);
            getTableNo();
            
        }

        private void getTableNo()
        {
            new frmGetTableNo().Show();
        }
    }
}
