using System;

public class Kasse : Zapfsäule
{
	public int Id { set; get; }
    public int Zapfsäule { get; }
    public int offenerBetrag { get; }
    public int Geldbestand { set; get; }

    public int getId()
    {
        return this.Id;
    }

    public void setId(int value)
    {
        this.Id = value;
    }

    public int getGeldbestand()
    {
        return this.Geldbestand;
    }
    
    public void setGeldbestand(int value)
    {
        this.Geldbestand = value;
    }


    public int getZapfsäule()
    {
        return this.Zapfsäule;
    }


    public int getoffenerBetrag()
    {
        return this.offenerBetrag;
    }











    //Klasse Welche Objekte erzeugt
    //Klasse welche Objekte abspeichert
    //Klasse welche Objekte wieder serialisert
    //Als nächstes Getter Setter Fertig
    //Dan erste Objekte erzeugen
}
