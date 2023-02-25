Console.WriteLine("enter number :");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i <number; i++)
{
    if (i % 3 == 0 | i % 5 == 0)
    {
        sum += i;
    }
}
Console.WriteLine(sum);
