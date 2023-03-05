string Repeat(string word, int count)
{
    string repeated = "";
while (count > 0)
    {
        repeated += word; count--;
    }
    return repeated;
}
Console.WriteLine( Repeat("Nurlan", 4) ); 
