
using System.Globalization;
Console.WriteLine("enter number");
long number = long.Parse(Console.ReadLine());
for (long i = number; 1 < i; i--)
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
            Console.WriteLine(i);
        }
    }
}

/* sade while
 * int j = 2;
int i = 18;
bool sade = false;
while (j < i-1)
{
    j++;
    if (i % j == 0)
    {
        sade = true;
    }
}
if (sade)
{
        Console.WriteLine("murekkeb");
}
else
{
        Console.WriteLine("sade");
}

*/
/*sade

*/