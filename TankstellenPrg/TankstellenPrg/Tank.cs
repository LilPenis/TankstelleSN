using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankstellenPrg
{
    [Serializable]
    public class Tank
    {
        public double LiterBestand;
        public string Bezeichnung;

        public Tank(double Liter,string Bezeichnung)
        {
            SetBezeichnung(Bezeichnung);
            SetLiterBestand(Liter);

        }
        public void SetLiterBestand(double Liter)
        {
            if(Liter < 100)
            {
                MessageBox.Show("Der Tankbestand eines Tankes ist unter 100Liter gefallen, Bitte Nachschub bessorgen");
            }
            else
            {
                this.LiterBestand = Liter;
            }
           
        }
        public double GetLiterBestand()
        {
            return this.LiterBestand;
        }
        public void SetBezeichnung(string Name)
        {
            this.Bezeichnung = Name;
        }
        public string GetBezeichnung()
        {
            return this.Bezeichnung;
        }
    }
}
