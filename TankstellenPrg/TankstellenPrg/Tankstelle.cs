using System;
using System.Collections.Generic;

public class Tankstelle
{
	
     public int Id;
     public string Adresse;
     public List<Benzin> benzinSorten;
    public List<Zapfsäule> säulen;
    //Tankstelle Hat alles ist Gottes Klasse
    public Tankstelle()
    {
        Adresse = "HarlemTankstelle";
        Id = 1;
        benzinSorten = CreateBenzinObject();
        säulen = CreateSaule();
    }
    public List<Benzin> CreateBenzinObject()
   {
        List<Benzin> benzinSorten = new List<Benzin>();
        benzinSorten.Add(new Benzin(1,"Diesel",0.98));
        benzinSorten.Add(new Benzin(2,"Bleifrei",0.8));
        benzinSorten.Add(new Benzin(3,"Super98",1.1));
        return benzinSorten;

    }
    public List<Zapfsäule> CreateSaule()
    {
        List<Zapfsäule> säulen = new List<Zapfsäule>();
        säulen.Add(new Zapfsäule(1));
        säulen.Add(new Zapfsäule(2));
        säulen.Add(new Zapfsäule(3));
        säulen.Add(new Zapfsäule(4));
        return säulen;
    }





}
