namespace ConsoleApp3;

class Fruits
{
    //field 
    public string Name;
    public string Description;
    public string Color;
    public string taste;
    public Fruits()
    {
    }
    public Fruits(string name, string color) : this()
    {
        this.Name = Name;
        this.Color = Color;
    }

    public Fruits(string Name, string Color, string taste) : this(Name, Color)
    {
        this.taste = taste;
    }

    public string Description2()
    {
        return (Color + " " + taste);
    }
    public string GetInfo1()
    {
        return (Name + " " + Description2());
    }


}
