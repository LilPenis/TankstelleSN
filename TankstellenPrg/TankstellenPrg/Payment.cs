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
        double Price;
        int MyPay;
        double Liter;
        double TankBestandDiesel;
        double TankBestandBleifrei;
        double TankBestandSuper98;
        Tankstelle tankstelle;

            public Payment(double Price, double Liter, Tankstelle tankstelle)
            {
                this.Price = Price;
                this.Liter = Liter;
            this.tankstelle = tankstelle;
                
                InitializeComponent();
            }

            private void Payment_Load(object sender, EventArgs e)
            {
                BezahlBetrag.Text = Convert.ToString(Price);
            }           

            private void Ei_Click_1(object sender, EventArgs e)
            {
                MyPay += 1;
                WasBezahl.Text = Convert.ToString(MyPay);

                if (MyPay >= Price)
                {
                    PB.Enabled = true;
                }

            }

            private void Zwei_Click_1(object sender, EventArgs e)
            {
                MyPay += 2;
                WasBezahl.Text = Convert.ToString(MyPay);

                if (MyPay >= Price)
                {
                    PB.Enabled = true;
                }

            }

            private void Feuf_Click_1(object sender, EventArgs e)
            {
                MyPay += 5;
                WasBezahl.Text = Convert.ToString(MyPay);

                if (MyPay >= Price)
                {
                    PB.Enabled = true;
                }

            }

            private void Zä_Click_1(object sender, EventArgs e)
            {
                MyPay += 10;
                WasBezahl.Text = Convert.ToString(MyPay);

                if (MyPay >= Price)
                {
                    PB.Enabled = true;
                }

            }

            private void Zw_Click_1(object sender, EventArgs e)
            {
                MyPay += 20;
                WasBezahl.Text = Convert.ToString(MyPay);

                if (MyPay >= Price)
                {
                    PB.Enabled = true;
                }

            }

            private void Fü_Click_1(object sender, EventArgs e)
            {
                MyPay += 50;
                WasBezahl.Text = Convert.ToString(MyPay);

                if (MyPay >= Price)
                {
                    PB.Enabled = true;
                }

            }

            private void Hun_Click_1(object sender, EventArgs e)
            {
                MyPay += 100;
                WasBezahl.Text = Convert.ToString(MyPay);

                if (MyPay >= Price)
                {
                    PB.Enabled = true;
                }

            }

            private void PB_Click_1(object sender, EventArgs e)
            {
            double Rückgel = GetRückgeld(MyPay, Price);
                Receipt quittungg = new Receipt(Price,Liter,MyPay,tankstelle);
                quittungg.Show();
                Close();
                
            }

        private double GetRückgeld(int MyPay,double Price)
        {
            double rückgeld = Price - MyPay;
            while (rückgeld > 0)
            {
                if (rückgeld > 100)
                {

                }
                else if(rückgeld > 50)
                {

                }
                else if (rückgeld > 20)
                {

                }
                else if (rückgeld > 10)
                {

                }
                else if (rückgeld > 5)
                {

                }
                else if (rückgeld > 2)
                {

                }
                else if (rückgeld > 1)
                {

                }
                else if (rückgeld > 0.5)
                {

                }
                else if (rückgeld > 0.2)
                {

                }
                else if (rückgeld > 0.1)
                {

                }
                else
                {
                    
                }
                

            }
            return rückgeld;
        }
    


        private void WasBezahl_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


