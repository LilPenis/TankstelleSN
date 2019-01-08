using System;
using System.Collections.Generic;
using TankstellenPrg;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Tankstelle
{
	
     string fileName = "hi";
     public int Id;
     public string Adresse;
     public List<Benzin> benzinSorten;
     public List<Zapfsäule> säulen;
     public List<Tank> tanks;
    
    //Tankstelle Hat alles ist Gottes Klasse
    public Tankstelle()
    {
        Adresse = "HarlemTankstelle";
        Id = 1;
        benzinSorten = CreateBenzinObject();
        säulen = CreateSaule();
        tanks = CreateTanks();
    }
    public List<Benzin> CreateBenzinObject()
    {
        List<Benzin> benzinSorten = new List<Benzin>();
        benzinSorten.Add(new Benzin(1,"Diesel",1));
        benzinSorten.Add(new Benzin(2,"Bleifrei",2));
        benzinSorten.Add(new Benzin(3,"Super98",3));
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
    public List<Tank> CreateTanks()
    {
        List<Tank> tanks = new List<Tank>();
        tanks.Add(new Tank(2000, "DieselTank"));
        tanks.Add(new Tank(2000, "BleifreiTank"));
        tanks.Add(new Tank(2000, "Super98Tank"));
        return tanks;
    }
    public void SpeichertBenzins(List<Benzin> benzinSorten)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(fileName, FileMode.Create);
        bf.Serialize(fs, benzinSorten);
    }
    public void SpeichertTanks(List<Tank> tanks)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(fileName, FileMode.Create);
        bf.Serialize(fs, tanks);
    }
    public void SpeichertSäulen(List<Zapfsäule> zapfhähne)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(fileName, FileMode.Create);
        bf.Serialize(fs, zapfhähne);
    }






}
