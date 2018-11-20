using System;
using System.Collections.Generic;
using TankstellenPrg;

public class Benzin : Zapfhan
{
    int Id { get; set; }
    int KostenproLiter { get; set; }
    string Bezeichnung { get; set; }

    public int getId()
    {
        return this.Id;
    }

    public void setMyId(int value)
    {
        this.Id = value;
    }

    public int getKostenproLiter()
    {
        return this.KostenproLiter;
    }

    public void setKostenPproLiter(int value)
    {
        this.KostenproLiter = value;
    }
    public string getBezeichnung()
    {
        return this.Bezeichnung;
    }

    public void setBezeichnung(string value)
    {
        this.Bezeichnung = value;
    }

}
