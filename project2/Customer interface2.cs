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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phone P = new Phone();
            P.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TakeawayPhone P = new TakeawayPhone();
            P.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListPhone P = new ListPhone();
            P.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comments C = new Comments();
            C.Show();
           
          
        }
    }
}
