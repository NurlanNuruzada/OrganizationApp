Console.WriteLine("eded daxil edin");
int eded = int.Parse(Console.ReadLine());
bool murekkeb = false;
for (int i = 2;i<eded; i++)
{
    if (eded % i == 0)
    {
        murekkeb = true;
    }  
}
if (murekkeb)
{
        Console.WriteLine("eded murekkebdir");
}
else
{
    Console.WriteLine("eded sadedir");
}
