using System;
using System.Collections.Generic;
using TankstellenPrg;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Tankstelle
{
    //properties der Klasse Tankstelle

    public int Id;
    public string Adresse;
    public List<Benzin> BenzinSorten;
    public List<Zapfsäule> Säulen;
    public List<Tank> Tanks;
    public BinaryFormatter bf = new BinaryFormatter();
    //Klassen Variablen
    string fileName = @"C:\Tankstelle\TankstelleSN\TankstellenPrg\Daten.txt";
    string tankFileName = @"C:\Tankstelle\TankstelleSN\TankstellenPrg\Tank.txt";

    //Konstruktor Der Tankstellen Klasse
    public Tankstelle()
    {
        //schaut ob Files mit den Daten schon exsistiert
        if (File.Exists(fileName) && File.Exists(tankFileName))
        {
            //Falls Files exsistieren werden sie Geöffnet damit man die Daten auslesen kann
            FileStream fs = new FileStream(fileName, FileMode.Open);
            FileStream fs2 = new FileStream(tankFileName, FileMode.Open);
            //Benzin,Säulen,und der Inhalt des Tanks werden ausgelesen
            this.BenzinSorten = ReadBenzin(bf, fs);
            this.Säulen = ReadSäule(bf, fs);
            this.Tanks = ReadTank(bf, fs2);
            fs.Close();
        }
        else
        {
            //Falls die Files noch nicht Exsistieren wernden sie erstellt, Tank File wird später erstellt da es noch nicht gebraucht wird
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            //Objekte werden erzeugt und abgespeichert
            this.BenzinSorten = CreateBenzinObject();
            this.Säulen = CreateSaule();
            this.Tanks = CreateTanks();
            SpeichertBenzins(BenzinSorten, bf, fs);
            SpeichertSäulen(Säulen, bf, fs);
            fs.Close();

        }
        //Tankstelle bekommt einen Namen und eine ID
        Adresse = "HarlemTankstelle";
        Id = 1;
    }
    //Kreiert Benzin Objekte
    public List<Benzin> CreateBenzinObject()
    {
        List<Benzin> benzinSorten = new List<Benzin>();
        benzinSorten.Add(new Benzin(1, "Diesel", 1));
        benzinSorten.Add(new Benzin(2, "Bleifrei", 2));
        benzinSorten.Add(new Benzin(3, "Super98", 3));
        return benzinSorten;

    }
    //Kreiert Zapfsäulen Objekte
    public List<Zapfsäule> CreateSaule()
    {
        List<Zapfsäule> säulen = new List<Zapfsäule>();
        säulen.Add(new Zapfsäule(1));
        säulen.Add(new Zapfsäule(2));
        säulen.Add(new Zapfsäule(3));
        säulen.Add(new Zapfsäule(4));
        return säulen;
    }
    //Kreiert Tanks
    public List<Tank> CreateTanks()
    {
        List<Tank> tanks = new List<Tank>();
        tanks.Add(new Tank(2000, "DieselTank"));
        tanks.Add(new Tank(2000, "BleifreiTank"));
        tanks.Add(new Tank(2000, "Super98Tank"));
        return tanks;
    }
    //Speichert Benzin Objekte (Serialisierung)
    public void SpeichertBenzins(List<Benzin> benzinSorten, BinaryFormatter bf, FileStream fs)
    {
        bf.Serialize(fs, benzinSorten);
    }
    //Speichert Säulen Objekte (Serialisierung)
    public void SpeichertSäulen(List<Zapfsäule> zapfhähne, BinaryFormatter bf, FileStream fs)
    {
        bf.Serialize(fs, zapfhähne);
    }
    //Liest Tank Objekte aus File (DeSerialiesierung)
    public List<Tank> ReadTank(BinaryFormatter bf, FileStream fs2)
    {
        List<Tank> tanks = (List<Tank>)bf.Deserialize(fs2);
        return tanks;
    }
    //Liest Benzin Objekte aus File (DeSerialiesierung)
    public List<Benzin> ReadBenzin(BinaryFormatter bf, FileStream fs)
    {
        List<Benzin> benzinListe = (List<Benzin>)bf.Deserialize(fs);
        return benzinListe;
    }
    //Liest Säulen Objekte aus File (DeSerialiesierung)
    public List<Zapfsäule> ReadSäule(BinaryFormatter bf, FileStream fs)
    {
        List<Zapfsäule> säuleList = (List<Zapfsäule>)bf.Deserialize(fs);
        return säuleList;
    }






}
