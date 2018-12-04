using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankstellenPrg
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

        private void S1_Click(object sender, EventArgs e)
        {
            Säule1 säule1 = new Säule1();
            säule1.Show();
        }

        private void S2_Click(object sender, EventArgs e)
        {
            Säule2 säule2 = new Säule2();
            säule2.Show();
        }

        private void S3_Click(object sender, EventArgs e)
        {
            Säule3 säule3 = new Säule3();
            säule3.Show();
        }

        private void S4_Click(object sender, EventArgs e)
        {
            Säule4 säule4 = new Säule4();
            säule4.Show();
        }

        private void CBM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
