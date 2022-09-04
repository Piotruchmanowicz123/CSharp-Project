using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuesse
{
    public partial class Form1 : Form
    {
        int Num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGenerateNum_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Num = rnd.Next(0, 100);
            LbOutput.Text = "";
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            int UserInput = int.Parse(TxtInput.Text);
            if (UserInput < Num)
            {
                LbOutput.Text = "To low";
            } else if (UserInput > Num)
            {
                LbOutput.Text = "To high";
            } else if (UserInput == Num)
            {
                Winner popup = new Winner();
                string message = "You won";
                MessageBox.Show(message);
            }
        }

        private void LbOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
