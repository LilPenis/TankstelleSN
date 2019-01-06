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
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
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
            int Price;
            int MyPay;
            public Payment(int Price)
            {
                this.Price = Price;
                InitializeComponent();
            }

            private void PB_Click(object sender, EventArgs e)
            {
                Receipt quittungg = new Receipt();
                Close();
                quittungg.Show();

            }

            private void Fü_Click(object sender, EventArgs e)
            {
                MyPay += 50;
                WasBezahl.Text = Convert.ToString(MyPay);
            }

            private void Payment_Load(object sender, EventArgs e)
            {
                BezahlBetrag.Text = Convert.ToString(Price);
            }

            private void Ei_Click(object sender, EventArgs e)
            {
                MyPay += 1;
                WasBezahl.Text = Convert.ToString(MyPay);
            }

            private void Zwei_Click(object sender, EventArgs e)
            {
                MyPay += 2;
                WasBezahl.Text = Convert.ToString(MyPay);
            }

            private void Feuf_Click(object sender, EventArgs e)
            {
                MyPay += 5;
                WasBezahl.Text = Convert.ToString(MyPay);
            }

            private void Zä_Click(object sender, EventArgs e)
            {
                MyPay += 10;
                WasBezahl.Text = Convert.ToString(MyPay);
            }

            private void Zw_Click(object sender, EventArgs e)
            {
                MyPay += 20;
                WasBezahl.Text = Convert.ToString(MyPay);
            }

            private void Hun_Click(object sender, EventArgs e)
            {
                MyPay += 100;
                WasBezahl.Text = Convert.ToString(MyPay);
            }
        }
    }

}
    }
}
