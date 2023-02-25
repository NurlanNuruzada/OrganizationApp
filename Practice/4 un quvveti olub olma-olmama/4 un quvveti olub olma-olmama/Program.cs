Console.WriteLine("inut pow number");
int pow = int.Parse(Console.ReadLine());
Console.WriteLine("input test number");
int number = int.Parse(Console.ReadLine()); ;
bool test = false;
for (int i = 1; i <= number; i*=pow)
{
    if (number == i)
    {
        test = true;
        Console.WriteLine($"the number {number} is pow of {pow}");
        break;
    }
}
    if (!test)
    {
        Console.WriteLine($"the number {number} is not pow of {pow}");
    }