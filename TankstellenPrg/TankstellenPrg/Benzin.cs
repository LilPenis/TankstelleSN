using System;
using System.Collections.Generic;
using TankstellenPrg;

public class Benzin 

{
    public int Id { get; set; }
    public double KostenproLiter { get; set; }
    public string Bezeichnung { get; set; }

    public Benzin(int Id, string Bezeichnung,double Preis)
    {
        setId(Id);
        setBezeichnung(Bezeichnung);
        setKostenPproLiter(Preis);
    }

    public int getId()
    {
        return this.Id;
    }

    public void setId(int value)
    {
        this.Id = value;
    }

    public double getKostenproLiter()
    {
        return this.KostenproLiter;
    }

    public void setKostenPproLiter(double value)
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
