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
    public partial class Säule2 : Form
    {
        public Säule2()
        {
            InitializeComponent();
        }
        int GasPrice = 0;
        int Liter = 0;
        int Price = 0;

        private void Säule2_Load(object sender, EventArgs e)
        {
            SLT2.Text = Convert.ToString(Liter);
            SFrT2.Text = Convert.ToString(Price);
        }

        private void SC2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void S2D_Click(object sender, EventArgs e)
        {
            GasPrice = 10;
            STT2.Start();
        }

        private void STT2_Tick(object sender, EventArgs e)
        {
            Liter++;
            Price += GasPrice;
            SLT2.Text = Convert.ToString(Liter);
            SFrT2.Text = Convert.ToString(Price);
        }

        private void SS2_Click(object sender, EventArgs e)
        {
            STT2.Stop();
        }
    }
}
