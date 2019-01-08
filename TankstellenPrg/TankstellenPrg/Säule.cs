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
    public partial class Säule : Form
    {

        double gasPriceDiesel;
        double gasPriceBleiFrei;
        double gasPriceSuper98;
        double Liter = 0.0;
        public double Price = 0;
        int identifier = 0;
        double TankBestabdDiesel;
        double TankBestabSuper98;
        double TankBestabdBleifrei;
        Tankstelle tankstelle;
        Tank dieselTank;
        Tank super98Tank;
        Tank bleifreiTank;

        public Säule(Zapfsäule zapfsäule, Tankstelle tankstelle)
        {
            InitializeComponent();
            Benzin diesel = tankstelle.benzinSorten.Find(t => t.Bezeichnung == "Diesel");
            Benzin bleiFrei = tankstelle.benzinSorten.Find(t => t.Bezeichnung == "Bleifrei");
            Benzin super98 = tankstelle.benzinSorten.Find(t => t.Bezeichnung == "Super98");
            dieselTank = tankstelle.tanks.Find(t => t.Bezeichnung == "DieselTank");
            super98Tank = tankstelle.tanks.Find(t => t.Bezeichnung == "Super98Tank");
            bleifreiTank = tankstelle.tanks.Find(t => t.Bezeichnung == "BleifreiTank");
            gasPriceDiesel = diesel.getKostenproLiter();
            gasPriceBleiFrei = bleiFrei.getKostenproLiter();
            gasPriceSuper98 = super98.getKostenproLiter();
            TankBestabdDiesel = dieselTank.GetLiterBestand();
            TankBestabdBleifrei = bleifreiTank.GetLiterBestand();
            TankBestabSuper98 = super98Tank.GetLiterBestand();
            this.tankstelle = tankstelle;
            
        }

        double GasPrice;
        
        


        private void SFr1_Click(object sender, EventArgs e)
        {

        }

        private void SC1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void S1D_Click(object sender, EventArgs e)
        {
            
            identifier = 1;
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
            S1D.Text = S1D.Text += "  " + gasPriceDiesel.ToString() +" "+ "CHF"+ " " + "pro/L";
            S198.Text = S198.Text += "  " + gasPriceSuper98.ToString() + " " + "CHF" + " " + "pro/L";
            S1B.Text = S1B.Text += "  " + gasPriceBleiFrei.ToString() + " " + "CHF" + " " + "pro/L";
        }

        private void STT1_Tick(object sender, EventArgs e)
        {
            switch (identifier)
            {
                case 1:
                    GasPrice = gasPriceDiesel / 10;
                   
                    break;
                case 2:
                    GasPrice = gasPriceBleiFrei / 10;
                    
                    break;
                case 3:
                    GasPrice = gasPriceSuper98 / 10;
                    
                    break;

            }
            Liter = Liter + 0.1;
            Price += GasPrice;
            SLT1.Text = Convert.ToString(Math.Round( Liter,1));
            SFrT1.Text = Convert.ToString(Math.Round(Price,1));
        }

        private void SS1_Click(object sender, EventArgs e)
        {
            STT1.Stop();
            SP1.Visible = true;
            switch (identifier)
            {
                case 1:
                    dieselTank.SetLiterBestand(TankBestabdDiesel -= Liter);
                    identifier = 0;
                    break;
                case 2:
                    bleifreiTank.SetLiterBestand(TankBestabdBleifrei -= Liter);
                    identifier = 0;
                    break;
                case 3:
                    super98Tank.SetLiterBestand(TankBestabSuper98 -= Liter);
                    identifier = 0;
                    break;

            }
        }

        private void S1B_Click(object sender, EventArgs e)
        {
            identifier = 2;
            S1D.Enabled = false;
            S198.Enabled = false;
            SC1.Enabled = false;
            SS1.Enabled = true;
            STT1.Start();
        }

        private void S198_Click(object sender, EventArgs e)
        {
            identifier = 3;
            S1B.Enabled = false;
            S1D.Enabled = false;
            SC1.Enabled = false;
            SS1.Enabled = true;
            STT1.Start();
        }


        

        private void SP1_Click(object sender, EventArgs e)
        {
            
            Payment Bezahlung = new Payment(Price,Liter,tankstelle);
            Bezahlung.Show();
            Close();
        }
    }
}
