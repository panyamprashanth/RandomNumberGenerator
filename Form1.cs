using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        private int maxRandomRange = 9;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrRemaining_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void nextRandom_Tick(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            int randomnumb = Rnd.Next(0, maxRandomRange);
            textBox1.Text = randomnumb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrRemaining.Start();
            nextRandom.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maxRandomRange += 10;
        }
    }
}
