using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankstellenPrg
{
    public class Zapfhan : Zapfsäule
    {
        public int Id { get; set; }
        public int Lieterzahl;
        public bool bockiert;

        public int getId()
        {
            return this.Id;
        }

        public void setId(int value)
        {
            this.Id = value;
        }
        public int getLieterzahl()
        {
            return this.Lieterzahl;
        }

        public void setLieterzahl(int value)
        {
            this.Lieterzahl = value;
        }
        public bool blockiert()
        {
            return true;
        }



    }
}
