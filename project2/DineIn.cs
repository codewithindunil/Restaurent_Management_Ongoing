﻿using System;
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
        public DineIn()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmDesserts menu = new frmDesserts(orderNo);
            menu.TopLevel = false; ;
            panel2.Controls.Add(menu);
            menu.Show();

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

        }

        private void buns1_Load(object sender, EventArgs e)
        {

        }

        private void DineIn_Load(object sender, EventArgs e)
        {
            String x = new OrderDb().searchNextOrderNo();
            int max = int.Parse(x) + 1;
            this.orderNo = max.ToString();
            Console.WriteLine(orderNo);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
