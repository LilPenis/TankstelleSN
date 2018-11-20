using System;

public class Auto : Kunde
{
    public int Id { get; set; }
    public int Benzinstand { get; set; }
    public int Tankvolumen { get; set; }

    public int getId()
    {
        return this.Id;
    }

    public void setMyId(int value)
    {
        this.Id = value;
    }
    public int getBenzinstand()
    {
        return this.Benzinstand;
    }

    public void setBenzinstand(int value)
    {
        this.Benzinstand = value;
    }
    public int getTankvolumen()
    {
        return this.Tankvolumen;
    }

    public void setTankvolumen(int value)
    {
        this.Tankvolumen = value;
    }



}
