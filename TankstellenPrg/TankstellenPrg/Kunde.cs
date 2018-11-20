using System;

public class Kunde 
{
    int Id { get; set; }
    public string Name { get; set; }
    int Bargeld { get; set; }

    public int getId()
    {
        return this.Id;
    }

    public void setMyProperty(int value)
    {
        this.Id = value;
    }

    public string getName()
    {
        return this.Name;
    }

    public void setName(string value)
    {
        this.Name = value;
    }


    public int getBargeld()
    {
        return this.Bargeld;
    }

    public void setBargeld(int value)
    {
        this.Bargeld = value;
    }


}
