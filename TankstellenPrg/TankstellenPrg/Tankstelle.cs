using System;
using System.Collections.Generic;
using TankstellenPrg;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Tankstelle
{

     string fileName = @"C:\Tankstelle\TankstelleSN\TankstellenPrg\Daten.txt";
     string TankFileName = @"C:\Tankstelle\TankstelleSN\TankstellenPrg\Tank.txt";
     public int Id;
     public string Adresse;
     public List<Benzin> benzinSorten;
     public List<Zapfsäule> säulen;
     public List<Tank> tanks;
     public BinaryFormatter bf = new BinaryFormatter();

    //Tankstelle Hat alles ist Gottes Klasse
    public Tankstelle()
    {//Ich eruüge s File jetzt Immmer
        //Nur den erzüge wens nonig exsistiert sust lese
        
        
        if (File.Exists(fileName))
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            FileStream fs2 = new FileStream(TankFileName, FileMode.OpenOrCreate);
            this.benzinSorten = ReadBenzin(bf,fs);
            this.säulen = ReadSäule(bf,fs);
            this.tanks = ReadTank(bf,fs2);
            fs.Close();
        }
        else
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            this.benzinSorten = CreateBenzinObject();
            this.säulen = CreateSaule();
            this.tanks = CreateTanks();
            SpeichertBenzins(benzinSorten,bf,fs);
            SpeichertSäulen(säulen,bf,fs);
            //SpeichertTanks(tanks,bf,fs);
            fs.Close();

        }
        Adresse = "HarlemTankstelle";
        Id = 1;

        ////Abfrage ob File Exsistiert
        //benzinSorten = CreateBenzinObject();
        //säulen = CreateSaule();
        //tanks = CreateTanks();
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
    public void SpeichertBenzins(List<Benzin> benzinSorten, BinaryFormatter bf,FileStream fs)
    {
        bf.Serialize(fs, benzinSorten);
    }
    //public void SpeichertTanks(List<Tank> tanks, BinaryFormatter bf, FileStream fs)
    //{
    //    bf.Serialize(fs, tanks);
    //}
    public void SpeichertSäulen(List<Zapfsäule> zapfhähne, BinaryFormatter bf, FileStream fs)
    {
        bf.Serialize(fs, zapfhähne);
    }
    public List<Tank> ReadTank(BinaryFormatter bf, FileStream fs)
    {
        List<Tank> tanks = (List<Tank>)bf.Deserialize(fs);
        return tanks;
    }
    public List<Benzin> ReadBenzin(BinaryFormatter bf, FileStream fs)
    {
        List<Benzin> benzinListe = (List<Benzin>)bf.Deserialize(fs);
        return benzinListe;
    }
    public List<Zapfsäule> ReadSäule(BinaryFormatter bf, FileStream fs)
    {
        List<Zapfsäule> säuleList = (List<Zapfsäule>)bf.Deserialize(fs);
        return säuleList;
    }






}
