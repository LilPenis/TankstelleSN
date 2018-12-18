using System;
using System.Collections.Generic;

public class Tankstelle
{
	
     public int Id;
     public string Adresse;
     public List<Benzin> benzinSorten;
    //Tankstelle Hat alles ist Gottes Klasse
    public Tankstelle()
    {
        Adresse = "HarlemTankstelle";
        Id = 1;
    }
    public List<Benzin> CreateBenzinObject()
    {
        List<Benzin> benzinSorten = new List<Benzin>();
        benzinSorten.Add(new Benzin(1,"diesel",0.98));
        benzinSorten.Add(new Benzin(2,"Bleifrei",0.8));
        benzinSorten.Add(new Benzin(3,"super98",1.1));
        return benzinSorten;

    }





}
