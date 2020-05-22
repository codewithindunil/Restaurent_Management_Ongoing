using MySql.Data.MySqlClient;
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
    public partial class frmBill : Form
    {
        float total=0;
        int poss = 40;
        String orderNo;
        public frmBill(String orderNo)
        {
            this.orderNo = orderNo;
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            loadBill();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadBill()
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=restauretdb;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "select * from orders_tb where orderNo='" + orderNo + "'";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    String item = rd["itemCode"].ToString();
                    String qty = rd["qty"].ToString();
                    String size = rd["size"].ToString();
                    String price = rd["total"].ToString();
                    total = total + float.Parse(price);
                    lblTotal.Text = total.ToString();
                    addItem(item, qty, size, price);



                }
                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void addItem(String item,String qty,String size,String price)
        {


            BillItem it = new BillItem(item, qty, size, price);
            panel1.Controls.Add(it);
            it.Top = poss;
            it.Left = 20;
            poss = (it.Top + it.Height + 10);
        }
    }
}
