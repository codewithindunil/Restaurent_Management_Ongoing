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
    public partial class frmGetTableNo : Form
    {
        public frmGetTableNo()
        {
            InitializeComponent();
        }

        private void btnSubit_Click(object sender, EventArgs e)
        {
            new DineIn(txtTable.Text).Show();
            this.Hide();
        }
    }
}