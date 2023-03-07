namespace ConsoleApp3;

class vegtable:Fruits
{

    public string shape;
    public string wherecanfoud;
    public vegtable()
    {
    }
    public vegtable(string name, string color) : this()
    {
        this.Name = Name;
        this.Color = Color;
    }

    public vegtable(string Name, string Color, string taste) : this(Name, Color)
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
