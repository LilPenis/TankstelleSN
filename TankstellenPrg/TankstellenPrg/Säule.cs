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
        //properties
        double BenzinPreisDiesel;
        double BenzinPreisBleifrei;
        double BenzinPreisSuper98;
        double TankBestabdDiesel;
        double TankBestabSuper98;
        double TankBestabdBleifrei;
        Tankstelle tankstelle;
        Tank dieselTank;
        Tank super98Tank;
        Tank bleifreiTank;
        //Classen Variablen
        double liter = 0.0;
        public double preis = 0;
        int identifier = 0;
        //Konstruktor der Säule Holt Objekte welche Gebraucht werden und weist sie richtig zu
        public Säule(Zapfsäule zapfsäule, Tankstelle tankstelle)
        {
            InitializeComponent();
            Benzin diesel = tankstelle.BenzinSorten.Find(t => t.Bezeichnung == "Diesel");
            Benzin bleiFrei = tankstelle.BenzinSorten.Find(t => t.Bezeichnung == "Bleifrei");
            Benzin super98 = tankstelle.BenzinSorten.Find(t => t.Bezeichnung == "Super98");
            dieselTank = tankstelle.Tanks.Find(t => t.Bezeichnung == "DieselTank");
            super98Tank = tankstelle.Tanks.Find(t => t.Bezeichnung == "Super98Tank");
            bleifreiTank = tankstelle.Tanks.Find(t => t.Bezeichnung == "BleifreiTank");
            BenzinPreisDiesel = diesel.getKostenproLiter();
            BenzinPreisBleifrei = bleiFrei.getKostenproLiter();
            BenzinPreisSuper98 = super98.getKostenproLiter();
            TankBestabdDiesel = dieselTank.GetLiterBestand();
            TankBestabdBleifrei = bleifreiTank.GetLiterBestand();
            TankBestabSuper98 = super98Tank.GetLiterBestand();
            this.tankstelle = tankstelle;

        }

        double GasPrice;


        private void SC1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Wird ausgelöst wenn Diesel Geklickt wurder
        private void S1D_Click(object sender, EventArgs e)
        {

            identifier = 1;
            S1B.Enabled = false;
            S198.Enabled = false;
            SC1.Enabled = false;
            SS1.Enabled = true;
            STT1.Start();

        }

        //Wenn Säule geladen wird wird Preis direkt Sichtbar angezeigt
        private void Säule1_Load(object sender, EventArgs e)
        {
            SLT1.Text = Convert.ToString(liter);
            SFrT1.Text = Convert.ToString(preis);
            S1D.Text = S1D.Text += "  " + BenzinPreisDiesel.ToString() + " " + "CHF" + " " + "pro/L";
            S198.Text = S198.Text += "  " + BenzinPreisSuper98.ToString() + " " + "CHF" + " " + "pro/L";
            S1B.Text = S1B.Text += "  " + BenzinPreisBleifrei.ToString() + " " + "CHF" + " " + "pro/L";
        }
        //Wird ausgelöst wenn Bleifrei Geklickt wurde
        private void S1B_Click(object sender, EventArgs e)
        {
            identifier = 2;
            S1D.Enabled = false;
            S198.Enabled = false;
            SC1.Enabled = false;
            SS1.Enabled = true;
            STT1.Start();
        }
        //Wird ausgelöst wenn Super98 Geklickt wurde
        private void S198_Click(object sender, EventArgs e)
        {
            identifier = 3;
            S1B.Enabled = false;
            S1D.Enabled = false;
            SC1.Enabled = false;
            SS1.Enabled = true;
            STT1.Start();
        }

        //Timer welche Hochzähtl und dazu noch ermittlet Welche Benzin Sorte geklickt wurde
        private void STT1_Tick(object sender, EventArgs e)
        {
            switch (identifier)
            {
                case 1:
                    GasPrice = BenzinPreisDiesel / 10;

                    break;
                case 2:
                    GasPrice = BenzinPreisBleifrei / 10;

                    break;
                case 3:
                    GasPrice = BenzinPreisSuper98 / 10;

                    break;

            }
            liter = liter + 0.1;
            preis += GasPrice;
            SLT1.Text = Convert.ToString(Math.Round(liter, 1));
            SFrT1.Text = Convert.ToString(Math.Round(preis, 1));
        }
        //Stopt Den Tank Vorgang und zieht bezogene Liter Zahl vom Tank ab
        private void SS1_Click(object sender, EventArgs e)
        {
            STT1.Stop();
            SP1.Visible = true;
            switch (identifier)
            {
                case 1:
                    dieselTank.SetLiterBestand(TankBestabdDiesel -= liter);
                    identifier = 0;
                    break;
                case 2:
                    bleifreiTank.SetLiterBestand(TankBestabdBleifrei -= liter);
                    identifier = 0;
                    break;
                case 3:
                    super98Tank.SetLiterBestand(TankBestabSuper98 -= liter);
                    identifier = 0;
                    break;

            }
        }




        //Löst Bezahlung aus -> Kasse erscheint
        private void SP1_Click(object sender, EventArgs e)
        {

            Payment Bezahlung = new Payment(preis, liter, tankstelle);
            Bezahlung.Show();
            Close();

        }
    }
}
