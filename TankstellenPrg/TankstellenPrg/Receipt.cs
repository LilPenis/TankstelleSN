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
    public partial class Receipt : Form
    {
        double Price;
        double Liter;
        int MyPay;
        double Change;
        double TankBestandDiesel;
        double TankbestandBleifrei;
        double TankBestandSuper98;
            
        public Receipt(double Price, double Liter, int MyPay,Tankstelle tankstelle)
        {
            this.Price = Price;
            this.Liter = Liter;
            this.MyPay = MyPay;
            Tank dieselTank = tankstelle.tanks.Find(t => t.Bezeichnung == "DieselTank");
            Tank super98Tank = tankstelle.tanks.Find(t => t.Bezeichnung == "Super98Tank");
            Tank bleiferiTank = tankstelle.tanks.Find(t => t.Bezeichnung == "BleifreiTank");
            this.TankBestandDiesel = dieselTank.GetLiterBestand();
            this.TankbestandBleifrei = bleiferiTank.GetLiterBestand();
            this.TankBestandSuper98 = super98Tank.GetLiterBestand();

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

        }
        private double GetRückgeld(double Price,int MyPay)
        {

            this.Change = MyPay - Price;
            return Change;
        }

        private void Betrag_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
