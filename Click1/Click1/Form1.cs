using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click1
{
    public partial class Form1 : Form
    {
        
        double Lbnum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lbnum++;
            Counter.Text = Lbnum.ToString();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            Lbnum--;
            Counter.Text = Lbnum.ToString();
        }

        private void plus10_Click(object sender, EventArgs e)
        {
            Lbnum += 10;
            Counter.Text = Lbnum.ToString();
        }

        private void min10_Click(object sender, EventArgs e)
        {
            Lbnum -= 10;
            Counter.Text = Lbnum.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Lbnum = 0;
            Counter.Text = Lbnum.ToString();
        }

        private void sqaure_Click(object sender, EventArgs e)
        {
            Lbnum  *= Lbnum;
            Counter.Text = Lbnum.ToString();
        }

        private void sqroot_Click(object sender, EventArgs e)
        {
            Lbnum = Math.Sqrt(Lbnum);
            Counter.Text = Lbnum.ToString();
        }
    }
}
