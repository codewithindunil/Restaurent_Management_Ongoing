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
    public partial class KitchenOrders : UserControl
    {
        public KitchenOrders()
        {
            InitializeComponent();
        }
        public KitchenOrders(String name, String size,String qty)
        {
            InitializeComponent();
            bunifuCustomLabel1.Text = name;
            bunifuCustomLabel2.Text = size;

        }
        private void KitchenOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
