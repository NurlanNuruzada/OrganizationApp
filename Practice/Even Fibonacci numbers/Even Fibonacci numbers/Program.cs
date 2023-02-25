Console.WriteLine("INPUT THE NUMBER");
int num = int.Parse(Console.ReadLine());
int total = 0;
int num1 = 1;
int num2 = 1;
int num3 = 2;
while (num3<num)
{
    num3 = num1 + num2;
    num1 = num2;
    num2 = num3;
    if (num1 % 2 == 0)
    {
        total += num1;
    }
}
Console.WriteLine($"sum of Fibonacci's even numbers smaller than input  number is :");
Console.WriteLine(total);

