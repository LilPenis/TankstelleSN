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
    public partial class Payment : Form
    {
        //Properties
        double Preis;
        int MeineBezahlung;
        double Liter;
        double TankBestandDiesel;
        double TankBestandBleifrei;
        double TankBestandSuper98;
        Tankstelle Tankstelle;

        //Konstruktor
        public Payment(double Price, double Liter, Tankstelle tankstelle)
        {
            this.Preis = Price;
            this.Liter = Liter;
            this.Tankstelle = tankstelle;

            InitializeComponent();
        }
        
        private void Payment_Load(object sender, EventArgs e)
        {
            BezahlBetrag.Text = Convert.ToString(Preis);
        }
        //1 Fr Click
        private void Ei_Click_1(object sender, EventArgs e)
        {
            MeineBezahlung += 1;
            WasBezahl.Text = Convert.ToString(MeineBezahlung);

            if (MeineBezahlung >= Preis)
            {
                PB.Enabled = true;
            }

        }
        //2 Fr Click
        private void Zwei_Click_1(object sender, EventArgs e)
        {
            MeineBezahlung += 2;
            WasBezahl.Text = Convert.ToString(MeineBezahlung);

            if (MeineBezahlung >= Preis)
            {
                PB.Enabled = true;
            }

        }
        //5 Fr Click
        private void Feuf_Click_1(object sender, EventArgs e)
        {
            MeineBezahlung += 5;
            WasBezahl.Text = Convert.ToString(MeineBezahlung);

            if (MeineBezahlung >= Preis)
            {
                PB.Enabled = true;
            }

        }
        //10 Fr Click
        private void Zä_Click_1(object sender, EventArgs e)
        {
            MeineBezahlung += 10;
            WasBezahl.Text = Convert.ToString(MeineBezahlung);

            if (MeineBezahlung >= Preis)
            {
                PB.Enabled = true;
            }

        }
        //20 Fr Click
        private void Zw_Click_1(object sender, EventArgs e)
        {
            MeineBezahlung += 20;
            WasBezahl.Text = Convert.ToString(MeineBezahlung);

            if (MeineBezahlung >= Preis)
            {
                PB.Enabled = true;
            }

        }
        //50 Fr Click
        private void Fü_Click_1(object sender, EventArgs e)
        {
            MeineBezahlung += 50;
            WasBezahl.Text = Convert.ToString(MeineBezahlung);

            if (MeineBezahlung >= Preis)
            {
                PB.Enabled = true;
            }

        }
        //100 Fr Click
        private void Hun_Click_1(object sender, EventArgs e)
        {
            MeineBezahlung += 100;
            WasBezahl.Text = Convert.ToString(MeineBezahlung);

            if (MeineBezahlung >= Preis)
            {
                PB.Enabled = true;
            }

        }

        private void PB_Click_1(object sender, EventArgs e)
        {

            Receipt quittungg = new Receipt(Preis, Liter, MeineBezahlung, Tankstelle);
            quittungg.Show();
            Close();


        }
    }
}


