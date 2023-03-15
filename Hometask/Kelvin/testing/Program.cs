using testing;
Kelvin kelvin = new Kelvin()
{
    DegreeKelvin = 4324
};
Celsius celsius = kelvin;
Console.WriteLine(celsius.Degree);
