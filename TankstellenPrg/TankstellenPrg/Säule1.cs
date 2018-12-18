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
    public partial class Säule1 : Form
    {//Diese Säule fertig machen und Swag getten
        
        public Säule1()
        {
            InitializeComponent();
        }
        int GasPrice = 0;
        int Liter = 0;
        int Price = 0;


        private void SFr1_Click(object sender, EventArgs e)
        {

        }

        private void SC1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void S1D_Click(object sender, EventArgs e)
        {
            GasPrice = 10;
            S1B.Enabled = false;
            S198.Enabled = false;
            SC1.Enabled = false;
            SS1.Enabled = true;
            STT1.Start();

        }
     

        private void Säule1_Load(object sender, EventArgs e)
        {
            SLT1.Text = Convert.ToString(Liter);
            SFrT1.Text = Convert.ToString(Price);
        }

        private void STT1_Tick(object sender, EventArgs e)
        {
            Liter++;
            Price += GasPrice;
            SLT1.Text = Convert.ToString(Liter);
            SFrT1.Text = Convert.ToString(Price);
        }

        private void SS1_Click(object sender, EventArgs e)
        {
            STT1.Stop();
            SP1.Visible = true;
        }

        private void S1B_Click(object sender, EventArgs e)
        {
            GasPrice = 10;
            S1D.Enabled = false;
            S198.Enabled = false;
            SC1.Enabled = false;
            SS1.Enabled = true;
            STT1.Start();
        }

        private void S198_Click(object sender, EventArgs e)
        {
            GasPrice = 10;
            S1B.Enabled = false;
            S1D.Enabled = false;
            SC1.Enabled = false;
            SS1.Enabled = true;
            STT1.Start();
        }

        private void SP1_Click(object sender, EventArgs e)
        {
            //Dynamische Form Gooooooooggggggle
            Payment Bezahlung = new Payment();
            Bezahlung.Show();
            Close();
        }
    }
}
