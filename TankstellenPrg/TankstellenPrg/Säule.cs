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
        int Liter = 0;
        public double Price = 0;
        int identifier = 0;

        public Säule(Zapfsäule zapfsäule, Tankstelle tankstelle)
        {
            InitializeComponent();
            Benzin diesel = tankstelle.benzinSorten.Find(t => t.Bezeichnung == "Diesel");
            Benzin bleiFrei = tankstelle.benzinSorten.Find(t => t.Bezeichnung == "Bleifrei");
            Benzin super98 = tankstelle.benzinSorten.Find(t => t.Bezeichnung == "Super98");
            gasPriceDiesel = diesel.getKostenproLiter();
            gasPriceBleiFrei = bleiFrei.getKostenproLiter();
            gasPriceSuper98 = super98.getKostenproLiter();


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
        }

        private void STT1_Tick(object sender, EventArgs e)
        {
            switch (identifier)
            {
                case 1:
                    GasPrice = gasPriceDiesel;
                    identifier = 0;
                    break;
                case 2:
                    GasPrice = gasPriceBleiFrei;
                    identifier = 0;
                    break;
                case 3:
                    GasPrice = gasPriceSuper98;
                    identifier = 0;
                    break;
                    
            }
            Liter++;
            Price += gasPriceDiesel;
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
            
            Payment Bezahlung = new Payment(Price);
            Bezahlung.Show();
            Close();
        }
    }
}
