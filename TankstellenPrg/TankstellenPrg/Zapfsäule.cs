using System;
using System.Collections.Generic;
using TankstellenPrg;

[Serializable]
public class Zapfsäule
{

        public int Id;

    public Zapfsäule(int Id)
    {
        setId(Id);
    }
    public void setId(int value)
    {
        this.Id = value;
    }



}
