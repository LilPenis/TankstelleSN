﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankstellenPrg
{
    public class Zapfhan 
    {
        public int Id { get; set; }
        public double Lieterzahl;
        public bool bockiert;

        public int getId()
        {
            return this.Id;
        }

        public void setId(int value)
        {
            this.Id = value;
        }
        public double getLieterzahl()
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
