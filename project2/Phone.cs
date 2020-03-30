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
    public partial class Phone : Form
    {
        public Phone()
        {
            InitializeComponent();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DineIn D = new DineIn();
            D.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
