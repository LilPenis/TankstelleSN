using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TankstellenPrg
{
    public partial class Receipt : Form
    {
        string tankFile = @"C:\Tankstelle\TankstelleSN\TankstellenPrg\Tank.txt";
        double Price;
        double Liter;
        double MyPay;
        double Change;
        double TankBestandDiesel;
        double TankbestandBleifrei;
        double TankBestandSuper98;
        
        Tankstelle tankstelle;
        List<Tank> Tanks;

      
            
        public Receipt(double Price, double Liter, double MyPay,Tankstelle tankstelle)
        {

            this.Price = Math.Round(Price,1);
            this.Liter = Liter;
            this.MyPay = Math.Round(MyPay, 1);
            Tank dieselTank = tankstelle.tanks.Find(t => t.Bezeichnung == "DieselTank");
            Tank super98Tank = tankstelle.tanks.Find(t => t.Bezeichnung == "Super98Tank");
            Tank bleiferiTank = tankstelle.tanks.Find(t => t.Bezeichnung == "BleifreiTank");
            this.TankBestandDiesel = dieselTank.GetLiterBestand();
            this.TankbestandBleifrei = bleiferiTank.GetLiterBestand();
            this.TankBestandSuper98 = super98Tank.GetLiterBestand();
            this.Tanks = tankstelle.tanks;
            this.tankstelle = tankstelle;
            

          


            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            bezogeneLiter.Text = Convert.ToString(Liter);
            Betrag.Text = Convert.ToString(Price);
            Rückgeld.Text = Convert.ToString(GetRückgeld(Price, MyPay));
            Bezahlt.Text = Convert.ToString(MyPay);
            DieslTank.Text = Convert.ToString(TankBestandDiesel);
            BleifreiTank.Text = Convert.ToString(TankbestandBleifrei);
            Super98Tank.Text = Convert.ToString(TankBestandSuper98);
            GetAnzahlRückgeld(MyPay, Price);

        }
        private double GetRückgeld(double Price,double MyPay)
        {

            this.Change = MyPay - Price;
            return Change;
        }

        private void Betrag_TextChanged(object sender, EventArgs e)
        {

        }

        private void schliessen_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs2 = new FileStream(tankFile, FileMode.OpenOrCreate);
            bf.Serialize(fs2, Tanks);


            Close();

        }
        private double GetAnzahlRückgeld(double MyPay, double Price)
        {
            int hundert = 0;
            int fünfzig = 0;
            int zwanzig = 0;
            int zehn = 0;
            int fünf = 0;
            int zwei = 0;
            int eins = 0;
            int nulleins = 0;
            int nullfünf = 0;
            double rückgeld = 0;
            rückgeld = MyPay - Price;
            //rückgeld = Math.Round(rückgeld, 1);
            while (rückgeld > 0.1)
            {
                if (rückgeld > 100)
                {

                    Hundert.Text = Convert.ToString(++hundert);
                    rückgeld = rückgeld - 100;
                }
                else if (rückgeld > 50)
                {

                    Fünfzig.Text = Convert.ToString(++fünfzig);
                    rückgeld = rückgeld - 50;

                }
                else if (rückgeld > 20)
                {

                    Zwanzig.Text = Convert.ToString(++zwanzig);
                    rückgeld = rückgeld - 20;

                }
                else if (rückgeld > 10)
                {

                    Zehner.Text = Convert.ToString(++zehn);
                    rückgeld = rückgeld - 10;

                }
                else if (rückgeld > 5)
                {

                    Fünfer.Text = Convert.ToString(++fünf);
                    rückgeld = rückgeld - 5;

                }
                else if (rückgeld > 2)
                {

                    Zweier.Text = Convert.ToString(++zwei);
                    rückgeld = rückgeld - 2;

                }
                else if (rückgeld > 1)
                {

                    Hundert.Text = Convert.ToString(++eins);
                    rückgeld = rückgeld - 1;
                }
                else if (rückgeld > 0.5)
                {
                    NullFünfziger.Text = Convert.ToString(++nullfünf);
                    rückgeld = rückgeld - 0.5;
                }
                else if (rückgeld > 0.1)
                {
                    NullEiner.Text = Convert.ToString(++nulleins);
                    rückgeld = rückgeld - 0.1;
                }



            }
            return rückgeld;
        }

    }
}
