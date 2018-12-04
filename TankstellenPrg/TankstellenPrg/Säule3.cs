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
    public partial class Säule3 : Form
    {
        public Säule3()
        {
            InitializeComponent();
        }
        int GasPrice = 0;
        int Liter = 0;
        int Price = 0;

        
        private void SC3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void S3D_Click_1(object sender, EventArgs e)
        {
            GasPrice = 10;
            STT3.Start();
        }

        private void Säule3_Load_1(object sender, EventArgs e)
        {
            SLT3.Text = Convert.ToString(Liter);
            SFrT3.Text = Convert.ToString(Price);
        }

        private void STT3_Tick_1(object sender, EventArgs e)
        {
            Liter++;
            Price += GasPrice;
            SLT3.Text = Convert.ToString(Liter);
            SFrT3.Text = Convert.ToString(Price);
        }

        private void SS3_Click_1(object sender, EventArgs e)
        {
            STT3.Stop();
        }
    }
}
