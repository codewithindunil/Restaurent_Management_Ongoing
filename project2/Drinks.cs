﻿using System;
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
    public partial class Drinks : UserControl
    {
        String itemCode;
        String orderNo = "";
        String tbleNo = "";
        public Drinks(String orderNo, String tbleNo)
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
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            itemCode = "1";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void Drinks_Load(object sender, EventArgs e)
        {
          
        }
    }
}
