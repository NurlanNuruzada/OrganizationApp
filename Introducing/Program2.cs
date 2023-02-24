#region task (1 Qeyd; bug olarag sonuncu reqemi de daxil edir  )
//n den m e kimi tek ededlerin cemini tapin n<m
Console.WriteLine("Input positive number1:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input positive number greater than greather than number1:");
int number2 = int.Parse(Console.ReadLine());
int result = 0;
while (number1 < number2)
{
    number1++;
    if (number1 > number2)
    {
        Console.WriteLine("number2 must be greater than number1 ");
        break;
    }
    else if (number1 < 0)
    {
        Console.WriteLine("enter positive number");
        break;
    }
    else if (number1 % 2 == 0) continue;
    result += number1;
}
Console.WriteLine($"Sum:{result}");
#endregion


#region task 2
using System;
Console.WriteLine("Input a number");
var number = int.Parse(Console.ReadLine());
var pow = 1;
while (number>=pow)
{
   pow*=3;
}
    pow/=3;
if (pow == number)
{
    Console.WriteLine($"the number {number}, is pow of 3");
}
else if (number <= 0)
{
    Console.WriteLine($"the number {number}, is must be greater than 0");
}
else
{
    Console.WriteLine($"the number {number}, is not pow of 3");
}
#endregion
