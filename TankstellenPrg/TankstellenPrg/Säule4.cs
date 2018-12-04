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
    public partial class Säule4 : Form
    {
        public Säule4()
        {
            InitializeComponent();
        }
        int GasPrice = 0;
        int Liter = 0;
        int Price = 0;
        private void SC4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Säule4_Load(object sender, EventArgs e)
        {
            SLT4.Text = Convert.ToString(Liter);
            SFrT4.Text = Convert.ToString(Price);
        }

        private void S4D_Click(object sender, EventArgs e)
        {
            GasPrice = 10;
            STT4.Start();
        }

        private void STT4_Tick(object sender, EventArgs e)
        {
            Liter++;
            Price += GasPrice;
            SLT4.Text = Convert.ToString(Liter);
            SFrT4.Text = Convert.ToString(Price);
        }

        private void SS4_Click(object sender, EventArgs e)
        {
            STT4.Stop();
        }
    }
}
