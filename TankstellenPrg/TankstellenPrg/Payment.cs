﻿using System;
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
            
                Receipt quittungg = new Receipt(Price,Liter,MyPay,tankstelle);
                quittungg.Show();
                Close();
                
            }

        
    


        private void WasBezahl_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


