
int number = 21;
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
            Console.WriteLine(i);
            break;
        }
    }
}
