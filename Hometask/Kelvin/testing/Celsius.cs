namespace testing;

public class Celsius
{
    public double Degree { get; set; }
    public static implicit operator  Celsius(Kelvin kelvin)
    {
        return new Celsius { Degree = kelvin.DegreeKelvin - 273 };

    }
}
