
using System.Runtime.InteropServices;

int PrimalNumTest (int num)
{

bool tester = false;
for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        tester = true;
        break;
    }
}
if (tester)
{
    Console.WriteLine("the number is Complex");
}
else
{
    Console.WriteLine("the number is primal");
}return num;

}
int Divisors (int number)
{
    Console.WriteLine($"dvisors of the {number} :");

    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine(i);
        }
    }
    return number;
}
int EvenPrimDrivisor (int number)
{
    for (int i = number; 1 < i; i--)
    {
        if (number % i == 0)
        {
            bool test = false;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                    test = true;
                continue;
            }
            if (!test)
            {
                Console.WriteLine("the Even divisor of number =" +i);
                break;
            }
        }
    }
    return number;
}
int PowOfNum (int number)
{
int result = 1;
{
            Console.WriteLine($"the 10 pow of {number}  :");
    for (int i = 0; i < 10; i++) 
    {
        result *= number;
        Console.WriteLine($"{number} ^ {i} = {result}");
    }
}return number;
}
int multiler (int number)
{
int result = 0;
{
    Console.WriteLine($"the  10 times {number}(number)  :");
    for (int i = 1; i <= 10;i++)
    {
         result = number * i;
        Console.WriteLine($"{number} x {i} = {result}");

    }
}
return number;
}
PrimalNumTest(11);
EvenPrimDrivisor(121);
Divisors(11);
PowOfNum(3);
multiler(11);





